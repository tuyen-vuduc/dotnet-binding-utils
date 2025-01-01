using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace IO.Ktor.Utils.IO.Core
{
    partial class DefaultBufferPool
    {
        protected override Java.Lang.Object ProduceInstance()
            => this.ProduceInstance_();
    }

    partial class Output : global::Java.Lang.IAppendable
    {
        global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(char c)
            => Append(c);

        global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence? csq, int start, int end)
            => Append(csq, start, end);

        global::Java.Lang.IAppendable global::Java.Lang.IAppendable.Append(global::Java.Lang.ICharSequence? csq)
            => Append(csq);
    }
}

namespace IO.Ktor.Utils.IO
{
    partial class ByteChannelSequentialBase
    {
        static Delegate? cb_lookAhead_Lkotlin_jvm_functions_Function1_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
        [global::System.Obsolete]
        static Delegate GetLookAhead_Lkotlin_jvm_functions_Function1_Lkotlin_coroutines_Continuation_Handler()
        {
            if (cb_lookAhead_Lkotlin_jvm_functions_Function1_Lkotlin_coroutines_Continuation_ == null)
                cb_lookAhead_Lkotlin_jvm_functions_Function1_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(n_LookAhead_Lkotlin_jvm_functions_Function1_Lkotlin_coroutines_Continuation_));
            return cb_lookAhead_Lkotlin_jvm_functions_Function1_Lkotlin_coroutines_Continuation_;
        }

        [global::System.Obsolete]
        static IntPtr n_LookAhead_Lkotlin_jvm_functions_Function1_Lkotlin_coroutines_Continuation_(IntPtr jnienv, IntPtr native__this, IntPtr native_visitor, IntPtr native_p1)
        {
            var __this = global::Java.Lang.Object.GetObject<global::IO.Ktor.Utils.IO.ByteChannelSequentialBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var visitor = (global::Kotlin.Jvm.Functions.IFunction1?)global::Java.Lang.Object.GetObject<global::Kotlin.Jvm.Functions.IFunction1>(native_visitor, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.LookAhead(visitor!));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='io.ktor.utils.io']/interface[@name='ByteReadChannel']/method[@name='lookAheadSuspend' and count(parameter)=2 and parameter[1][@type='kotlin.jvm.functions.Function2&lt;? super io.ktor.utils.io.LookAheadSuspendSession, ? super kotlin.coroutines.Continuation&lt;? super R&gt;, ? extends java.lang.Object&gt;'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super R&gt;']]"
        [global::System.Obsolete(@"deprecated")]
        [Register("lookAheadSuspend", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetLookAhead_Lkotlin_jvm_functions_Function1_Lkotlin_coroutines_Continuation_Handler")]
        [global::Java.Interop.JavaTypeParameters(new string[] { "R" })]
        public abstract global::Java.Lang.Object? LookAhead(global::Kotlin.Jvm.Functions.IFunction1 visitor);
    }

    partial class ByteChannelSequentialBaseInvoker
    {
        [global::System.Obsolete(@"deprecated")]
        public override unsafe global::Java.Lang.Object? LookAhead(global::Kotlin.Jvm.Functions.IFunction1 visitor)
        {
            const string __id = "lookAhead(Lkotlin/jvm/functions/Function1;)Ljava/lang/Object;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((visitor == null) ? IntPtr.Zero : JNIEnv.ToLocalJniHandle(visitor));
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return (global::Java.Lang.Object?)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}

namespace IO.Ktor.Utils.IO.Pool
{
    partial class DirectByteBufferPool
    {
        protected override Java.Lang.Object ProduceInstance()
            => this.ProduceInstance_();
    }
    partial class ByteBufferPool
    {
        protected override Java.Lang.Object ProduceInstance()
            => this.ProduceInstance_();
    }

    partial class NoPoolImpl : global::IO.Ktor.Utils.IO.Pool.IObjectPool
    {
        static Delegate? cb_borrow;
#pragma warning disable 0169
        static Delegate GetBorrowHandler()
        {
            if (cb_borrow == null)
                cb_borrow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_Borrow));
            return cb_borrow;
        }

        static IntPtr n_Borrow(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::IO.Ktor.Utils.IO.Pool.NoPoolImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return JNIEnv.ToLocalJniHandle(__this.Borrow());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='io.ktor.utils.io.pool']/class[@name='NoPoolImpl']/method[@name='borrow' and count(parameter)=0]"
        [Register("borrow", "()V", "GetBorrowHandler")]
        public abstract global::Java.Lang.Object Borrow();
    }

    partial class NoPoolImplInvoker
    {
        [Register("closeSource", "()V", "GetCloseSourceHandler")]
        public override unsafe global::Java.Lang.Object Borrow()
        {
            const string __id = "borrow.()V";
            try
            {
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(
                    __id,
                    this,
                    null);

                return (global::Java.Lang.Object?)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}