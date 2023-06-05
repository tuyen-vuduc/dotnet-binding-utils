using Android.Runtime;
using System;

delegate bool _JniMarshal_PPL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0);
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

namespace Com.Drivesync.Android.Location
{
    partial interface IDsGeofenceProvider : global::Com.Drivesync.Android.Provider.IGenericProvider
    {

    }
    partial interface IDsGeofenceRequest : global::Com.Drivesync.Android.Provider.IGenericProviderRequest
    {

    }

    partial class IDsGeofenceProviderInvoker
    {

        static Delegate cb_createRequest;
#pragma warning disable 0169
        static Delegate GetCreateRequestHandler()
        {
            if (cb_createRequest == null)
                cb_createRequest = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_CreateRequest));
            return cb_createRequest;
        }

        static IntPtr n_CreateRequest(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle(__this.CreateRequest());
        }
#pragma warning restore 0169

        IntPtr id_createRequest;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest CreateRequest()
        {
            if (id_createRequest == IntPtr.Zero)
                id_createRequest = JNIEnv.GetMethodID(class_ref, "createRequest", "()Lcom/drivesync/android/provider/GenericProviderRequest;");
            return global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_createRequest), JniHandleOwnership.TransferLocalRef);
        }

        static Delegate cb_getRequiredPermissions;
#pragma warning disable 0169
        static Delegate GetGetRequiredPermissionsHandler()
        {
            if (cb_getRequiredPermissions == null)
                cb_getRequiredPermissions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetRequiredPermissions));
            return cb_getRequiredPermissions;
        }

        static IntPtr n_GetRequiredPermissions(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.ToLocalJniHandle(__this.RequiredPermissions);
        }
#pragma warning restore 0169

        IntPtr id_getRequiredPermissions;
        public unsafe global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Provider.DsProviderPermission> RequiredPermissions
        {
            get
            {
                if (id_getRequiredPermissions == IntPtr.Zero)
                    id_getRequiredPermissions = JNIEnv.GetMethodID(class_ref, "getRequiredPermissions", "()Ljava/util/List;");
                return global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getRequiredPermissions), JniHandleOwnership.TransferLocalRef);
            }
        }

        static Delegate cb_cancelUpdates_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetCancelUpdates_Landroid_content_Context_Ljava_lang_String_Handler()
        {
            if (cb_cancelUpdates_Landroid_content_Context_Ljava_lang_String_ == null)
                cb_cancelUpdates_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_CancelUpdates_Landroid_content_Context_Ljava_lang_String_));
            return cb_cancelUpdates_Landroid_content_Context_Ljava_lang_String_;
        }

        static IntPtr n_CancelUpdates_Landroid_content_Context_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_logMessage)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            var logMessage = JNIEnv.GetString(native_logMessage, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.CancelUpdates(context, logMessage));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_cancelUpdates_Landroid_content_Context_Ljava_lang_String_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest CancelUpdates(global::Android.Content.Context context, string logMessage)
        {
            if (id_cancelUpdates_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
                id_cancelUpdates_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "cancelUpdates", "(Landroid/content/Context;Ljava/lang/String;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            IntPtr native_logMessage = JNIEnv.NewString((string)logMessage);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            __args[1] = new JValue(native_logMessage);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_cancelUpdates_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_logMessage);
            return __ret;
        }

        static Delegate cb_getMissingPermissions_Landroid_content_Context_;
#pragma warning disable 0169
        [global::System.Obsolete]
        static Delegate GetGetMissingPermissions_Landroid_content_Context_Handler()
        {
            if (cb_getMissingPermissions_Landroid_content_Context_ == null)
                cb_getMissingPermissions_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetMissingPermissions_Landroid_content_Context_));
            return cb_getMissingPermissions_Landroid_content_Context_;
        }

        [global::System.Obsolete]
        static IntPtr n_GetMissingPermissions_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.ToLocalJniHandle(__this.GetMissingPermissions(context));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getMissingPermissions_Landroid_content_Context_;
        public unsafe global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Provider.DsProviderPermission> GetMissingPermissions(global::Android.Content.Context context)
        {
            if (id_getMissingPermissions_Landroid_content_Context_ == IntPtr.Zero)
                id_getMissingPermissions_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getMissingPermissions", "(Landroid/content/Context;)Ljava/util/List;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            var __ret = global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMissingPermissions_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_getPendingIntent_Landroid_content_Context_;
#pragma warning disable 0169
        static Delegate GetGetPendingIntent_Landroid_content_Context_Handler()
        {
            if (cb_getPendingIntent_Landroid_content_Context_ == null)
                cb_getPendingIntent_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetPendingIntent_Landroid_content_Context_));
            return cb_getPendingIntent_Landroid_content_Context_;
        }

        static IntPtr n_GetPendingIntent_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetPendingIntent(context));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getPendingIntent_Landroid_content_Context_;
        public unsafe global::Android.App.PendingIntent GetPendingIntent(global::Android.Content.Context context)
        {
            if (id_getPendingIntent_Landroid_content_Context_ == IntPtr.Zero)
                id_getPendingIntent_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getPendingIntent", "(Landroid/content/Context;)Landroid/app/PendingIntent;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getPendingIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_hasRequiredPermissions_Landroid_content_Context_;
#pragma warning disable 0169
        static Delegate GetHasRequiredPermissions_Landroid_content_Context_Handler()
        {
            if (cb_hasRequiredPermissions_Landroid_content_Context_ == null)
                cb_hasRequiredPermissions_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(n_HasRequiredPermissions_Landroid_content_Context_));
            return cb_hasRequiredPermissions_Landroid_content_Context_;
        }

        static bool n_HasRequiredPermissions_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            bool __ret = __this.HasRequiredPermissions(context);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_hasRequiredPermissions_Landroid_content_Context_;
        public unsafe bool HasRequiredPermissions(global::Android.Content.Context context)
        {
            if (id_hasRequiredPermissions_Landroid_content_Context_ == IntPtr.Zero)
                id_hasRequiredPermissions_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "hasRequiredPermissions", "(Landroid/content/Context;)Z");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_hasRequiredPermissions_Landroid_content_Context_, __args);
            return __ret;
        }

        static Delegate cb_parseResult_Landroid_content_Intent_;
