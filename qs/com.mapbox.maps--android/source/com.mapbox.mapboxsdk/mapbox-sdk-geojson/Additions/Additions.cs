using System;
using System.Collections.Generic;
using Android.Runtime;
using GoogleGson.Stream;
using Java.Interop;

namespace Com.Mapbox.Geojson.Gson
{
    partial class BoundingBoxTypeAdapter
    {
        public override Java.Lang.Object Read(JsonReader p0)
            => ReadX(p0);

        public override void Write(JsonWriter p0, Java.Lang.Object p1)
            => Write(p0, p1 as BoundingBox);
    }
}

namespace Com.Mapbox.Geojson
{
    using System.Linq;
    using PolygonPoints = global::System.Collections.Generic.IList<global::Com.Mapbox.Geojson.Point>;

    partial class Polygon : global::Com.Mapbox.Geojson.ICoordinateContainer
    {
        // This method is explicitly implemented as a member of an instantiated Com.Mapbox.Geojson.ICoordinateContainer
        global::Java.Lang.Object global::Com.Mapbox.Geojson.ICoordinateContainer.Coordinates()
        {
            var coornidates = Coordinates().ToArray();
            return global::Android.Runtime.JavaArray<PolygonPoints>.FromArray<PolygonPoints>(coornidates);
        }
    }
}

namespace Com.Mapbox.Geojson
{
    using System.Linq;
    using MultiPolygonPoints = global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Mapbox.Geojson.Point>>;

    partial class MultiPolygon : global::Com.Mapbox.Geojson.ICoordinateContainer
    {
        // This method is explicitly implemented as a member of an instantiated Com.Mapbox.Geojson.ICoordinateContainer
        global::Java.Lang.Object global::Com.Mapbox.Geojson.ICoordinateContainer.Coordinates()
        {
            var coornidates = Coordinates().ToArray();
            return global::Android.Runtime.JavaArray<MultiPolygonPoints>.FromArray<MultiPolygonPoints>(coornidates);
        }
    }
}

namespace Com.Mapbox.Geojson
{
    using System.Linq;

    partial class LineString : global::Com.Mapbox.Geojson.ICoordinateContainer
    {
        // This method is explicitly implemented as a member of an instantiated Com.Mapbox.Geojson.ICoordinateContainer
        global::Java.Lang.Object global::Com.Mapbox.Geojson.ICoordinateContainer.Coordinates()
        {
            var coornidates = Coordinates().ToArray();
            return global::Android.Runtime.JavaArray<global::Com.Mapbox.Geojson.Point>.FromArray<global::Com.Mapbox.Geojson.Point>(coornidates);
        }
    }
}

namespace Com.Mapbox.Geojson
{
    using System.Linq;
    using MultiLineStringPoints = global::System.Collections.Generic.IList<global::Com.Mapbox.Geojson.Point>;

    partial class MultiLineString : global::Com.Mapbox.Geojson.ICoordinateContainer
    {
        // This method is explicitly implemented as a member of an instantiated Com.Mapbox.Geojson.ICoordinateContainer
        global::Java.Lang.Object global::Com.Mapbox.Geojson.ICoordinateContainer.Coordinates()
        {
            var coornidates = Coordinates().ToArray();
            return global::Android.Runtime.JavaArray<MultiLineStringPoints>.FromArray<MultiLineStringPoints>(coornidates);
        }
    }
}

namespace Com.Mapbox.Geojson
{
    using System.Linq;

    partial class Point : global::Com.Mapbox.Geojson.ICoordinateContainer
    {
        // This method is explicitly implemented as a member of an instantiated Com.Mapbox.Geojson.ICoordinateContainer
        global::Java.Lang.Object global::Com.Mapbox.Geojson.ICoordinateContainer.Coordinates()
        {
            var coornidates = Coordinates().ToArray();
            return global::Android.Runtime.JavaArray<global::Java.Lang.Double>.FromArray<global::Java.Lang.Double>(coornidates);
        }
    }
}

namespace Com.Mapbox.Geojson
{
    using System.Linq;

    partial class MultiPoint : global::Com.Mapbox.Geojson.ICoordinateContainer
    {
        // This method is explicitly implemented as a member of an instantiated Com.Mapbox.Geojson.ICoordinateContainer
        global::Java.Lang.Object global::Com.Mapbox.Geojson.ICoordinateContainer.Coordinates()
        {
            var coornidates = Coordinates().ToArray();
            return global::Android.Runtime.JavaArray<global::Com.Mapbox.Geojson.Point>.FromArray<global::Com.Mapbox.Geojson.Point>(coornidates);
        }
    }
}