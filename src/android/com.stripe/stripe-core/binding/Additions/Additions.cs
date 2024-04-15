using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Android.Core.Model
{
    partial class StripeFile
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class StripeFileParams
    {
        partial class FileLink
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
    }
    partial class Country
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class CountryCode
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
}
namespace Com.Stripe.Android.Core
{
    partial class AppInfo
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class StripeError
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
}
namespace Com.Stripe.Android.Core.Utils
{
    partial class RealIsWorkManagerAvailable_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
}
namespace Com.Stripe.Android.Core.Networking
{
    partial class LinearRetryDelaySupplier_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class ExponentialBackoffRetryDelaySupplier_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class DefaultAnalyticsRequestV2Executor_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class DefaultAnalyticsRequestExecutor_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class ApiRequest_Options_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class ApiRequest
    {
        partial class Options
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
    }
    partial class ApiRequest_Options_Factory
    {

    }
}
namespace Com.Stripe.Android.Core.Injection
{
    partial class CoreCommonModule_ProvideLocaleFactory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class CoreCommonModule_ProvideLoggerFactory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class CoroutineContextModule_ProvideUIContextFactory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class CoroutineContextModule_ProvideWorkContextFactory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
}