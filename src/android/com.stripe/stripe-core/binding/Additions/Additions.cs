using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Android.Core.Strings.Transformations
{
    partial class Replace
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
}

namespace Com.Stripe.Android.Core.Model
{
    partial class StripeFile
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class StripeFileParams
    {
        partial class FileLink
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
    }
    partial class Country
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class CountryCode
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
}
namespace Com.Stripe.Android.Core
{
    partial class AppInfo
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class StripeError
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
}
namespace Com.Stripe.Android.Core.Networking
{
    partial interface IStripeConnection
    {
        partial class AbstractConnection : Com.Stripe.Android.Core.Networking.IStripeConnection
        {
            static Delegate? cb_getResponse;
#pragma warning disable 0169
            static Delegate GetGetResponseHandler()
            {
                if (cb_getResponse == null)
                    cb_getResponse = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetResponse);
                return cb_getResponse;
            }

            static IntPtr n_GetResponse(IntPtr jnienv, IntPtr native__this)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Android.Core.Networking.IStripeConnection.AbstractConnection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
                return JNIEnv.ToLocalJniHandle(__this.Response);
            }
#pragma warning restore 0169

            public virtual unsafe global::Com.Stripe.Android.Core.Networking.StripeResponse Response
            {
                // Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.android.core.networking']/class[@name='StripeConnection.AbstractConnection']/method[@name='getResponse' and count(parameter)=0]"
                [Register("getResponse", "()Lcom/stripe/android/core/networking/StripeResponse;", "GetGetResponseHandler")]
                get
                {
                    const string __id = "getResponse.()Lcom/stripe/android/core/networking/StripeResponse;";
                    try
                    {
                        var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                        return global::Java.Lang.Object.GetObject<global::Com.Stripe.Android.Core.Networking.StripeResponse>(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
                    }
                    finally
                    {
                    }
                }
            }
            static Delegate? cb_getResponseCode;
#pragma warning disable 0169
            static Delegate GetGetResponseCodeHandler()
            {
                if (cb_getResponseCode == null)
                    cb_getResponseCode = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_I)n_GetResponseCode);
                return cb_getResponseCode;
            }

            static int n_GetResponseCode(IntPtr jnienv, IntPtr native__this)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Android.Core.Networking.IStripeConnection.AbstractConnection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
                return __this.ResponseCode;
            }
#pragma warning restore 0169

            public virtual unsafe int ResponseCode
            {
                // Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.android.core.networking']/class[@name='StripeConnection.AbstractConnection']/method[@name='getResponseCode' and count(parameter)=0]"
                [Register("getResponseCode", "()I", "GetGetResponseCodeHandler")]
                get
                {
                    const string __id = "getResponseCode.()I";
                    try
                    {
                        var __rm = _members.InstanceMethods.InvokeVirtualInt32Method(__id, this, null);
                        return __rm;
                    }
                    finally
                    {
                    }
                }
            }

            static Delegate? cb_createBodyFromResponseStream_Ljava_io_InputStream_;
