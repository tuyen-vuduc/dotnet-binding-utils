using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Izettle.Payments.Android.Core {
    partial interface ILocationInfoController {
        partial class Companion {
            global::Java.Lang.Object global::Kotlin.Jvm.Functions.IFunction1.Invoke(global::Java.Lang.Object obj)
                => Invoke(obj as global::Android.Content.Context) as global::Java.Lang.Object;
        }
    }
    partial interface IFileWrapper {
        partial class Factory {
            global::Java.Lang.Object global::Kotlin.Jvm.Functions.IFunction1.Invoke(global::Java.Lang.Object obj)
                => Invoke(obj as global::Java.IO.File) as global::Java.Lang.Object;
        }
    }
}