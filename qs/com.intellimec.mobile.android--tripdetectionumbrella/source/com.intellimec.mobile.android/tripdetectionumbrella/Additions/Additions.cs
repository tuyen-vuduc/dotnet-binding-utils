using System.Collections.Generic;
using Android.Content;
using AndroidX.Startup;
using Java.Lang;

namespace Com.Drivesync.Android.Trips
{
    partial class ImsTripManagerInitializer : global::AndroidX.Startup.IInitializer
    {
        Java.Lang.Object IInitializer.Create(Context p0)
            => Create(p0) as Java.Lang.Object;

        IList<Class> IInitializer.Dependencies()
            => Dependencies();
    }
}