#pragma warning disable 0169
        static Delegate GetParseResult_Landroid_content_Intent_Handler()
        {
            if (cb_parseResult_Landroid_content_Intent_ == null)
                cb_parseResult_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_ParseResult_Landroid_content_Intent_));
            return cb_parseResult_Landroid_content_Intent_;
        }

        static IntPtr n_ParseResult_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.ParseResult(intent));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_parseResult_Landroid_content_Intent_;
        public unsafe global::Java.Lang.Object ParseResult(global::Android.Content.Intent intent)
        {
            if (id_parseResult_Landroid_content_Intent_ == IntPtr.Zero)
                id_parseResult_Landroid_content_Intent_ = JNIEnv.GetMethodID(class_ref, "parseResult", "(Landroid/content/Intent;)Ljava/lang/Object;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object)intent).Handle);
            var __ret = (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_parseResult_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_requestUpdates_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetRequestUpdates_Landroid_content_Context_Ljava_lang_String_Handler()
        {
            if (cb_requestUpdates_Landroid_content_Context_Ljava_lang_String_ == null)
                cb_requestUpdates_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_RequestUpdates_Landroid_content_Context_Ljava_lang_String_));
            return cb_requestUpdates_Landroid_content_Context_Ljava_lang_String_;
        }

        static IntPtr n_RequestUpdates_Landroid_content_Context_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_logMessage)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            var logMessage = JNIEnv.GetString(native_logMessage, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RequestUpdates(context, logMessage));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_requestUpdates_Landroid_content_Context_Ljava_lang_String_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest RequestUpdates(global::Android.Content.Context context, string logMessage)
        {
            if (id_requestUpdates_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
                id_requestUpdates_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "requestUpdates", "(Landroid/content/Context;Ljava/lang/String;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            IntPtr native_logMessage = JNIEnv.NewString((string)logMessage);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            __args[1] = new JValue(native_logMessage);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_requestUpdates_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_logMessage);
            return __ret;
        }

        static Delegate cb_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_;
#pragma warning disable 0169
        static Delegate GetSetOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_Handler()
        {
            if (cb_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_ == null)
                cb_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_));
            return cb_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_;
        }

        static IntPtr n_SetOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onFailureListener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var onFailureListener = (global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnFailureListener)global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnFailureListener>(native_onFailureListener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetOnFailureListener(onFailureListener));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest SetOnFailureListener(global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnFailureListener onFailureListener)
        {
            if (id_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_ == IntPtr.Zero)
                id_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_ = JNIEnv.GetMethodID(class_ref, "setOnFailureListener", "(Lcom/drivesync/android/provider/GenericProviderRequest$OnFailureListener;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((onFailureListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)onFailureListener).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_;
#pragma warning disable 0169
        static Delegate GetSetOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_Handler()
        {
            if (cb_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_ == null)
                cb_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_));
            return cb_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_;
        }

        static IntPtr n_SetOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onSuccessListener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var onSuccessListener = (global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnSuccessListener>(native_onSuccessListener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetOnSuccessListener(onSuccessListener));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest SetOnSuccessListener(global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnSuccessListener onSuccessListener)
        {
            if (id_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_ == IntPtr.Zero)
                id_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_ = JNIEnv.GetMethodID(class_ref, "setOnSuccessListener", "(Lcom/drivesync/android/provider/GenericProviderRequest$OnSuccessListener;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((onSuccessListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)onSuccessListener).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_;
#pragma warning disable 0169
        static Delegate GetSetUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_Handler()
        {
            if (cb_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_ == null)
                cb_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_));
            return cb_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_;
        }

        static IntPtr n_SetUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_updateListener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var action = JNIEnv.GetString(native_action, JniHandleOwnership.DoNotTransfer);
            var updateListener = (global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnUpdateListener>(native_updateListener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetUpdateListener(action, updateListener));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest SetUpdateListener(string action, global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnUpdateListener updateListener)
        {
            if (id_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_ == IntPtr.Zero)
                id_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_ = JNIEnv.GetMethodID(class_ref, "setUpdateListener", "(Ljava/lang/String;Lcom/drivesync/android/provider/GenericProviderRequest$OnUpdateListener;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            IntPtr native_action = JNIEnv.NewString((string)action);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_action);
            __args[1] = new JValue((updateListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)updateListener).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_action);
            return __ret;
        }

        static Delegate cb_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
        static Delegate GetSetUpdateListener_Ljava_lang_String_Ljava_lang_Class_Handler()
        {
            if (cb_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_ == null)
                cb_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetUpdateListener_Ljava_lang_String_Ljava_lang_Class_));
            return cb_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_;
        }

        static IntPtr n_SetUpdateListener_Ljava_lang_String_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_manifestReceiverClass)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var action = JNIEnv.GetString(native_action, JniHandleOwnership.DoNotTransfer);
            var manifestReceiverClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class>(native_manifestReceiverClass, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetUpdateListener(action, manifestReceiverClass));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest SetUpdateListener(string action, global::Java.Lang.Class manifestReceiverClass)
        {
            if (id_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
                id_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID(class_ref, "setUpdateListener", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            IntPtr native_action = JNIEnv.NewString((string)action);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_action);
            __args[1] = new JValue((manifestReceiverClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object)manifestReceiverClass).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_action);
            return __ret;
        }
    }

    partial class IDsGeofenceRequestInvoker
    {

        static Delegate cb_getRequiredPermissions;
#pragma warning disable 0169
        static Delegate GetGetRequiredPermissionsHandler()
        {
            if (cb_getRequiredPermissions == null)
                cb_getRequiredPermissions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetRequiredPermissions));
            return cb_getRequiredPermissions;
        }

        static IntPtr n_GetRequiredPermissions(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.ToLocalJniHandle(__this.RequiredPermissions);
        }
