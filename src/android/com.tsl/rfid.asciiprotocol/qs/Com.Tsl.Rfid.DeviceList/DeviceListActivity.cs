using System.Security.Permissions;
using Android;
using Android.Content;
using Android.Content.PM;
using Android.Util;
using Android.Views;
using AndroidX.Core.Content;
using AndroidX.RecyclerView.Widget;
using Com.UK.Tsl.Rfid.Asciiprotocol.Device;
using Com.UK.Tsl.Utils;

namespace Com.Tsl.Rfid.DeviceList;

public class DeviceListActivity : Activity
{
    // Debugging
    private static readonly string TAG = "DeviceListActivity";
    private static readonly bool D = true;

    // Intent request codes
    public const int SELECT_DEVICE_REQUEST = 0x5344;


    /// Return Intent extra
    public static string EXTRA_DEVICE_INDEX = "tsl_device_index";
    public static string EXTRA_DEVICE_ACTION = "tsl_device_action";

    /// Actions requested for the chosen device
    public static int DEVICE_CONNECT = 1;
    public static int DEVICE_CHANGE = 2;
    public static int DEVICE_DISCONNECT = 3;


    // Member fields
    private RecyclerView mRecyclerView;
    private ReaderViewAdapter mAdapter;
    private RecyclerView.LayoutManager mLayoutManager;
    private ObservableReaderList mReaders;
    private TextView mBluetoothPermissionsPrompt;

    private Reader mSelectedReader = null;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Setup the window
        RequestWindowFeature(WindowFeatures.IndeterminateProgress);
        SetContentView(Resource.Layout.reader_list);

        mBluetoothPermissionsPrompt = (TextView)FindViewById(Resource.Id.bluetooth_permissions_prompt);
        mRecyclerView = (RecyclerView)FindViewById(Resource.Id.reader_recycler_view);

        RecyclerView.ItemDecoration itemDecoration = new DividerItemDecoration(this, DividerItemDecoration.Vertical);
        mRecyclerView.AddItemDecoration(itemDecoration);

        // use this setting to improve performance if you know that changes
        // in content do not change the layout size of the RecyclerView
        //mRecyclerView.setHasFixedSize(true);

        // use a linear layout manager
        mLayoutManager = new LinearLayoutManager(this);
        mRecyclerView.SetLayoutManager(mLayoutManager);
        mReaders = ReaderManager.SharedInstance().ReaderList;
        mAdapter = new ReaderViewAdapter(mReaders);
        mRecyclerView.SetAdapter(mAdapter);

        ItemClickSupport.addTo(mRecyclerView).setOnItemClickListener((RecyclerView recyclerView, int position, View v) =>
        {
            int oldIndex = mAdapter.getSelectedRowIndex();
            mAdapter.setSelectedRowIndex(position);
            if (oldIndex == position)
            {
                // Offer disconnect
                offerDisconnect(mReaders.List()[position], position);
            }
            else
            {
                // Warn about disconnection of other reader
                if (oldIndex >= 0)
                {
                    offerChange(mReaders.List()[oldIndex], oldIndex, mReaders.List()[position], position);
                }
                else
                {
                    returnSelectedReader(position, DEVICE_CONNECT);
                }
            }
        });

        // Set result CANCELED in case the user backs out
        SetResult(Result.Canceled);

        // Configure the ReaderManager when necessary
        ReaderManager.Create(ApplicationContext);

        // Add observers for changes
        ReaderManager.SharedInstance().ReaderList.ReaderAddedEvent().AddObserver(mAddedObserver);
        ReaderManager.SharedInstance().ReaderList.ReaderUpdatedEvent().AddObserver(mUpdatedObserver);
        ReaderManager.SharedInstance().ReaderList.ReaderRemovedEvent().AddObserver(mRemovedObserver);


