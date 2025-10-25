using System;
using System.Collections;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

internal delegate sbyte _JniMarshal_PPLI_B(IntPtr jnienv, nint klass, nint p0, int p1);
internal delegate char _JniMarshal_PPLI_C(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
internal delegate double _JniMarshal_PPLI_D(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
internal delegate float _JniMarshal_PPLI_F(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
internal delegate int _JniMarshal_PPLI_I(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
internal delegate long _JniMarshal_PPLI_J(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
internal delegate short _JniMarshal_PPLI_S(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
internal delegate bool _JniMarshal_PPLI_Z(IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
internal delegate double _JniMarshal_PP_D(IntPtr jnienv, IntPtr klass);
internal delegate char _JniMarshal_PP_C(IntPtr jnienv, IntPtr klass);
internal delegate float _JniMarshal_PP_F(IntPtr jnienv, IntPtr klass);
internal delegate long _JniMarshal_PP_J(IntPtr jnienv, IntPtr klass);
internal delegate short _JniMarshal_PP_S(IntPtr jnienv, IntPtr klass);
internal delegate sbyte _JniMarshal_PP_B(IntPtr jnienv, IntPtr klass);
internal delegate int _JniMarshal_PPL_I(IntPtr jnienv, IntPtr klass, IntPtr p0);
// Missing marshal delegate used by generated stubs
internal delegate IntPtr _JniMarshal_PPLILL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2, IntPtr p3);

namespace KotlinX.Serialization.Json
{
    partial interface IJsonDecoder : global::KotlinX.Serialization.Encoding.ICompositeDecoder, global::KotlinX.Serialization.Encoding.IDecoder
    {

    }
    partial class IJsonDecoderInvoker
    {
        static Delegate? cb_decodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_Z(n_DecodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static bool n_DecodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            bool __ret = __this.DecodeBooleanElement(descriptor!, index!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe bool DecodeBooleanElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeBooleanElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)Z");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_decodeBooleanElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_B(n_DecodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static sbyte n_DecodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            sbyte __ret = __this.DecodeByteElement(descriptor!, index!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe sbyte DecodeByteElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeByteElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)B");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.CallByteMethod(((global::Java.Lang.Object)this).Handle, id_decodeByteElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_C(n_DecodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static char n_DecodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            char __ret = __this.DecodeCharElement(descriptor!, index!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe char DecodeCharElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeCharElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)C");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.CallCharMethod(((global::Java.Lang.Object)this).Handle, id_decodeCharElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_;
#pragma warning disable 0169
        static Delegate GetDecodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_Handler()
        {
            if (cb_decodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_ == null)
                cb_decodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(n_DecodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_));
            return cb_decodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_;
        }

        static int n_DecodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.DecodeCollectionSize(descriptor!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_;
        public unsafe int DecodeCollectionSize(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor)
        {
            if (id_decodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_ == IntPtr.Zero)
                id_decodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNIEnv.GetMethodID(java_class_ref, "decodeCollectionSize", "(LKotlinX/serialization/descriptors/SerialDescriptor;)I");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_decodeCollectionSize_LKotlinX_serialization_descriptors_SerialDescriptor_, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_D(n_DecodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static double n_DecodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            double __ret = __this.DecodeDoubleElement(descriptor!, index!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe double DecodeDoubleElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeDoubleElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)D");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.CallDoubleMethod(((global::Java.Lang.Object)this).Handle, id_decodeDoubleElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_;
#pragma warning disable 0169
        static Delegate GetDecodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_Handler()
        {
            if (cb_decodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_ == null)
                cb_decodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(n_DecodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_));
            return cb_decodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_;
        }

        static int n_DecodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.DecodeElementIndex(descriptor!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_;
        public unsafe int DecodeElementIndex(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor)
        {
            if (id_decodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_ == IntPtr.Zero)
                id_decodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNIEnv.GetMethodID(java_class_ref, "decodeElementIndex", "(LKotlinX/serialization/descriptors/SerialDescriptor;)I");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_decodeElementIndex_LKotlinX_serialization_descriptors_SerialDescriptor_, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_F(n_DecodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static float n_DecodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            float __ret = __this.DecodeFloatElement(descriptor!, index!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe float DecodeFloatElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeFloatElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)F");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.CallFloatMethod(((global::Java.Lang.Object)this).Handle, id_decodeFloatElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(n_DecodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static IntPtr n_DecodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.DecodeInlineElement(descriptor!, index!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe global::KotlinX.Serialization.Encoding.IDecoder DecodeInlineElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeInlineElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)LKotlinX/serialization/encoding/Decoder;");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Encoding.IDecoder>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeInlineElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args), JniHandleOwnership.TransferLocalRef)!;
            return __ret;
        }

        static Delegate? cb_decodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_I(n_DecodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static int n_DecodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.DecodeIntElement(descriptor!, index!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe int DecodeIntElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeIntElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)I");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_decodeIntElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_J(n_DecodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static long n_DecodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            long __ret = __this.DecodeLongElement(descriptor!, index!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe long DecodeLongElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeLongElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)J");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_decodeLongElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetDecodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_Handler()
        {
            if (cb_decodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_ == null)
                cb_decodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLILL_L(n_DecodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_));
            return cb_decodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_;
        }

        static IntPtr n_DecodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index, IntPtr native_deserializer, IntPtr native_previousValue)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            var deserializer = (global::KotlinX.Serialization.IDeserializationStrategy?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.IDeserializationStrategy>(native_deserializer, JniHandleOwnership.DoNotTransfer);
            var previousValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_previousValue, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.DecodeNullableSerializableElement(descriptor!, index!, deserializer!, previousValue));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_;
        public unsafe global::Java.Lang.Object? DecodeNullableSerializableElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index, global::KotlinX.Serialization.IDeserializationStrategy deserializer, global::Java.Lang.Object? previousValue)
        {
            if (id_decodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_ == IntPtr.Zero)
                id_decodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_ = JNIEnv.GetMethodID(java_class_ref, "decodeNullableSerializableElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;ILKotlinX/serialization/DeserializationStrategy;Ljava/lang/Object;)Ljava/lang/Object;");
            JValue* __args = stackalloc JValue[4];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            __args[2] = new JValue((deserializer == null) ? IntPtr.Zero : ((global::Java.Lang.Object)deserializer).Handle);
            __args[3] = new JValue((previousValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object)previousValue).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeNullableSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate? cb_decodeSequentially;
#pragma warning disable 0169
        static Delegate GetDecodeSequentiallyHandler()
        {
            if (cb_decodeSequentially == null)
                cb_decodeSequentially = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(n_DecodeSequentially));
            return cb_decodeSequentially;
        }

        static bool n_DecodeSequentially(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeSequentially();
        }
#pragma warning restore 0169

        IntPtr id_decodeSequentially;
        public unsafe bool DecodeSequentially()
        {
            if (id_decodeSequentially == IntPtr.Zero)
                id_decodeSequentially = JNIEnv.GetMethodID(java_class_ref, "decodeSequentially", "()Z");
            return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_decodeSequentially)!;
        }

        static Delegate? cb_decodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetDecodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_Handler()
        {
            if (cb_decodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_ == null)
                cb_decodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLILL_L(n_DecodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_));
            return cb_decodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_;
        }

        static IntPtr n_DecodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index, IntPtr native_deserializer, IntPtr native_previousValue)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            var deserializer = (global::KotlinX.Serialization.IDeserializationStrategy?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.IDeserializationStrategy>(native_deserializer, JniHandleOwnership.DoNotTransfer);
            var previousValue = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_previousValue, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.DecodeSerializableElement(descriptor!, index!, deserializer!, previousValue));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_;
        public unsafe global::Java.Lang.Object? DecodeSerializableElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index, global::KotlinX.Serialization.IDeserializationStrategy deserializer, global::Java.Lang.Object? previousValue)
        {
            if (id_decodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_ == IntPtr.Zero)
                id_decodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_ = JNIEnv.GetMethodID(java_class_ref, "decodeSerializableElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;ILKotlinX/serialization/DeserializationStrategy;Ljava/lang/Object;)Ljava/lang/Object;");
            JValue* __args = stackalloc JValue[4];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            __args[2] = new JValue((deserializer == null) ? IntPtr.Zero : ((global::Java.Lang.Object)deserializer).Handle);
            __args[3] = new JValue((previousValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object)previousValue).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeSerializableElement_LKotlinX_serialization_descriptors_SerialDescriptor_ILKotlinX_serialization_DeserializationStrategy_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate? cb_decodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_S(n_DecodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static short n_DecodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            short __ret = __this.DecodeShortElement(descriptor!, index!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe short DecodeShortElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeShortElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)S");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.CallShortMethod(((global::Java.Lang.Object)this).Handle, id_decodeShortElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
#pragma warning disable 0169
        static Delegate GetDecodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_IHandler()
        {
            if (cb_decodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == null)
                cb_decodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(n_DecodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I));
            return cb_decodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        }

        static IntPtr n_DecodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.NewString(__this.DecodeStringElement(descriptor!, index!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I;
        public unsafe string DecodeStringElement(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor, int index)
        {
            if (id_decodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I == IntPtr.Zero)
                id_decodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I = JNIEnv.GetMethodID(java_class_ref, "decodeStringElement", "(LKotlinX/serialization/descriptors/SerialDescriptor;I)Ljava/lang/String;");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            __args[1] = new JValue(index);
            var __ret = JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeStringElement_LKotlinX_serialization_descriptors_SerialDescriptor_I, __args), JniHandleOwnership.TransferLocalRef)!;
            return __ret;
        }

        static Delegate? cb_endStructure_LKotlinX_serialization_descriptors_SerialDescriptor_;
#pragma warning disable 0169
        static Delegate GetEndStructure_LKotlinX_serialization_descriptors_SerialDescriptor_Handler()
        {
            if (cb_endStructure_LKotlinX_serialization_descriptors_SerialDescriptor_ == null)
                cb_endStructure_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(n_EndStructure_LKotlinX_serialization_descriptors_SerialDescriptor_));
            return cb_endStructure_LKotlinX_serialization_descriptors_SerialDescriptor_;
        }

        static void n_EndStructure_LKotlinX_serialization_descriptors_SerialDescriptor_(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            __this.EndStructure(descriptor!);
        }
#pragma warning restore 0169

        IntPtr id_endStructure_LKotlinX_serialization_descriptors_SerialDescriptor_;
        public unsafe void EndStructure(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor)
        {
            if (id_endStructure_LKotlinX_serialization_descriptors_SerialDescriptor_ == IntPtr.Zero)
                id_endStructure_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNIEnv.GetMethodID(java_class_ref, "endStructure", "(LKotlinX/serialization/descriptors/SerialDescriptor;)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_endStructure_LKotlinX_serialization_descriptors_SerialDescriptor_, __args);
        }

        static Delegate? cb_beginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_;
#pragma warning disable 0169
        static Delegate GetBeginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_Handler()
        {
            if (cb_beginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_ == null)
                cb_beginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_BeginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_));
            return cb_beginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_;
        }

        static IntPtr n_BeginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.BeginStructure(descriptor!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_beginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_;
        public unsafe global::KotlinX.Serialization.Encoding.ICompositeDecoder BeginStructure(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor)
        {
            if (id_beginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_ == IntPtr.Zero)
                id_beginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNIEnv.GetMethodID(java_class_ref, "beginStructure", "(LKotlinX/serialization/descriptors/SerialDescriptor;)LKotlinX/serialization/encoding/CompositeDecoder;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Encoding.ICompositeDecoder>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_beginStructure_LKotlinX_serialization_descriptors_SerialDescriptor_, __args), JniHandleOwnership.TransferLocalRef)!;
            return __ret;
        }

        static Delegate? cb_decodeBoolean;
#pragma warning disable 0169
        static Delegate GetDecodeBooleanHandler()
        {
            if (cb_decodeBoolean == null)
                cb_decodeBoolean = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(n_DecodeBoolean));
            return cb_decodeBoolean;
        }

        static bool n_DecodeBoolean(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeBoolean();
        }
#pragma warning restore 0169

        IntPtr id_decodeBoolean;
        public unsafe bool DecodeBoolean()
        {
            if (id_decodeBoolean == IntPtr.Zero)
                id_decodeBoolean = JNIEnv.GetMethodID(java_class_ref, "decodeBoolean", "()Z");
            return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_decodeBoolean)!;
        }

        static Delegate? cb_decodeByte;
#pragma warning disable 0169
        static Delegate GetDecodeByteHandler()
        {
            if (cb_decodeByte == null)
                cb_decodeByte = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_B(n_DecodeByte));
            return cb_decodeByte;
        }

        static sbyte n_DecodeByte(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeByte();
        }
#pragma warning restore 0169

        IntPtr id_decodeByte;
        public unsafe sbyte DecodeByte()
        {
            if (id_decodeByte == IntPtr.Zero)
                id_decodeByte = JNIEnv.GetMethodID(java_class_ref, "decodeByte", "()B");
            return JNIEnv.CallByteMethod(((global::Java.Lang.Object)this).Handle, id_decodeByte)!;
        }

        static Delegate? cb_decodeChar;
#pragma warning disable 0169
        static Delegate GetDecodeCharHandler()
        {
            if (cb_decodeChar == null)
                cb_decodeChar = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_C(n_DecodeChar));
            return cb_decodeChar;
        }

        static char n_DecodeChar(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeChar();
        }
