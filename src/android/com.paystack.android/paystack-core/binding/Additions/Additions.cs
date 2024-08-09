#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Paystack.Android.Core.Api.Models
{
    partial class AccessCodeData
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class ChannelOptions
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class ChargeAuthorization
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class ChargeResponse
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class Customer
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
    partial class MobileMoneyChannelOption
    {
        partial class Creator
        {
            global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? source) => this.CreateFromParcel(source);
            global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size) => this.NewArray(size);
        }
    }
}
namespace Com.Paystack.Android.Core.Api.Models
{
    partial class MobileMoneyChargeResponse
    {
        partial class DisplayType
        {

            partial class Serializer : global::KotlinX.Serialization.ISerializationStrategy
            {
                Java.Lang.Object? KotlinX.Serialization.IDeserializationStrategy.Deserialize(KotlinX.Serialization.Encoding.IDecoder decoder)
                    => Deserialize(decoder);

                void KotlinX.Serialization.ISerializationStrategy.Serialize(KotlinX.Serialization.Encoding.IEncoder encoder, Java.Lang.Object? value)
                    => Serialize(encoder, value as global::Com.Paystack.Android.Core.Api.Models.MobileMoneyChargeResponse.DisplayType);
            }
        }
    }
    partial class PaymentChannel
    {

        partial class PaymentChannelSerializer : global::KotlinX.Serialization.ISerializationStrategy
        {
            Java.Lang.Object? KotlinX.Serialization.IDeserializationStrategy.Deserialize(KotlinX.Serialization.Encoding.IDecoder decoder)
                => Deserialize(decoder);

            void KotlinX.Serialization.ISerializationStrategy.Serialize(KotlinX.Serialization.Encoding.IEncoder encoder, Java.Lang.Object? value)
                => Serialize(encoder, value as global::Com.Paystack.Android.Core.Api.Models.PaymentChannel);
        }
    }
    partial class TransactionStatusSerializer : global::KotlinX.Serialization.ISerializationStrategy
        {
            Java.Lang.Object? KotlinX.Serialization.IDeserializationStrategy.Deserialize(KotlinX.Serialization.Encoding.IDecoder decoder)
                => Deserialize(decoder);

            void KotlinX.Serialization.ISerializationStrategy.Serialize(KotlinX.Serialization.Encoding.IEncoder encoder, Java.Lang.Object? value)
                => Serialize(encoder, value as global::Com.Paystack.Android.Core.Api.Models.TransactionStatus);
        }
}