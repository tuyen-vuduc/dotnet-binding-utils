namespace Com.Drivesync.Android.Provider.Mobile
{
    partial class AbstractMockProviderRequest
    {
        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest CancelUpdates(global::Android.Content.Context context, string logMessage)
            => CancelUpdatesX(context, logMessage) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest RequestUpdates(global::Android.Content.Context context, string logMessage)
            => RequestUpdatesX(context, logMessage) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest SetOnFailureListener(global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnFailureListener onFailureListener)
            => SetOnFailureListenerX(onFailureListener) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest SetOnSuccessListener(global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnSuccessListener onSuccessListener)
            => SetOnSuccessListenerX(onSuccessListener) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest SetUpdateListener(string action, global::Java.Lang.Class manifestReceiverClass)
            => SetUpdateListenerX(action, manifestReceiverClass) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest SetUpdateListener(string action, global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnUpdateListener updateListener)
            => SetUpdateListenerX(action, updateListener) as Com.Drivesync.Android.Provider.IGenericProviderRequest;
    }

    partial class AbstractProviderRequest
    {
        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest CancelUpdates(global::Android.Content.Context context, string logMessage)
            => CancelUpdatesX(context, logMessage) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest RequestUpdates(global::Android.Content.Context context, string logMessage)
            => RequestUpdatesX(context, logMessage) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest SetOnFailureListener(global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnFailureListener onFailureListener)
            => SetOnFailureListenerX(onFailureListener) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest SetOnSuccessListener(global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnSuccessListener onSuccessListener)
            => SetOnSuccessListenerX(onSuccessListener) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest SetUpdateListener(string action, global::Java.Lang.Class manifestReceiverClass)
            => SetUpdateListenerX(action, manifestReceiverClass) as Com.Drivesync.Android.Provider.IGenericProviderRequest;

        public virtual unsafe Com.Drivesync.Android.Provider.IGenericProviderRequest SetUpdateListener(string action, global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnUpdateListener updateListener)
            => SetUpdateListenerX(action, updateListener) as Com.Drivesync.Android.Provider.IGenericProviderRequest;
    }
}