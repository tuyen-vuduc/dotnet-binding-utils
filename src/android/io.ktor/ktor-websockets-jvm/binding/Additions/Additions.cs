using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace IO.Ktor.Websocket
{
    partial class ProtocolViolationException : global::Xamarin.KotlinX.Coroutines.ICopyableThrowable
    {
        global::Java.Lang.Object? global::Xamarin.KotlinX.Coroutines.ICopyableThrowable.CreateCopy()
        {
            var obj = CreateCopy() as global::Android.Runtime.IJavaObject;

            return new global::Java.Lang.Object(obj.Handle, JniHandleOwnership.DoNotTransfer);
        }
    }
    partial class FrameTooBigException : global::Xamarin.KotlinX.Coroutines.ICopyableThrowable
    {
        global::Java.Lang.Object? global::Xamarin.KotlinX.Coroutines.ICopyableThrowable.CreateCopy()
        {
            var obj = CreateCopy() as global::Android.Runtime.IJavaObject;

            return new global::Java.Lang.Object(obj.Handle, JniHandleOwnership.DoNotTransfer);
        }
    }
}