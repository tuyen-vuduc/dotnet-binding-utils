//
//  TSPSExternalPaymentMethodConfiguration.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import StripePaymentSheet

/// Configuration for external payment methods
/// - Seealso: See the [integration guide](https://stripe.com/docs/payments/external-payment-methods?platform=ios).
@objc(TSPSExternalPaymentMethodConfiguration) public class TSPSExternalPaymentMethodConfiguration : NSObject {
    private var origin: PaymentSheet.ExternalPaymentMethodConfiguration

    override public init() {
        self.origin = PaymentSheet.ExternalPaymentMethodConfiguration(
            externalPaymentMethods: [],
            externalPaymentMethodConfirmHandler: { externalPaymentMethodType, billingDetails, completion in
                
            })
        super.init()
    }
    
    /// Initializes an `ExternalPaymentMethodConfiguration`
    /// - Parameter externalPaymentMethods: A list of external payment methods to display in PaymentSheet e.g., ["external_paypal"].
    /// - Parameter externalPaymentMethodConfirmHandler: A handler called when the customer confirms the payment using an external payment method.
    /// - Seealso: See the [integration guide](https://stripe.com/docs/payments/external-payment-methods?platform=ios).
    @objc public convenience init(externalPaymentMethods: [String], externalPaymentMethodConfirmHandler: @escaping (
        _ externalPaymentMethodType: String,
        _ billingDetails: STPPaymentMethodBillingDetails,
        _ completion: @escaping ((TSPSPaymentSheetResult, Error?) -> Void)
    ) -> Void) {
        self.init()
        self.origin = PaymentSheet.ExternalPaymentMethodConfiguration(
            externalPaymentMethods: externalPaymentMethods,
            externalPaymentMethodConfirmHandler: {
                externalPaymentMethodType, billingDetails, completionx in
                externalPaymentMethodConfirmHandler(
                    externalPaymentMethodType,
                    billingDetails) {
                        result, error in
                        switch result {
                        case .canceled:
                            completionx(.canceled)
                        case .completed:
                            completionx(.completed)
                        default:
                            if let error {
                                completionx(.failed(error: error))
                                return
                            }
                        }
                    }
            })
    }

    /// A list of external payment methods to display in PaymentSheet.
    /// e.g. ["external_paypal"].
    @objc public var externalPaymentMethods: [String] {
        get {
            self.origin.externalPaymentMethods
        }
        set {
            self.origin.externalPaymentMethods = newValue
        }
    }

    /// This handler is called when the customer confirms the payment using an external payment method.
    /// Your implementation should complete the payment and call the `completion` parameter with the result.
    /// - Note: This is always called on the main thread.
    @objc public var externalPaymentMethodConfirmHandler: (
        _ externalPaymentMethodType: String,
        _ billingDetails: STPPaymentMethodBillingDetails,
        _ completion: @escaping ((TSPSPaymentSheetResult, Error?) -> Void)
    ) -> Void {
        get {
            return {
                externalPaymentMethodType, billingDetails, completionx in
                self.origin.externalPaymentMethodConfirmHandler(externalPaymentMethodType, billingDetails) {
                    result in
                    switch result {
                    case .canceled:
                        completionx(.canceled, nil)
                    case .completed:
                        completionx(.completed, nil)
                    case .failed(let error):
                        completionx(.failed, error)
                    }
                }
            }
        }
        set {
            self.origin.externalPaymentMethodConfirmHandler = {
                externalPaymentMethodType, billingDetails, completionx in
                newValue(
                    externalPaymentMethodType,
                    billingDetails) {
                        result, error in
                        switch result {
                        case .canceled:
                            completionx(.canceled)
                        case .completed:
                            completionx(.completed)
                        default:
                            if let error {
                                completionx(.failed(error: error))
                                return
                            }
                        }
                    }
            }
        }
    }
    
    func unwrap() -> PaymentSheet.ExternalPaymentMethodConfiguration {
        self.origin
    }
}
