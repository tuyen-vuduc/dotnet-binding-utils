using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Mapbox.Common
{
    partial class BaseMapboxInitializer : global::AndroidX.Startup.IInitializer
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
            => this.Create(context);
    }

    partial class CoreInitializer : global::AndroidX.Startup.IInitializer
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
            => this.Create(context);
    }
    partial class MapboxSDKCommonInitializerImpl : global::AndroidX.Startup.IInitializer
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
            => this.Create(context);
    }

    partial class ResponseReadStream : global::Com.Mapbox.Common.IReadStream
    {
        long global::Com.Mapbox.Common.IReadStream.ReadBytes()
            => this.InvokeReadBytes();
    }
}