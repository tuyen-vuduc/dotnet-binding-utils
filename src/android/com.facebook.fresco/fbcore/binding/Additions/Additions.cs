using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using System.Linq;


namespace Com.Facebook.Common.Executors
{
	partial interface IHandlerExecutorService : global::Java.Util.Concurrent.IScheduledExecutorService
	{
	}
	partial class IHandlerExecutorServiceInvoker
	{
		static Delegate? cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSchedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == null)
				cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLJL_L)n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_);
			return cb_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long delay, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var command = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Schedule(command, delay, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Util.Concurrent.IScheduledFuture? Schedule(global::Java.Lang.IRunnable? command, long delay, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "schedule", "(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
			__args[1] = new JValue(delay);
			__args[2] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_schedule_Ljava_lang_Runnable_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetSchedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ == null)
				cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLJL_L)n_Schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_);
			return cb_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_callable, long delay, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var callable = (global::Java.Util.Concurrent.ICallable?)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable>(native_callable, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Schedule(callable, delay, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Util.Concurrent.IScheduledFuture? Schedule(global::Java.Util.Concurrent.ICallable? callable, long delay, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "schedule", "(Ljava/util/concurrent/Callable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue((callable == null) ? IntPtr.Zero : ((global::Java.Lang.Object)callable).Handle);
			__args[1] = new JValue(delay);
			__args[2] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_schedule_Ljava_util_concurrent_Callable_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == null)
				cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLJJL_L)n_ScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_);
			return cb_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_ScheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long initialDelay, long period, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var command = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.ScheduleAtFixedRate(command, initialDelay, period, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Util.Concurrent.IScheduledFuture? ScheduleAtFixedRate(global::Java.Lang.IRunnable? command, long initialDelay, long period, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "scheduleAtFixedRate", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			JValue* __args = stackalloc JValue[4];
			__args[0] = new JValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
			__args[1] = new JValue(initialDelay);
			__args[2] = new JValue(period);
			__args[3] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_scheduleAtFixedRate_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == null)
				cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLJJL_L)n_ScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_);
			return cb_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_ScheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_command, long initialDelay, long delay, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var command = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.ScheduleWithFixedDelay(command, initialDelay, delay, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Util.Concurrent.IScheduledFuture? ScheduleWithFixedDelay(global::Java.Lang.IRunnable? command, long initialDelay, long delay, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "scheduleWithFixedDelay", "(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture;");
			JValue* __args = stackalloc JValue[4];
			__args[0] = new JValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
			__args[1] = new JValue(initialDelay);
			__args[2] = new JValue(delay);
			__args[3] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IScheduledFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_scheduleWithFixedDelay_Ljava_lang_Runnable_JJLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_isShutdown;
#pragma warning disable 0169
		static Delegate GetIsShutdownHandler()
		{
			if (cb_isShutdown == null)
				cb_isShutdown = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_Z)n_IsShutdown);
			return cb_isShutdown;
		}

		static bool n_IsShutdown(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsShutdown;
		}
#pragma warning restore 0169

		IntPtr id_isShutdown;
		public unsafe bool IsShutdown
		{
			get
			{
				if (id_isShutdown == IntPtr.Zero)
					id_isShutdown = JNIEnv.GetMethodID(java_class_ref, "isShutdown", "()Z");
				return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isShutdown);
			}
		}

		static Delegate? cb_isTerminated;
#pragma warning disable 0169
		static Delegate GetIsTerminatedHandler()
		{
			if (cb_isTerminated == null)
				cb_isTerminated = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_Z)n_IsTerminated);
			return cb_isTerminated;
		}

		static bool n_IsTerminated(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsTerminated;
		}