#pragma warning restore 0169

        IntPtr id_getRequiredPermissions;
        public unsafe global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Provider.DsProviderPermission> RequiredPermissions
        {
            get
            {
                if (id_getRequiredPermissions == IntPtr.Zero)
                    id_getRequiredPermissions = JNIEnv.GetMethodID(class_ref, "getRequiredPermissions", "()Ljava/util/List;");
                return global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getRequiredPermissions), JniHandleOwnership.TransferLocalRef);
            }
        }

        static Delegate cb_cancelUpdates_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetCancelUpdates_Landroid_content_Context_Ljava_lang_String_Handler()
        {
            if (cb_cancelUpdates_Landroid_content_Context_Ljava_lang_String_ == null)
                cb_cancelUpdates_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_CancelUpdates_Landroid_content_Context_Ljava_lang_String_));
            return cb_cancelUpdates_Landroid_content_Context_Ljava_lang_String_;
        }

        static IntPtr n_CancelUpdates_Landroid_content_Context_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_logMessage)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            var logMessage = JNIEnv.GetString(native_logMessage, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.CancelUpdates(context, logMessage));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_cancelUpdates_Landroid_content_Context_Ljava_lang_String_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest CancelUpdates(global::Android.Content.Context context, string logMessage)
        {
            if (id_cancelUpdates_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
                id_cancelUpdates_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "cancelUpdates", "(Landroid/content/Context;Ljava/lang/String;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            IntPtr native_logMessage = JNIEnv.NewString((string)logMessage);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            __args[1] = new JValue(native_logMessage);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_cancelUpdates_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_logMessage);
            return __ret;
        }

        static Delegate cb_getMissingPermissions_Landroid_content_Context_;
#pragma warning disable 0169
        [global::System.Obsolete]
        static Delegate GetGetMissingPermissions_Landroid_content_Context_Handler()
        {
            if (cb_getMissingPermissions_Landroid_content_Context_ == null)
                cb_getMissingPermissions_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetMissingPermissions_Landroid_content_Context_));
            return cb_getMissingPermissions_Landroid_content_Context_;
        }

        [global::System.Obsolete]
        static IntPtr n_GetMissingPermissions_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.ToLocalJniHandle(__this.GetMissingPermissions(context));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getMissingPermissions_Landroid_content_Context_;
        public unsafe global::System.Collections.Generic.IList<global::Com.Drivesync.Android.Provider.DsProviderPermission> GetMissingPermissions(global::Android.Content.Context context)
        {
            if (id_getMissingPermissions_Landroid_content_Context_ == IntPtr.Zero)
                id_getMissingPermissions_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getMissingPermissions", "(Landroid/content/Context;)Ljava/util/List;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            var __ret = global::Android.Runtime.JavaList<global::Com.Drivesync.Android.Provider.DsProviderPermission>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMissingPermissions_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_getPendingIntent_Landroid_content_Context_;
#pragma warning disable 0169
        static Delegate GetGetPendingIntent_Landroid_content_Context_Handler()
        {
            if (cb_getPendingIntent_Landroid_content_Context_ == null)
                cb_getPendingIntent_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_GetPendingIntent_Landroid_content_Context_));
            return cb_getPendingIntent_Landroid_content_Context_;
        }

        static IntPtr n_GetPendingIntent_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetPendingIntent(context));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getPendingIntent_Landroid_content_Context_;
        public unsafe global::Android.App.PendingIntent GetPendingIntent(global::Android.Content.Context context)
        {
            if (id_getPendingIntent_Landroid_content_Context_ == IntPtr.Zero)
                id_getPendingIntent_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getPendingIntent", "(Landroid/content/Context;)Landroid/app/PendingIntent;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getPendingIntent_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_hasRequiredPermissions_Landroid_content_Context_;
#pragma warning disable 0169
        static Delegate GetHasRequiredPermissions_Landroid_content_Context_Handler()
        {
            if (cb_hasRequiredPermissions_Landroid_content_Context_ == null)
                cb_hasRequiredPermissions_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(n_HasRequiredPermissions_Landroid_content_Context_));
            return cb_hasRequiredPermissions_Landroid_content_Context_;
        }

        static bool n_HasRequiredPermissions_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            bool __ret = __this.HasRequiredPermissions(context);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_hasRequiredPermissions_Landroid_content_Context_;
        public unsafe bool HasRequiredPermissions(global::Android.Content.Context context)
        {
            if (id_hasRequiredPermissions_Landroid_content_Context_ == IntPtr.Zero)
                id_hasRequiredPermissions_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "hasRequiredPermissions", "(Landroid/content/Context;)Z");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_hasRequiredPermissions_Landroid_content_Context_, __args);
            return __ret;
        }

        static Delegate cb_parseResult_Landroid_content_Intent_;