#pragma warning restore 0169

        IntPtr id_decodeChar;
        public unsafe char DecodeChar()
        {
            if (id_decodeChar == IntPtr.Zero)
                id_decodeChar = JNIEnv.GetMethodID(java_class_ref, "decodeChar", "()C");
            return JNIEnv.CallCharMethod(((global::Java.Lang.Object)this).Handle, id_decodeChar)!;
        }

        static Delegate? cb_decodeDouble;
#pragma warning disable 0169
        static Delegate GetDecodeDoubleHandler()
        {
            if (cb_decodeDouble == null)
                cb_decodeDouble = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(n_DecodeDouble));
            return cb_decodeDouble;
        }

        static double n_DecodeDouble(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeDouble();
        }
#pragma warning restore 0169

        IntPtr id_decodeDouble;
        public unsafe double DecodeDouble()
        {
            if (id_decodeDouble == IntPtr.Zero)
                id_decodeDouble = JNIEnv.GetMethodID(java_class_ref, "decodeDouble", "()D");
            return JNIEnv.CallDoubleMethod(((global::Java.Lang.Object)this).Handle, id_decodeDouble)!;
        }

        static Delegate? cb_decodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_;
#pragma warning disable 0169
        static Delegate GetDecodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_Handler()
        {
            if (cb_decodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_ == null)
                cb_decodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(n_DecodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_));
            return cb_decodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_;
        }

        static int n_DecodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_(IntPtr jnienv, IntPtr native__this, IntPtr native_enumDescriptor)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var enumDescriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_enumDescriptor, JniHandleOwnership.DoNotTransfer);
            int __ret = __this.DecodeEnum(enumDescriptor!);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_;
        public unsafe int DecodeEnum(global::KotlinX.Serialization.Descriptors.ISerialDescriptor enumDescriptor)
        {
            if (id_decodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_ == IntPtr.Zero)
                id_decodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNIEnv.GetMethodID(java_class_ref, "decodeEnum", "(LKotlinX/serialization/descriptors/SerialDescriptor;)I");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((enumDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)enumDescriptor).Handle);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_decodeEnum_LKotlinX_serialization_descriptors_SerialDescriptor_, __args)!;
            return __ret;
        }

        static Delegate? cb_decodeFloat;
