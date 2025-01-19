using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Android.Uicore.Elements
{
    partial class SameAsShippingElement
    {
        global::Com.Stripe.Android.Uicore.Elements.IController global::Com.Stripe.Android.Uicore.Elements.IFormElement.Controller => Controller;
    }
}

namespace Com.Stripe.Android.Uicore.Elements
{
    partial class TextFieldStateConstants
    {
        partial class Error
        {
            partial class Blank
            {

            }
        }
    }
    partial class RowElement
    {
        public override ISectionFieldErrorController SectionFieldErrorController()
            => SectionFieldErrorRowController();
    }
    partial class SectionElement
    {
        global::Com.Stripe.Android.Uicore.Elements.IController global::Com.Stripe.Android.Uicore.Elements.IFormElement.Controller => Controller;
    }
    partial class OTPElement
    {
        global::Com.Stripe.Android.Uicore.Elements.IController global::Com.Stripe.Android.Uicore.Elements.IFormElement.Controller => Controller;
    }
    partial class SimpleTextFieldConfig
    {
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldConfig.TrailingIcon => TrailingIcon;
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldConfig.Loading => Loading;
    }
    partial class PostalCodeConfig
    {
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldConfig.TrailingIcon => TrailingIcon;
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldConfig.Loading => Loading;
    }
    partial class EmailConfig
    {
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldConfig.TrailingIcon => TrailingIcon;
    }
    partial class NameConfig
    {
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldConfig.TrailingIcon => TrailingIcon;
    }
    partial class SimpleTextFieldController
    {
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.IInputController.Label => Label;
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldController.Label => Label;
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldController.PlaceHolder => PlaceHolder;
    }
    partial class AddressTextFieldController
    {
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.IInputController.Label => Label;
        global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow global::Com.Stripe.Android.Uicore.Elements.ITextFieldController.Label => Label;
    }
    partial class CheckboxFieldElement
    {
        global::Com.Stripe.Android.Uicore.Elements.IController global::Com.Stripe.Android.Uicore.Elements.IFormElement.Controller => Controller;
    }
    partial interface IParameterDestination
    {
        partial class Api
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object? global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
        partial class Local
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
    partial class IdentifierSpec
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class AddressType
    {
        partial class Normal
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
        partial class ShippingCondensed
        {
            partial class Creator
            {
                unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel? parcel)
                    => CreateFromParcel(parcel);

                unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                    => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
            }
        }
        partial class ShippingExpanded
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
}