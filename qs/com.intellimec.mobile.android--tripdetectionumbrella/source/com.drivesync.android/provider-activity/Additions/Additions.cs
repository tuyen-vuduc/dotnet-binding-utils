using Android.Content;

namespace Com.Drivesync.Android.Provider.Activity.Mobile
{
    partial class GmsActivityProvider
    {
        public override global::Java.Lang.Object ParseResult(global::Android.Content.Intent intent)
            => ParseResultX(intent);

        public override global::Com.Drivesync.Android.Provider.IGenericProviderRequest CreateRequest()
            => CreateRequestX();
    }
}