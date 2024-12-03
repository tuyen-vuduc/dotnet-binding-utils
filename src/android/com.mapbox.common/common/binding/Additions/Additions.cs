
namespace Com.Mapbox.Common
{
    partial class BaseMapboxInitializer
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
            => Create(context);
    }
    partial class MapboxSDKCommonInitializerImpl
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
            => Create(context);
    }
    partial class CoreInitializer
    {
        global::Java.Lang.Object global::AndroidX.Startup.IInitializer.Create(global::Android.Content.Context context)
            => Create(context);
    }
}

namespace Com.Mapbox.Common
{
    partial class ResponseReadStream
    {
        long global::Com.Mapbox.Common.IReadStream.ReadBytes()
            => InvokeReadBytes();
    }
}