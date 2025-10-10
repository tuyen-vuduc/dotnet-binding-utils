namespace Com.Mapbox.Maps {   
    using System;

    public sealed class OnStyleLoadedAction : Java.Lang.Object, Style.IOnStyleLoaded
    {
        private readonly Action<Style> styleLoaded;

        public OnStyleLoadedAction(Action<Style> styleLoaded)
        {
            this.styleLoaded = styleLoaded;
        }

        public void OnStyleLoaded(Style style) => styleLoaded?.Invoke(style);
    }

    partial class MapboxMap {
        public unsafe void GetStyle (
            Action<Style> styleLoaded)
            => GetStyle(new OnStyleLoadedAction(styleLoaded));

        public unsafe void LoadStyle (
            global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension styleExtension,
            Action<Style> styleLoaded)
            => LoadStyle(styleExtension, new OnStyleLoadedAction(styleLoaded));

        public unsafe void LoadStyle (
            global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension styleExtension,
            Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyle(
                styleExtension, new OnStyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyle (
            global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension styleExtension,
            global::Com.Mapbox.Maps.TransitionOptions styleTransitionOptions,
            Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyle(
                styleExtension, styleTransitionOptions,
                new OnStyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyle (string style, Action<Style> styleLoaded)
            => LoadStyle(style, new OnStyleLoadedAction(styleLoaded));

        public unsafe void LoadStyleUri (string styleUri, Action<Style> styleLoaded)
            => LoadStyleUri(styleUri, new OnStyleLoadedAction(styleLoaded));

        public unsafe void LoadStyleUri (
            string styleUri, Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyleUri(
                styleUri, new OnStyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyleUri (
            string styleUri, 
            global::Com.Mapbox.Maps.TransitionOptions styleTransitionOptions,
            Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyleUri(
                styleUri, styleTransitionOptions,
                new OnStyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyleJson (string styleJson, Action<Style> styleLoaded)
            => LoadStyleJson(styleJson, new OnStyleLoadedAction(styleLoaded));

        public unsafe void LoadStyleJson (
            string styleJson, Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyleJson(
                styleJson, new OnStyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyleJson (
            string styleJson, 
            global::Com.Mapbox.Maps.TransitionOptions styleTransitionOptions,
            Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyleJson(
                styleJson, styleTransitionOptions,
                new OnStyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));
    }
}