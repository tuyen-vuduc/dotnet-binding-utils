//
//  TSPSAppearance.swift
//  StripePaymentsheetObjC
//
//  Created by Tuyen Vu on 6/22/24.
//

import Foundation
import UIKit
import StripePaymentSheet

/// Describes the appearance of PaymentSheet
@objc(TSPSAppearance) public class TSPSAppearance: NSObject {
    /// The default appearance for PaymentSheet
    @objc public static let `default` = TSPSAppearance()

    private var origin: PaymentSheet.Appearance
    
    /// Creates a `PaymentSheet.Appearance` with default values
    @objc public override init() {
        origin = PaymentSheet.Appearance()
    }

    /// Describes the appearance of fonts in PaymentSheet
    @objc public var font: TSPSAppearanceFont {
        TSPSAppearanceFont(&origin.font)
    }

    /// Describes the colors in PaymentSheet
    @objc public var colors: TSPSAppearanceColors  {
        TSPSAppearanceColors(&origin.colors)
    }

    /// Describes the appearance of the primary button (e.g., the "Pay" button)
    @objc public var primaryButton: TSPSAppearancePrimaryButton {
        TSPSAppearancePrimaryButton(&self.origin.primaryButton)
    }

    /// The corner radius used for buttons, inputs, tabs in PaymentSheet
    /// - Note: The behavior of this property is consistent with the behavior of corner radius on `CALayer`
    @objc public var cornerRadius: CGFloat {
        get {
            origin.cornerRadius
        }
        set {
            origin.cornerRadius = newValue
        }
    }

    /// The border used for inputs and tabs in PaymentSheet
    /// - Note: The behavior of this property is consistent with the behavior of border width on `CALayer`
    @objc public var borderWidth: CGFloat {
        get {
            origin.borderWidth
        }
        set {
            origin.borderWidth = newValue
        }
    }

    /// The shadow used for inputs and tabs in PaymentSheet
    /// - Note: Set this to `.disabled` to disable shadows
    @objc public var shadow: TSPSAppearanceShadow {
        TSPSAppearanceShadow(&origin.shadow)
    }
    
    func unwrap() -> PaymentSheet.Appearance {
        return origin
    }
}

// MARK: Fonts

/// Describes the appearance of fonts in PaymentSheet
@objc public class TSPSAppearanceFont: NSObject {
    private var origin: PaymentSheet.Appearance.Font

    override public init() {
        origin = PaymentSheet.Appearance.Font()
    }
    
    /// Creates a `PaymentSheet.Appearance.Font` with default values
    public convenience init(_ origin: inout PaymentSheet.Appearance.Font) {
        self.init()
        self.origin = origin
    }

    /// The scale factor for all font sizes in PaymentSheet.
    /// Font sizes are multiplied by this value before being displayed. For example, setting this to 1.2 increases the size of all text by 20%.
    /// - Note: This value must be greater than 0. The default value is 1.0.
    /// - Note: This is used in conjunction with the Dynamic Type accessibility text size.
    @objc public var sizeScaleFactor: CGFloat {
        get {
            origin.sizeScaleFactor
        }
        set {
            origin.sizeScaleFactor = newValue
        }
    }

    /// The font family of this font is used throughout PaymentSheet. PaymentSheet uses this font at multiple weights (e.g., regular, medium, semibold) if they exist.
    /// - Note: The size and weight of the font is ignored. To adjust font sizes, see `sizeScaleFactor`.
    @objc public var base: UIFont {
        get {
            origin.base
        }
        set {
            origin.base = newValue
        }
    }
}

// MARK: Colors

/// Describes the colors in PaymentSheet
@objc public class TSPSAppearanceColors: NSObject {
    private var origin: PaymentSheet.Appearance.Colors

    /// Creates a `PaymentSheet.Appearance.Colors` with default values
    public override init() {
        origin = PaymentSheet.Appearance.Colors()
    }
    
    public convenience init(_ origin: inout PaymentSheet.Appearance.Colors) {
        self.init()
        self.origin = origin
    }

    /// The primary color used throughout PaymentSheet
    @objc public var primary: UIColor {
        get {
            origin.primary
        }
        set {
            origin.primary = newValue
        }
    }

    /// The color used for the background of PaymentSheet
    @objc public var background: UIColor  {
        get {
            origin.background
        }
        set {
            origin.background = newValue
        }
    }

    /// The color used for the background of inputs, tabs, and other components
    @objc public var componentBackground: UIColor  {
        get {
            origin.componentBackground
        }
        set {
            origin.componentBackground = newValue
        }
    }

    /// The border color used for inputs, tabs, and other components
    @objc public var componentBorder: UIColor  {
        get {
            origin.componentBorder
        }
        set {
            origin.componentBorder = newValue
        }
    }

    /// The color of the divider lines used inside inputs, tabs, and other components
    @objc public var componentDivider: UIColor  {
        get {
            origin.componentDivider
        }
        set {
            origin.componentDivider = newValue
        }
    }

    /// The default text color used in PaymentSheet, appearing over the background color
    @objc public var text: UIColor  {
        get {
            origin.text
        }
        set {
            origin.text = newValue
        }
    }

    /// The color used for text of secondary importance. For example, this color is used for the label above input fields
    @objc public var textSecondary: UIColor  {
        get {
            origin.textSecondary
        }
        set {
            origin.textSecondary = newValue
        }
    }

    /// The color of text appearing over `componentBackground`
    @objc public var componentText: UIColor  {
        get {
            origin.componentText
        }
        set {
            origin.componentText = newValue
        }
    }

