using System;
using System.Linq;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Imagepipeline.Bitmaps
{
    partial class SimpleBitmapReleaser
    {
        unsafe void global::Com.Facebook.Common.References.IResourceReleaser.Release(global::Java.Lang.Object? value)
            => Release(value as global::Android.Graphics.Bitmap);
    }
}

namespace Com.Facebook.Cache.Disk
{
    partial class DefaultDiskStorage
    {
        global::System.Collections.Generic.ICollection<global::Com.Facebook.Cache.Disk.IDiskStorage.IEntry>? global::Com.Facebook.Cache.Disk.IDiskStorage.Entries
                => Entries?.ToList();
    }
}

namespace Com.Facebook.Imagepipeline.Image
{
    partial class BaseCloseableImage
    {
        void global::Com.Facebook.Fresco.Middleware.IHasExtraData.PutExtras(System.Collections.Generic.IDictionary<string, Java.Lang.Object> extras)
            => PutExtras(extras != null
                ? new Dictionary<string, object>(
                    extras.Select(x => new System.Collections.Generic.KeyValuePair<string, object>(x.Key, x.Value))
                )
                : null);
    }

    partial interface ICloseableImage : global::Com.Facebook.Imagepipeline.Image.IImageInfo
    {

    }

    partial interface ICloseableImage : global::Com.Facebook.Fresco.Middleware.IHasExtraData
    { }

    partial class ICloseableImageInvoker
    { 
        static Delegate? cb_getExtras;
#pragma warning disable 0169
        static Delegate GetGetExtrasHandler()
        {
            if (cb_getExtras == null)
                cb_getExtras = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetExtras);
            return cb_getExtras;
        }

        static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Middleware.IHasExtraData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.ToLocalJniHandle(__this.Extras);
        }
#pragma warning restore 0169

        IntPtr id_getExtras;
        public unsafe global::System.Collections.Generic.IDictionary<global::System.String, global::Java.Lang.Object> Extras
        {
            get
            {
                if (id_getExtras == IntPtr.Zero)
                    id_getExtras = JNIEnv.GetMethodID(class_ref, "getExtras", "()Ljava/util/Map;");
                return global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtras), JniHandleOwnership.TransferLocalRef)!;
            }
        }

        static Delegate? cb_getExtra_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetGetExtra_Ljava_lang_String_Handler()
        {
            if (cb_getExtra_Ljava_lang_String_ == null)
                cb_getExtra_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_GetExtra_Ljava_lang_String_);
            return cb_getExtra_Ljava_lang_String_;
        }

        static IntPtr n_GetExtra_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableImage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetExtra(key!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getExtra_Ljava_lang_String_;
        public unsafe global::Java.Lang.Object? GetExtra(string key)
        {
            if (id_getExtra_Ljava_lang_String_ == IntPtr.Zero)
                id_getExtra_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getExtra", "(Ljava/lang/String;)Ljava/lang/Object;");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(native_key);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtra_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_key);
            return __ret;
        }

        static Delegate? cb_getExtra_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetGetExtra_Ljava_lang_String_Ljava_lang_Object_Handler()
        {
            if (cb_getExtra_Ljava_lang_String_Ljava_lang_Object_ == null)
                cb_getExtra_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_L)n_GetExtra_Ljava_lang_String_Ljava_lang_Object_);
            return cb_getExtra_Ljava_lang_String_Ljava_lang_Object_;
        }

        static IntPtr n_GetExtra_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_valueIfNotFound)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableImage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            var valueIfNotFound = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_valueIfNotFound, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetExtra(key!, valueIfNotFound));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getExtra_Ljava_lang_String_Ljava_lang_Object_;
        public unsafe global::Java.Lang.Object? GetExtra(string key, global::Java.Lang.Object? valueIfNotFound)
        {
            if (id_getExtra_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
                id_getExtra_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "getExtra", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_key);
            __args[1] = new JValue((valueIfNotFound == null) ? IntPtr.Zero : ((global::Java.Lang.Object)valueIfNotFound).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtra_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_key);
            return __ret;
        }

        static Delegate? cb_putExtra_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetPutExtra_Ljava_lang_String_Ljava_lang_Object_Handler()
        {
            if (cb_putExtra_Ljava_lang_String_Ljava_lang_Object_ == null)
                cb_putExtra_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_V)n_PutExtra_Ljava_lang_String_Ljava_lang_Object_);
            return cb_putExtra_Ljava_lang_String_Ljava_lang_Object_;
        }

        static void n_PutExtra_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableImage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
            __this.PutExtra(key!, value);
        }
