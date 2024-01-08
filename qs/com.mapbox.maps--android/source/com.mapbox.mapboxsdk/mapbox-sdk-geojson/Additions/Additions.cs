namespace Com.Mapbox.Geojson.Gson
{
    public partial class BoundingBoxTypeAdapter
    {
        public override unsafe global::Java.Lang.Object Read(global::GoogleGson.Stream.JsonReader @in)
        {
            return ReadBoudingBox(@in);
        }

        public override unsafe void Write(global::GoogleGson.Stream.JsonWriter @out, global::Java.Lang.Object value)
        {
            Write(@out, value as global::Com.Mapbox.Geojson.BoundingBox);
        }
    }
}


namespace Com.Mapbox.Geojson
{
    public partial class PointAsCoordinatesTypeAdapter
    {
        public override unsafe global::Java.Lang.Object Read(global::GoogleGson.Stream.JsonReader @in)
        {
            return ReadPoint(@in);
        }

        public override unsafe void Write(global::GoogleGson.Stream.JsonWriter @out, global::Java.Lang.Object value)
        {
            Write(@out, value as global::Com.Mapbox.Geojson.Point);
        }
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
