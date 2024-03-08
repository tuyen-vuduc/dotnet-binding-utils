namespace Com.Mapbox.Maps.Plugins.Gestures {
    public static class GesturesExtensions {
        public static unsafe global::Com.Mapbox.Maps.Plugins.Gestures.IGesturesPlugin GetGestures (this global::Com.Mapbox.Maps.Plugins.Delegates.IMapPluginProviderDelegate obj)
            => GesturesUtils.GetGestures(obj);
        public static unsafe global::Com.Mapbox.Android.Gestures.AndroidGesturesManager GetGesturesManager (this global::Com.Mapbox.Maps.Plugins.Delegates.IMapPluginExtensionsDelegate obj)
            => GesturesUtils.GetGesturesManager(obj);
    }
}