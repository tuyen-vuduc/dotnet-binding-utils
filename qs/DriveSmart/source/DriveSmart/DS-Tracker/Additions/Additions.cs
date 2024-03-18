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