#pragma warning disable 0169
        static Delegate GetDecodeFloatHandler()
        {
            if (cb_decodeFloat == null)
                cb_decodeFloat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(n_DecodeFloat));
            return cb_decodeFloat;
        }

        static float n_DecodeFloat(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeFloat();
        }
#pragma warning restore 0169

        IntPtr id_decodeFloat;
        public unsafe float DecodeFloat()
        {
            if (id_decodeFloat == IntPtr.Zero)
                id_decodeFloat = JNIEnv.GetMethodID(java_class_ref, "decodeFloat", "()F");
            return JNIEnv.CallFloatMethod(((global::Java.Lang.Object)this).Handle, id_decodeFloat)!;
        }

        static Delegate? cb_decodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_;
#pragma warning disable 0169
        static Delegate GetDecodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_Handler()
        {
            if (cb_decodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_ == null)
                cb_decodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_DecodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_));
            return cb_decodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_;
        }

        static IntPtr n_DecodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_(IntPtr jnienv, IntPtr native__this, IntPtr native_descriptor)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var descriptor = (global::KotlinX.Serialization.Descriptors.ISerialDescriptor?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Descriptors.ISerialDescriptor>(native_descriptor, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.DecodeInline(descriptor!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_;
        public unsafe global::KotlinX.Serialization.Encoding.IDecoder DecodeInline(global::KotlinX.Serialization.Descriptors.ISerialDescriptor descriptor)
        {
            if (id_decodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_ == IntPtr.Zero)
                id_decodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_ = JNIEnv.GetMethodID(java_class_ref, "decodeInline", "(LKotlinX/serialization/descriptors/SerialDescriptor;)LKotlinX/serialization/encoding/Decoder;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((descriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object)descriptor).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Encoding.IDecoder>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeInline_LKotlinX_serialization_descriptors_SerialDescriptor_, __args), JniHandleOwnership.TransferLocalRef)!;
            return __ret;
        }

        static Delegate? cb_decodeInt;
#pragma warning disable 0169
        static Delegate GetDecodeIntHandler()
        {
            if (cb_decodeInt == null)
                cb_decodeInt = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(n_DecodeInt));
            return cb_decodeInt;
        }

        static int n_DecodeInt(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeInt();
        }
#pragma warning restore 0169

        IntPtr id_decodeInt;
        public unsafe int DecodeInt()
        {
            if (id_decodeInt == IntPtr.Zero)
                id_decodeInt = JNIEnv.GetMethodID(java_class_ref, "decodeInt", "()I");
            return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_decodeInt)!;
        }

        static Delegate? cb_decodeLong;
#pragma warning disable 0169
        static Delegate GetDecodeLongHandler()
        {
            if (cb_decodeLong == null)
                cb_decodeLong = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(n_DecodeLong));
            return cb_decodeLong;
        }

        static long n_DecodeLong(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeLong();
        }
#pragma warning restore 0169

        IntPtr id_decodeLong;
        public unsafe long DecodeLong()
        {
            if (id_decodeLong == IntPtr.Zero)
                id_decodeLong = JNIEnv.GetMethodID(java_class_ref, "decodeLong", "()J");
            return JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_decodeLong)!;
        }

        static Delegate? cb_decodeNotNullMark;
