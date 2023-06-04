namespace Com.Drivesync.Android.Location.Mobile
{
    partial class GmsGeofenceProvider : Com.Drivesync.Android.Location.IDsGeofenceProvider
    {
        public override unsafe global::Java.Lang.Object ParseResult(global::Android.Content.Intent intent)
            => ParseResultX(intent);

        public override unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest CreateRequest()
            => CreateRequestX() as global::Com.Drivesync.Android.Provider.IGenericProviderRequest;

        partial class GmsGeofenceRequest
        {
            public override unsafe global::Java.Lang.Object ParseResult(global::Android.Content.Intent intent)
                => ParseResultX(intent);
        }
    }
}