using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Kotlinx.Coroutines.Slf4j
{
    partial class MDCContext : global::Xamarin.KotlinX.Coroutines.IThreadContextElement
    {
        void global::Xamarin.KotlinX.Coroutines.IThreadContextElement.RestoreThreadContext (
            global::Kotlin.Coroutines.ICoroutineContext context,
            global::Java.Lang.Object? oldState)
        {
            var x = (IJavaObject)oldState!;
            RestoreThreadContext (
                context,
                new JavaDictionary<string, string>(
                    x.Handle,
                    JniHandleOwnership.TransferGlobalRef
                )
            );
        }

        global::Java.Lang.Object global::Xamarin.KotlinX.Coroutines.IThreadContextElement.UpdateThreadContext(
            global::Kotlin.Coroutines.ICoroutineContext context)
        {
            var result = UpdateThreadContext(
                context
            );

            return result is null
                ? null
                : new JavaDictionary<string, string>(
                    result
                );
        }
    }
}