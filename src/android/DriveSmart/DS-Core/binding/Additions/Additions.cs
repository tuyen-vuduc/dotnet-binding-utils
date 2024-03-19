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