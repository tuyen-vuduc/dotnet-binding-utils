using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using static Android.Provider.DocumentsContract;

namespace Com.Stripe.Android.Stripe3ds2.Databinding
{
    partial class StripeChallengeActivityBinding
    {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
    }

    partial class StripeChallengeFragmentBinding
    {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
    }

    partial class StripeChallengeSubmitDialogBinding
    {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
    }

    partial class StripeChallengeZoneMultiSelectViewBinding
    {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
    }

    partial class StripeChallengeZoneSingleSelectViewBinding
    {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
    }

    partial class StripeChallengeZoneTextViewBinding
    {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
    }

    partial class StripeInformationZoneViewBinding
    {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
    }

    partial class StripeProgressViewLayoutBinding
    {
        global::Android.Views.View global::AndroidX.ViewBinding.IViewBinding.Root => Root;
    }
}


namespace Com.Stripe.Android.Stripe3ds2.Init
{
    partial class Warning
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

namespace Com.Stripe.Android.Stripe3ds2.Transaction
{
    partial class ChallengeRequestResult
    {
        partial class Failed
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
        partial class Canceled
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
        partial class Timeout
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
        partial class Success
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
        partial class RuntimeError
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
        partial class ProtocolError
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
    partial class ChallengeParameters
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class AuthenticationRequestParameters
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