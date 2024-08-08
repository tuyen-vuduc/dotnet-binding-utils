using Android.Content.Res;
using Android.Content;
using Android.Graphics;
using Android.Views;
using Com.UK.Tsl.Rfid.Asciiprotocol.Device;
using AndroidX.RecyclerView.Widget;

namespace Com.Tsl.Rfid.DeviceList;

public class ReaderViewAdapter : RecyclerView.Adapter
{
    private ObservableReaderList mReaders;

    // Provide a reference to the views for each data item
    // Complex data items may need more than one view per item, and
    // you provide access to all the views for a data item in a view holder
    class ReaderViewHolder : RecyclerView.ViewHolder
    {
        // each data item is just a string in this case
        ImageView mImageView;
        TextView mNameTextView;
        TextView mDescriptionTextView;
        TextView mBtTextView;
        TextView mBleTextView;
        TextView mUsbTextView;

        public ReaderViewHolder(View itemView) : base(itemView)
        {

            mImageView = (ImageView)itemView.FindViewById(Resource.Id.imageView);

            mNameTextView = (TextView)itemView.FindViewById(Resource.Id.nameTextView);
            mDescriptionTextView = (TextView)itemView.FindViewById(Resource.Id.descriptionTextView);

            mBtTextView = (TextView)itemView.FindViewById(Resource.Id.btTextView);
            mBleTextView = (TextView)itemView.FindViewById(Resource.Id.bleTextView);
            mBleTextView.Visibility = ViewStates.Gone;
            mUsbTextView = (TextView)itemView.FindViewById(Resource.Id.usbTextView);
            mContext = itemView.Context;
        }

        private Context mContext;

        public void bind(Reader reader, bool isSelected)
        {
            Resources resources = mContext.Resources;
            bool isUsbPresent = reader.HasTransportOfType(TransportType.Usb);
            bool isUsbActive = reader.HasConnectedTransportOfType(TransportType.Usb);

            bool isBtPresent = reader.HasTransportOfType(TransportType.Bluetooth);
            bool isBtActive = reader.HasConnectedTransportOfType(TransportType.Bluetooth);
            bool hasSerialNumber = reader.SerialNumber != null;

            int rImageId = ReaderMedia.listImageFor(reader);
            mImageView.SetImageResource(rImageId);
            mNameTextView.Text = (reader.DisplayName);
            mNameTextView.SetTypeface(mNameTextView.Typeface, hasSerialNumber ? TypefaceStyle.Bold : TypefaceStyle.Italic);
            string infoLine = resources.GetString(ReaderMedia.descriptionFor(reader));
            infoLine += (infoLine.Length != 0 ? "\n" : "") + reader.DisplayInfoLine;
            infoLine += (infoLine.Length != 0 ? "\n" : "") + reader.DisplayTransportLine;
            mDescriptionTextView.Text = infoLine;

            TextView usbTV = mUsbTextView;
            usbTV.Visibility = isUsbPresent ? ViewStates.Visible : ViewStates.Invisible;
            usbTV.SetTextColor(isUsbActive ? resources.GetColor(Resource.Color.dl_transport_on) : resources.GetColor(Resource.Color.dl_transport_off));

            TextView btTV = mBtTextView;
            btTV.Visibility = isBtPresent ? ViewStates.Visible : ViewStates.Invisible;
            btTV.SetTextColor(isBtActive ? resources.GetColor(Resource.Color.dl_transport_on) : resources.GetColor(Resource.Color.dl_transport_off));

            ItemView.SetBackgroundColor(isSelected ? resources.GetColor(Resource.Color.dl_row_selected) : resources.GetColor(Resource.Color.dl_row_normal));
        }
    }


    public int getSelectedRowIndex()
    {
        return mSelectedRowIndex;
    }

    public void setSelectedRowIndex(int selectedRowIndex)
    {
        if (selectedRowIndex != mSelectedRowIndex)
        {
            int oldRowIndex = mSelectedRowIndex;

            mSelectedRowIndex = selectedRowIndex;

            NotifyItemChanged(oldRowIndex);
            NotifyItemChanged(mSelectedRowIndex);
        }
    }

    private int mSelectedRowIndex = -1;


    // Provide a suitable constructor (depends on the kind of dataset)
    public ReaderViewAdapter(ObservableReaderList readers)
    {
        mReaders = readers;
    }


    // Create new views (invoked by the layout manager)
    public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
    {
        Context context = parent.Context;
        LayoutInflater inflater = LayoutInflater.From(context);

        // create a new view
        View readerView = inflater.Inflate(Resource.Layout.reader_list_row, parent, false);

        return new ReaderViewHolder(readerView);
    }

    // Replace the contents of a view (invoked by the layout manager)
    public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    {
        // - get element from your dataset at this position
        // - replace the contents of the view with that element
        Reader reader = mReaders.List()[position];
        (holder as ReaderViewHolder).bind(reader, position == mSelectedRowIndex);
    }

    // Return the size of your dataset (invoked by the layout manager)
    public override int ItemCount => mReaders.List().Count;
}