#pragma warning restore 0169

		IntPtr id_isTerminated;
		public unsafe bool IsTerminated
		{
			get
			{
				if (id_isTerminated == IntPtr.Zero)
					id_isTerminated = JNIEnv.GetMethodID(java_class_ref, "isTerminated", "()Z");
				return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isTerminated);
			}
		}

		static Delegate? cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwaitTermination_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ == null)
				cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPJL_Z)n_AwaitTermination_JLjava_util_concurrent_TimeUnit_);
			return cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_AwaitTermination_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AwaitTermination(timeout, unit);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		public unsafe bool AwaitTermination(long timeout, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_awaitTermination_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			JValue* __args = stackalloc JValue[2];
			__args[0] = new JValue(timeout);
			__args[1] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_awaitTermination_JLjava_util_concurrent_TimeUnit_, __args);
			return __ret;
		}

		static Delegate? cb_invokeAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetInvokeAll_LSystem_Collections_ICollection_Handler()
		{
			if (cb_invokeAll_LSystem_Collections_ICollection_ == null)
				cb_invokeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_InvokeAll_LSystem_Collections_ICollection_);
			return cb_invokeAll_LSystem_Collections_ICollection_;
		}

		static IntPtr n_InvokeAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle(__this.InvokeAll(tasks));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAll_LSystem_Collections_ICollection_;
		public unsafe global::System.Collections.IList? InvokeAll(global::System.Collections.ICollection? tasks)
		{
			if (id_invokeAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_invokeAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(java_class_ref, "invokeAll", "(LSystem/Collections/ICollection;)Ljava/util/List;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(native_tasks);
			var __ret = global::Android.Runtime.JavaList.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAll_LSystem_Collections_ICollection_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate? cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetInvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == null)
				cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLJL_L)n_InvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_);
			return cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_InvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle(__this.InvokeAll(tasks, timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::System.Collections.IList? InvokeAll(global::System.Collections.ICollection? tasks, long timeout, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "invokeAll", "(LSystem/Collections/ICollection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue(native_tasks);
			__args[1] = new JValue(timeout);
			__args[2] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = global::Android.Runtime.JavaList.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate? cb_invokeAny_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetInvokeAny_LSystem_Collections_ICollection_Handler()
		{
			if (cb_invokeAny_LSystem_Collections_ICollection_ == null)
				cb_invokeAny_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_InvokeAny_LSystem_Collections_ICollection_);
			return cb_invokeAny_LSystem_Collections_ICollection_;
		}

		static IntPtr n_InvokeAny_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.InvokeAny(tasks));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAny_LSystem_Collections_ICollection_;
		public unsafe global::Java.Lang.Object? InvokeAny(global::System.Collections.ICollection? tasks)
		{
			if (id_invokeAny_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_invokeAny_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(java_class_ref, "invokeAny", "(LSystem/Collections/ICollection;)Ljava/lang/Object;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(native_tasks);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAny_LSystem_Collections_ICollection_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate? cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetInvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == null)
				cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLJL_L)n_InvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_);
			return cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_InvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.InvokeAny(tasks, timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Lang.Object? InvokeAny(global::System.Collections.ICollection? tasks, long timeout, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "invokeAny", "(LSystem/Collections/ICollection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue(native_tasks);
			__args[1] = new JValue(timeout);
			__args[2] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate? cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_V)n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Shutdown();
		}
#pragma warning restore 0169

		IntPtr id_shutdown;
		public unsafe void Shutdown()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID(java_class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_shutdown);
		}

		static Delegate? cb_shutdownNow;
#pragma warning disable 0169
		static Delegate GetShutdownNowHandler()
		{
			if (cb_shutdownNow == null)
				cb_shutdownNow = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_ShutdownNow);
			return cb_shutdownNow;
		}

		static IntPtr n_ShutdownNow(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.ToLocalJniHandle(__this.ShutdownNow());
		}