#pragma warning disable 0169
        static Delegate GetParseResult_Landroid_content_Intent_Handler()
        {
            if (cb_parseResult_Landroid_content_Intent_ == null)
                cb_parseResult_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_ParseResult_Landroid_content_Intent_));
            return cb_parseResult_Landroid_content_Intent_;
        }

        static IntPtr n_ParseResult_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.ParseResult(intent));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_parseResult_Landroid_content_Intent_;
        public unsafe global::Java.Lang.Object ParseResult(global::Android.Content.Intent intent)
        {
            if (id_parseResult_Landroid_content_Intent_ == IntPtr.Zero)
                id_parseResult_Landroid_content_Intent_ = JNIEnv.GetMethodID(class_ref, "parseResult", "(Landroid/content/Intent;)Ljava/lang/Object;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object)intent).Handle);
            var __ret = (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_parseResult_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_requestUpdates_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetRequestUpdates_Landroid_content_Context_Ljava_lang_String_Handler()
        {
            if (cb_requestUpdates_Landroid_content_Context_Ljava_lang_String_ == null)
                cb_requestUpdates_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_RequestUpdates_Landroid_content_Context_Ljava_lang_String_));
            return cb_requestUpdates_Landroid_content_Context_Ljava_lang_String_;
        }

        static IntPtr n_RequestUpdates_Landroid_content_Context_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_logMessage)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_context, JniHandleOwnership.DoNotTransfer);
            var logMessage = JNIEnv.GetString(native_logMessage, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.RequestUpdates(context, logMessage));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_requestUpdates_Landroid_content_Context_Ljava_lang_String_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest RequestUpdates(global::Android.Content.Context context, string logMessage)
        {
            if (id_requestUpdates_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
                id_requestUpdates_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "requestUpdates", "(Landroid/content/Context;Ljava/lang/String;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            IntPtr native_logMessage = JNIEnv.NewString((string)logMessage);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object)context).Handle);
            __args[1] = new JValue(native_logMessage);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_requestUpdates_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_logMessage);
            return __ret;
        }

        static Delegate cb_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_;