#pragma warning disable 0169
            static Delegate GetCreateBodyFromResponseStream_Ljava_io_InputStream_Handler()
            {
                if (cb_createBodyFromResponseStream_Ljava_io_InputStream_ == null)
                    cb_createBodyFromResponseStream_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_CreateBodyFromResponseStream_Ljava_io_InputStream_);
                return cb_createBodyFromResponseStream_Ljava_io_InputStream_;
            }

            static IntPtr n_CreateBodyFromResponseStream_Ljava_io_InputStream_(IntPtr jnienv, IntPtr native__this, IntPtr native_responseStream)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Stripe.Android.Core.Networking.IStripeConnection.AbstractConnection>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
                var responseStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle(native_responseStream, JniHandleOwnership.DoNotTransfer);
                IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.CreateBodyFromResponseStream(responseStream));
                return __ret;
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.android.core.networking']/class[@name='StripeConnection.AbstractConnection']/method[@name='createBodyFromResponseStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
            [Register("createBodyFromResponseStream", "(Ljava/io/InputStream;)Ljava/lang/Object;", "GetCreateBodyFromResponseStream_Ljava_io_InputStream_Handler")]
            public abstract global::Java.Lang.Object? CreateBodyFromResponseStream(global::System.IO.Stream? responseStream);
        }
        partial class AbstractConnectionInvoker
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.android.core.networking']/class[@name='StripeConnection.AbstractConnection']/method[@name='createBodyFromResponseStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
            [Register("createBodyFromResponseStream", "(Ljava/io/InputStream;)Ljava/lang/Object;", "GetCreateBodyFromResponseStream_Ljava_io_InputStream_Handler")]
            public override unsafe global::Java.Lang.Object? CreateBodyFromResponseStream(global::System.IO.Stream? responseStream)
            {
                const string __id = "createBodyFromResponseStream.(Ljava/io/InputStream;)Ljava/lang/Object;";
                IntPtr native_responseStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle(responseStream);
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(native_responseStream);
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                    return (global::Java.Lang.Object?)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_responseStream);
                    global::System.GC.KeepAlive(responseStream);
                }
            }
        }
        partial class FileConnection
        {
            public override unsafe global::Java.Lang.Object? CreateBodyFromResponseStream(global::System.IO.Stream? responseStream)
                => CreateBodyFromResponseStreamX(responseStream);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.android.core.networking']/class[@name='StripeConnection.FileConnection']/method[@name='createBodyFromResponseStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
            [Register("createBodyFromResponseStream", "(Ljava/io/InputStream;)Ljava/io/File;", "")]
            public unsafe global::Java.IO.File? CreateBodyFromResponseStreamX(global::System.IO.Stream? responseStream)
            {
                const string __id = "createBodyFromResponseStream.(Ljava/io/InputStream;)Ljava/io/File;";
                IntPtr native_responseStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle(responseStream);
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(native_responseStream);
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Java.IO.File>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_responseStream);
                    global::System.GC.KeepAlive(responseStream);
                }
            }
        }
        partial class Default
        {
            public override unsafe global::Java.Lang.Object? CreateBodyFromResponseStream(global::System.IO.Stream? responseStream)
                => CreateBodyFromResponseStreamX(responseStream);

            // Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.android.core.networking']/class[@name='StripeConnection.Default']/method[@name='createBodyFromResponseStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
            [Register("createBodyFromResponseStream", "(Ljava/io/InputStream;)Ljava/io/File;", "")]
            public unsafe global::Java.IO.File? CreateBodyFromResponseStreamX(global::System.IO.Stream? responseStream)
            {
                const string __id = "createBodyFromResponseStream.(Ljava/io/InputStream;)Ljava/io/File;";
                IntPtr native_responseStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle(responseStream);
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue(native_responseStream);
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Java.IO.File>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_responseStream);
                    global::System.GC.KeepAlive(responseStream);
                }
            }
        }
    }
    partial interface IConnectionFactory
    {
        partial class Default
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.android.core.networking']/class[@name='ConnectionFactory.Default']/method[@name='create' and count(parameter)=1 and parameter[1][@type='com.stripe.android.core.networking.StripeRequest']]"
            [Register("create", "(Lcom/stripe/android/core/networking/StripeRequest;)Lcom/stripe/android/core/networking/StripeConnection;", "")]
            public unsafe global::Com.Stripe.Android.Core.Networking.IStripeConnection Create(global::Com.Stripe.Android.Core.Networking.StripeRequest request)
            {
                const string __id = "create.(Lcom/stripe/android/core/networking/StripeRequest;)Lcom/stripe/android/core/networking/StripeConnection;";
                try
                {
                    JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                    __args[0] = new JniArgumentValue((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object)request).Handle);
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                    return global::Java.Lang.Object.GetObject<global::Com.Stripe.Android.Core.Networking.IStripeConnection>(__rm.Handle, JniHandleOwnership.TransferLocalRef)!;
                }
                finally
                {
                    global::System.GC.KeepAlive(request);
                }
            }
        }
    }
    partial class ApiRequest
    {
        partial class Options
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
    }
}
namespace Com.Stripe.Android.Core.Model.Serializers
{
    partial class CountryListSerializer : global::KotlinX.Serialization.ISerializationStrategy
    {
        Java.Lang.Object? KotlinX.Serialization.IDeserializationStrategy.Deserialize(KotlinX.Serialization.Encoding.IDecoder decoder)
            => new global::Android.Runtime.JavaList<global::Com.Stripe.Android.Core.Model.Country>(Deserialize(decoder));

        void KotlinX.Serialization.ISerializationStrategy.Serialize(KotlinX.Serialization.Encoding.IEncoder encoder, Java.Lang.Object? value)
        {
            var xvalue = global::Android.Runtime.JavaList<global::Com.Stripe.Android.Core.Model.Country>.FromJniHandle(
                value.Handle,
                JniHandleOwnership.TransferLocalRef);
            Serialize(encoder, xvalue);
        }
    }
}
namespace Com.Stripe.Android.Core.Frauddetection
{
    partial class FraudDetectionData
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
}