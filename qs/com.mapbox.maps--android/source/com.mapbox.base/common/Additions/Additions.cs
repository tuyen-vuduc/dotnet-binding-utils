namespace Com.Mapbox.Functions {
    using System;
    using Kotlin.Jvm.Functions;

    public class Function1Action<T>
        : Java.Lang.Object, IFunction1
        where T: Java.Lang.Object
    {
        private readonly Action<T> action;

        public Function1Action(Action<T> action)
        {
            this.action = action;
        }

        public Java.Lang.Object? Invoke(Java.Lang.Object? p0)
        {
            action?.Invoke((T)p0);

            return null;
        }
    }
}