using Android.Runtime;
using Java.Interop;

namespace Com.Drivesync.Android.Provider.Mobile
{
    partial class AbstractProvider : global::Com.Drivesync.Android.Provider.IGenericProvider
    {
        static Delegate? cb_createRequest;
#pragma warning disable 0169
        static Delegate GetCreateRequestHandler()
        {
            if (cb_createRequest == null)
                cb_createRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_CreateRequest));
            return cb_createRequest;
        }

        static IntPtr n_CreateRequest(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.Mobile.AbstractProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return JNIEnv.ToLocalJniHandle(__this.CreateRequest());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.provider.mobile']/class[@name='AbstractProvider']/method[@name='createRequest' and count(parameter)=0]"
        [Register("createRequest", "()Lcom/drivesync/android/provider/GenericProviderRequest;", "GetCreateRequestHandler")]
        public abstract global::Com.Drivesync.Android.Provider.IGenericProviderRequest CreateRequest();

        static Delegate? cb_parseResult_Landroid_content_Intent_;
#pragma warning disable 0169
        static Delegate GetParseResult_Landroid_content_Intent_Handler()
        {
            if (cb_parseResult_Landroid_content_Intent_ == null)
                cb_parseResult_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_ParseResult_Landroid_content_Intent_));
            return cb_parseResult_Landroid_content_Intent_;
        }

        static IntPtr n_ParseResult_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.Mobile.AbstractProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.ParseResult(intent!));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.provider.mobile']/class[@name='AbstractProvider']/method[@name='parseResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
        [Register("parseResult", "(Landroid/content/Intent;)Ljava/lang/Object;", "GetParseResult_Landroid_content_Intent_Handler")]
        public abstract global::Java.Lang.Object? ParseResult(global::Android.Content.Intent intent);
    }
    partial class AbstractProviderInvoker
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.provider.mobile']/class[@name='AbstractProvider']/method[@name='createRequest' and count(parameter)=0]"
        [Register("createRequest", "()Lcom/drivesync/android/provider/GenericProviderRequest;", "GetCreateRequestHandler")]
        public override unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest CreateRequest()
        {
            const string __id = "createRequest.()Lcom/drivesync/android/provider/GenericProviderRequest;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                return global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.provider.mobile']/class[@name='AbstractProvider']/method[@name='parseResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
        [Register("parseResult", "(Landroid/content/Intent;)Ljava/lang/Object;", "GetParseResult_Landroid_content_Intent_Handler")]
        public override unsafe global::Java.Lang.Object? ParseResult(global::Android.Content.Intent intent)
        {
            const string __id = "parseResult.(Landroid/content/Intent;)Ljava/lang/Object;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object)intent).Handle);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return (global::Java.Lang.Object?)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(intent);
            }
        }
    }

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

    partial class AbstractProviderRequest : Com.Drivesync.Android.Provider.IGenericProviderRequest
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

        static Delegate? cb_parseResult_Landroid_content_Intent_;
#pragma warning disable 0169
        static Delegate GetParseResult_Landroid_content_Intent_Handler()
        {
            if (cb_parseResult_Landroid_content_Intent_ == null)
                cb_parseResult_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_ParseResult_Landroid_content_Intent_));
            return cb_parseResult_Landroid_content_Intent_;
        }

        static IntPtr n_ParseResult_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.Mobile.AbstractProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.ParseResult(intent!));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.provider.mobile']/class[@name='AbstractProviderRequest']/method[@name='parseResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
        [Register("parseResult", "(Landroid/content/Intent;)Ljava/lang/Object;", "GetParseResult_Landroid_content_Intent_Handler")]
        public abstract global::Java.Lang.Object? ParseResult(global::Android.Content.Intent intent);

        static Delegate? cb_getRequiredPermissions;
#pragma warning disable 0169
        static Delegate GetGetRequiredPermissionsHandler()
        {
            if (cb_getRequiredPermissions == null)
                cb_getRequiredPermissions = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetRequiredPermissions);
            return cb_getRequiredPermissions;
        }

        static IntPtr n_GetRequiredPermissions(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.Mobile.AbstractProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.ToLocalJniHandle(__this.RequiredPermissions);
        }
#pragma warning restore 0169

        public abstract global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Provider.DsProviderPermission> RequiredPermissions
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.provider.mobile']/class[@name='AbstractProviderRequest']/method[@name='getRequiredPermissions' and count(parameter)=0]"
            [Register("getRequiredPermissions", "()Ljava/util/List;", "GetGetRequiredPermissionsHandler")]
            get;
        }
    }
    partial class AbstractProviderRequestInvoker
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.provider.mobile']/class[@name='AbstractProviderRequest']/method[@name='parseResult' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
        [Register("parseResult", "(Landroid/content/Intent;)Ljava/lang/Object;", "GetParseResult_Landroid_content_Intent_Handler")]
        public override unsafe global::Java.Lang.Object? ParseResult(global::Android.Content.Intent intent)
        {
            const string __id = "parseResult.(Landroid/content/Intent;)Ljava/lang/Object;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object)intent).Handle);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return (global::Java.Lang.Object?)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(intent);
            }
        }
        public override unsafe global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Provider.DsProviderPermission> RequiredPermissions
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.drivesync.android.provider.mobile']/class[@name='AbstractProviderRequest']/method[@name='getRequiredPermissions' and count(parameter)=0]"
            [Register("getRequiredPermissions", "()Ljava/util/List;", "GetGetRequiredPermissionsHandler")]
            get
            {
                const string __id = "getRequiredPermissions.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
                }
                finally
                {
                }
            }
        }
    }
}