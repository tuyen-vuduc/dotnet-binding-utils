using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Mp4parser.Tools
{
    using System.Linq;
    
    partial class RangeStartMap
    {
        global::System.Collections.ICollection global::Java.Util.IMap.EntrySet() => EntrySet()?.ToList();
    }
}