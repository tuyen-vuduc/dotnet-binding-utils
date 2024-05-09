using System;
using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Com.Drivesync.Android.Devices.Bluetooth
{
    partial class BaseBluetoothDeviceProvider : global::Com.Drivesync.Android.Devices.Providers.IDsDeviceProvider
    {
        static Delegate? cb_startDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_;
#pragma warning disable 0169
        static Delegate GetStartDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_Handler()
        {
            if (cb_startDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_ == null)
                cb_startDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLJL_V(n_StartDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_));
            return cb_startDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_;
        }

        static void n_StartDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_devices, long timeout, IntPtr native_listener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Devices.Bluetooth.BaseBluetoothDeviceProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            var devices = global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Devices.DsDevice>.FromJniHandle(native_devices, JniHandleOwnership.DoNotTransfer);
            var listener = (global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener?)global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener>(native_listener, JniHandleOwnership.DoNotTransfer);
            __this.StartDeviceDetection(context!, devices, timeout, listener!);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.devices.bluetooth']/class[@name='BaseBluetoothDeviceProvider']/method[@name='startDeviceDetection' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.drivesync.android.devices.DsDevice&gt;'] and parameter[3][@type='long'] and parameter[4][@type='com.drivesync.android.devices.listeners.DsDeviceUpdateListener']]"
        [Register("startDeviceDetection", "(Landroid/content/Context;Ljava/util/List;JLcom/drivesync/android/devices/listeners/DsDeviceUpdateListener;)V", "GetStartDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_Handler")]
        public abstract void StartDeviceDetection(global::Android.Content.Context context, global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Devices.DsDevice>? devices, long timeout, global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener);


        static Delegate? cb_stopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_;
#pragma warning disable 0169
        static Delegate GetStopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_Handler()
        {
            if (cb_stopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_ == null)
                cb_stopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(n_StopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_));
            return cb_stopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_;
        }

        static void n_StopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_listener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Devices.Bluetooth.BaseBluetoothDeviceProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            var listener = (global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener?)global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener>(native_listener, JniHandleOwnership.DoNotTransfer);
            __this.StopDeviceDetection(context!, listener!);
        }
#pragma warning restore 0169

        [Register("stopDeviceDetection", "(Landroid/content/Context;Lcom/drivesync/android/devices/listeners/DsDeviceUpdateListener;)V", "GetStopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_Handler")]
        public abstract void StopDeviceDetection(global::Android.Content.Context context, global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener);

        static Delegate? cb_getSupportedDeviceTypes;
#pragma warning disable 0169
        static Delegate GetGetSupportedDeviceTypesHandler()
        {
            if (cb_getSupportedDeviceTypes == null)
                cb_getSupportedDeviceTypes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetSupportedDeviceTypes));
            return cb_getSupportedDeviceTypes;
        }

        static IntPtr n_GetSupportedDeviceTypes(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Devices.Bluetooth.BaseBluetoothDeviceProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaList<string>.ToLocalJniHandle(__this.SupportedDeviceTypes);
        }
#pragma warning restore 0169

        public abstract global::System.Collections.Generic.IList<global::System.String> SupportedDeviceTypes
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.devices.bluetooth']/class[@name='BaseBluetoothDeviceProvider']/method[@name='getSupportedDeviceTypes' and count(parameter)=0]"
            [Register("getSupportedDeviceTypes", "()Ljava/util/List;", "GetGetSupportedDeviceTypesHandler")]
            get;
        }
    }

    partial class BaseBluetoothDeviceProviderInvoker
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.devices.bluetooth']/class[@name='BaseBluetoothDeviceProvider']/method[@name='startDeviceDetection' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.drivesync.android.devices.DsDevice&gt;'] and parameter[3][@type='long'] and parameter[4][@type='com.drivesync.android.devices.listeners.DsDeviceUpdateListener']]"
        [Register("startDeviceDetection", "(Landroid/content/Context;Ljava/util/List;JLcom/drivesync/android/devices/listeners/DsDeviceUpdateListener;)V", "GetStartDeviceDetection_Landroid_content_Context_Ljava_util_List_JLcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_Handler")]
        public override unsafe void StartDeviceDetection(global::Android.Content.Context context, global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Devices.DsDevice>? devices, long timeout, global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener)
        {
            const string __id = "startDeviceDetection.(Landroid/content/Context;Ljava/util/List;JLcom/drivesync/android/devices/listeners/DsDeviceUpdateListener;)V";
            IntPtr native_devices = global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Devices.DsDevice>.ToLocalJniHandle(devices);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
                __args[1] = new JniArgumentValue(native_devices);
                __args[2] = new JniArgumentValue(timeout);
                __args[3] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)listener).Handle);
                _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_devices);
                global::System.GC.KeepAlive(context);
                global::System.GC.KeepAlive(devices);
                global::System.GC.KeepAlive(listener);
            }
        }

        [Register("stopDeviceDetection", "(Landroid/content/Context;Lcom/drivesync/android/devices/listeners/DsDeviceUpdateListener;)V", "GetStopDeviceDetection_Landroid_content_Context_Lcom_drivesync_android_devices_listeners_DsDeviceUpdateListener_Handler")]
        public override unsafe void StopDeviceDetection(global::Android.Content.Context context, global::Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener)
        {
            const string __id = "stopDeviceDetection.(Landroid/content/Context;Lcom/drivesync/android/devices/listeners/DsDeviceUpdateListener;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
                __args[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)listener).Handle);
                _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(context);
                global::System.GC.KeepAlive(listener);
            }
        }

        public override unsafe global::System.Collections.Generic.IList<global::System.String> SupportedDeviceTypes
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.devices.bluetooth']/class[@name='BaseBluetoothDeviceProvider']/method[@name='getSupportedDeviceTypes' and count(parameter)=0]"
            [Register("getSupportedDeviceTypes", "()Ljava/util/List;", "GetGetSupportedDeviceTypesHandler")]
            get
            {
                const string __id = "getSupportedDeviceTypes.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<string>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
                }
                finally
                {
                }
            }
        }
    }

    partial class BluetoothProfileProvider
    {
        public override void StartDeviceDetection(Context context, IList<DsDevice>? devices, long timeout, Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener)
            => DoStartDeviceDetection(context, devices, timeout, listener);
        public override void StopDeviceDetection(Context context, Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener)
            => DoStopDeviceDetection(context, listener);
        public override IList<string> SupportedDeviceTypes => GetSupportedDeviceTypes();
    }
}
namespace Com.Drivesync.Android.Devices
{
    partial class BluetoothPairedAclProvider
    {
        public override void StartDeviceDetection(Context context, IList<DsDevice>? devices, long timeout, Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener)
            => DoStartDeviceDetection(context, devices, timeout, listener);
        public override void StopDeviceDetection(Context context, Com.Drivesync.Android.Devices.Listeners.IDsDeviceUpdateListener listener)
            => DoStopDeviceDetection(context, listener);
        public override IList<string> SupportedDeviceTypes => GetSupportedDeviceTypes();
    }
}