#pragma warning restore 0169

        IntPtr id_putExtra_Ljava_lang_String_Ljava_lang_Object_;
        public unsafe void PutExtra(string key, global::Java.Lang.Object? value)
        {
            if (id_putExtra_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
                id_putExtra_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "putExtra", "(Ljava/lang/String;Ljava/lang/Object;)V");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_key);
            __args[1] = new JValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_putExtra_Ljava_lang_String_Ljava_lang_Object_, __args);
            JNIEnv.DeleteLocalRef(native_key);
        }

        static Delegate? cb_putExtras_LSystem_Collections_Generic_IDictionary_2_;
#pragma warning disable 0169
        static Delegate GetPutExtras_LSystem_Collections_Generic_IDictionary_2_Handler()
        {
            if (cb_putExtras_LSystem_Collections_Generic_IDictionary_2_ == null)
                cb_putExtras_LSystem_Collections_Generic_IDictionary_2_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_PutExtras_LSystem_Collections_Generic_IDictionary_2_);
            return cb_putExtras_LSystem_Collections_Generic_IDictionary_2_;
        }

        static void n_PutExtras_LSystem_Collections_Generic_IDictionary_2_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableImage>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var extras = global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.FromJniHandle (native_extras, JniHandleOwnership.DoNotTransfer);
            __this.PutExtras(extras!);
        }
#pragma warning restore 0169

        IntPtr id_putExtras_LSystem_Collections_Generic_IDictionary_2_;
        public unsafe void PutExtras(global::System.Collections.Generic.IDictionary<global::System.String, global::Java.Lang.Object> extras)
        {
            if (id_putExtras_LSystem_Collections_Generic_IDictionary_2_ == IntPtr.Zero)
                id_putExtras_LSystem_Collections_Generic_IDictionary_2_ = JNIEnv.GetMethodID(class_ref, "putExtras", "(LSystem/Collections/Generic/IDictionary`2;)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((extras == null) ? IntPtr.Zero : ((global::Java.Lang.Object)extras).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_putExtras_LSystem_Collections_Generic_IDictionary_2_, __args);
        }
    }

    partial class ICloseableBitmapInvoker
    {
        static Delegate? cb_getExtras;
#pragma warning disable 0169
        static Delegate GetGetExtrasHandler()
        {
            if (cb_getExtras == null)
                cb_getExtras = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetExtras);
            return cb_getExtras;
        }

        static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Middleware.IHasExtraData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.ToLocalJniHandle(__this.Extras);
        }
#pragma warning restore 0169

        IntPtr id_getExtras;
        public unsafe global::System.Collections.Generic.IDictionary<global::System.String, global::Java.Lang.Object> Extras
        {
            get
            {
                if (id_getExtras == IntPtr.Zero)
                    id_getExtras = JNIEnv.GetMethodID(class_ref, "getExtras", "()Ljava/util/Map;");
                return global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtras), JniHandleOwnership.TransferLocalRef)!;
            }
        }

        static Delegate? cb_getExtra_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetGetExtra_Ljava_lang_String_Handler()
        {
            if (cb_getExtra_Ljava_lang_String_ == null)
                cb_getExtra_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_GetExtra_Ljava_lang_String_);
            return cb_getExtra_Ljava_lang_String_;
        }

        static IntPtr n_GetExtra_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableBitmap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetExtra(key!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getExtra_Ljava_lang_String_;
        public unsafe global::Java.Lang.Object? GetExtra(string key)
        {
            if (id_getExtra_Ljava_lang_String_ == IntPtr.Zero)
                id_getExtra_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getExtra", "(Ljava/lang/String;)Ljava/lang/Object;");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(native_key);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtra_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_key);
            return __ret;
        }

        static Delegate? cb_getExtra_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetGetExtra_Ljava_lang_String_Ljava_lang_Object_Handler()
        {
            if (cb_getExtra_Ljava_lang_String_Ljava_lang_Object_ == null)
                cb_getExtra_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_L)n_GetExtra_Ljava_lang_String_Ljava_lang_Object_);
            return cb_getExtra_Ljava_lang_String_Ljava_lang_Object_;
        }

        static IntPtr n_GetExtra_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_valueIfNotFound)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableBitmap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            var valueIfNotFound = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_valueIfNotFound, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetExtra(key!, valueIfNotFound));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getExtra_Ljava_lang_String_Ljava_lang_Object_;
        public unsafe global::Java.Lang.Object? GetExtra(string key, global::Java.Lang.Object? valueIfNotFound)
        {
            if (id_getExtra_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
                id_getExtra_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "getExtra", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_key);
            __args[1] = new JValue((valueIfNotFound == null) ? IntPtr.Zero : ((global::Java.Lang.Object)valueIfNotFound).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtra_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_key);
            return __ret;
        }

        static Delegate? cb_putExtra_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetPutExtra_Ljava_lang_String_Ljava_lang_Object_Handler()
        {
            if (cb_putExtra_Ljava_lang_String_Ljava_lang_Object_ == null)
                cb_putExtra_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_V)n_PutExtra_Ljava_lang_String_Ljava_lang_Object_);
            return cb_putExtra_Ljava_lang_String_Ljava_lang_Object_;
        }

        static void n_PutExtra_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableBitmap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
            __this.PutExtra(key!, value);
        }
