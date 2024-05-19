#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Hcaptcha.Encode
{
    partial class DurationSerializer : global::KotlinX.Serialization.ISerializationStrategy
    {
        Java.Lang.Object? KotlinX.Serialization.IDeserializationStrategy.Deserialize(KotlinX.Serialization.Encoding.IDecoder decoder)
            => Deserialize(decoder);

        void KotlinX.Serialization.ISerializationStrategy.Serialize(KotlinX.Serialization.Encoding.IEncoder encoder, Java.Lang.Object? value)
            => Serialize(encoder, value is Java.Lang.Long longValue ? longValue.LongValue() : 0);
    }
}

namespace Com.Stripe.Hcaptcha
{
    partial class HCaptchaStateListener
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
}