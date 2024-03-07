namespace Com.Mapbox.Maps.Plugins.Delegates.Listeners {
    using System;
    public class OnMapLoadErrorListenerAction : Java.Lang.Object, IOnMapLoadErrorListener {
        private readonly Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> action;

        public OnMapLoadErrorListenerAction(Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> action)
        {
            this.action = action;
        }

        public void OnMapLoadError (global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData eventData)
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