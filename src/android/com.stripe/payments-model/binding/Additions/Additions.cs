using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
namespace Com.Stripe.Android.Model.Parsers
{
    partial class ConsumerPaymentDetailsJsonParser
    {
        global::Java.Lang.Object? global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json) => Parse(json);
    }
    partial class LinkConsumerIncentiveJsonParser
    {
        global::Java.Lang.Object? global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json) => Parse(json);
    }
}
namespace Com.Stripe.Android.Model
{
    partial interface IConsumerPaymentDetailsCreateParams
    {
        partial class BankAccount
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
    partial interface IIncentiveEligibilitySession
    {
        partial class DeferredIntent
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
    partial interface IConsumerPaymentDetailsCreateParams
    {
        partial class Card
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
    partial interface IIncentiveEligibilitySession
    {
        partial class PaymentIntent
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
    partial interface IIncentiveEligibilitySession
    {
        partial class SetupIntent
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
}
namespace Com.Stripe.Android.Model
{
    partial class ConsumerPaymentDetailsUpdateParams
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class LinkConsumerIncentive
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class SharePaymentDetails
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class LinkConsumerIncentive
    {
        partial class IncentiveParams
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
    partial class ConsumerPaymentDetails
    {
        partial class BankAccount
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
    partial class ConsumerPaymentDetails
    {
        partial class BillingAddress
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
    partial class ConsumerPaymentDetails
    {
        partial class Card
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
    partial class ConsumerPaymentDetails
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class ConsumerPaymentDetails
    {
        partial class Passthrough
        {
            partial class Creator
            {
                global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
                global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
            }
        }
    }
}

namespace Com.Stripe.Android.Cards
{
    partial class Bin
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

namespace Com.Stripe.Android.Model
{
    partial class AttachConsumerToLinkAccountSession
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class ConsumerSessionSignup
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class ConsumerSessionLookup
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class Card
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class BankAccount
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class Token
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class ConsumerSession
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }

        partial class VerificationSession
        {
            partial class SessionState
            {
                partial class Creator
                {
                    unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                        => CreateFromParcel(parcel);

                    unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                        => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
                }
            }
            partial class SessionType
            {
                partial class Creator
                {
                    unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                        => CreateFromParcel(parcel);

                    unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                        => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
                }
            }
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
    }
}

namespace Com.Stripe.Android.Model.Parsers
{
    partial class ConsumerSessionSignupJsonParser
    {
        global::Java.Lang.Object global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json)
            => Parse(json);
    }
    partial class BankAccountJsonParser
    {
        global::Java.Lang.Object global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json)
            => Parse(json);
    }
    partial class CardJsonParser
    {
        global::Java.Lang.Object global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json)
            => Parse(json);
    }
    partial class ConsumerSessionJsonParser
    {
        global::Java.Lang.Object global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json)
            => Parse(json);
    }
    partial class ConsumerSessionLookupJsonParser
    {
        global::Java.Lang.Object global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json)
            => Parse(json);
    }
    partial class TokenJsonParser
    {
        global::Java.Lang.Object global::Com.Stripe.Android.Core.Model.Parsers.IModelJsonParser.Parse(global::Org.Json.JSONObject json)
            => Parse(json);
    }
}