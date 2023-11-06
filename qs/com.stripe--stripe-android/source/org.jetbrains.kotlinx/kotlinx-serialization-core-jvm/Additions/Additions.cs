using Android.Runtime;
using Java.Interop;
using System;

namespace Kotlinx.Serialization.Builtins
{
    partial class LongAsStringSerializer
    {
        global::Java.Lang.Object IDeserializationStrategy.Deserialize(global::Kotlinx.Serialization.Encoding.IDecoder decoder)
        {
            return Deserialize(decoder);;
        }

        void ISerializationStrategy.Serialize(global::Kotlinx.Serialization.Encoding.IEncoder encoder, global::Java.Lang.Object value)
        {
            Serialize(encoder, (value as global::Java.Lang.Long).LongValue());
        }
    }
}

namespace Kotlinx.Serialization.Internal
{
    partial class NamedValueEncoder
    {
        protected override global::Java.Lang.Object GetTag(Kotlinx.Serialization.Descriptors.ISerialDescriptor p0, int index)
        {
            var tag = GetTagX(p0, index);
            return new global::Java.Lang.String(tag);
        }
    }
    partial class NamedValueDecoder
    {
        protected override global::Java.Lang.Object GetTag(Kotlinx.Serialization.Descriptors.ISerialDescriptor p0, int index)
        {
            var tag = GetTagX(p0, index);
            return new global::Java.Lang.String(tag);
        }
    }
}

namespace Kotlinx.Serialization.Internal
{
    partial interface IGeneratedSerializer : global::Kotlinx.Serialization.IKSerializer
    {

    }

    partial class IGeneratedSerializerInvoker : global::Java.Lang.Object, IGeneratedSerializer
    {
        static Delegate cb_getDescriptor;
#pragma warning disable 0169
        static Delegate GetGetDescriptorHandler()
        {
            if (cb_getDescriptor == null)
                cb_getDescriptor = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetDescriptor);
            return cb_getDescriptor;
        }

        static IntPtr n_GetDescriptor(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Internal.IGeneratedSerializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle((__this as global::Kotlinx.Serialization.ISerializationStrategy).Descriptor);
        }
#pragma warning restore 0169

        IntPtr id_getDescriptor;
        public unsafe global::Kotlinx.Serialization.Descriptors.ISerialDescriptor Descriptor
        {
            get
            {
                if (id_getDescriptor == IntPtr.Zero)
                    id_getDescriptor = JNIEnv.GetMethodID(class_ref, "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;");
                return global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Descriptors.ISerialDescriptor>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getDescriptor), JniHandleOwnership.TransferLocalRef);
            }
        }

        static Delegate cb_deserialize_Lkotlinx_serialization_encoding_Decoder_;
#pragma warning disable 0169
        static Delegate GetDeserialize_Lkotlinx_serialization_encoding_Decoder_Handler()
        {
            if (cb_deserialize_Lkotlinx_serialization_encoding_Decoder_ == null)
                cb_deserialize_Lkotlinx_serialization_encoding_Decoder_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_Deserialize_Lkotlinx_serialization_encoding_Decoder_);
            return cb_deserialize_Lkotlinx_serialization_encoding_Decoder_;
        }

        static IntPtr n_Deserialize_Lkotlinx_serialization_encoding_Decoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_decoder)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Internal.IGeneratedSerializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var decoder = (global::Kotlinx.Serialization.Encoding.IDecoder)global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Encoding.IDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Deserialize(decoder));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_deserialize_Lkotlinx_serialization_encoding_Decoder_;
        public unsafe global::Java.Lang.Object Deserialize(global::Kotlinx.Serialization.Encoding.IDecoder decoder)
        {
            if (id_deserialize_Lkotlinx_serialization_encoding_Decoder_ == IntPtr.Zero)
                id_deserialize_Lkotlinx_serialization_encoding_Decoder_ = JNIEnv.GetMethodID(class_ref, "deserialize", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/lang/Object;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((decoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)decoder).Handle);
            var __ret = (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_deserialize_Lkotlinx_serialization_encoding_Decoder_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetSerialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_Handler()
        {
            if (cb_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_ == null)
                cb_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_V)n_Serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_);
            return cb_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_;
        }

        static void n_Serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_encoder, IntPtr native_value)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Internal.IGeneratedSerializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var encoder = (global::Kotlinx.Serialization.Encoding.IEncoder)global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Encoding.IEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
            var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
            __this.Serialize(encoder, value);
        }
