//
//  TSPSApplePayConfiguration.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import PassKit
import StripePaymentSheet

/// Configuration related to Apple Pay
@objc(TSPSApplePayConfiguration) public class TSPSApplePayConfiguration : NSObject {
    /// The Apple Merchant Identifier to use during Apple Pay transactions.
    /// To obtain one, see https://stripe.com/docs/apple-pay#native
    @objc public let merchantId: String

    /// The two-letter ISO 3166 code of the country of your business, e.g. "US"
    /// See your account's country value here https://dashboard.stripe.com/settings/account
    @objc public let merchantCountryCode: String

    /// Defines the label that will be displayed in the Apple Pay button.
    /// See <https://developer.apple.com/design/human-interface-guidelines/technologies/apple-pay/buttons-and-marks/>
    /// for all available options.
    @objc public let buttonType: PKPaymentButtonType

    /// An array of payment summary item objects that summarize the amount of the payment. This property is identical to `PKPaymentRequest.paymentSummaryItems`.
    /// If `nil`, we display a single line item with the amount on the PaymentIntent or "Amount pending" for SetupIntents.
    /// If you're using a SetupIntent for a recurring payment, you should set this to display the amount you intend to charge, in accordance with https://developer.apple.com/design/human-interface-guidelines/technologies/apple-pay/subscriptions-and-donations
    /// Follow Apple's documentation to set this property: https://developer.apple.com/documentation/passkit/pkpaymentrequest/1619231-paymentsummaryitems
    @objc public let paymentSummaryItems: [PKPaymentSummaryItem]?

    /// Optional handler blocks for Apple Pay
    @objc public let customHandlers: TSPSApplePayConfigurationHandlers?

    /// Initializes a ApplePayConfiguration
    @objc public init(
        merchantId: String,
        merchantCountryCode: String,
        buttonType: PKPaymentButtonType = .plain,
        paymentSummaryItems: [PKPaymentSummaryItem]? = nil,
        customHandlers: TSPSApplePayConfigurationHandlers? = nil
    ) {
        self.merchantId = merchantId
        self.merchantCountryCode = merchantCountryCode
        self.buttonType = buttonType
        self.paymentSummaryItems = paymentSummaryItems
        self.customHandlers = customHandlers
    }
    
    func unwrap() -> PaymentSheet.ApplePayConfiguration {
        return PaymentSheet.ApplePayConfiguration(
            merchantId: merchantId,
            merchantCountryCode: merchantCountryCode,
            buttonType: buttonType,
            paymentSummaryItems: paymentSummaryItems,
            customHandlers: customHandlers.map { $0.unwrap() })
    }
}
