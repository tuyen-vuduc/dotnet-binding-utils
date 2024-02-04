using Android.Runtime;
using Java.Interop;
using System;
using System.Linq;

namespace Com.Github.Kittinunf.Fuel.Core.Requests
{
    partial class UploadRequest
    {
        global::Com.Github.Kittinunf.Fuel.Core.IRequest global::Com.Github.Kittinunf.Fuel.Core.IRequestFactory.IRequestConvertible.Request => Request;
    }
    partial class DownloadRequest
    {
        global::Com.Github.Kittinunf.Fuel.Core.IRequest global::Com.Github.Kittinunf.Fuel.Core.IRequestFactory.IRequestConvertible.Request => Request;
    }
    partial class CancellableRequest
    {
        global::Com.Github.Kittinunf.Fuel.Core.IRequest global::Com.Github.Kittinunf.Fuel.Core.IRequestFactory.IRequestConvertible.Request => Request;
        global::Java.Lang.Object global::Java.Util.Concurrent.IFuture.Get() => Get();
        global::Java.Lang.Object global::Java.Util.Concurrent.IFuture.Get(long p0, global::Java.Util.Concurrent.TimeUnit p1) => Get(p0, p1);
    }
}

namespace Com.Github.Kittinunf.Fuel.Core.Extensions
{
    partial class AuthenticatedRequest
    {
        global::Com.Github.Kittinunf.Fuel.Core.IRequest global::Com.Github.Kittinunf.Fuel.Core.IRequestFactory.IRequestConvertible.Request => Request;
    }
}

namespace Com.Github.Kittinunf.Fuel.Core
{
    partial class InlineDataPart
    {
        public override System.IO.Stream InputStream()
        {
            return new Android.Runtime.InputStreamInvoker(InvokeInputStream());
        }
    }

    partial class Progress : global::Kotlin.Jvm.Functions.IFunction2
    {
        global::Java.Lang.Object global::Kotlin.Jvm.Functions.IFunction2.Invoke(global::Java.Lang.Object p0, global::Java.Lang.Object p1)
        {
            if (p0 is global::Java.Lang.Long l0 &&
                p1 is global::Java.Lang.Long l1)
            {
                Invoke(l0.LongValue(), l1.LongValue());
            }

            return null;
        }
    }

    partial class Headers : global::Java.Util.IMap
    {
        global::System.Collections.ICollection global::Java.Util.IMap.Values() => Values?.ToList();

        int global::Java.Util.IMap.Size() => Size;

        global::Java.Lang.Object global::Java.Util.IMap.Remove(Java.Lang.Object key) => new Android.Runtime.JavaList(Remove(key));

        void global::Java.Util.IMap.PutAll(global::System.Collections.IDictionary m) => PutAll(m as global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.ICollection<string>>);

        global::Java.Lang.Object global::Java.Util.IMap.Put(global::Java.Lang.Object key, global::Java.Lang.Object value)
        {
            var strings = global::Android.Runtime.JavaCollection<string>.FromJniHandle(value.Handle, Android.Runtime.JniHandleOwnership.TransferLocalRef);

            var result = Put(key?.ToString(), strings);

            return new Android.Runtime.JavaList(result);
        }

        global::System.Collections.ICollection global::Java.Util.IMap.KeySet() => KeySet()?.ToList();

        global::Java.Lang.Object global::Java.Util.IMap.Get(global::Java.Lang.Object key)
        {
            return new Android.Runtime.JavaList(Get(key));
        }

        global::System.Collections.ICollection global::Java.Util.IMap.EntrySet() => EntrySet()?.ToList();
    }
}

namespace Com.Github.Kittinunf.Fuel.Core.Interceptors
{
    partial class ParameterEncoder : global::Kotlin.Jvm.Functions.IFunction1
    {
        global::Java.Lang.Object global::Kotlin.Jvm.Functions.IFunction1.Invoke(global::Java.Lang.Object p0)
        {
            return Invoke(p0 as global::Kotlin.Jvm.Functions.IFunction1) as global::Java.Lang.Object;
        }
    }

    partial class LogRequestInterceptor : global::Kotlin.Jvm.Functions.IFunction1
    {
        global::Java.Lang.Object global::Kotlin.Jvm.Functions.IFunction1.Invoke(global::Java.Lang.Object p0)
        {
            return Invoke(p0 as global::Kotlin.Jvm.Functions.IFunction1) as global::Java.Lang.Object;
        }
    }

    partial class LogResponseInterceptor : global::Kotlin.Jvm.Functions.IFunction1
    {
        global::Java.Lang.Object global::Kotlin.Jvm.Functions.IFunction1.Invoke(global::Java.Lang.Object p0)
        {
            return Invoke(p0 as global::Kotlin.Jvm.Functions.IFunction2) as global::Java.Lang.Object;
        }
    }

    partial class LogRequestAsCurlInterceptor : global::Kotlin.Jvm.Functions.IFunction1
    {
        global::Java.Lang.Object global::Kotlin.Jvm.Functions.IFunction1.Invoke(global::Java.Lang.Object p0)
        {
            return Invoke(p0 as global::Kotlin.Jvm.Functions.IFunction1) as global::Java.Lang.Object;
        }
    }
}

