#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Square.Moshi;

namespace IO.Getstream.Chat.Android.Client.Parser2.Adapters
{
    partial class DateAdapter
    {
        public override Java.Lang.Object FromJson(JsonReader p0)
            => FromJson_(p0);

        public override void ToJson(JsonWriter p0, Java.Lang.Object p1)
            => ToJson(p0, p1 as Java.Util.Date);
    }
}