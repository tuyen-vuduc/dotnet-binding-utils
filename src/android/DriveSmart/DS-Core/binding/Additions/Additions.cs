using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Drivesmart.Dscore.Utils.Wrappers
{
    partial class ListMapperImpl
    {
        Java.Lang.Object? global::Com.Drivesmart.Dscore.Interfaces.Wrapper.IMapper.Map(Java.Lang.Object? input)
        {
            IntPtr native_input = JNIEnv.ToLocalJniHandle(input);

            try
            {
                var xinput = Android.Runtime.JavaList.FromJniHandle(native_input, JniHandleOwnership.TransferLocalRef);
                return (Java.Lang.Object?)Map(xinput);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_input);
            }
        }

        Java.Lang.Object? global::Com.Drivesmart.Dscore.Interfaces.Wrapper.IMapper.MapInvert(Java.Lang.Object? input)
        {
            IntPtr native_input = JNIEnv.ToLocalJniHandle(input);

            try
            {
                var xinput = Android.Runtime.JavaList.FromJniHandle(native_input, JniHandleOwnership.TransferLocalRef);
                return (Java.Lang.Object?)MapInvert(xinput);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_input);
            }
        }
    }

    partial class NullableInputListMapperImpl
    {
        Java.Lang.Object? global::Com.Drivesmart.Dscore.Interfaces.Wrapper.IMapper.Map(Java.Lang.Object? input)
        {
            IntPtr native_input = JNIEnv.ToLocalJniHandle(input);

            try
            {
                var xinput = Android.Runtime.JavaList.FromJniHandle(native_input, JniHandleOwnership.TransferLocalRef);
                return (Java.Lang.Object?)Map(xinput);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_input);
            }
        }

        Java.Lang.Object? global::Com.Drivesmart.Dscore.Interfaces.Wrapper.IMapper.MapInvert(Java.Lang.Object? input)
        {
            IntPtr native_input = JNIEnv.ToLocalJniHandle(input);

            try
            {
                var xinput = Android.Runtime.JavaList.FromJniHandle(native_input, JniHandleOwnership.TransferLocalRef);
                return (Java.Lang.Object?)MapInvert(xinput);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_input);
            }
        }
    }

    partial class NullableOutputListMapperImpl
    {
        Java.Lang.Object? global::Com.Drivesmart.Dscore.Interfaces.Wrapper.IMapper.Map(Java.Lang.Object? input)
        {
            IntPtr native_input = JNIEnv.ToLocalJniHandle(input);

            try
            {
                var xinput = Android.Runtime.JavaList.FromJniHandle(native_input, JniHandleOwnership.TransferLocalRef);
                return (Java.Lang.Object?)Map(xinput);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_input);
            }
        }

        Java.Lang.Object? global::Com.Drivesmart.Dscore.Interfaces.Wrapper.IMapper.MapInvert(Java.Lang.Object? input)
        {
            IntPtr native_input = JNIEnv.ToLocalJniHandle(input);

            try
            {
                var xinput = Android.Runtime.JavaList.FromJniHandle(native_input, JniHandleOwnership.TransferLocalRef);
                return (Java.Lang.Object?)MapInvert(xinput);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_input);
            }
        }
    }
}

namespace Microsoft.Aspnet.Signalr.Client
{
    partial class DateSerializer : global::GoogleGson.IJsonDeserializer, global::GoogleGson.IJsonSerializer
    {
        Java.Lang.Object? global::GoogleGson.IJsonDeserializer.Deserialize(global::GoogleGson.JsonElement? p0, Java.Lang.Reflect.IType? p1, global::GoogleGson.IJsonDeserializationContext? p2)
            => Deserialize(p0, p1, p2);

        global::GoogleGson.JsonElement? global::GoogleGson.IJsonSerializer.Serialize(Java.Lang.Object? p0, Java.Lang.Reflect.IType? p1, global::GoogleGson.IJsonSerializationContext? p2)
            => Serialize(p0 as Java.Util.Date, p1, p2);
    }
    partial class CalendarSerializer : global::GoogleGson.IJsonDeserializer, global::GoogleGson.IJsonSerializer
    {
        Java.Lang.Object? global::GoogleGson.IJsonDeserializer.Deserialize(global::GoogleGson.JsonElement? p0, Java.Lang.Reflect.IType? p1, global::GoogleGson.IJsonDeserializationContext? p2)
            => Deserialize(p0, p1, p2);

        global::GoogleGson.JsonElement? global::GoogleGson.IJsonSerializer.Serialize(Java.Lang.Object? p0, Java.Lang.Reflect.IType? p1, global::GoogleGson.IJsonSerializationContext? p2)
            => Serialize(p0 as Java.Util.Calendar, p1, p2);
    }
}