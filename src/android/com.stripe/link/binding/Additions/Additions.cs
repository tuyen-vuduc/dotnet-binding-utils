using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Android.Link.Account
{
    partial class LinkStore_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
}
namespace Com.Stripe.Android.Link.Analytics
{
    partial class LinkAnalyticsHelper_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
}
namespace Com.Stripe.Android.Link.Injection
{
    partial class LinkModule_Companion_ProvideConsumersApiServiceFactory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
}
namespace Com.Stripe.Android.Link
{
    partial class LinkActivityContract
    {
        public override global::Android.Content.Intent CreateIntent(global::Android.Content.Context context, global::Java.Lang.Object? args)
            => CreateIntent(context, args as Args);
        public override global::Java.Lang.Object? ParseResult(int resultCode, global::Android.Content.Intent? intent)
            => ParseResultX(resultCode, intent);
    }

    partial class LinkActivityContract_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class LinkPaymentLauncher_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
    partial class RealLinkConfigurationCoordinator_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
}
namespace Com.Stripe.Android.Link.UI.Inline
{
    partial class InlineSignupViewModel_Factory
    {
        global::Java.Lang.Object global::JavaX.Inject.IProvider.Get() => (global::Java.Lang.Object)(object)Get();
    }
}
namespace Com.Stripe.Android.Link
{
    partial class LinkActivityResult
    {
        partial class Canceled
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source)
  => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => this.NewArray(size);
            }
        }
    }
    partial class LinkActivityResult
    {
        partial class Completed
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source)
              => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => this.NewArray(size);
            }
        }
    }
    partial class LinkActivityResult
    {
        partial class Failed
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source)
              => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => this.NewArray(size);
            }
        }
    }
    partial class LinkConfiguration
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source)
              => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => this.NewArray(size);
        }
    }
    partial class LinkConfiguration
    {
        partial class CustomerInfo
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source)
              => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => this.NewArray(size);
            }
        }
    }
    partial class LinkPaymentDetails
    {
        partial class New
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source)
              => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => this.NewArray(size);
            }
        }
    }
    partial class LinkPaymentDetails
    {
        partial class Saved
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source)
              => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => this.NewArray(size);
            }
        }
    }
}