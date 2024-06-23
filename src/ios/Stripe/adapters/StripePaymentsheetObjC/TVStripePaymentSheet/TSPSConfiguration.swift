//
//  TSPSConfiguration.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import UIKit
import StripeCore
import StripePayments
import StripePaymentSheet

/// Configuration for PaymentSheet
@objc(TSPSConfiguration) public class TSPSConfiguration : NSObject {
    /// If true, allows payment methods that do not move money at the end of the checkout. Defaults to false.
    /// - Description: Some payment methods can't guarantee you will receive funds from your customer at the end of the checkout because they take time to settle (eg. most bank debits, like SEPA or ACH) or require customer action to complete (e.g. OXXO, Konbini, Boleto). If this is set to true, make sure your integration listens to webhooks for notifications on whether a payment has succeeded or not.
    /// - Seealso: https://stripe.com/docs/payments/payment-methods#payment-notification
    @objc public var allowsDelayedPaymentMethods: Bool = false

    /// If `true`, allows payment methods that require a shipping address, like Afterpay and Affirm. Defaults to `false`.
    /// Set this to `true` if you collect shipping addresses and set `Configuration.shippingDetails` or set `shipping` details directly on the PaymentIntent.
    /// - Note: PaymentSheet considers this property `true` and allows payment methods that require a shipping address if `shipping` details are present on the PaymentIntent when PaymentSheet loads.
    @objc public var allowsPaymentMethodsRequiringShippingAddress: Bool = false

    /// The APIClient instance used to make requests to Stripe
    @objc public var apiClient: STPAPIClient = STPAPIClient.shared

    /// Configuration related to Apple Pay
    /// If set, PaymentSheet displays Apple Pay as a payment option
    @objc public var applePay: TSPSApplePayConfiguration?

    /// The color of the Buy or Add button. Defaults to `.systemBlue` when `nil`.
    @objc public var primaryButtonColor: UIColor?

    /// The label to use for the primary button.
    ///
    /// If not set, Payment Sheet will display suitable default labels
    /// for payment and setup intents.
    @objc public var primaryButtonLabel: String?

    /// The color styling to use for PaymentSheet UI
    /// Default value is SheetStyle.automatic
    /// @see SheetStyle
    @objc public var style: TSPSUserInterfaceStyle = .automatic

    /// Configuration related to the Stripe Customer
    /// If set, the customer can select a previously saved payment method within PaymentSheet
    @objc public var customer: TSPSCustomerConfiguration?

    /// Your customer-facing business name.
    /// The default value is the name of your app, using CFBundleDisplayName or CFBundleName
    @objc public var merchantDisplayName: String?

    /// A URL that redirects back to your app that PaymentSheet can use to auto-dismiss
    /// web views used for additional authentication, e.g. 3DS2
    @objc public var returnURL: String?

    /// PaymentSheet pre-populates fields with the values provided.
    /// If `billingDetailsCollectionConfiguration.attachDefaultsToPaymentMethod` is `true`, these values will
    /// be attached to the payment method even if they are not collected by the PaymentSheet UI.
    @objc public var defaultBillingDetails: STPPaymentMethodBillingDetails?

    /// PaymentSheet offers users an option to save some payment methods for later use.
    /// Default value is .automatic
    /// @see SavePaymentMethodOptInBehavior
    @objc  public var savePaymentMethodOptInBehavior: TSPSSavePaymentMethodOptInBehavior = .automatic

    /// Describes the appearance of PaymentSheet
    @objc  public var appearance: TSPSAppearance?
    
    /// A closure that returns the customer's shipping details.
    /// This is used to display a "Billing address is same as shipping" checkbox if `defaultBillingDetails` is not provided
    /// If `name` and `line1` are populated, it's also [attached to the PaymentIntent](https://stripe.com/docs/api/payment_intents/object#payment_intent_object-shipping) during payment.
    @objc public var shippingDetails: () -> TSPSAddressDetails? = { nil }
    
    /// The list of preferred networks that should be used to process payments made with a co-branded card.
    /// This value will only be used if your user hasn't selected a network themselves.
    @objc public var preferredNetworks: [NSNumber]?

    /// Initializes a Configuration with default values
    @objc public override init() {
        super.init()
    }

    /// Describes how billing details should be collected.
    /// All values default to `automatic`.
    /// If `never` is used for a required field for the Payment Method used during checkout,
    /// you **must** provide an appropriate value as part of `defaultBillingDetails`.
    @objc public var billingDetailsCollectionConfiguration: TSPSBillingDetailsCollectionConfiguration?

    /// Optional configuration to display a custom message when a saved payment method is removed.
    @objc public var removeSavedPaymentMethodMessage: String?

    /// Configuration for external payment methods.
    @objc public var externalPaymentMethodConfiguration: TSPSExternalPaymentMethodConfiguration?

