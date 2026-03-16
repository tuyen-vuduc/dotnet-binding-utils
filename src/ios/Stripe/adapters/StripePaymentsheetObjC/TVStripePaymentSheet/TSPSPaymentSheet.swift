//
//  TSPSPaymentSheet.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import UIKit
import StripePayments
import StripePaymentSheet
import PassKit

@objc(TSPSPaymentSheet)
public class TSPSPaymentSheet : NSObject {
    private var origin: PaymentSheet!
    
    /// Initializes a PaymentSheet
    /// - Parameter paymentIntentClientSecret: The [client secret](https://stripe.com/docs/api/payment_intents/object#payment_intent_object-client_secret) of a Stripe PaymentIntent object
    /// - Note: This can be used to complete a payment - don't log it, store it, or expose it to anyone other than the customer.
    /// - Parameter configuration: Configuration for the PaymentSheet. e.g. your business name, Customer details, etc.
    @objc public convenience init(paymentIntentClientSecret: String, configuration: TSPSConfiguration) {
        self.init()
        
        origin = PaymentSheet(
            paymentIntentClientSecret: paymentIntentClientSecret,
            configuration: configuration.unwrap())
    }
    
    /// Initializes a PaymentSheet
    /// - Parameter setupIntentClientSecret: The [client secret](https://stripe.com/docs/api/setup_intents/object#setup_intent_object-client_secret) of a Stripe SetupIntent object
    /// - Parameter configuration: Configuration for the PaymentSheet. e.g. your business name, Customer details, etc.
    @objc public convenience init(setupIntentClientSecret: String, configuration:TSPSConfiguration, differentiator: String) {
        self.init()
        
        origin = PaymentSheet(
            setupIntentClientSecret: setupIntentClientSecret,
            configuration: configuration.unwrap())
    }
    
    @objc public static func resetCustomer() {
        PaymentSheet.resetCustomer()
    }
    
    /// Presents a sheet for a customer to complete their payment
    /// - Parameter presentingViewController: The view controller to present a payment sheet
    /// - Parameter completion: Called with the result of the payment after the payment sheet is dismissed.
    @objc public func present(
        from presentingViewController: UIViewController,
        completion: @escaping (TSPSPaymentSheetResult, Error?) -> Void
    ) {
        origin.present(from: presentingViewController) { result in
            switch result {
            case .completed:
                completion(.completed, nil)
            case .canceled:
                completion(.canceled, nil)
            case .failed(let error):
                completion(.failed, error)
            }
        }
    }
}
