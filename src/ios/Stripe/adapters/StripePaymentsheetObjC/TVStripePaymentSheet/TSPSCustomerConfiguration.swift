//
//  TSPSCustomerConfiguration.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import StripePaymentSheet

/// Configuration related to the Stripe Customer
@objc(TSPSCustomerConfiguration) public class TSPSCustomerConfiguration : NSObject {
    /// The identifier of the Stripe Customer object.
    /// See https://stripe.com/docs/api/customers/object#customer_object-id
    @objc public var id: String {
        self.origin.id
    }

    /// A short-lived token that allows the SDK to access a Customer's payment methods
    @objc public var ephemeralKeySecret: String {
        self.origin.ephemeralKeySecret
    }
    
    private var origin: PaymentSheet.CustomerConfiguration

    /// Initializes a CustomerConfiguration with an ephemeralKeySecret
    @objc public init(id: String, ephemeralKeySecret: String) {
        self.origin = PaymentSheet.CustomerConfiguration(id: id, ephemeralKeySecret: ephemeralKeySecret)
    }
}

extension TSPSCustomerConfiguration {
    func unwrap() -> PaymentSheet.CustomerConfiguration {
        self.origin
    }
}
