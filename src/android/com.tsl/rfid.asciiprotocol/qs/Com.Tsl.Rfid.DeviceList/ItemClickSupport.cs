using Android.Views;
using AndroidX.RecyclerView.Widget;
using static Android.Views.View;

namespace Com.Tsl.Rfid.DeviceList;

public class ItemClickSupport : Java.Lang.Object
{
    private readonly RecyclerView mRecyclerView;
    private OnItemClickListener mOnItemClickListener;
    private OnItemLongClickListener mOnItemLongClickListener;

    private ItemClickSupport(RecyclerView recyclerView)
    {
        mRecyclerView = recyclerView;
        mRecyclerView.SetTag(Resource.Id.item_click_support, this);
        mRecyclerView.ChildViewAttachedToWindow += ChildViewAttachedToWindow;
        mRecyclerView.ChildViewDetachedFromWindow += ChildViewDetachedFromWindow;
    }

    private void ChildViewDetachedFromWindow(object? sender, RecyclerView.ChildViewDetachedFromWindowEventArgs e)
    {
        if (mOnItemClickListener != null)
        {
            e.View.Click -= mOnClickListener;
        }
        if (mOnItemLongClickListener != null)
        {
            e.View.LongClick -= mOnLongClickListener;
        }
    }

    private void mOnLongClickListener(object? sender, LongClickEventArgs e)
    {
        if (mOnItemLongClickListener != null)
        {
            RecyclerView.ViewHolder holder = mRecyclerView.GetChildViewHolder(sender as View);
            e.Handled = mOnItemLongClickListener.Invoke(mRecyclerView, holder.AdapterPosition, sender as View);
        }
        else
        {
            e.Handled = false;
        }
    }

    private void mOnClickListener(object? sender, EventArgs e)
    {
        if (mOnItemClickListener != null)
        {
            var v = sender as View;
            RecyclerView.ViewHolder holder = mRecyclerView.GetChildViewHolder(v);
            mOnItemClickListener.Invoke(mRecyclerView, holder.AdapterPosition, v);
        }
    }

    private void ChildViewAttachedToWindow(object? sender, RecyclerView.ChildViewAttachedToWindowEventArgs e)
    {
        if (mOnItemClickListener != null)
        {
            e.View.Click += mOnClickListener;
        }
        if (mOnItemLongClickListener != null)
        {
            e.View.LongClick += mOnLongClickListener;
        }
    }

    public static ItemClickSupport addTo(RecyclerView view)
    {
        ItemClickSupport support = (ItemClickSupport)view.GetTag(Resource.Id.item_click_support);
        if (support == null)
        {
            support = new ItemClickSupport(view);
        }
        return support;
    }

    public static ItemClickSupport removeFrom(RecyclerView view)
    {
        ItemClickSupport support = (ItemClickSupport)view.GetTag(Resource.Id.item_click_support);
        if (support != null)
        {
            support.detach(view);
        }
        return support;
    }

    public ItemClickSupport setOnItemClickListener(OnItemClickListener listener)
    {
        mOnItemClickListener = listener;
        return this;
    }

    public ItemClickSupport setOnItemLongClickListener(OnItemLongClickListener listener)
    {
        mOnItemLongClickListener = listener;
        return this;
    }

    private void detach(RecyclerView view)
    {
        view.ChildViewAttachedToWindow -= ChildViewAttachedToWindow;
        view.SetTag(Resource.Id.item_click_support, null);
    }
}

public delegate void OnItemClickListener(RecyclerView recyclerView, int position, View v);

public delegate bool OnItemLongClickListener(RecyclerView recyclerView, int position, View v);
