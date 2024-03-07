namespace Com.Mapbox.Functions
{
    using System;
    using Kotlin.Jvm.Functions;

    public sealed class Function1Action<T>
        : Java.Lang.Object, IFunction1
        where T : Android.Runtime.IJavaObject
    {
        private readonly Action<T> action;

        public Function1Action(Action<T> action)
        {
            this.action = action;
        }

        public Java.Lang.Object? Invoke(Java.Lang.Object? p0)
        {
            Android.Runtime.IJavaObject obj = p0;

            action?.Invoke((T)obj);

            return null;
        }
    }
}