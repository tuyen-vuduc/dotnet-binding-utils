using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Maps.Loader
{
    partial class MapboxMapsInitializerImpl : global::AndroidX.Startup.IInitializer
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
            => this.Create(context);
    }
}