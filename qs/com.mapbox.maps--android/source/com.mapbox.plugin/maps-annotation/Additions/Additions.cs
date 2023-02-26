namespace Com.Mapbox.Maps.Plugin.Annotation.Generated
{
    partial class PolygonAnnotationManager
    {
        protected override global::Java.Lang.Object CreateLayer() => DoCreateLayer();
        protected override global::Java.Lang.Object CreateDragLayer() => DoCreateDragLayer();
    }
    partial class CircleAnnotationManager
    {
        protected override global::Java.Lang.Object CreateLayer() => DoCreateLayer();
        protected override global::Java.Lang.Object CreateDragLayer() => DoCreateDragLayer();
    }
    partial class PointAnnotationManager
    {
        protected override global::Java.Lang.Object CreateLayer() => DoCreateLayer();
        protected override global::Java.Lang.Object CreateDragLayer() => DoCreateDragLayer();
    }
    partial class PolylineAnnotationManager
    {
        protected override global::Java.Lang.Object CreateLayer() => DoCreateLayer();
        protected override global::Java.Lang.Object CreateDragLayer() => DoCreateDragLayer();
    }
}
    namespace Com.Mapbox.Maps.Plugin.Annotation.Generated
{
    partial class CircleAnnotationOptions
    {
        public global::Java.Lang.Object Build(long id, global::Com.Mapbox.Maps.Plugin.Annotation.IAnnotationManager annotationManager)
        {
            return DoBuild(id, annotationManager);
        }
    }
    partial class PolylineAnnotationOptions
    {
        public global::Java.Lang.Object Build(long id, global::Com.Mapbox.Maps.Plugin.Annotation.IAnnotationManager annotationManager)
        {
            return DoBuild(id, annotationManager);
        }
    }
    partial class PolygonAnnotationOptions
    {
        public global::Java.Lang.Object Build(long id, global::Com.Mapbox.Maps.Plugin.Annotation.IAnnotationManager annotationManager)
        {
            return DoBuild(id, annotationManager);
        }
    }
    partial class PointAnnotationOptions
    {
        public global::Java.Lang.Object Build(long id, global::Com.Mapbox.Maps.Plugin.Annotation.IAnnotationManager annotationManager)
        {
            return DoBuild(id, annotationManager);
        }
    }
}

namespace Com.Mapbox.Maps.Plugin.Annotation.Generated
{
    partial class PolygonAnnotation
    {
        public override global::Java.Lang.Object GetOffsetGeometry(global::Com.Mapbox.Maps.Plugin.Delegates.IMapCameraManagerDelegate mapCameraManagerDelegate, global::Com.Mapbox.Android.Gestures.MoveDistancesObject moveDistancesObject)
        {
            return DoGetOffsetGeometry(mapCameraManagerDelegate, moveDistancesObject);
        }
    }
    partial class PolylineAnnotation
    {
        public override global::Java.Lang.Object GetOffsetGeometry(global::Com.Mapbox.Maps.Plugin.Delegates.IMapCameraManagerDelegate mapCameraManagerDelegate, global::Com.Mapbox.Android.Gestures.MoveDistancesObject moveDistancesObject)
        {
            return DoGetOffsetGeometry(mapCameraManagerDelegate, moveDistancesObject);
        }
    }
    partial class CircleAnnotation
    {
        public override global::Java.Lang.Object GetOffsetGeometry(global::Com.Mapbox.Maps.Plugin.Delegates.IMapCameraManagerDelegate mapCameraManagerDelegate, global::Com.Mapbox.Android.Gestures.MoveDistancesObject moveDistancesObject)
        {
            return DoGetOffsetGeometry(mapCameraManagerDelegate, moveDistancesObject);
        }
    }
    partial class PointAnnotation
    {
        public override global::Java.Lang.Object GetOffsetGeometry(global::Com.Mapbox.Maps.Plugin.Delegates.IMapCameraManagerDelegate mapCameraManagerDelegate, global::Com.Mapbox.Android.Gestures.MoveDistancesObject moveDistancesObject)
        {
            return DoGetOffsetGeometry(mapCameraManagerDelegate, moveDistancesObject);
        }
    }
}