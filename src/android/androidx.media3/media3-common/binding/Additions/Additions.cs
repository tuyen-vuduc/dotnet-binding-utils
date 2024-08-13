#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Androidx.Media3.Common
{
    partial class StreamKey
    {
        int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
        {
            return o is global::Androidx.Media3.Common.StreamKey s ? CompareTo(s) : -1;
        }
    }
    partial class DrmInitData
    {
        unsafe int global::Java.Util.IComparator.Compare(
                Java.Lang.Object? o1,
                Java.Lang.Object? o2)
                => Compare(
                    o1 as global::Androidx.Media3.Common.DrmInitData.SchemeData,
                    o2 as global::Androidx.Media3.Common.DrmInitData.SchemeData);
    }
}
namespace Androidx.Media3.Common.Util
{
    partial class ConstantRateTimestampIterator
    {
        global::Androidx.Media3.Common.Util.ITimestampIterator global::Androidx.Media3.Common.Util.ITimestampIterator.CopyOf() => CopyOf();
    }
}