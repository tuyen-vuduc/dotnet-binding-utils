using System;
using System.Linq;
using Android.Content;
using Android.Runtime;

namespace Com.Facebook.Share.Widget
{
    partial class GameRequestDialog
    {

        static Delegate cb_getOrderedModeHandlers;
#pragma warning disable 0169
        static Delegate GetGetOrderedModeHandlersHandler()
        {
            if (cb_getOrderedModeHandlers == null)
                cb_getOrderedModeHandlers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetOrderedModeHandlers));
            return cb_getOrderedModeHandlers;
        }

        static IntPtr n_GetOrderedModeHandlers(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Share.Widget.GameRequestDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.ToLocalJniHandle(__this.OrderedModeHandlersX);
        }
#pragma warning restore 0169

        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.share.widget']/class[@name='GameRequestDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "GetGetOrderedModeHandlersHandler")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }
}