#pragma warning restore 0169

		IntPtr id_shutdownNow;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.IRunnable>? ShutdownNow()
		{
			if (id_shutdownNow == IntPtr.Zero)
				id_shutdownNow = JNIEnv.GetMethodID(java_class_ref, "shutdownNow", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_shutdownNow), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_submit_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_lang_Runnable_Handler()
		{
			if (cb_submit_Ljava_lang_Runnable_ == null)
				cb_submit_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_Submit_Ljava_lang_Runnable_);
			return cb_submit_Ljava_lang_Runnable_;
		}

		static IntPtr n_Submit_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var task = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_lang_Runnable_;
		public unsafe global::Java.Util.Concurrent.IFuture? Submit(global::Java.Lang.IRunnable? task)
		{
			if (id_submit_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_submit_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(java_class_ref, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object)task).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_lang_Runnable_Ljava_lang_Object_Handler()
		{
			if (cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == null)
				cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_L)n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_);
			return cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		}

		static IntPtr n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_task, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var task = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			var result = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task, result));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		public unsafe global::Java.Util.Concurrent.IFuture? Submit(global::Java.Lang.IRunnable? task, global::Java.Lang.Object? result)
		{
			if (id_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == IntPtr.Zero)
				id_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNIEnv.GetMethodID(java_class_ref, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[2];
			__args[0] = new JValue((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object)task).Handle);
			__args[1] = new JValue((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object)result).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_lang_Runnable_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_submit_Ljava_util_concurrent_Callable_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_util_concurrent_Callable_Handler()
		{
			if (cb_submit_Ljava_util_concurrent_Callable_ == null)
				cb_submit_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_Submit_Ljava_util_concurrent_Callable_);
			return cb_submit_Ljava_util_concurrent_Callable_;
		}

		static IntPtr n_Submit_Ljava_util_concurrent_Callable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var task = (global::Java.Util.Concurrent.ICallable?)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable>(native_task, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_util_concurrent_Callable_;
		public unsafe global::Java.Util.Concurrent.IFuture? Submit(global::Java.Util.Concurrent.ICallable? task)
		{
			if (id_submit_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_submit_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID(java_class_ref, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object)task).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_execute_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_Runnable_Handler()
		{
			if (cb_execute_Ljava_lang_Runnable_ == null)
				cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_Execute_Ljava_lang_Runnable_);
			return cb_execute_Ljava_lang_Runnable_;
		}

		static void n_Execute_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.IHandlerExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var command = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			__this.Execute(command);
		}
#pragma warning restore 0169

		IntPtr id_execute_Ljava_lang_Runnable_;
		public unsafe void Execute(global::Java.Lang.IRunnable? command)
		{
			if (id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_execute_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(java_class_ref, "execute", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_execute_Ljava_lang_Runnable_, __args);
		}

	}
}


namespace Com.Facebook.Common.Executors
{
	partial interface ISerialExecutorService : global::Java.Util.Concurrent.IExecutorService
	{
	}

	partial class ISerialExecutorServiceInvoker
	{
		static Delegate? cb_isShutdown;
#pragma warning disable 0169
		static Delegate GetIsShutdownHandler()
		{
			if (cb_isShutdown == null)
				cb_isShutdown = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_Z)n_IsShutdown);
			return cb_isShutdown;
		}

		static bool n_IsShutdown(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsShutdown;
		}
#pragma warning restore 0169

		IntPtr id_isShutdown;
		public unsafe bool IsShutdown
		{
			get
			{
				if (id_isShutdown == IntPtr.Zero)
					id_isShutdown = JNIEnv.GetMethodID(java_class_ref, "isShutdown", "()Z");
				return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isShutdown);
			}
		}

		static Delegate? cb_isTerminated;
#pragma warning disable 0169
		static Delegate GetIsTerminatedHandler()
		{
			if (cb_isTerminated == null)
				cb_isTerminated = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_Z)n_IsTerminated);
			return cb_isTerminated;
		}

		static bool n_IsTerminated(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsTerminated;
		}
