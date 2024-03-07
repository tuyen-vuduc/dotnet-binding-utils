using System;

namespace Com.Mapbox.Maps.Plugins.Locationcomponent
{
    public sealed class PuckLocatedAtPointListenerAction : Java.Lang.Object, global::Com.Mapbox.Maps.Plugins.Locationcomponent.IPuckLocatedAtPointListener
    {
        Action<bool> onResult;
        public PuckLocatedAtPointListenerAction(Action<bool> onResult)
        {
            this.onResult = onResult;
        }

        public void OnResult(bool isPuckLocatedAtPoint) => onResult?.Invoke(isPuckLocatedAtPoint);
    }

    public static class LocationComponentPluginExtensions
    {
        public static void IsLocatedAt(
            this ILocationComponentPlugin locationComponent,
            global::Com.Mapbox.Geojson.Point point, Action<bool> onResult)
            => locationComponent.IsLocatedAt(point, new PuckLocatedAtPointListenerAction(onResult));

        public static System.Threading.Tasks.Task<bool> IsLocatedAtAsync(
            this ILocationComponentPlugin locationComponent,
            global::Com.Mapbox.Geojson.Point point, Action<bool> onResult)
        {
            var tcs = new System.Threading.Tasks.TaskCompletionSource<bool>();

            IsLocatedAt(locationComponent, point, result => tcs.TrySetResult(result));

            return tcs.Task;
        }
    }
}

namespace Com.Mapbox.Maps.Plugins.Gestures
{
    public sealed class OnMapClickListenerFunction : Java.Lang.Object, IOnMapClickListener
    {
        Func<global::Com.Mapbox.Geojson.Point, bool> func;
        public OnMapClickListenerFunction(Func<global::Com.Mapbox.Geojson.Point, bool> func)
        {
            this.func = func;
        }

        public bool OnMapClick(global::Com.Mapbox.Geojson.Point point)
        {
            return func?.Invoke(point) ?? false;
        }
    }

    public static class IGesturesPluginExtensions
    {
        public static void OnMapClick(
            this IGesturesPlugin gestures,
            Func<global::Com.Mapbox.Geojson.Point, bool> mapClicked)
            => gestures.AddOnMapClickListener(new OnMapClickListenerFunction(mapClicked));
    }
}

namespace Com.Mapbox.Maps.Plugins.Delegates.Listeners
{
    using System;
    public sealed class OnMapLoadErrorListenerAction : Java.Lang.Object, IOnMapLoadErrorListener
    {
        private readonly Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> action;

        public OnMapLoadErrorListenerAction(Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> action)
        {
            this.action = action;
        }

        public void OnMapLoadError(global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData eventData)
            => action?.Invoke(eventData);
    }
}
namespace Com.Mapbox.Maps.Plugins.Attributions.Generated
{
    partial class AttributionSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}

namespace Com.Mapbox.Maps.Plugins.Compass.Generated
{
    partial class CompassSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}

namespace Com.Mapbox.Maps.Plugins.Gestures.Generated
{
    partial class GesturesSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}

namespace Com.Mapbox.Maps.Plugins.Locationcomponent.Generated
{
    partial class LocationComponentSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps.Plugins.Logo.Generated
{
    partial class LogoSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps
{
    partial class ImageHolder
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps.Plugins
{
    partial class LocationPuck2D
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps.Plugins
{
    partial class LocationPuck3D
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}
namespace Com.Mapbox.Maps.Plugins.Scalebar.Generated
{
    partial class ScaleBarSettings
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel source)
            {
                return this.CreateFromParcel(source);
            }

            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
            {
                return this.NewArray(size);
            }
        }
    }
}