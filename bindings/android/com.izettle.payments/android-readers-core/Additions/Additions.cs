using System.Linq;

namespace Com.Izettle.Payments.Android.Readers.Core
{
    partial class ReaderColor
    {
        partial class CREATOR
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }
    partial class ReaderModel
    {
        partial class CREATOR
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }
}