#pragma warning restore 0169

        IntPtr id_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_;
        public unsafe void Serialize(global::Kotlinx.Serialization.Encoding.IEncoder encoder, global::Java.Lang.Object value)
        {
            if (id_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_ == IntPtr.Zero)
                id_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "serialize", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/Object;)V");
            IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((encoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)encoder).Handle);
            __args[1] = new JValue(native_value);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_, __args);
            JNIEnv.DeleteLocalRef(native_value);
        }

    }
}

namespace Kotlinx.Serialization
{
    public partial interface IKSerializer : global::Kotlinx.Serialization.IDeserializationStrategy, global::Kotlinx.Serialization.ISerializationStrategy
    {
    }

    internal partial class IKSerializerInvoker : global::Java.Lang.Object, IKSerializer
    {
        static Delegate cb_getDescriptor;
#pragma warning disable 0169
        static Delegate GetGetDescriptorHandler()
        {
            if (cb_getDescriptor == null)
                cb_getDescriptor = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetDescriptor);
            return cb_getDescriptor;
        }

        static IntPtr n_GetDescriptor(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.IKSerializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.ToLocalJniHandle((__this as global::Kotlinx.Serialization.ISerializationStrategy).Descriptor);
        }
#pragma warning restore 0169

        IntPtr id_getDescriptor;
        public unsafe global::Kotlinx.Serialization.Descriptors.ISerialDescriptor Descriptor
        {
            get
            {
                if (id_getDescriptor == IntPtr.Zero)
                    id_getDescriptor = JNIEnv.GetMethodID(class_ref, "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;");
                return global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Descriptors.ISerialDescriptor>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getDescriptor), JniHandleOwnership.TransferLocalRef);
            }
        }

        static Delegate cb_deserialize_Lkotlinx_serialization_encoding_Decoder_;
#pragma warning disable 0169
        static Delegate GetDeserialize_Lkotlinx_serialization_encoding_Decoder_Handler()
        {
            if (cb_deserialize_Lkotlinx_serialization_encoding_Decoder_ == null)
                cb_deserialize_Lkotlinx_serialization_encoding_Decoder_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_Deserialize_Lkotlinx_serialization_encoding_Decoder_);
            return cb_deserialize_Lkotlinx_serialization_encoding_Decoder_;
        }

        static IntPtr n_Deserialize_Lkotlinx_serialization_encoding_Decoder_(IntPtr jnienv, IntPtr native__this, IntPtr native_decoder)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.IKSerializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var decoder = (global::Kotlinx.Serialization.Encoding.IDecoder)global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Encoding.IDecoder>(native_decoder, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Deserialize(decoder));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_deserialize_Lkotlinx_serialization_encoding_Decoder_;
        public unsafe global::Java.Lang.Object Deserialize(global::Kotlinx.Serialization.Encoding.IDecoder decoder)
        {
            if (id_deserialize_Lkotlinx_serialization_encoding_Decoder_ == IntPtr.Zero)
                id_deserialize_Lkotlinx_serialization_encoding_Decoder_ = JNIEnv.GetMethodID(class_ref, "deserialize", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/lang/Object;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((decoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)decoder).Handle);
            var __ret = (global::Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_deserialize_Lkotlinx_serialization_encoding_Decoder_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate cb_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetSerialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_Handler()
        {
            if (cb_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_ == null)
                cb_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_V)n_Serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_);
            return cb_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_;
        }

        static void n_Serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_encoder, IntPtr native_value)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.IKSerializer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            var encoder = (global::Kotlinx.Serialization.Encoding.IEncoder)global::Java.Lang.Object.GetObject<global::Kotlinx.Serialization.Encoding.IEncoder>(native_encoder, JniHandleOwnership.DoNotTransfer);
            var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
            __this.Serialize(encoder, value);
        }
#pragma warning restore 0169

        IntPtr id_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_;
        public unsafe void Serialize(global::Kotlinx.Serialization.Encoding.IEncoder encoder, global::Java.Lang.Object value)
        {
            if (id_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_ == IntPtr.Zero)
                id_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "serialize", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/Object;)V");
            IntPtr native_value = JNIEnv.ToLocalJniHandle(value);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((encoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object)encoder).Handle);
            __args[1] = new JValue(native_value);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_serialize_Lkotlinx_serialization_encoding_Encoder_Ljava_lang_Object_, __args);
            JNIEnv.DeleteLocalRef(native_value);
        }

    }
}