#pragma warning restore 0169

        IntPtr id_putExtra_Ljava_lang_String_Ljava_lang_Object_;
        public unsafe void PutExtra(string key, global::Java.Lang.Object? value)
        {
            if (id_putExtra_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
                id_putExtra_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "putExtra", "(Ljava/lang/String;Ljava/lang/Object;)V");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_key);
            __args[1] = new JValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_putExtra_Ljava_lang_String_Ljava_lang_Object_, __args);
            JNIEnv.DeleteLocalRef(native_key);
        }

        static Delegate? cb_putExtras_LSystem_Collections_Generic_IDictionary_2_;
#pragma warning disable 0169
        static Delegate GetPutExtras_LSystem_Collections_Generic_IDictionary_2_Handler()
        {
            if (cb_putExtras_LSystem_Collections_Generic_IDictionary_2_ == null)
                cb_putExtras_LSystem_Collections_Generic_IDictionary_2_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_PutExtras_LSystem_Collections_Generic_IDictionary_2_);
            return cb_putExtras_LSystem_Collections_Generic_IDictionary_2_;
        }

        static void n_PutExtras_LSystem_Collections_Generic_IDictionary_2_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableBitmap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var extras = global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.FromJniHandle(native_extras, JniHandleOwnership.DoNotTransfer);
            __this.PutExtras(extras!);
        }
#pragma warning restore 0169

        IntPtr id_putExtras_LSystem_Collections_Generic_IDictionary_2_;
        public unsafe void PutExtras(global::System.Collections.Generic.IDictionary<global::System.String, global::Java.Lang.Object> extras)
        {
            if (id_putExtras_LSystem_Collections_Generic_IDictionary_2_ == IntPtr.Zero)
                id_putExtras_LSystem_Collections_Generic_IDictionary_2_ = JNIEnv.GetMethodID(class_ref, "putExtras", "(LSystem/Collections/Generic/IDictionary`2;)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((extras == null) ? IntPtr.Zero : ((global::Java.Lang.Object)extras).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_putExtras_LSystem_Collections_Generic_IDictionary_2_, __args);
        }
    }

    partial class ICloseableStaticBitmapInvoker
    {
        static Delegate? cb_getExtras;
#pragma warning disable 0169
        static Delegate GetGetExtrasHandler()
        {
            if (cb_getExtras == null)
                cb_getExtras = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetExtras);
            return cb_getExtras;
        }

        static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Middleware.IHasExtraData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.ToLocalJniHandle(__this.Extras);
        }