    /// The color used for input placeholder text
    @objc public var componentPlaceholderText: UIColor  {
        get {
            origin.componentPlaceholderText
        }
        set {
            origin.componentPlaceholderText = newValue
        }
    }

    /// The color used for icons in PaymentSheet, such as the close or back icons
    @objc public var icon: UIColor  {
        get {
            origin.icon
        }
        set {
            origin.icon = newValue
        }
    }

    /// The color used to indicate errors or destructive actions in PaymentSheet
    @objc public var danger: UIColor  {
        get {
            origin.danger
        }
        set {
            origin.danger = newValue
        }
    }
}

// MARK: Shadow

/// Represents a shadow in PaymentSheet
@objc public class TSPSAppearanceShadow: NSObject {
    /// Color of the shadow
    /// - Note: The behavior of this property is consistent with `CALayer.shadowColor`
    public var color: UIColor  {
        get {
            origin.color
        }
        set {
            origin.color = newValue
        }
    }

    /// Opacity or alpha of the shadow
    /// - Note: The behavior of this property is consistent with `CALayer.shadowOpacity`
    public var opacity: CGFloat  {
        get {
            origin.opacity
        }
        set {
            origin.opacity = newValue
        }
    }

    /// Offset of the shadow
    /// - Note: The behavior of this property is consistent with `CALayer.shadowOffset`
    public var offset: CGSize  {
        get {
            origin.offset
        }
        set {
            origin.offset = newValue
        }
    }

    /// Radius of the shadow
    /// - Note: The behavior of this property is consistent with `CALayer.shadowRadius`
    public var radius: CGFloat {
        get {
            origin.radius
        }
        set {
            origin.radius = newValue
        }
    }

    /// Creates a `PaymentSheet.Appearance.Shadow` with default values
    public override init() {
        origin = PaymentSheet.Appearance.Shadow()
    }
    
    public convenience init(_ origin: inout PaymentSheet.Appearance.Shadow) {
        self.init()
        self.origin = origin
    }
    
    private var origin: PaymentSheet.Appearance.Shadow
    
}

// MARK: Primary Button

/// Describes the appearance of the primary button (e.g., the "Pay" button)
@objc public class TSPSAppearancePrimaryButton: NSObject {
    private var origin: PaymentSheet.Appearance.PrimaryButton
    
    /// Creates a `PaymentSheet.Appearance.PrimaryButton` with default values
    public override init() {
        origin = PaymentSheet.Appearance.PrimaryButton()
    }
    
    public convenience init(_ origin: inout PaymentSheet.Appearance.PrimaryButton) {
        self.init()
        self.origin = origin
    }

    /// The background color of the primary button
    /// - Note: If `nil`, `appearance.colors.primary` will be used as the primary button background color
    @objc public var backgroundColor: UIColor? {
        get {
            origin.backgroundColor
        }
        set {
            origin.backgroundColor = newValue
        }
    }

    /// The text color of the primary button
    /// - Note: If `nil`, defaults to either white or black depending on the color of the button
    @objc public var textColor: UIColor? {
        get {
            origin.textColor
        }
        set {
            origin.textColor = newValue
        }
    }

    /// The background color of the primary button when in a success state.
    /// - Note: Only applies to PaymentSheet. The primary button transitions to the success state when payment succeeds.
    @objc public var successBackgroundColor: UIColor  {
        get {
            origin.successBackgroundColor
        }
        set {
            origin.successBackgroundColor = newValue
        }
    }

    /// The text color of the primary button when in a success state.
    /// - Note: Only applies to PaymentSheet. The primary button transitions to the success state when payment succeeds.
    /// - Note: If `nil`, defaults to `textColor`
    @objc public var successTextColor: UIColor? {
        get {
            origin.successTextColor
        }
        set {
            origin.successTextColor = newValue
        }
    }

    /// The corner radius of the primary button
    /// - Note: If `nil`, `appearance.cornerRadius` will be used as the primary button corner radius
    /// - Note: The behavior of this property is consistent with the behavior of corner radius on `CALayer`
    @objc public var cornerRadius: NSNumber? {
        get {
            if let cornerRadius = origin.cornerRadius {
                return NSNumber(floatLiteral: cornerRadius)
            }
            return nil
        }
        set {
            if let value = newValue {
                self.origin.cornerRadius = CGFloat(value.floatValue)
            } else {
                self.origin.cornerRadius = nil
            }
        }
    }

    /// The border color of the primary button
    /// - Note: The behavior of this property is consistent with the behavior of border color on `CALayer`
    @objc public var borderColor: UIColor  {
        get {
            origin.borderColor
        }
        set {
            origin.borderColor = newValue
        }
    }

    /// The border width of the primary button
    /// - Note: The behavior of this property is consistent with the behavior of border width on `CALayer`
    @objc public var borderWidth: CGFloat  {
        get {
            origin.borderWidth
        }
        set {
            origin.borderWidth = newValue
        }
    }

    /// The font used for the text of the primary button
    /// - Note: If `nil`, `appearance.font.base` will be used as the primary button font
    /// - Note: `appearance.font.sizeScaleFactor` does not impact the size of this font
    @objc public var font: UIFont? {
        get {
            origin.font
        }
        set {
            origin.font = newValue
        }
    }

    /// The shadow of the primary button
    /// - Note: If `nil`, `appearance.shadow` will be used as the primary button shadow
    @objc public var shadow: TSPSAppearanceShadow {
        var shadow: PaymentSheet.Appearance.Shadow = origin.shadow ?? PaymentSheet.Appearance.Shadow()
        origin.shadow = shadow
        return TSPSAppearanceShadow(&shadow)
    }
    
    @objc public func removeShadow() {
        origin.shadow = nil
    }
}
