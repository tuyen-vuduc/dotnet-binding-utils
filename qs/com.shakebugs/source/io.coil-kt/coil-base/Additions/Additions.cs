using Android.Runtime;
using Android.Views;

namespace Coil.Memory
{
    partial interface IMemoryCache
    {
        partial class Key
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                {
                    return this.CreateFromParcel(parcel);
                }
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                {
                    return this.NewArray(size);
                }
            }
        }
    }
}

namespace Coil.Target
{
    partial class GenericViewTarget : IViewTarget, global::AndroidX.Lifecycle.IDefaultLifecycleObserver
    {
        global::Java.Lang.Object IViewTarget.GetView() => GetView();

        public virtual void OnDestroy(global::AndroidX.Lifecycle.ILifecycleOwner? p0) {

        }
        public virtual void OnPause(global::AndroidX.Lifecycle.ILifecycleOwner? p0)
        {

        }
        public virtual void OnCreate(global::AndroidX.Lifecycle.ILifecycleOwner? p0)
        {

        }
        public virtual void OnResume(global::AndroidX.Lifecycle.ILifecycleOwner? p0)
        {

        }
    }

    partial class ImageViewTarget
    {
        public override View GetView() => View;
    }
}