//
//  TSPSSavePaymentMethodOptInBehavior.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import StripePaymentSheet

/// Options for the default state of save payment method controls
/// @note Some jurisdictions may have rules governing the ability to default to opt-out behaviors
@objc(TSPSSavePaymentMethodOptInBehavior) public enum TSPSSavePaymentMethodOptInBehavior : Int {

    /// (Default) The SDK will apply opt-out behavior for supported countries.
    /// Currently, we use requiresOptIn for all countries.
    case automatic

    /// The control will always default to unselected and users
    /// will have to explicitly interact to save their payment method
    case requiresOptIn

    /// The control will always default to selected and users
    /// will have to explicitly interact to not save their payment method
    case requiresOptOut
}

extension TSPSSavePaymentMethodOptInBehavior {
    func unwrap() -> PaymentSheet.SavePaymentMethodOptInBehavior {
        switch self {
        case .automatic:
            return .automatic
        case .requiresOptIn:
            return .requiresOptIn
        case .requiresOptOut:
            return .requiresOptOut
        }
    }
}
