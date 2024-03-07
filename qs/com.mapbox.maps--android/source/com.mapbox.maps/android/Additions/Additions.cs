namespace Com.Mapbox.Maps {   
    using System;

    public class StyleLoadedAction : Java.Lang.Object, Style.IOnStyleLoaded
    {
        private readonly Action<Style> styleLoaded;

        public StyleLoadedAction(Action<Style> styleLoaded)
        {
            this.styleLoaded = styleLoaded;
        }

        public void OnStyleLoaded(Style style) => styleLoaded?.Invoke(style);
    }

    partial class MapboxMap {
        public unsafe void LoadStyle (
            global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension styleExtension,
            Action<Style> styleLoaded)
            => LoadStyle(styleExtension, new StyleLoadedAction(styleLoaded));

        public unsafe void LoadStyle (
            global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension styleExtension,
            Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyle(
                styleExtension, new StyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyle (
            global::Com.Mapbox.Maps.Extension.Style.IStyleContract.IStyleExtension styleExtension,
            global::Com.Mapbox.Maps.TransitionOptions styleTransitionOptions,
            Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyle(
                styleExtension, styleTransitionOptions,
                new StyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyle (string style, Action<Style> styleLoaded)
            => LoadStyle(style, new StyleLoadedAction(styleLoaded));

        public unsafe void LoadStyleUri (string styleUri, Action<Style> styleLoaded)
            => LoadStyleUri(styleUri, new StyleLoadedAction(styleLoaded));

        public unsafe void LoadStyleUri (
            string styleUri, Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyleUri(
                styleUri, new StyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyleUri (
            string styleUri, 
            global::Com.Mapbox.Maps.TransitionOptions styleTransitionOptions,
            Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyleUri(
                styleUri, styleTransitionOptions,
                new StyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyleJson (string styleJson, Action<Style> styleLoaded)
            => LoadStyleJson(styleJson, new StyleLoadedAction(styleLoaded));

        public unsafe void LoadStyleJson (
            string styleJson, Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyleJson(
                styleJson, new StyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));

        public unsafe void LoadStyleJson (
            string styleJson, 
            global::Com.Mapbox.Maps.TransitionOptions styleTransitionOptions,
            Action<Style> styleLoaded,
            Action<global::Com.Mapbox.Maps.Extension.Observable.Eventdata.MapLoadingErrorEventData> onError)
            => LoadStyleJson(
                styleJson, styleTransitionOptions,
                new StyleLoadedAction(styleLoaded), 
                new Com.Mapbox.Maps.Plugins.Delegates.Listeners.OnMapLoadErrorListenerAction(onError));
    }
}