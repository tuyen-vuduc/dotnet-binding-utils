#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Moshi.Adapters
{ 
    partial class Rfc3339DateJsonAdapter
    {
        public override Java.Lang.Object FromJson(global::Com.Squareup.Moshi.JsonReader? p0)
            => FromJson_(p0);

        public override void ToJson(global::Com.Squareup.Moshi.JsonWriter? p0, Java.Lang.Object? p1)
            => ToJson(p0, p1 as global::Java.Util.Date);
    }
}

namespace Com.Squareup.Moshi { 
    partial class Rfc3339DateJsonAdapter
    {
        public override Java.Lang.Object FromJson(global::Com.Squareup.Moshi.JsonReader? p0)
            => FromJson_(p0);

        public override void ToJson(global::Com.Squareup.Moshi.JsonWriter? p0, Java.Lang.Object? p1)
            => ToJson(p0, p1 as global::Java.Util.Date);
    }
}