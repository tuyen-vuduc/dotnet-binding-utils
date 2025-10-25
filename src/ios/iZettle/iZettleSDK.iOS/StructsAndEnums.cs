using Foundation;
using UIKit;
using ObjCRuntime;
using System;

namespace iZettleSDK
{
    [Native]
    public enum IZSDKPayPalQRCType : long {
        PayPal = 0,
        Venmo = 1
    }

    /// Used to set up the UI that should be presented in the PayPal payment flow - `PayPal` or `Venmo`.
    [Native]
    public enum IZSDKPayPalQRCAppearance : long
    {
        PayPal = 0,
        Venmo = 1
    }
    [Native]
    public enum IZSDKAlternativePaymentMethod : long
    {
        /// This payment method represents both `PayPal` and `Venmo` since we are considering `Venmo` as a subtype of `PayPal`.
        PayPalQRC = 0,
        /// This payment method allows manually entering the customer's card details. Read more about it at [developer portal](https://developer.zettle.com/docs/ios-sdk/)
        ManualCardEntry = 1
    }

    /// Defining which tipping style to be used when initiating a payment with tipping.
    ///
    /// Read more at [developer portal](https://developer.zettle.com/docs/ios-sdk/concepts/tipping-support) to understand which type(s) your market supports and what the difference between tipping styles are.
    ///
    /// **Important:** If your market does not support the selected style then the market default will be used.
    [Native]
    public enum IZSDKTippingStyle : long
    {
        /// Disable tipping option.
        None = 0,

        /// The market default option.
        MarketDefault,

        /// An amount based option.
        Amount,

        ///A percentage based option.
        Percentage
    }

    /// Defining which tipping style to be used when initiating a payment with tipping for Zettle readers.
    ///
    /// Read more at [developer portal](https://developer.zettle.com/docs/ios-sdk/concepts/tipping-support) to understand which type(s) your market supports and what the difference between tipping styles are.
    ///
    /// **Important:** If your market does not support the selected style then the market default will be used.
    [Native]
    public enum IZZettleReaderTippingStyle : long
    {
        /// Disable tipping option.
        None = 0,

        /// The market default option.
        MarketDefault,

        /// An amount based option.
        Amount,

        /// A percentage based option.
        Percentage
    }

    /// Defining which tipping style to be used when initiating a payment with tipping for PayPal readers.
    ///
    /// Read more at [developer portal](https://developer.zettle.com/docs/ios-sdk/concepts/tipping-support) to understand which type(s) your market supports and what the difference between tipping styles are.
    ///
    /// **Important:** If your market does not support the selected style then the market default will be used.
    [Native]
    public enum IZPayPalReaderTippingStyle : long
    {
        /// Disable tipping option.
        None = 0,

        /// The market default option.
        MarketDefault,

        /// A custom amount based option.
        CustomAmount,

        /// A percentage based option. Can be used together with predefined percentage options.
        PredefinedPercentage,

        /// Uses the tipping style configured by the merchant in Settings.
        /// Note: ensure Settings view is configured to display the PayPal Reader tipping Settings section.
        SDKConfigured
    }

    /// Defines PayPal QRC SDK errors.
    [Native]
    public enum IZSDKPayPalQRCErrorCode : long
    {
        // Common errors
        NetworkError = -2000,
        TechnicalError = -2001,

        // Payment errors
        LocationFailed = -2101,
        FeatureNotEnabled = -2102,
        OnboardingNotCompleted = -2103,
        SellerDataError = -2104,
        PaymentCancelledByMerchant = -2105,
        PaymentCancelledByBuyer = -2106,
        PaymentTimeout = -2107,
        InvalidAmount = -2108,
        AmountBelowMinimum = -2109,
        AmountAboveMaximum = -2110,

        // PaymentInfoErrors
        NotFound = -2201,
        NotAuthorized = -2202,
        RetrievalCancelled = -2203,

        // Refund errors
        RefundAmountTooHigh = -2301,
        RefundInsufficientFunds = -2302,
        RefundFailed = -2303,
        RefundCancelled = -2304,
    }

    [Native]
    public enum IZSDKErrorCode : long
    {
        UserNotLoggedIn = -1,
        PaymentNotFound = -100,
        ReferenceTooLong = -101,
        ReferenceIsNil = -102,
        OperationAlreadyInProgress = -300,
        InvalidAmount = -400,
        AmountTooLow = -401,
        AmountTooHigh = -402,
        DeviceNotSupported = -403,
        NotEligible = -404,
        AccountNotLinked = -405,
        NoNetwork = -406,
        UnableToPresentView = -407,
    }

    /// Defines Manual Card Entry SDK errors.
    [Native]
    public enum IZSDKManualCardEntryErrorCode : long
    {
        // Common errors
        NetworkError = -3000,
        TechnicalError = -3001,

        // Payment errors
        LocationFailed = -3101,
        FeatureNotEnabled = -3102,
        SellerDataError = -3104,
        PaymentCancelledByMerchant = -3105,
        InvalidAmount = -3108,
        AmountBelowMinimum = -3109,
        AmountAboveMaximum = -3110,

        // PaymentInfoErrors
        NotFound = -3201,
        NotAuthorized = -3202,
        RetrievalCancelled = -3203,

        // Refund errors
        RefundAmountTooHigh = -3301,
        RefundInsufficientFunds = -3302,
        RefundFailed = -3303,
        RefundCancelled = -3304
    }
}