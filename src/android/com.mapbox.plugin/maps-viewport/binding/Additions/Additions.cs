using System;
using System.Threading.Tasks;

namespace Com.Mapbox.Maps.Plugins.Viewport
{
    using Com.Mapbox.Maps.Plugins.Viewport.State;
    using Com.Mapbox.Maps.Plugins.Viewport.Transition;

    public static class ViewPortPluginExtensions
    {
        public static void TransitionTo(this IViewportPlugin viewportPlugin, IViewportState targetState, IViewportTransition transition, Action<bool> completion)
            => viewportPlugin.TransitionTo(targetState, transition, completion != null ? new ViewPortCompletionListenerAction(completion) : null);

        public static Task<bool> TransitionToAsync(this IViewportPlugin viewportPlugin, IViewportState targetState, IViewportTransition transition, Action<bool> completion)
        {
            var tcs = new TaskCompletionSource<bool>();

            viewportPlugin.TransitionTo(targetState, transition, isFinished => tcs.TrySetResult(isFinished));

            return tcs.Task;
        }
    }

    public class ViewPortCompletionListenerAction : Java.Lang.Object, ICompletionListener
    {
        private Action<bool> _action;

        public ViewPortCompletionListenerAction(Action<bool> action) => this._action = action;

        public void OnComplete(bool isFinished) => this._action?.Invoke(isFinished);
    }
}