//
//  TSPSApplePayConfigurationHandlers.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import PassKit
import StripePaymentSheet

/// Custom handler blocks for Apple Pay
@objc(TSPSApplePayConfigurationHandlers) public class TSPSApplePayConfigurationHandlers : NSObject {
    /// Optionally configure additional information on your PKPaymentRequest.
    /// This closure will be called after the PKPaymentRequest is created, but before the Apple Pay sheet is presented.
    /// In your implementation, you can configure the PKPaymentRequest to add custom fields, such as `recurringPaymentRequest`.
    /// See https://developer.apple.com/documentation/passkit/pkpaymentrequest for all configuration options.
    /// - Parameter: The PKPaymentRequest created by PaymentSheet.
    /// - Return: The PKPaymentRequest after your modifications.
    @objc public let paymentRequestHandler: ((PKPaymentRequest) -> PKPaymentRequest)?

    /// Optionally configure additional information on your PKPaymentAuthorizationResult.
    /// This closure will be called after the PaymentIntent or SetupIntent is confirmed, but before
    /// the Apple Pay sheet has been closed.
    /// In your implementation, you can configure the PKPaymentAuthorizationResult to add custom fields, such as `orderDetails`.
    /// See https://developer.apple.com/documentation/passkit/pkpaymentauthorizationresult for all configuration options.
    /// - Parameter $0: The PKPaymentAuthorizationResult created by PaymentSheet.
    /// - Parameter $1: A completion handler. You must call this handler with the PKPaymentAuthorizationResult on the main queue
    /// after applying your modifications.
    /// For example:
    /// ```
    /// .authorizationResultHandler = { result, completion in
    ///     result.orderDetails = PKPaymentOrderDetails(/* ... */)
    ///     completion(result)
    /// }
    /// ```
    /// WARNING: If you do not call the completion handler, your app will hang until the Apple Pay sheet times out.
    @objc public let authorizationResultHandler:
    ((PKPaymentAuthorizationResult, @escaping ((PKPaymentAuthorizationResult) -> Void)) -> Void)?

    /// Initializes the ApplePayConfiguration Handlers.
    @objc public init(
        paymentRequestHandler: ((PKPaymentRequest) -> PKPaymentRequest)? = nil,
        authorizationResultHandler: (
            (PKPaymentAuthorizationResult, @escaping ((PKPaymentAuthorizationResult) -> Void)) -> Void
        )? = nil
    ) {
        self.paymentRequestHandler = paymentRequestHandler
        self.authorizationResultHandler = authorizationResultHandler
    }
    
    func unwrap() -> PaymentSheet.ApplePayConfiguration.Handlers {
        return PaymentSheet.ApplePayConfiguration.Handlers(
            paymentRequestHandler: paymentRequestHandler,
            authorizationResultHandler: authorizationResultHandler)
    }
}