namespace Com.Github.Kittinunf.Fuel.Core.Deserializers
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.github.kittinunf.fuel.core.deserializers']/class[@name='EmptyDeserializer']"
    [global::Android.Runtime.Register("com/github/kittinunf/fuel/core/deserializers/EmptyDeserializer", DoNotGenerateAcw = true)]
    public sealed partial class EmptyDeserializer : global::Java.Lang.Object, global::Com.Github.Kittinunf.Fuel.Core.IDeserializable
    {

        // Metadata.xml XPath field reference: path="/api/package[@name='com.github.kittinunf.fuel.core.deserializers']/class[@name='EmptyDeserializer']/field[@name='INSTANCE']"
        [Register("INSTANCE")]
        public static global::Com.Github.Kittinunf.Fuel.Core.Deserializers.EmptyDeserializer Instance
        {
            get
            {
                const string __id = "INSTANCE.Lcom/github/kittinunf/fuel/core/deserializers/EmptyDeserializer;";

                var __v = _members.StaticFields.GetObjectValue(__id);
                return global::Java.Lang.Object.GetObject<global::Com.Github.Kittinunf.Fuel.Core.Deserializers.EmptyDeserializer>(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
        }

        static readonly JniPeerMembers _members = new XAPeerMembers("com/github/kittinunf/fuel/core/deserializers/EmptyDeserializer", typeof(EmptyDeserializer));

        internal static IntPtr class_ref
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        internal EmptyDeserializer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.github.kittinunf.fuel.core.deserializers']/class[@name='EmptyDeserializer']/method[@name='deserialize' and count(parameter)=1 and parameter[1][@type='com.github.kittinunf.fuel.core.Response']]"
        [Register("deserialize", "(Lcom/github/kittinunf/fuel/core/Response;)V", "")]
        public unsafe void Deserialize(global::Com.Github.Kittinunf.Fuel.Core.Response response)
        {
            const string __id = "deserialize.(Lcom/github/kittinunf/fuel/core/Response;)V";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object)response).Handle);
                _members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, __args);
            }
            finally
            {
                global::System.GC.KeepAlive(response);
            }
        }

        // This method is explicitly implemented as a member of an instantiated Com.Github.Kittinunf.Fuel.Core.IDeserializable
        global::Java.Lang.Object global::Com.Github.Kittinunf.Fuel.Core.IDeserializable.Deserialize(global::Com.Github.Kittinunf.Fuel.Core.Response response)
        {
            Deserialize(response);

            return null;
        }

    }
}
namespace Com.Github.Kittinunf.Fuel.Core.Deserializers
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.github.kittinunf.fuel.core.deserializers']/class[@name='ByteArrayDeserializer']"
    [global::Android.Runtime.Register("com/github/kittinunf/fuel/core/deserializers/ByteArrayDeserializer", DoNotGenerateAcw = true)]
    public sealed partial class ByteArrayDeserializer : global::Java.Lang.Object, global::Com.Github.Kittinunf.Fuel.Core.IDeserializable
    {
        static readonly JniPeerMembers _members = new XAPeerMembers("com/github/kittinunf/fuel/core/deserializers/ByteArrayDeserializer", typeof(ByteArrayDeserializer));

        internal static IntPtr class_ref
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public override global::Java.Interop.JniPeerMembers JniPeerMembers
        {
            get { return _members; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override IntPtr ThresholdClass
        {
            get { return _members.JniPeerType.PeerReference.Handle; }
        }

        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override global::System.Type ThresholdType
        {
            get { return _members.ManagedPeerType; }
        }

        internal ByteArrayDeserializer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.kittinunf.fuel.core.deserializers']/class[@name='ByteArrayDeserializer']/constructor[@name='ByteArrayDeserializer' and count(parameter)=0]"
        [Register(".ctor", "()V", "")]
        public unsafe ByteArrayDeserializer() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            const string __id = "()V";

            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), null);
                SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
                _members.InstanceMethods.FinishCreateInstance(__id, this, null);
            }
            finally
            {
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='com.github.kittinunf.fuel.core.deserializers']/class[@name='ByteArrayDeserializer']/method[@name='deserialize' and count(parameter)=1 and parameter[1][@type='com.github.kittinunf.fuel.core.Response']]"
        [Register("deserialize", "(Lcom/github/kittinunf/fuel/core/Response;)[B", "")]
        public unsafe byte[] Deserialize(global::Com.Github.Kittinunf.Fuel.Core.Response response)
        {
            const string __id = "deserialize.(Lcom/github/kittinunf/fuel/core/Response;)[B";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object)response).Handle);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return (byte[])JNIEnv.GetArray(__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
            }
            finally
            {
                global::System.GC.KeepAlive(response);
            }
        }

        // This method is explicitly implemented as a member of an instantiated Com.Github.Kittinunf.Fuel.Core.IDeserializable
        global::Java.Lang.Object global::Com.Github.Kittinunf.Fuel.Core.IDeserializable.Deserialize(global::Com.Github.Kittinunf.Fuel.Core.Response response)
        {
            var result = Deserialize(response);

            return new Android.Runtime.JavaList(result);
        }

    }
}