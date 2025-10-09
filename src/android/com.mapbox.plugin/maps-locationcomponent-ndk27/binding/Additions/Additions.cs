namespace Com.Mapbox.Maps.Plugins.Locationcomponent {
    public static class LocationcomponentExtensions {
        public static unsafe global::Com.Mapbox.Maps.Plugins.Locationcomponent.ILocationComponentPlugin GetLocationComponent (this global::Com.Mapbox.Maps.Plugins.Delegates.IMapPluginProviderDelegate obj)
            => LocationComponentUtils.GetLocationComponent(obj);
    }
}