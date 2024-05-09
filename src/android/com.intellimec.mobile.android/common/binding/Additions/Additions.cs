#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Intellimec.Mobile.Android.Common
{
    partial class ImsSdkInitializer
    {
        Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context p0)
            => (Java.Lang.Object)(object)DoCreate(p0);
    }
    partial class WorkManagerInitializer
    {
        Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context p0)
            => (Java.Lang.Object)(object)DoCreate(p0);
    }
}