    /// By default, PaymentSheet will use a dynamic ordering that optimizes payment method display for the customer.
    /// You can override the default order in which payment methods are displayed in PaymentSheet with a list of payment method types.
    /// See https://stripe.com/docs/api/payment_methods/object#payment_method_object-type for the list of valid types.  You may also pass external payment methods.
    /// - Example: ["card", "external_paypal", "klarna"]
    /// - Note: If you omit payment methods from this list, they’ll be automatically ordered by Stripe after the ones you provide. Invalid payment methods are ignored.
    @objc public var paymentMethodOrder: [String]?
    
    func unwrap() -> PaymentSheet.Configuration {
        var origin = PaymentSheet.Configuration()
        origin.allowsDelayedPaymentMethods = allowsDelayedPaymentMethods
        origin.allowsPaymentMethodsRequiringShippingAddress = allowsPaymentMethodsRequiringShippingAddress
        origin.apiClient = apiClient
        
        if let appearance = appearance {
            origin.appearance = appearance.unwrap()
        }
        
        if let applePay = applePay {
            origin.applePay = applePay.unwrap()
        }
        
        if let billingDetailsCollectionConfiguration = billingDetailsCollectionConfiguration {
            billingDetailsCollectionConfiguration.update(&origin.billingDetailsCollectionConfiguration)
        }
        
        if let customer = customer {
            origin.customer = customer.unwrap()
        }
        
        if let defaultBillingDetails = defaultBillingDetails {
            origin.defaultBillingDetails = defaultBillingDetails.unwrap()
        }
        
        if let externalPaymentMethodConfiguration = externalPaymentMethodConfiguration {
            origin.externalPaymentMethodConfiguration = externalPaymentMethodConfiguration.unwrap()
        }
        
        if let merchantDisplayName = merchantDisplayName {
            origin.merchantDisplayName = merchantDisplayName
        }
        
        origin.paymentMethodOrder = paymentMethodOrder
        origin.preferredNetworks = preferredNetworks?.map { $0.cardBrand }
        
        if let primaryButtonColor = primaryButtonColor {
            origin.primaryButtonColor = primaryButtonColor
        }
        
        if let primaryButtonLabel = primaryButtonLabel {
            origin.primaryButtonLabel = primaryButtonLabel
        }
        
        if let removeSavedPaymentMethodMessage = removeSavedPaymentMethodMessage {
            origin.removeSavedPaymentMethodMessage = removeSavedPaymentMethodMessage
        }
        
        if let returnURL = returnURL {
            origin.returnURL = returnURL
        }
        
        origin.savePaymentMethodOptInBehavior = savePaymentMethodOptInBehavior.unwrap()
        origin.shippingDetails = { [self] in shippingDetails()?.unwrap() }
        
        origin.style = style.unwrap()
        
        return origin
    }
}

extension STPPaymentMethodBillingDetails {
    func unwrap() -> PaymentSheet.BillingDetails {
        return PaymentSheet.BillingDetails(
            address: address?.unwrap() ?? PaymentSheet.Address(),
            email: email,
            name: name,
            phone: phone)
    }
}

extension STPPaymentMethodAddress {
    func unwrap() -> PaymentSheet.Address {
        return PaymentSheet.Address(
            city: city,
            country: country,
            line1: line1,
            line2: line2,
            postalCode: postalCode,
            state: state)
    }
}

extension NSNumber {
    public var cardBrand: STPCardBrand {
        STPCardBrand(rawValue: self.intValue)!
    }
}

/// The result of an attempt to confirm a PaymentIntent or SetupIntent
@objc public enum TSPSPaymentSheetResult : Int {
    /// The customer completed the payment or setup
    /// - Note: The payment may still be processing at this point; don't assume money has successfully moved.
    ///
    /// Your app should transition to a generic receipt view (e.g. a screen that displays "Your order is confirmed!"), and
    /// fulfill the order (e.g. ship the product to the customer) after receiving a successful payment event from Stripe -
    /// see https://stripe.com/docs/payments/handling-payment-events
    case completed = 0

    /// The customer canceled the payment or setup attempt
    case canceled

    /// An error occurred.
    /// - Note: `PaymentSheet` returns this only when an unrecoverable error is encountered (e.g. if PaymentSheet fails to load). In other cases, the error is shown directly to the user in the sheet (e.g. if payment failed).
    ///   `PaymentSheet.FlowController` returns this whenever an error is encountered.
    /// - Parameter error: The error encountered by the customer. You can display its `localizedDescription` to the customer.
    case failed
}

/// Style options for colors in PaymentSheet
@objc public enum TSPSUserInterfaceStyle: Int {

    /// (default) PaymentSheet will automatically switch between standard and dark mode compatible colors based on device settings
    case automatic = 0

    /// PaymentSheet will always use colors appropriate for standard, i.e. non-dark mode UI
    case alwaysLight

    /// PaymentSheet will always use colors appropriate for dark mode UI
    case alwaysDark
}

extension TSPSUserInterfaceStyle {
    func unwrap() -> PaymentSheet.UserInterfaceStyle {
        switch self {
        case .alwaysDark:
            return .alwaysDark
        case .alwaysLight:
            return .alwaysLight
        case .automatic:
            return .automatic
        }
    }
}

@objc public enum TSPSInitializationMode : Int {
    case paymentIntentClientSecret
    case setupIntentClientSecret
    case deferredIntent
}