#pragma warning restore 0169

		IntPtr id_isTerminated;
		public unsafe bool IsTerminated
		{
			get
			{
				if (id_isTerminated == IntPtr.Zero)
					id_isTerminated = JNIEnv.GetMethodID(java_class_ref, "isTerminated", "()Z");
				return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isTerminated);
			}
		}

		static Delegate? cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwaitTermination_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ == null)
				cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPJL_Z)n_AwaitTermination_JLjava_util_concurrent_TimeUnit_);
			return cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_AwaitTermination_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AwaitTermination(timeout, unit);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		public unsafe bool AwaitTermination(long timeout, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_awaitTermination_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			JValue* __args = stackalloc JValue[2];
			__args[0] = new JValue(timeout);
			__args[1] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_awaitTermination_JLjava_util_concurrent_TimeUnit_, __args);
			return __ret;
		}

		static Delegate? cb_invokeAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetInvokeAll_LSystem_Collections_ICollection_Handler()
		{
			if (cb_invokeAll_LSystem_Collections_ICollection_ == null)
				cb_invokeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_InvokeAll_LSystem_Collections_ICollection_);
			return cb_invokeAll_LSystem_Collections_ICollection_;
		}

		static IntPtr n_InvokeAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle(__this.InvokeAll(tasks));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAll_LSystem_Collections_ICollection_;
		public unsafe global::System.Collections.IList? InvokeAll(global::System.Collections.ICollection? tasks)
		{
			if (id_invokeAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_invokeAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(java_class_ref, "invokeAll", "(LSystem/Collections/ICollection;)Ljava/util/List;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(native_tasks);
			var __ret = global::Android.Runtime.JavaList.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAll_LSystem_Collections_ICollection_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate? cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetInvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == null)
				cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLJL_L)n_InvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_);
			return cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_InvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle(__this.InvokeAll(tasks, timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::System.Collections.IList? InvokeAll(global::System.Collections.ICollection? tasks, long timeout, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "invokeAll", "(LSystem/Collections/ICollection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue(native_tasks);
			__args[1] = new JValue(timeout);
			__args[2] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = global::Android.Runtime.JavaList.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate? cb_invokeAny_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetInvokeAny_LSystem_Collections_ICollection_Handler()
		{
			if (cb_invokeAny_LSystem_Collections_ICollection_ == null)
				cb_invokeAny_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_InvokeAny_LSystem_Collections_ICollection_);
			return cb_invokeAny_LSystem_Collections_ICollection_;
		}

		static IntPtr n_InvokeAny_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.InvokeAny(tasks));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAny_LSystem_Collections_ICollection_;
		public unsafe global::Java.Lang.Object? InvokeAny(global::System.Collections.ICollection? tasks)
		{
			if (id_invokeAny_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_invokeAny_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(java_class_ref, "invokeAny", "(LSystem/Collections/ICollection;)Ljava/lang/Object;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(native_tasks);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAny_LSystem_Collections_ICollection_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate? cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetInvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == null)
				cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLJL_L)n_InvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_);
			return cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_InvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			var unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.InvokeAny(tasks, timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Lang.Object? InvokeAny(global::System.Collections.ICollection? tasks, long timeout, global::Java.Util.Concurrent.TimeUnit? unit)
		{
			if (id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(java_class_ref, "invokeAny", "(LSystem/Collections/ICollection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue(native_tasks);
			__args[1] = new JValue(timeout);
			__args[2] = new JValue((unit == null) ? IntPtr.Zero : ((global::Java.Lang.Object)unit).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate? cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_V)n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Shutdown();
		}
#pragma warning restore 0169

		IntPtr id_shutdown;
		public unsafe void Shutdown()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID(java_class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_shutdown);
		}

		static Delegate? cb_shutdownNow;
#pragma warning disable 0169
		static Delegate GetShutdownNowHandler()
		{
			if (cb_shutdownNow == null)
				cb_shutdownNow = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_ShutdownNow);
			return cb_shutdownNow;
		}

		static IntPtr n_ShutdownNow(IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.ToLocalJniHandle(__this.ShutdownNow());
		}
#pragma warning restore 0169

		IntPtr id_shutdownNow;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.IRunnable>? ShutdownNow()
		{
			if (id_shutdownNow == IntPtr.Zero)
				id_shutdownNow = JNIEnv.GetMethodID(java_class_ref, "shutdownNow", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_shutdownNow), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate? cb_submit_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_lang_Runnable_Handler()
		{
			if (cb_submit_Ljava_lang_Runnable_ == null)
				cb_submit_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_Submit_Ljava_lang_Runnable_);
			return cb_submit_Ljava_lang_Runnable_;
		}

		static IntPtr n_Submit_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var task = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_lang_Runnable_;
		public unsafe global::Java.Util.Concurrent.IFuture? Submit(global::Java.Lang.IRunnable? task)
		{
			if (id_submit_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_submit_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(java_class_ref, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object)task).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_lang_Runnable_Ljava_lang_Object_Handler()
		{
			if (cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == null)
				cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLL_L)n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_);
			return cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		}

		static IntPtr n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_task, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var task = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			var result = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task, result));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		public unsafe global::Java.Util.Concurrent.IFuture? Submit(global::Java.Lang.IRunnable? task, global::Java.Lang.Object? result)
		{
			if (id_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == IntPtr.Zero)
				id_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNIEnv.GetMethodID(java_class_ref, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[2];
			__args[0] = new JValue((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object)task).Handle);
			__args[1] = new JValue((result == null) ? IntPtr.Zero : ((global::Java.Lang.Object)result).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_lang_Runnable_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_submit_Ljava_util_concurrent_Callable_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_util_concurrent_Callable_Handler()
		{
			if (cb_submit_Ljava_util_concurrent_Callable_ == null)
				cb_submit_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_Submit_Ljava_util_concurrent_Callable_);
			return cb_submit_Ljava_util_concurrent_Callable_;
		}

		static IntPtr n_Submit_Ljava_util_concurrent_Callable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var task = (global::Java.Util.Concurrent.ICallable?)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable>(native_task, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_util_concurrent_Callable_;
		public unsafe global::Java.Util.Concurrent.IFuture? Submit(global::Java.Util.Concurrent.ICallable? task)
		{
			if (id_submit_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_submit_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID(java_class_ref, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((task == null) ? IntPtr.Zero : ((global::Java.Lang.Object)task).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_execute_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_Runnable_Handler()
		{
			if (cb_execute_Ljava_lang_Runnable_ == null)
				cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_V)n_Execute_Ljava_lang_Runnable_);
			return cb_execute_Ljava_lang_Runnable_;
		}

		static void n_Execute_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var command = (global::Java.Lang.IRunnable?)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			__this.Execute(command);
		}
#pragma warning restore 0169

		IntPtr id_execute_Ljava_lang_Runnable_;
		public unsafe void Execute(global::Java.Lang.IRunnable? command)
		{
			if (id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_execute_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(java_class_ref, "execute", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((command == null) ? IntPtr.Zero : ((global::Java.Lang.Object)command).Handle);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_execute_Ljava_lang_Runnable_, __args);
		}

	}
}

namespace Com.Facebook.Datasource
{
	partial class FirstAvailableDataSourceSupplier
	{
		global::Java.Lang.Object? global::Com.Facebook.Common.Internal.ISupplier.Get() => (global::Java.Lang.Object?)(object)Get();
	}
	partial class IncreasingQualityDataSourceSupplier
	{
		global::Java.Lang.Object? global::Com.Facebook.Common.Internal.ISupplier.Get() => (global::Java.Lang.Object?)(object)Get();
	}
	partial class RetainingDataSourceSupplier
	{
		global::Java.Lang.Object? global::Com.Facebook.Common.Internal.ISupplier.Get() => (global::Java.Lang.Object?)(object)Get();
	}
}

namespace Com.Facebook.Common.Memory
{
	partial class DecodeBufferHelper
	{
		global::Java.Lang.Object global::AndroidX.Core.Util.Pools.IPool.Acquire() => Acquire();
		bool global::AndroidX.Core.Util.Pools.IPool.Release(global::Java.Lang.Object obj)
			=> Release(obj as global::Java.Nio.ByteBuffer);
	}
}

namespace Com.Facebook.Common.Executors
{
	partial class ScheduledFutureImpl
	{
		int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object other)
		{
			if (other is not global::Java.Util.Concurrent.IDelayed value)
			{
				return -1;
			}

			return CompareTo(value);
		}
	}
}