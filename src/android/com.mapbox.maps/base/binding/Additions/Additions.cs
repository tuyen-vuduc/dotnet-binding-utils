using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

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

    public sealed class OnMapLongClickListenerFunction : Java.Lang.Object, IOnMapLongClickListener
    {
        Func<global::Com.Mapbox.Geojson.Point, bool> func;
        public OnMapLongClickListenerFunction(Func<global::Com.Mapbox.Geojson.Point, bool> func)
        {
            this.func = func;
        }

        public bool OnMapLongClick(global::Com.Mapbox.Geojson.Point point)
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

        public static void OnMapLongClick(
            this IGesturesPlugin gestures,
            Func<global::Com.Mapbox.Geojson.Point, bool> mapLongClicked)
            => gestures.AddOnMapLongClickListener(new OnMapLongClickListenerFunction(mapLongClicked));
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

namespace Com.Mapbox.Maps.Interactions.Standard.Generated
{
    partial class StandardBuildings
    {
        public override unsafe global::Java.Lang.Object GetFeaturesetFeature(global::Com.Mapbox.Geojson.Feature feature, string? featureNamespace, global::Com.Mapbox.Bindgen.Value rawState)
            => GetFeaturesetFeature_(feature, featureNamespace, rawState);
        public override unsafe global::Java.Lang.Object GetFeatureState(global::Com.Mapbox.Bindgen.Value rawState)
            => GetFeatureState_(rawState);
    }
    partial class StandardPoi
    {
        public override unsafe global::Java.Lang.Object GetFeaturesetFeature(global::Com.Mapbox.Geojson.Feature feature, string? featureNamespace, global::Com.Mapbox.Bindgen.Value rawState)
            => GetFeaturesetFeature_(feature, featureNamespace, rawState);
        public override unsafe global::Java.Lang.Object GetFeatureState(global::Com.Mapbox.Bindgen.Value rawState)
            => GetFeatureState_(rawState);
    }
    partial class StandardPlaceLabels
    {
        public override unsafe global::Java.Lang.Object GetFeaturesetFeature(global::Com.Mapbox.Geojson.Feature feature, string? featureNamespace, global::Com.Mapbox.Bindgen.Value rawState)
            => GetFeaturesetFeature_(feature, featureNamespace, rawState);
        public override unsafe global::Java.Lang.Object GetFeatureState(global::Com.Mapbox.Bindgen.Value rawState)
            => GetFeatureState_(rawState);
    }
}