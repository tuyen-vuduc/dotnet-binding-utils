//
//  TSPSAddressDetails.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import StripeCore
import StripePayments
import StripePaymentSheet

/// The customer data collected by `AddressViewController`
@objc(TSPSAddressDetails) public class TSPSAddressDetails : NSObject {
    /// The customer's address
    @objc public let address: STPPaymentMethodAddress

    /// The customer's full name
    @objc public let name: String?

    /// The customer's phone number, in E.164 format (e.g. "+15551234567")
    @objc public let phone: String?

    /// Whether or not the checkbox is enabled.
    /// Seealso: `AdditionalFieldsConfiguration.checkboxLabel`
    @objc public let isCheckboxSelected: NSNumber?

    /// Initializes an AddressDetails
    @objc public init(address: STPPaymentMethodAddress, name: String? = nil, phone: String? = nil, isCheckboxSelected: NSNumber? = nil) {
        self.address = address
        self.name = name
        self.phone = phone
        self.isCheckboxSelected = isCheckboxSelected
    }
}

extension TSPSAddressDetails {
    func unwrap () -> AddressViewController.AddressDetails {
        let address = AddressViewController.AddressDetails.Address(
            city: address.city,
            country: address.country!,
            line1: address.line1!,
            line2: address.line2,
            postalCode: address.postalCode,
            state: address.state)
        return AddressViewController.AddressDetails(
            address: address,
            name: name, phone: phone,
            isCheckboxSelected: isCheckboxSelected?.boolValue)
    }
}