#pragma warning disable 0169
        static Delegate GetDecodeNotNullMarkHandler()
        {
            if (cb_decodeNotNullMark == null)
                cb_decodeNotNullMark = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(n_DecodeNotNullMark));
            return cb_decodeNotNullMark;
        }

        static bool n_DecodeNotNullMark(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeNotNullMark();
        }
#pragma warning restore 0169

        IntPtr id_decodeNotNullMark;
        public unsafe bool DecodeNotNullMark()
        {
            if (id_decodeNotNullMark == IntPtr.Zero)
                id_decodeNotNullMark = JNIEnv.GetMethodID(java_class_ref, "decodeNotNullMark", "()Z");
            return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_decodeNotNullMark)!;
        }

        static Delegate? cb_decodeNull;
#pragma warning disable 0169
        static Delegate GetDecodeNullHandler()
        {
            if (cb_decodeNull == null)
                cb_decodeNull = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_DecodeNull));
            return cb_decodeNull;
        }

        static IntPtr n_DecodeNull(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return JNIEnv.ToLocalJniHandle(__this.DecodeNull());
        }
#pragma warning restore 0169

        IntPtr id_decodeNull;
        public unsafe global::Java.Lang.Void? DecodeNull()
        {
            if (id_decodeNull == IntPtr.Zero)
                id_decodeNull = JNIEnv.GetMethodID(java_class_ref, "decodeNull", "()Ljava/lang/Void;");
            return global::Java.Lang.Object.GetObject<global::Java.Lang.Void>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeNull), JniHandleOwnership.TransferLocalRef);
        }

        static Delegate? cb_decodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_;
