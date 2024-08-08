using Android;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.InputMethods;
using AndroidX.Activity;
using AndroidX.Activity.Result;
using AndroidX.Activity.Result.Contract;
using AndroidX.AppCompat.App;
using AndroidX.Core.Content;
using AndroidX.LocalBroadcastManager.Content;
using Com.Tsl.Rfid.DeviceList;
using Com.UK.Tsl.Rfid.Asciiprotocol;
using Com.UK.Tsl.Rfid.Asciiprotocol.Device;
using Com.UK.Tsl.Rfid.Asciiprotocol.Responders;
using Com.UK.Tsl.Utils;

namespace Com.Tsl.Rfid.AsciiProtocolQs
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        // The Reader currently in use
        private Reader mReader = null;

        private bool mIsSelectingReader = false;

        private IMenuItem mConnectIMenuItem;
        private IMenuItem mDisconnectIMenuItem;

        // Debugging
        private static readonly string TAG = "TagFinderActivity";
        private static readonly bool D =
#if DEBUG
        true
#else
        false
#endif
        ;

        // The seek bar used to adjust the RF Output Power for RFID commands
        private SeekBar mPowerSeekBar;

        // The text-based parameters
        private EditText mTargetTagEditText;

        private TextView mRssiTextView;
        private TextView mRssiTitleTextView;
        private TextView mCountTextView;
        private TextView mRssiSubtitleTextView;
        private TextView mRssiInstructionTextView;

        private TextView mResultTextView;
        private ScrollView mResultScrollView;

        //Create model class derived from ModelBase
        private TagFinderModel mModel;

        private SignalPercentageConverter mPercentageConverter = new SignalPercentageConverter();


        /**
         * @return the current AsciiCommander
         */
        protected AsciiCommander getCommander() { return AsciiCommander.SharedInstance(); }

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_tag_finder);

            mBluetoothPermissionsPrompt = (TextView)FindViewById(Resource.Id.bluetooth_permissions_prompt);

            mGenericModelHandler = new GenericHandler(this);

            AndroidX.AppCompat.Widget.Toolbar toolbar = FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            // The SeekBar provides an integer value for the antenna power
            mPowerSeekBar = (SeekBar)FindViewById(Resource.Id.powerSeekBar);
            mPowerSeekBar.Enabled = false;

            // Set up the action buttons
            Button clearActionButton;

            // Set up the target EPC EditText
            mTargetTagEditText = (EditText)FindViewById(Resource.Id.targetTagEditText);
            mTargetTagEditText.AfterTextChanged += (s, e) =>
            {
                string value = e.Editable.ToString();

                mModel.setTargetTagEpc(value);

                UpdateUI();
            };
            mTargetTagEditText.FocusChange += (s, e) =>
            {
                if (!e.HasFocus)
                {
                    mModel.setTargetTagEpc(mTargetTagEditText.Text);
                    mModel.updateTarget();
                }
            };

            // Dismiss the keyboard
            mTargetTagEditText.EditorAction += (s, e) =>
            {
                if (e.ActionId == ImeAction.Done)
                {
                    mTargetTagEditText.ClearFocus();
                };

                // Set up the RSSI display
                mRssiTextView = (TextView)FindViewById(Resource.Id.rssiTextView);
                mRssiTitleTextView = (TextView)FindViewById(Resource.Id.rssiTitleTextView);
                mCountTextView = (TextView)FindViewById(Resource.Id.countTextView);
                mRssiSubtitleTextView = (TextView)FindViewById(Resource.Id.rssiSubtitleTextView);
                mRssiInstructionTextView = (TextView)FindViewById(Resource.Id.rssiInstructionTextView);

                // Set up the results area
                mResultTextView = (TextView)FindViewById(Resource.Id.resultTextView);
                mResultScrollView = (ScrollView)FindViewById(Resource.Id.resultScrollView);



                // Ensure the shared instance of AsciiCommander exists
                AsciiCommander.CreateSharedInstance(ApplicationContext);

                AsciiCommander commander = getCommander();

                // Ensure that all existing responders are removed
                commander.ClearResponders();

                // Add the LoggerResponder - this simply echoes all lines received from the reader to the log
                // and passes the line onto the next responder
                // This is ADDED FIRST so that no other responder can consume received lines before they are logged.
                commander.AddResponder(new LoggerResponder());

                // Add responder to enable the synchronous commands
                commander.AddSynchronousResponder();

                // Configure the ReaderManager when necessary
                ReaderManager.Create(ApplicationContext);

                // Add observers for changes
                ReaderManager.SharedInstance().ReaderList.ReaderAddedEvent().AddObserver(mAddedObserver);
                ReaderManager.SharedInstance().ReaderList.ReaderUpdatedEvent().AddObserver(mUpdatedObserver);
                ReaderManager.SharedInstance().ReaderList.ReaderRemovedEvent().AddObserver(mRemovedObserver);


                // Create a (custom) model and configure its commander and handler
                mModel = new TagFinderModel();
                mModel.setCommander(getCommander());
                mModel.setHandler(mGenericModelHandler);

                mModel.setRawSignalDelegate(new XSignalStrengthReceivedDelegate((level) =>
                    {
                        //                readonly string value = level == null ? "---" : string.format("%d %%", mPercentageConverter.asPercentage(level));
                        string value = level == null ? "---" : string.Format("{0} {1} ({2})", mPercentageConverter.asPercentage(level.Value), level);
                        mRssiTextView.Post(() =>
                        {
                            mRssiTextView.Text = (mModel.isScanning() ? value : "---");
                        });
                    }));

                mModel.setPercentageSignalDelegate(new XSignalStrengthReceivedDelegate((level) =>
                {
                    string value = level == null ? "---" : level.ToString() + "%";
                    mRssiTextView.Post(() =>
                    {
                        mRssiTextView.Text = (mModel.isScanning() ? value : "---");
                    });
                }));

                mModel.setSignalStrengthCountDelegate(new XSignalStrengthCountDelegate((transponderCount) =>
                {
                    mCountTextView.Post(() =>
                    {
                        mCountTextView.Text = GetString(Resource.String.count_label_text) + transponderCount;
                    });
                }));

            };
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            // Remove observers for changes
            ReaderManager.SharedInstance().ReaderList.ReaderAddedEvent().RemoveObserver(mAddedObserver);
            ReaderManager.SharedInstance().ReaderList.ReaderUpdatedEvent().RemoveObserver(mUpdatedObserver);
            ReaderManager.SharedInstance().ReaderList.ReaderRemovedEvent().RemoveObserver(mRemovedObserver);
        }

        protected override void OnStart()
        {
            base.OnStart();
            checkForBluetoothPermission();
        }

        //----------------------------------------------------------------------------------------------
        // Menu
        //----------------------------------------------------------------------------------------------

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            // Inflate the menu; this adds items to the action bar if it is present.
            MenuInflater.Inflate(Resource.Menu.menu_tag_finder, menu);

            mConnectIMenuItem = menu.FindItem(Resource.Id.connect_reader_menu_item);
            mDisconnectIMenuItem = menu.FindItem(Resource.Id.disconnect_reader_menu_item);

            return true;
        }

        /**
         * Prepare the menu options
         */
        public override bool OnPrepareOptionsMenu(IMenu menu)
        {
            bool isConnected = getCommander().IsConnected;
            mDisconnectIMenuItem.SetEnabled(isConnected);

            mConnectIMenuItem.SetEnabled(true);
            mConnectIMenuItem.SetTitle((mReader != null && mReader.IsConnected
                ? Resource.String.change_reader_menu_item_text
                : Resource.String.connect_reader_menu_item_text));

            return base.OnPrepareOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            // Handle action bar item clicks here. The action bar will
            // automatically handle clicks on the Home/Up button, so long
            // as you specify a parent activity in AndroidManifest.xml.
            int id = item.ItemId;

            switch (id)
            {

                case Resource.Id.connect_reader_menu_item:
                    // Launch the DeviceListActivity to see available Readers
                    mIsSelectingReader = true;
                    int index = -1;
                    if (mReader != null)
                    {
                        index = ReaderManager.SharedInstance().ReaderList.List().IndexOf(mReader);
                    }
                    Intent selectIntent = new Intent(this, typeof(DeviceListActivity));
                    if (index >= 0)
                    {
                        selectIntent.PutExtra(DeviceListActivity.EXTRA_DEVICE_INDEX, index);
                    }
                    StartActivityForResult(selectIntent, DeviceListActivity.SELECT_DEVICE_REQUEST);
                    return true;

                case Resource.Id.disconnect_reader_menu_item:
                    if (mReader != null)
                    {
                        mReader.Disconnect();
                        mReader = null;
                    }

                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        //----------------------------------------------------------------------------------------------
        // Pause & Resume life cycle
        //----------------------------------------------------------------------------------------------

        protected override void OnPause()
        {
            base.OnPause();

            mModel.setEnabled(false);

            // Register to receive notifications from the AsciiCommander
            LocalBroadcastManager.GetInstance(this).UnregisterReceiver(mCommanderMessageReceiver);

            // Disconnect from the reader to allow other Apps to use it
            // unless pausing when USB device attached or using the DeviceListActivity to select a Reader
            if (!mIsSelectingReader && !ReaderManager.SharedInstance().DidCauseOnPause() && mReader != null)
            {
                mReader.Disconnect();
            }

            ReaderManager.SharedInstance().OnPause();
        }

        protected override void OnResume()
        {
            base.OnResume();

            mModel.setEnabled(true);

            // Register to receive notifications from the AsciiCommander
            LocalBroadcastManager.GetInstance(this).RegisterReceiver(mCommanderMessageReceiver, new IntentFilter(AsciiCommander.StateChangedNotification));

            // Remember if the pause/resume was caused by ReaderManager - this will be cleared when ReaderManager.onResume() is called
            bool readerManagerDidCauseOnPause = ReaderManager.SharedInstance().DidCauseOnPause();

            // The ReaderManager needs to know about Activity lifecycle changes
            ReaderManager.SharedInstance().OnResume();

            // The Activity may start with a reader already connected (perhaps by another App)
            // Update the ReaderList which will add any unknown reader, firing events appropriately
            ReaderManager.SharedInstance().UpdateList();

            // Locate a Reader to use when necessary
            AutoSelectReader(!readerManagerDidCauseOnPause);

            mIsSelectingReader = false;

            displayReaderState();
            UpdateUI();
        }

        //
        // Automatically select the Reader to use
        //
        private void AutoSelectReader(bool attemptReconnect)
        {
            ObservableReaderList readerList = ReaderManager.SharedInstance().ReaderList;
            Reader usbReader = null;
            if (readerList.List().Count >= 1)
            {
                // Currently only support a single USB connected device so we can safely take the
                // first CONNECTED reader if there is one
                foreach (Reader reader in readerList.List())
                {
                    if (reader.HasTransportOfType(TransportType.Usb))
                    {
                        usbReader = reader;
                        break;
                    }
                }
            }

            if (mReader == null)
            {
                if (usbReader != null)
                {
                    // Use the Reader found, if any
                    mReader = usbReader;
                    getCommander().Reader = mReader;
                }
            }
            else
            {
                // If already connected to a Reader by anything other than USB then
                // switch to the USB Reader
                IAsciiTransport activeTransport = mReader.ActiveTransport;
                if (activeTransport != null && activeTransport.Type() != TransportType.Usb && usbReader != null)
                {
                    appendMessage("Disconnecting from: " + mReader.DisplayName + "\n");
                    mReader.Disconnect();

                    mReader = usbReader;

                    // Use the Reader found, if any
                    getCommander().Reader = mReader;
                }
            }

            // Reconnect to the chosen Reader
            if (mReader != null
                    && !mReader.IsConnecting
                    && (mReader.ActiveTransport == null || mReader.ActiveTransport.ConnectionStatus().Value() == ConnectionState.Disconnected))
            {
                // Attempt to reconnect on the last used transport unless the ReaderManager is cause of OnPause (USB device connecting)
                if (attemptReconnect)
                {
                    if (mReader.AllowMultipleTransports() || mReader.LastTransportType == null)
                    {
                        // Reader allows multiple transports or has not yet been connected so connect to it over any available transport
                        if (mReader.Connect())
                        {
                            appendMessage("Connecting to: " + mReader.DisplayName + "\n");
                        }
                        else
                        {
                            appendMessage("Unable to start connecting to: " + mReader.DisplayName + "\n");
                        }
                    }
                    else
                    {
                        // Reader supports only a single active transport so connect to it over the transport that was last in use
                        if (mReader.Connect(mReader.LastTransportType))
                        {
                            appendMessage("Connecting (over last transport) to: " + mReader.DisplayName + "\n");
                        }
                        else
                        {
                            appendMessage("Unable to start connecting to: " + mReader.DisplayName + "\n");
                        }
                    }
                }
            }
        }


        // ReaderList Observers
        Observable.IObserver _mAddedObserver;
        Observable.IObserver mAddedObserver => _mAddedObserver ??= new XObservableObserver((Observable observable, Reader reader) =>
        {
            // See if this newly added Reader should be used
            AutoSelectReader(true);
        });

        Observable.IObserver mUpdatedObserver = new XObservableObserver((Observable observable, Reader reader) =>
        {
        });

        Observable.IObserver _mRemovedObserver;
        Observable.IObserver mRemovedObserver => _mRemovedObserver ??= new XObservableObserver((Observable observable, Reader reader) =>
        {
            // Was the current Reader removed
            if (reader == mReader)
            {
                mReader = null;

                // Stop using the old Reader
                getCommander().Reader = (mReader);
            }
        });


        //----------------------------------------------------------------------------------------------
        // Model notifications
        //----------------------------------------------------------------------------------------------

        private class GenericHandler : WeakHandler<MainActivity>
        {
            public GenericHandler(MainActivity t) : base(t)
            {
            }

            public override void handleMessage(Android.OS.Message msg, MainActivity t)
            {
                try
                {
                    switch (msg.What)
                    {
                        case ModelBase.BUSY_STATE_CHANGED_NOTIFICATION:
                            if (t.mModel.error() != null)
                            {
                                t.appendMessage("\n Task failed:\n" + t.mModel.error().Message + "\n\n");
                            }
                            t.UpdateUI();
                            break;

                        case ModelBase.MESSAGE_NOTIFICATION:
                            string message = (string)msg.Obj;
                            t.appendMessage(message);
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                }

            }
        };

        // The handler for model messages
        private static GenericHandler mGenericModelHandler;

        //----------------------------------------------------------------------------------------------
        // UI state and display update
        //----------------------------------------------------------------------------------------------

        // Append the given message to the bottom of the results area
        private void appendMessage(string message)
        {
            string msg = message;
            mResultScrollView.Post(() =>
            {
                // Select the last row so it will scroll into view...
                mResultTextView.Append(msg);

                mResultScrollView.Post(() =>
                {
                    mResultScrollView.FullScroll(FocusSearchDirection.Down);
                });
            });
        }

        private void displayReaderState()
        {

            string connectionMsg = "Reader: ";
            switch (getCommander().ConnectionState)
            {
                case ConnectionState x when x == ConnectionState.Connected:
                    connectionMsg += getCommander().ConnectedDeviceName;
                    break;
                case ConnectionState x when x == ConnectionState.Connecting:
                    connectionMsg += "Connecting...";
                    break;
                default:
                    connectionMsg += "Disconnected";
                    break;
            }
            Title = connectionMsg;
        }

        //
        // Set the state for the UI controls
        //
        private void UpdateUI()
        {
            bool isConnected = getCommander().IsConnected;
            bool canIssueCommand = isConnected & !mModel.isBusy();

            mRssiSubtitleTextView.Text = string.Format("Using: {0} ASCII command", mModel.isFindTagCommandAvailable() ? "\".ft\" - Find Tag" : "\".iv\" - Inventory");
            string instructions = "";
            if (isConnected)
            {
                if (string.IsNullOrEmpty(mModel.getTargetTagEpc()))
                {
                    instructions = Resources.GetString(Resource.String.rssi_instruction_placeholder_text);
                }
                else
                {
                    instructions = "Pull trigger to scan";
                }
            }
            else
            {
                instructions = "Connect a TSL Reader";
            }
            mRssiInstructionTextView.Text = instructions;

        }


        //----------------------------------------------------------------------------------------------
        // AsciiCommander message handling
        //----------------------------------------------------------------------------------------------

        //
        // Handle the messages broadcast from the AsciiCommander
        //
        private BroadcastReceiver _mCommanderMessageReceiver;
        private BroadcastReceiver mCommanderMessageReceiver => _mCommanderMessageReceiver ??= new XBroadcastReceiver((Context context, Intent intent) =>
        {
            string connectionStateMsg = getCommander().ConnectionState.ToString();
            Log.Debug("", "AsciiCommander state changed - isConnected: " + getCommander().IsConnected + " (" + connectionStateMsg + ")");
            Log.Debug("TFA", string.Format("IsConnecting: {0}", mReader == null ? "No Reader" : mReader.IsConnecting));

            if (getCommander() != null)
            {
                displayReaderState();

                if (getCommander().IsConnected)
                {
                    appendMessage("Connected to: " + mReader.DisplayName + "\n");
                    mModel.resetDevice();
                    // Use a new converter to reset dynamic range
                    mPercentageConverter = new SignalPercentageConverter();
                }
                else if (getCommander().ConnectionState == ConnectionState.Disconnected)
                {
                    // A manual disconnect will have cleared mReader
                    if (mReader != null)
                    {
                        // See if this is from a failed connection attempt
                        if (!mReader.WasLastConnectSuccessful())
                        {
                            // Unable to connect so have to choose reader again
                            mReader = null;
                        }
                    }
                }

                UpdateUI();
            }
        });

        //----------------------------------------------------------------------------------------------
        // Handler for
        //----------------------------------------------------------------------------------------------

        //
        // Handle Intent results
        //

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent? data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            switch (requestCode)
            {
                case DeviceListActivity.SELECT_DEVICE_REQUEST:
                    // When DeviceListActivity returns with a device to connect
                    if (resultCode == Result.Ok)
                    {
                        int readerIndex = data.Extras.GetInt(DeviceListActivity.EXTRA_DEVICE_INDEX);
                        Reader chosenReader = ReaderManager.SharedInstance().ReaderList.List()[readerIndex];

                        int action = data.Extras.GetInt(DeviceListActivity.EXTRA_DEVICE_ACTION);

                        // If already connected to a different reader then disconnect it
                        if (mReader != null)
                        {
                            if (action == DeviceListActivity.DEVICE_CHANGE || action == DeviceListActivity.DEVICE_DISCONNECT)
                            {
                                mReader.Disconnect();
                                if (action == DeviceListActivity.DEVICE_DISCONNECT)
                                {
                                    mReader = null;
                                }
                            }
                        }

                        // Use the Reader found
                        if (action == DeviceListActivity.DEVICE_CHANGE || action == DeviceListActivity.DEVICE_CONNECT)
                        {
                            mReader = chosenReader;
                            getCommander().Reader = mReader;
                        }
                    }
                    break;
            }
        }

        //----------------------------------------------------------------------------------------------
        // Bluetooth permissions checking
        //----------------------------------------------------------------------------------------------

        private TextView mBluetoothPermissionsPrompt;

        private void checkForBluetoothPermission()
        {
            // Older permissions are granted at install time
            if ((int)Android.OS.Build.VERSION.SdkInt < 31) return;

            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.BluetoothConnect) != Permission.Granted
                    || ContextCompat.CheckSelfPermission(this, Manifest.Permission.BluetoothScan) != Permission.Granted)
            {
                mBluetoothPermissionsPrompt.Visibility = ViewStates.Visible;
                if (ShouldShowRequestPermissionRationale(Manifest.Permission.BluetoothConnect))
                {
                    // In an educational UI, explain to the user why your app requires this
                    // permission for a specific feature to behave as expected. In this UI,
                    // include a "cancel" or "no thanks" button that allows the user to
                    // continue using your app without granting the permission.
                    offerBluetoothPermissionRationale();
                }
                else
                {
                    requestPermissionLauncher.Launch(bluetoothPermissions);
                }
            }
            else
            {
                mBluetoothPermissionsPrompt.Visibility = ViewStates.Gone;
            }
        }

        private readonly string[] bluetoothPermissions = new string[] { Manifest.Permission.BluetoothConnect, Manifest.Permission.BluetoothScan };

        void offerBluetoothPermissionRationale()
        {
            // Older permissions are granted at install time
            if ((int)Android.OS.Build.VERSION.SdkInt < 31) return;

            Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this);
            builder.SetMessage("Permission is required to connect to TSL Readers over Bluetooth")
                   .SetTitle("Allow Bluetooth?");

            builder.SetPositiveButton("Show Permission Dialog", (s, e) =>
            {
                requestPermissionLauncher.Launch(new string[] { Manifest.Permission.BluetoothConnect, Manifest.Permission.BluetoothScan });
            });


            Android.App.AlertDialog dialog = builder.Create();
            dialog.Show();
        }


        void showBluetoothPermissionDeniedConsequences()
        {
            // Note: When permissions have been denied, this will be invoked everytime checkForBluetoothPermission() is called
            // In your app, we suggest you limit the number of times the User is notified.
            Toast.MakeText(this, "This app will not be able to connect to TSL Readers via Bluetooth.", ToastLength.Long).Show();
        }


        // Register the permissions callback, which handles the user's response to the
        // system permissions dialog. Save the return value, an instance of
        // ActivityResultLauncher, as an instance variable.
        ActivityResultLauncher? _requestPermissionLauncher;
        private ActivityResultLauncher requestPermissionLauncher => _requestPermissionLauncher ??= RegisterForActivityResult(
                new ActivityResultContracts.RequestMultiplePermissions(),
                new XActivityResultCallback(permissionsGranted =>
                {
                    if (permissionsGranted is not Java.Util.IMap map) { return; }

                    bool allGranted = true;
                    foreach (bool isGranted in map.Values())
                    {
                        allGranted = allGranted && isGranted;
                    }

                    if (allGranted)
                    {
                        // Permission is granted. Continue the action or workflow in your
                        // app.

                        // Update the ReaderList which will add any unknown reader, firing events appropriately
                        ReaderManager.SharedInstance().UpdateList();
                        mBluetoothPermissionsPrompt.Visibility = ViewStates.Gone;
                    }
                    else
                    {
                        // Explain to the user that the feature is unavailable because the
                        // features requires a permission that the user has denied. At the
                        // same time, respect the user's decision. Don't link to system
                        // settings in an effort to convince the user to change their
                        // decision.
                        showBluetoothPermissionDeniedConsequences();
                    }
                }));
    }

    class XActivityResultCallback : Java.Lang.Object, IActivityResultCallback
    {
        private Action<Java.Lang.Object> callback;

        public XActivityResultCallback(Action<Java.Lang.Object> callback)
        {
            this.callback = callback;
        }

        public void OnActivityResult(Java.Lang.Object? result)
        {
            callback?.Invoke(result);
        }
    }
}