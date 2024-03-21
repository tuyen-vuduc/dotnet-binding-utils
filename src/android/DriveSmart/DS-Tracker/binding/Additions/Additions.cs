namespace Com.Dstracker.Utils
{
    partial class DoAsyncVoid
    {
        protected override Java.Lang.Object? DoInBackground(params Java.Lang.Object[]? @params)
        {
            return DoInBackground(@params.Cast<Java.Lang.Object>().ToArray());
        }
    }
}

namespace Com.Dstracker {
    partial class EventEntry : global::Android.Provider.IBaseColumns { }
}

namespace Com.Dstracker.Singleton
{
    using System;
    using Com.Dstracker.Enums;
    using Kotlin.Jvm.Functions;

    partial class Tracker
    {
        public void GetOrAddUserIdBy(string userId, Action<Outcome> action)
        {
            var func1 = new Function1Action<Outcome>(action);
            this.GetOrAddUserIdBy(userId, func1);
        }
        public void Configure(string userId, Action<Outcome> action)
        {
            var func1 = new Function1Action<Outcome>(action);
            this.SetUserId(userId, func1);
        }
        public void SetUserId(string userId, Action<Outcome> action)
        {
            var func1 = new Function1Action<Outcome>(action);
            this.SetUserId(userId, func1);
        }
        public void Start(string withMetaData, Action<Outcome> action)
        {
            var func1 = new Function1Action<Outcome>(action);
            this.Start(withMetaData, func1);
        }
        public void Stop(string userId, Action<Outcome> action)
        {
            var func1 = new Function1Action<Outcome>(action);
            this.Stop(func1);
        }
    }

    public class Function1Action<T> : Java.Lang.Object, IFunction1
    {
        private readonly Action<T> action;

        public Function1Action(Action<T> action)
        {
            this.action = action;
        }

        public Java.Lang.Object? Invoke(Java.Lang.Object? p0)
        {
            action?.Invoke((T)(object)p0);
            return null;
        }
    }
}