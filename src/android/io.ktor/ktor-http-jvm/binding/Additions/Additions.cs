using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace IO.Ktor.Http
{
    partial class HttpStatusCode : global::Java.Lang.IComparable
    {
        int global::Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
        {
            return CompareTo(o as HttpStatusCode);
        }
    }
}