//
//  TSPSBillingDetailsCollectionConfiguration.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import StripePaymentSheet

/// Configuration for how billing details are collected during checkout.
@objc(TSPSBillingDetailsCollectionConfiguration) public class TSPSBillingDetailsCollectionConfiguration: NSObject {

    /// How to collect the name field.
    /// Defaults to `automatic`.
    @objc public var name: TSPSBillingDetailsCollectionConfigurationCollectionMode = .automatic

    /// How to collect the phone field.
    /// Defaults to `automatic`.
    @objc public var phone: TSPSBillingDetailsCollectionConfigurationCollectionMode = .automatic

    /// How to collect the email field.
    /// Defaults to `automatic`.
    @objc public var email: TSPSBillingDetailsCollectionConfigurationCollectionMode = .automatic

    /// How to collect the billing address.
    /// Defaults to `automatic`.
    @objc public var address: TSPSBillingDetailsCollectionConfigurationAddressCollectionMode = .automatic

    /// Whether the values included in `Configuration.defaultBillingDetails` should be attached to the payment
    /// method, this includes fields that aren't displayed in the form.
    ///
    /// If `false` (the default), those values will only be used to prefill the corresponding fields in the form.
    @objc public var attachDefaultsToPaymentMethod = false
}

extension TSPSBillingDetailsCollectionConfiguration {
    func update(_ origin: inout PaymentSheet.BillingDetailsCollectionConfiguration) {
        origin.address = address.unwrap()
        origin.attachDefaultsToPaymentMethod = attachDefaultsToPaymentMethod
        origin.email = email.unwrap()
        origin.name = name.unwrap()
        origin.phone = phone.unwrap()
    }
}

/// Billing details fields collection options.
@objc public enum TSPSBillingDetailsCollectionConfigurationCollectionMode: Int {
    /// The field will be collected depending on the Payment Method's requirements.
    case automatic
    /// The field will never be collected.
    /// If this field is required by the Payment Method, you must provide it as part of `defaultBillingDetails`.
    case never
    /// The field will always be collected, even if it isn't required for the Payment Method.
    case always
}

extension TSPSBillingDetailsCollectionConfigurationCollectionMode {
    func unwrap() -> PaymentSheet.BillingDetailsCollectionConfiguration.CollectionMode {
        switch self {
        case .always:
            return .always
        case .automatic:
            return .automatic
        case .never:
            return .never
        }
    }
}

/// Billing address collection options.
@objc public enum TSPSBillingDetailsCollectionConfigurationAddressCollectionMode: Int {
    /// Only the fields required by the Payment Method will be collected, this may be none.
    case automatic
    /// Address will never be collected.
    /// If the Payment Method requires a billing address, you must provide it as part of
    /// `defaultBillingDetails`.
    case never
    /// Collect the full billing address, regardless of the Payment Method requirements.
    case full
}

extension TSPSBillingDetailsCollectionConfigurationAddressCollectionMode {
    func unwrap() -> PaymentSheet.BillingDetailsCollectionConfiguration.AddressCollectionMode {
        switch self {
        case .full:
            return .full
        case .automatic:
            return .automatic
        case .never:
            return .never
        }
    }
}