#pragma warning disable 0169
        static Delegate GetSetOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_Handler()
        {
            if (cb_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_ == null)
                cb_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_));
            return cb_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_;
        }

        static IntPtr n_SetOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onFailureListener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var onFailureListener = (global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnFailureListener)global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnFailureListener>(native_onFailureListener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetOnFailureListener(onFailureListener));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest SetOnFailureListener(global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnFailureListener onFailureListener)
        {
            if (id_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_ == IntPtr.Zero)
                id_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_ = JNIEnv.GetMethodID(class_ref, "setOnFailureListener", "(Lcom/drivesync/android/provider/GenericProviderRequest$OnFailureListener;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((onFailureListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)onFailureListener).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setOnFailureListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnFailureListener_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_;
#pragma warning disable 0169
        static Delegate GetSetOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_Handler()
        {
            if (cb_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_ == null)
                cb_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_SetOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_));
            return cb_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_;
        }

        static IntPtr n_SetOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_onSuccessListener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var onSuccessListener = (global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnSuccessListener>(native_onSuccessListener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetOnSuccessListener(onSuccessListener));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest SetOnSuccessListener(global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnSuccessListener onSuccessListener)
        {
            if (id_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_ == IntPtr.Zero)
                id_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_ = JNIEnv.GetMethodID(class_ref, "setOnSuccessListener", "(Lcom/drivesync/android/provider/GenericProviderRequest$OnSuccessListener;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((onSuccessListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)onSuccessListener).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setOnSuccessListener_Lcom_drivesync_android_provider_GenericProviderRequest_OnSuccessListener_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_;
#pragma warning disable 0169
        static Delegate GetSetUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_Handler()
        {
            if (cb_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_ == null)
                cb_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_));
            return cb_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_;
        }

        static IntPtr n_SetUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_updateListener)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var action = JNIEnv.GetString(native_action, JniHandleOwnership.DoNotTransfer);
            var updateListener = (global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnUpdateListener)global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnUpdateListener>(native_updateListener, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetUpdateListener(action, updateListener));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest SetUpdateListener(string action, global::Com.Drivesync.Android.Provider.IGenericProviderRequest.IOnUpdateListener updateListener)
        {
            if (id_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_ == IntPtr.Zero)
                id_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_ = JNIEnv.GetMethodID(class_ref, "setUpdateListener", "(Ljava/lang/String;Lcom/drivesync/android/provider/GenericProviderRequest$OnUpdateListener;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            IntPtr native_action = JNIEnv.NewString((string)action);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_action);
            __args[1] = new JValue((updateListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object)updateListener).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setUpdateListener_Ljava_lang_String_Lcom_drivesync_android_provider_GenericProviderRequest_OnUpdateListener_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_action);
            return __ret;
        }

        static Delegate cb_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_;
#pragma warning disable 0169
        static Delegate GetSetUpdateListener_Ljava_lang_String_Ljava_lang_Class_Handler()
        {
            if (cb_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_ == null)
                cb_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_SetUpdateListener_Ljava_lang_String_Ljava_lang_Class_));
            return cb_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_;
        }

        static IntPtr n_SetUpdateListener_Ljava_lang_String_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_action, IntPtr native_manifestReceiverClass)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var action = JNIEnv.GetString(native_action, JniHandleOwnership.DoNotTransfer);
            var manifestReceiverClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class>(native_manifestReceiverClass, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.SetUpdateListener(action, manifestReceiverClass));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_;
        public unsafe global::Com.Drivesync.Android.Provider.IGenericProviderRequest SetUpdateListener(string action, global::Java.Lang.Class manifestReceiverClass)
        {
            if (id_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
                id_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID(class_ref, "setUpdateListener", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/drivesync/android/provider/GenericProviderRequest;");
            IntPtr native_action = JNIEnv.NewString((string)action);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_action);
            __args[1] = new JValue((manifestReceiverClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object)manifestReceiverClass).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Com.Drivesync.Android.Provider.IGenericProviderRequest>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_setUpdateListener_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_action);
            return __ret;
        }
    }
}