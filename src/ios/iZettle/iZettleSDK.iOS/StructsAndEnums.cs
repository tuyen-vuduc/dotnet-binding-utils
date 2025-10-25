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
        PayPalQRC = 0
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
        AmountTooHigh = -402
    }
}