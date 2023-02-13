namespace Com.Izettle.Payments.Android.Core
{
    partial interface ILocationInfoController
    {
        partial class Companion
        {
            public unsafe global::Java.Lang.Object Invoke(global::Java.Lang.Object context)
                => (global::Java.Lang.Object)Invoke(context as global::Android.Content.Context);
        }
    }
    partial interface IFileWrapper
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke(global::Java.Lang.Object context)
                => (global::Java.Lang.Object)Invoke(context as global::Java.IO.File);
        }
    }
}