#pragma warning restore 0169

        IntPtr id_getExtras;
        public unsafe global::System.Collections.Generic.IDictionary<global::System.String, global::Java.Lang.Object> Extras
        {
            get
            {
                if (id_getExtras == IntPtr.Zero)
                    id_getExtras = JNIEnv.GetMethodID(class_ref, "getExtras", "()Ljava/util/Map;");
                return global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtras), JniHandleOwnership.TransferLocalRef)!;
            }
        }

        static Delegate? cb_getExtra_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetGetExtra_Ljava_lang_String_Handler()
        {
            if (cb_getExtra_Ljava_lang_String_ == null)
                cb_getExtra_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_GetExtra_Ljava_lang_String_);
            return cb_getExtra_Ljava_lang_String_;
        }

        static IntPtr n_GetExtra_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableBitmap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetExtra(key!));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getExtra_Ljava_lang_String_;
        public unsafe global::Java.Lang.Object? GetExtra(string key)
        {
            if (id_getExtra_Ljava_lang_String_ == IntPtr.Zero)
                id_getExtra_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getExtra", "(Ljava/lang/String;)Ljava/lang/Object;");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(native_key);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtra_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_key);
            return __ret;
        }

        static Delegate? cb_getExtra_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetGetExtra_Ljava_lang_String_Ljava_lang_Object_Handler()
        {
            if (cb_getExtra_Ljava_lang_String_Ljava_lang_Object_ == null)
                cb_getExtra_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_L)n_GetExtra_Ljava_lang_String_Ljava_lang_Object_);
            return cb_getExtra_Ljava_lang_String_Ljava_lang_Object_;
        }

        static IntPtr n_GetExtra_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_valueIfNotFound)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableBitmap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            var valueIfNotFound = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_valueIfNotFound, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.GetExtra(key!, valueIfNotFound));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getExtra_Ljava_lang_String_Ljava_lang_Object_;
        public unsafe global::Java.Lang.Object? GetExtra(string key, global::Java.Lang.Object? valueIfNotFound)
        {
            if (id_getExtra_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
                id_getExtra_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "getExtra", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_key);
            __args[1] = new JValue((valueIfNotFound == null) ? IntPtr.Zero : ((global::Java.Lang.Object)valueIfNotFound).Handle);
            var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtra_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
            JNIEnv.DeleteLocalRef(native_key);
            return __ret;
        }

        static Delegate? cb_putExtra_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
        static Delegate GetPutExtra_Ljava_lang_String_Ljava_lang_Object_Handler()
        {
            if (cb_putExtra_Ljava_lang_String_Ljava_lang_Object_ == null)
                cb_putExtra_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_V)n_PutExtra_Ljava_lang_String_Ljava_lang_Object_);
            return cb_putExtra_Ljava_lang_String_Ljava_lang_Object_;
        }

        static void n_PutExtra_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableBitmap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var key = JNIEnv.GetString(native_key, JniHandleOwnership.DoNotTransfer);
            var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
            __this.PutExtra(key!, value);
        }
#pragma warning restore 0169

        IntPtr id_putExtra_Ljava_lang_String_Ljava_lang_Object_;
        public unsafe void PutExtra(string key, global::Java.Lang.Object? value)
        {
            if (id_putExtra_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
                id_putExtra_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "putExtra", "(Ljava/lang/String;Ljava/lang/Object;)V");
            IntPtr native_key = JNIEnv.NewString((string?)key);
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(native_key);
            __args[1] = new JValue((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object)value).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_putExtra_Ljava_lang_String_Ljava_lang_Object_, __args);
            JNIEnv.DeleteLocalRef(native_key);
        }

        static Delegate? cb_putExtras_LSystem_Collections_Generic_IDictionary_2_;
#pragma warning disable 0169
        static Delegate GetPutExtras_LSystem_Collections_Generic_IDictionary_2_Handler()
        {
            if (cb_putExtras_LSystem_Collections_Generic_IDictionary_2_ == null)
                cb_putExtras_LSystem_Collections_Generic_IDictionary_2_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_PutExtras_LSystem_Collections_Generic_IDictionary_2_);
            return cb_putExtras_LSystem_Collections_Generic_IDictionary_2_;
        }

        static void n_PutExtras_LSystem_Collections_Generic_IDictionary_2_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.ICloseableBitmap>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var extras = global::Android.Runtime.JavaDictionary<global::System.String, global::Java.Lang.Object>.FromJniHandle(native_extras, JniHandleOwnership.DoNotTransfer);
            __this.PutExtras(extras!);
        }
#pragma warning restore 0169

        IntPtr id_putExtras_LSystem_Collections_Generic_IDictionary_2_;
        public unsafe void PutExtras(global::System.Collections.Generic.IDictionary<global::System.String, global::Java.Lang.Object> extras)
        {
            if (id_putExtras_LSystem_Collections_Generic_IDictionary_2_ == IntPtr.Zero)
                id_putExtras_LSystem_Collections_Generic_IDictionary_2_ = JNIEnv.GetMethodID(class_ref, "putExtras", "(LSystem/Collections/Generic/IDictionary`2;)V");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue((extras == null) ? IntPtr.Zero : ((global::Java.Lang.Object)extras).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_putExtras_LSystem_Collections_Generic_IDictionary_2_, __args);
        }
    }
}