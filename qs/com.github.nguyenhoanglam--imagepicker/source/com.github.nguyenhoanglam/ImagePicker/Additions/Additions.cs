using Android.OS;
using AndroidX.RecyclerView.Widget;
using Java.Lang;

namespace Com.Nguyenhoanglam.Imagepicker.Databinding
{
    using Android.Views;
    using AndroidX.ViewBinding;

    partial class ImagepickerActivityCameraBinding : global::AndroidX.ViewBinding.IViewBinding
    {
        View IViewBinding.Root => this.Root;
    }

    partial class ImagepickerFragmentBinding : global::AndroidX.ViewBinding.IViewBinding
    {
        View IViewBinding.Root => this.Root;
    }

    partial class ImagepickerImagePreviewBinding : global::AndroidX.ViewBinding.IViewBinding
    {
        View IViewBinding.Root => this.Root;
    }

    partial class ImagepickerActivityImagepickerBinding : global::AndroidX.ViewBinding.IViewBinding
    {
        View IViewBinding.Root => this.Root;
    }

    partial class ImagepickerItemFolderBinding : global::AndroidX.ViewBinding.IViewBinding
    {
        View IViewBinding.Root => this.Root;
    }

    partial class ImagepickerItemImageBinding : global::AndroidX.ViewBinding.IViewBinding
    {
        View IViewBinding.Root => this.Root;
    }
}

namespace Com.Nguyenhoanglam.Imagepicker.Model
{
    partial class CustomColor
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Object IParcelableCreator.CreateFromParcel(Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            Object[] IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
    partial class CustomDrawable
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Object IParcelableCreator.CreateFromParcel(Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            Object[] IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
    partial class CustomMessage
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Object IParcelableCreator.CreateFromParcel(Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            Object[] IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}

namespace Com.Nguyenhoanglam.Imagepicker.Model 
{ 
    partial class GridCount
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Object IParcelableCreator.CreateFromParcel(Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            Object[] IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
    partial class Image
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Object IParcelableCreator.CreateFromParcel(Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            Object[] IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
    partial class ImagePickerConfig
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Object IParcelableCreator.CreateFromParcel(Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            Object[] IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
    partial class ImageSort
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Object IParcelableCreator.CreateFromParcel(Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            Object[] IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Nguyenhoanglam.Imagepicker.UI.Adapter
{
    partial class FolderPickerAdapter : global::Com.Nguyenhoanglam.Imagepicker.UI.Adapter.BaseRecyclerViewAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            this.OnBindViewHolder(holder as FolderViewHolder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(Android.Views.ViewGroup parent, int viewType)
        {
            return this.OnCreateFolderViewHolder(parent, viewType);
        }
    }
    partial class ImagePickerAdapter : global::Com.Nguyenhoanglam.Imagepicker.UI.Adapter.BaseRecyclerViewAdapter
    {
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            this.OnBindViewHolder(holder as ImageViewHolder, position);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(Android.Views.ViewGroup parent, int viewType)
        {
            return this.OnCreateImageViewHolder(parent, viewType);
        }
    }
}