#pragma warning disable 0169
        static Delegate GetDecodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_Handler()
        {
            if (cb_decodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_ == null)
                cb_decodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_DecodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_));
            return cb_decodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_;
        }

        static IntPtr n_DecodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_(IntPtr jnienv, IntPtr native__this, IntPtr native_deserializer)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var deserializer = (global::KotlinX.Serialization.IDeserializationStrategy?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.IDeserializationStrategy>(native_deserializer, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.DecodeNullableSerializableValue(deserializer!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_;
        public unsafe global::Java.Lang.Object? DecodeNullableSerializableValue(global::KotlinX.Serialization.IDeserializationStrategy deserializer)
        {
            if (id_decodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_ == IntPtr.Zero)
                id_decodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_ = JNIEnv.GetMethodID(java_class_ref, "decodeNullableSerializableValue", "(LKotlinX/serialization/DeserializationStrategy;)Ljava/lang/Object;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((deserializer == null) ? IntPtr.Zero : ((global::Java.Lang.Object)deserializer).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeNullableSerializableValue_LKotlinX_serialization_DeserializationStrategy_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate? cb_decodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_;
#pragma warning disable 0169
        static Delegate GetDecodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_Handler()
        {
            if (cb_decodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_ == null)
                cb_decodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(n_DecodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_));
            return cb_decodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_;
        }

        static IntPtr n_DecodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_(IntPtr jnienv, IntPtr native__this, IntPtr native_deserializer)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var deserializer = (global::KotlinX.Serialization.IDeserializationStrategy?)global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.IDeserializationStrategy>(native_deserializer, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.DecodeSerializableValue(deserializer!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_decodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_;
        public unsafe global::Java.Lang.Object? DecodeSerializableValue(global::KotlinX.Serialization.IDeserializationStrategy deserializer)
        {
            if (id_decodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_ == IntPtr.Zero)
                id_decodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_ = JNIEnv.GetMethodID(java_class_ref, "decodeSerializableValue", "(LKotlinX/serialization/DeserializationStrategy;)Ljava/lang/Object;");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((deserializer == null) ? IntPtr.Zero : ((global::Java.Lang.Object)deserializer).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeSerializableValue_LKotlinX_serialization_DeserializationStrategy_, __args), JniHandleOwnership.TransferLocalRef);
            return __ret;
        }

        static Delegate? cb_decodeShort;
#pragma warning disable 0169
        static Delegate GetDecodeShortHandler()
        {
            if (cb_decodeShort == null)
                cb_decodeShort = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_S(n_DecodeShort));
            return cb_decodeShort;
        }

        static short n_DecodeShort(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.DecodeShort();
        }
#pragma warning restore 0169

        IntPtr id_decodeShort;
        public unsafe short DecodeShort()
        {
            if (id_decodeShort == IntPtr.Zero)
                id_decodeShort = JNIEnv.GetMethodID(java_class_ref, "decodeShort", "()S");
            return JNIEnv.CallShortMethod(((global::Java.Lang.Object)this).Handle, id_decodeShort)!;
        }

        static Delegate? cb_decodeString;
#pragma warning disable 0169
        static Delegate GetDecodeStringHandler()
        {
            if (cb_decodeString == null)
                cb_decodeString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_DecodeString));
            return cb_decodeString;
        }

        static IntPtr n_DecodeString(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::KotlinX.Serialization.Json.IJsonDecoder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return JNIEnv.NewString(__this.DecodeString());
        }
#pragma warning restore 0169

        IntPtr id_decodeString;
        public unsafe string DecodeString()
        {
            if (id_decodeString == IntPtr.Zero)
                id_decodeString = JNIEnv.GetMethodID(java_class_ref, "decodeString", "()Ljava/lang/String;");
            return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_decodeString), JniHandleOwnership.TransferLocalRef)!;
        }
    }

    partial class JsonObject : global::Java.Util.IMap
    {
        System.Collections.ICollection global::Java.Util.IMap.EntrySet()
            => EntrySet().ToList();

        Java.Lang.Object? global::Java.Util.IMap.Get(Java.Lang.Object? key)
            => Get(key);

        System.Collections.ICollection global::Java.Util.IMap.KeySet()
            => KeySet().ToList();

        Java.Lang.Object? global::Java.Util.IMap.Put(Java.Lang.Object? key, Java.Lang.Object? value)
            => Put(key?.ToString(), value as global::KotlinX.Serialization.Json.JsonElement);

        void global::Java.Util.IMap.PutAll(IDictionary m)
            => PutAll(new Dictionary<string, global::KotlinX.Serialization.Json.JsonElement>(
                m.Keys.Cast<string>().Select(x => new KeyValuePair<string, global::KotlinX.Serialization.Json.JsonElement>(
                x, m[x] as global::KotlinX.Serialization.Json.JsonElement
                ))));

        Java.Lang.Object? global::Java.Util.IMap.Remove(Java.Lang.Object? key)
            => Remove(key);

        int global::Java.Util.IMap.Size() => Size;

        System.Collections.ICollection global::Java.Util.IMap.Values()
            => Values.ToList();
    }


    partial class JsonArray : global::Java.Util.IList
    {
        bool global::Java.Util.IList.Add(global::Java.Lang.Object obj)
            => Add(obj as global::KotlinX.Serialization.Json.JsonElement);
        void global::Java.Util.IList.Add(int index, global::Java.Lang.Object obj)
            => Add(index, obj as global::KotlinX.Serialization.Json.JsonElement);

        bool Java.Util.ICollection.Add(Java.Lang.Object? obj)
            => Add(obj as global::KotlinX.Serialization.Json.JsonElement);

        bool global::Java.Util.IList.AddAll(global::System.Collections.ICollection items)
            => AddAll(items.Cast<global::KotlinX.Serialization.Json.JsonElement>().ToList());
        bool global::Java.Util.IList.AddAll(int index, global::System.Collections.ICollection items)
            => AddAll(index, items.Cast<global::KotlinX.Serialization.Json.JsonElement>().ToList());

        bool Java.Util.ICollection.AddAll(System.Collections.ICollection items)
            => AddAll(items.Cast<global::KotlinX.Serialization.Json.JsonElement>().ToList());

        bool Java.Util.IList.Contains(Java.Lang.Object? o)
            => Contains(o as global::KotlinX.Serialization.Json.JsonElement);

        bool Java.Util.IList.ContainsAll(System.Collections.ICollection items)
            => ContainsAll(items.Cast<global::Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.ContainsAll(System.Collections.ICollection items)
            => ContainsAll(items.Cast<global::Java.Lang.Object>().ToList());

        Java.Lang.Object? Java.Util.IList.Get(int index)
            => Get(index);

        int Java.Util.IList.IndexOf(Java.Lang.Object? o)
            => IndexOf(o as global::KotlinX.Serialization.Json.JsonElement);

        int Java.Util.IList.LastIndexOf(Java.Lang.Object? o)
            => LastIndexOf(o as global::KotlinX.Serialization.Json.JsonElement);

        Java.Lang.Object? Java.Util.IList.Remove(int index)
            => Remove(index);
        bool Java.Util.IList.Remove(Java.Lang.Object? o)
            => Remove(o as global::KotlinX.Serialization.Json.JsonElement);

        bool Java.Util.IList.RemoveAll(System.Collections.ICollection items)
            => RemoveAll(items.Cast<global::Java.Lang.Object>().ToList());
        bool Java.Util.ICollection.RemoveAll(System.Collections.ICollection items)
            => RemoveAll(items.Cast<global::Java.Lang.Object>().ToList());

        bool Java.Util.IList.RetainAll(System.Collections.ICollection items)
            => RetainAll(items.Cast<global::Java.Lang.Object>().ToList());

        bool Java.Util.ICollection.RetainAll(System.Collections.ICollection items)
            => RetainAll(items.Cast<global::Java.Lang.Object>().ToList());

        Java.Lang.Object? Java.Util.IList.Set(int index, Java.Lang.Object? element)
            => Set(index, element as global::KotlinX.Serialization.Json.JsonElement);

        int Java.Util.IList.Size() => Size;

        int Java.Util.ICollection.Size() => Size;

        System.Collections.IList Java.Util.IList.SubList(int fromIndex, int toIndex)
            => SubList(fromIndex, toIndex).ToList();
    }
}