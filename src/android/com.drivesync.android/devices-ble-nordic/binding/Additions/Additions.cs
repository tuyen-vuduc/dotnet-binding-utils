namespace Com.Drivesync.Android.Devices.Ble
{
    partial class BaseBleDeviceProvider : global::Com.Drivesync.Android.Devices.Ble.CommonBleDeviceProvider
    { }

    partial class CommonBleDeviceProvider
    {
        public override unsafe void StartDeviceDetection(global::Android.Content.Context context, global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Devices.DsDevice> devices, long timeout, global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener)
            => StartDeviceDetectionX(context, devices, timeout, listener);
    }
}