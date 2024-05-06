using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Braintreepayments.Api
{
    partial class Card_
    {

        static Delegate? cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
        static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
        {
            if (cb_writeToParcel_Landroid_os_Parcel_I == null)
                cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(n_WriteToParcel_Landroid_os_Parcel_I));
            return cb_writeToParcel_Landroid_os_Parcel_I;
        }

        static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Braintreepayments.Api.Card_>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
            var flags = (global::Android.OS.ParcelableWriteFlags)native_flags;
            __this.WriteToParcel(dest, flags!);
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.braintreepayments.api']/class[@name='Card']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
        [Register("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
        public unsafe void WriteToParcel(global::Android.OS.Parcel? dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
        {
            const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[2];
                __args[0] = new JniArgumentValue((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object)dest).Handle);
                __args[1] = new JniArgumentValue((int)flags);
                _members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(dest);
            }
        }
    }
}