        // See if there is a reader currently in use
        Intent intent = Intent;
        int startIndex = intent.GetIntExtra(EXTRA_DEVICE_INDEX, -1);
        if (startIndex >= 0)
        {
            mSelectedReader = ReaderManager.SharedInstance().ReaderList.List()[startIndex];
            mRecyclerView.ScrollToPosition(startIndex);
        }
    }

    void offerDisconnect(Reader reader, int index)
    {
        int confirmedIndex = index;
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.SetMessage("From:  " + reader.DisplayName)
               .SetTitle("Disconnect?");

        builder.SetPositiveButton("Disconnect", (s, e) =>
        {
            returnSelectedReader(confirmedIndex, DEVICE_DISCONNECT);
        });

        builder.SetNegativeButton("Cancel", (s, e) =>
        {
            // User cancelled the dialog
        });
        AlertDialog dialog = builder.Create();
        dialog.Show();
    }


    void offerChange(Reader oldReader, int oldIndex, Reader newReader, int newIndex)
    {
        int restoreIndex = oldIndex;
        int confirmedIndex = newIndex;
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.SetMessage(string.Format("From:  {0}\n\nTo:  {1}", oldReader.DisplayName, newReader.DisplayName))
               .SetTitle("Change Reader?");

        builder.SetPositiveButton("Change", (s, e) =>
        {
            returnSelectedReader(confirmedIndex, DEVICE_CHANGE);
        });

        builder.SetNegativeButton("Cancel", (s, e) =>
        {
            // User cancelled - revert to previous
            mAdapter.setSelectedRowIndex(restoreIndex);
        });
        AlertDialog dialog = builder.Create();
        dialog.Show();
    }


    void returnSelectedReader(int readerIndex, int action)
    {
        // Create the result Intent
        Intent intent = new Intent();
        intent.PutExtra(EXTRA_DEVICE_INDEX, readerIndex);
        intent.PutExtra(EXTRA_DEVICE_ACTION, action);

        // Set result and finish this Activity
        SetResult(Result.Ok, intent);
        Finish();
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();

        // Remove observers for changes
        ReaderManager.SharedInstance().ReaderList.ReaderAddedEvent().RemoveObserver(mAddedObserver);
        ReaderManager.SharedInstance().ReaderList.ReaderUpdatedEvent().RemoveObserver(mUpdatedObserver);
        ReaderManager.SharedInstance().ReaderList.ReaderRemovedEvent().RemoveObserver(mRemovedObserver);
    }

    public override bool OnCreateOptionsMenu(IMenu? menu)
    {
        // Inflate the menu; this adds items to the action bar if it is present.
        MenuInflater.Inflate(Resource.Menu.menu_device_list, menu);

        return true;
    }

    public override bool OnOptionsItemSelected(IMenuItem item)
    {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.ItemId;

        if (id == Resource.Id.action_add_new)
        {
            StartActivity(new Intent(Android.Provider.Settings.ActionBluetoothSettings));
            return true;
        }

        return base.OnOptionsItemSelected(item);
    }

    protected override void OnPause()
    {
        base.OnPause();
        ReaderManager.SharedInstance().OnPause();

    }

    protected override void OnResume()
    {
        base.OnResume();
        ReaderManager.SharedInstance().OnResume();

        // Set Bluetooth permissions prompt visibility
        bool isPromptVisible = false;
        if ((int)Android.OS.Build.VERSION.SdkInt >= 31)
        {
            isPromptVisible = (ContextCompat.CheckSelfPermission(this, Manifest.Permission.BluetoothConnect) != Permission.Granted
                    || ContextCompat.CheckSelfPermission(this, Manifest.Permission.BluetoothScan) != Permission.Granted);
        }
        else
        {
            isPromptVisible = (ContextCompat.CheckSelfPermission(this, Manifest.Permission.Bluetooth) != Permission.Granted
                    || ContextCompat.CheckSelfPermission(this, Manifest.Permission.BluetoothAdmin) != Permission.Granted);
        }
        mBluetoothPermissionsPrompt.Visibility = isPromptVisible ? ViewStates.Visible : ViewStates.Gone;


        // The Activity may start with a reader already connected (perhaps by another App)
        // Update the ReaderList which will add any unknown reader, firing events appropriately
        ReaderManager.SharedInstance().UpdateList();
        if (mAdapter != null)
        {
            // Reapply the selected Reader in case the Reader list has been changed while paused
            mAdapter.setSelectedRowIndex(-1);
            mAdapter.NotifyDataSetChanged();
            int readerIndex = ReaderManager.SharedInstance().ReaderList.List().IndexOf(mSelectedReader);
            mAdapter.setSelectedRowIndex(readerIndex);
        }
    }

    Observable.IObserver _mAddedObserver;
    Observable.IObserver mAddedObserver => _mAddedObserver ??= new XObservableObserver((Observable observable, Reader reader) =>
    {
        if (D) { Log.Debug(TAG, "Reader arrived"); }
        int readerIndex = ReaderManager.SharedInstance().ReaderList.List().IndexOf(reader);
        mAdapter.NotifyItemInserted(readerIndex);

        // If the new Reader is connected over USB then this will be auto selected and
        if (reader.HasTransportOfType(TransportType.Usb))
        {
            returnSelectedReader(readerIndex, mSelectedReader != null ? DEVICE_CHANGE : DEVICE_CONNECT);
        }
    });

    Observable.IObserver _mUpdatedObserver;
    Observable.IObserver mUpdatedObserver => _mUpdatedObserver ??= new XObservableObserver((Observable observable, Reader reader) =>
    {
        if (D) { Log.Debug(TAG, "Reader updated"); }
        int readerIndex = ReaderManager.SharedInstance().ReaderList.List().IndexOf(reader);
        // A Reader has changed - check to see if it is the currently selected Reader and no longer connected
        if (!reader.IsConnected && mAdapter.getSelectedRowIndex() == readerIndex)
        {
            mAdapter.setSelectedRowIndex(-1);
        }
        mAdapter.NotifyItemChanged(readerIndex);
    });

    Observable.IObserver _mRemovedObserver;
    Observable.IObserver mRemovedObserver => _mRemovedObserver ??= new XObservableObserver((Observable observable, Reader reader) =>
    {
        if (D) { Log.Debug(TAG, "Reader Removed"); }
        int readerIndex = ReaderManager.SharedInstance().ReaderList.List().IndexOf(reader);
        if (mAdapter.getSelectedRowIndex() == readerIndex)
        {
            mAdapter.setSelectedRowIndex(-1);
        }
        mAdapter.NotifyItemRemoved(readerIndex);
    });
}

public class XObservableObserver : Java.Lang.Object, Observable.IObserver
{
    private Action<Observable, Reader> value;

    public XObservableObserver(Action<Observable, Reader> value)
    {
        this.value = value;
    }

    public void Update(Observable? p0, Java.Lang.Object? p1)
    {
        value?.Invoke(p0, p1 as Reader);
    }
}
