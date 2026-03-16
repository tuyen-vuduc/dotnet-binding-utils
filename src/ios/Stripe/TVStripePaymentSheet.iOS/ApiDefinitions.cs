using System;
using Foundation;
using ObjCRuntime;
using PassKit;
using TVStripePaymentSheet;
using StripePayments;
using StripeCore;
using UIKit;

namespace TVStripePaymentSheet
{
	delegate void OnPaymentSheetResult(TSPSPaymentSheetResult result, NSError error);
	delegate void OnPaymentAuthorizationResult(PKPaymentAuthorizationResult result);
	delegate void OnAuthorizationResult(PKPaymentAuthorizationResult result, OnPaymentAuthorizationResult completion);

	// @interface TSPSAddressDetails : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TSPSAddressDetails
	{
		// @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nonnull address;
		[Export ("address", ArgumentSemantic.Strong)]
		STPPaymentMethodAddress Address { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable isCheckboxSelected;
		[NullAllowed, Export ("isCheckboxSelected", ArgumentSemantic.Strong)]
		NSNumber IsCheckboxSelected { get; }

		// -(instancetype _Nonnull)initWithAddress:(STPPaymentMethodAddress * _Nonnull)address name:(NSString * _Nullable)name phone:(NSString * _Nullable)phone isCheckboxSelected:(NSNumber * _Nullable)isCheckboxSelected __attribute__((objc_designated_initializer));
		[Export ("initWithAddress:name:phone:isCheckboxSelected:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPPaymentMethodAddress address, [NullAllowed] string name, [NullAllowed] string phone, [NullAllowed] NSNumber isCheckboxSelected);
	}

	// @interface TSPSAppearance : NSObject
	[BaseType (typeof(NSObject))]
	interface TSPSAppearance
	{
		// @property (readonly, getter = default, nonatomic, strong, class) TSPSAppearance * _Nonnull default_;
		[Static]
		[Export ("default_", ArgumentSemantic.Strong)]
		TSPSAppearance Default_ { [Bind ("default")] get; }

		// @property (readonly, nonatomic, strong) TSPSAppearanceFont * _Nonnull font;
		[Export ("font", ArgumentSemantic.Strong)]
		TSPSAppearanceFont Font { get; }

		// @property (readonly, nonatomic, strong) TSPSAppearanceColors * _Nonnull colors;
		[Export ("colors", ArgumentSemantic.Strong)]
		TSPSAppearanceColors Colors { get; }

		// @property (readonly, nonatomic, strong) TSPSAppearancePrimaryButton * _Nonnull primaryButton;
		[Export ("primaryButton", ArgumentSemantic.Strong)]
		TSPSAppearancePrimaryButton PrimaryButton { get; }

		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (readonly, nonatomic, strong) TSPSAppearanceShadow * _Nonnull shadow;
		[Export ("shadow", ArgumentSemantic.Strong)]
		TSPSAppearanceShadow Shadow { get; }
	}

	// @interface TSPSAppearanceColors : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20TVStripePaymentSheet20TSPSAppearanceColors")]
	interface TSPSAppearanceColors
	{
		// @property (nonatomic, strong) UIColor * _Nonnull primary;
		[Export ("primary", ArgumentSemantic.Strong)]
		UIColor Primary { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull background;
		[Export ("background", ArgumentSemantic.Strong)]
		UIColor Background { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull componentBackground;
		[Export ("componentBackground", ArgumentSemantic.Strong)]
		UIColor ComponentBackground { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull componentBorder;
		[Export ("componentBorder", ArgumentSemantic.Strong)]
		UIColor ComponentBorder { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull componentDivider;
		[Export ("componentDivider", ArgumentSemantic.Strong)]
		UIColor ComponentDivider { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull text;
		[Export ("text", ArgumentSemantic.Strong)]
		UIColor Text { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull textSecondary;
		[Export ("textSecondary", ArgumentSemantic.Strong)]
		UIColor TextSecondary { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull componentText;
		[Export ("componentText", ArgumentSemantic.Strong)]
		UIColor ComponentText { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull componentPlaceholderText;
		[Export ("componentPlaceholderText", ArgumentSemantic.Strong)]
		UIColor ComponentPlaceholderText { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull icon;
		[Export ("icon", ArgumentSemantic.Strong)]
		UIColor Icon { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull danger;
		[Export ("danger", ArgumentSemantic.Strong)]
		UIColor Danger { get; set; }
	}

	// @interface TSPSAppearanceFont : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20TVStripePaymentSheet18TSPSAppearanceFont")]
	interface TSPSAppearanceFont
	{
		// @property (nonatomic) CGFloat sizeScaleFactor;
		[Export ("sizeScaleFactor")]
		nfloat SizeScaleFactor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull base;
		[Export ("base", ArgumentSemantic.Strong)]
		UIFont Base { get; set; }
	}

	// @interface TSPSAppearancePrimaryButton : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20TVStripePaymentSheet27TSPSAppearancePrimaryButton")]
	interface TSPSAppearancePrimaryButton
	{
		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull successBackgroundColor;
		[Export ("successBackgroundColor", ArgumentSemantic.Strong)]
		UIColor SuccessBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable successTextColor;
		[NullAllowed, Export ("successTextColor", ArgumentSemantic.Strong)]
		UIColor SuccessTextColor { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable cornerRadius;
		[NullAllowed, Export ("cornerRadius", ArgumentSemantic.Strong)]
		NSNumber CornerRadius { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull borderColor;
		[Export ("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable font;
		[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (readonly, nonatomic, strong) TSPSAppearanceShadow * _Nonnull shadow;
		[Export ("shadow", ArgumentSemantic.Strong)]
		TSPSAppearanceShadow Shadow { get; }

		// -(void)removeShadow;
		[Export ("removeShadow")]
		void RemoveShadow ();
	}

	// @interface TSPSAppearanceShadow : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC20TVStripePaymentSheet20TSPSAppearanceShadow")]
	interface TSPSAppearanceShadow
	{
	}

	// @interface TSPSApplePayConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TSPSApplePayConfiguration
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull merchantId;
		[Export ("merchantId")]
		string MerchantId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull merchantCountryCode;
		[Export ("merchantCountryCode")]
		string MerchantCountryCode { get; }

		// @property (readonly, nonatomic) PKPaymentButtonType buttonType;
		[Export ("buttonType")]
		PKPaymentButtonType ButtonType { get; }

		// @property (readonly, copy, nonatomic) NSArray<PKPaymentSummaryItem *> * _Nullable paymentSummaryItems;
		[NullAllowed, Export ("paymentSummaryItems", ArgumentSemantic.Copy)]
		PKPaymentSummaryItem[] PaymentSummaryItems { get; }

		// @property (readonly, nonatomic, strong) TSPSApplePayConfigurationHandlers * _Nullable customHandlers;
		[NullAllowed, Export ("customHandlers", ArgumentSemantic.Strong)]
		TSPSApplePayConfigurationHandlers CustomHandlers { get; }

		// -(instancetype _Nonnull)initWithMerchantId:(NSString * _Nonnull)merchantId merchantCountryCode:(NSString * _Nonnull)merchantCountryCode buttonType:(PKPaymentButtonType)buttonType paymentSummaryItems:(NSArray<PKPaymentSummaryItem *> * _Nullable)paymentSummaryItems customHandlers:(TSPSApplePayConfigurationHandlers * _Nullable)customHandlers __attribute__((objc_designated_initializer));
		[Export ("initWithMerchantId:merchantCountryCode:buttonType:paymentSummaryItems:customHandlers:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string merchantId, string merchantCountryCode, PKPaymentButtonType buttonType, [NullAllowed] PKPaymentSummaryItem[] paymentSummaryItems, [NullAllowed] TSPSApplePayConfigurationHandlers customHandlers);
	}

	// @interface TSPSApplePayConfigurationHandlers : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TSPSApplePayConfigurationHandlers
	{
		// @property (readonly, copy, nonatomic) PKPaymentRequest * _Nonnull (^ _Nullable)(PKPaymentRequest * _Nonnull) paymentRequestHandler;
		[NullAllowed, Export ("paymentRequestHandler", ArgumentSemantic.Copy)]
		Func<PKPaymentRequest, PKPaymentRequest> PaymentRequestHandler { get; }

		// @property (readonly, copy, nonatomic) void (^ _Nullable)(PKPaymentAuthorizationResult * _Nonnull, void (^ _Nonnull)(PKPaymentAuthorizationResult * _Nonnull)) authorizationResultHandler;
		[NullAllowed, Export ("authorizationResultHandler", ArgumentSemantic.Copy)]
		OnAuthorizationResult AuthorizationResultHandler { get; }

		// -(instancetype _Nonnull)initWithPaymentRequestHandler:(PKPaymentRequest * _Nonnull (^ _Nullable)(PKPaymentRequest * _Nonnull))paymentRequestHandler authorizationResultHandler:(void (^ _Nullable)(PKPaymentAuthorizationResult * _Nonnull, void (^ _Nonnull)(PKPaymentAuthorizationResult * _Nonnull)))authorizationResultHandler __attribute__((objc_designated_initializer));
		[Export ("initWithPaymentRequestHandler:authorizationResultHandler:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] Func<PKPaymentRequest, PKPaymentRequest> paymentRequestHandler, [NullAllowed] OnAuthorizationResult authorizationResultHandler);
	}

	// @interface TSPSBillingDetailsCollectionConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface TSPSBillingDetailsCollectionConfiguration
	{
		// @property (nonatomic) enum TSPSBillingDetailsCollectionConfigurationCollectionMode name;
		[Export ("name", ArgumentSemantic.Assign)]
		TSPSBillingDetailsCollectionConfigurationCollectionMode Name { get; set; }

		// @property (nonatomic) enum TSPSBillingDetailsCollectionConfigurationCollectionMode phone;
		[Export ("phone", ArgumentSemantic.Assign)]
		TSPSBillingDetailsCollectionConfigurationCollectionMode Phone { get; set; }

		// @property (nonatomic) enum TSPSBillingDetailsCollectionConfigurationCollectionMode email;
		[Export ("email", ArgumentSemantic.Assign)]
		TSPSBillingDetailsCollectionConfigurationCollectionMode Email { get; set; }

		// @property (nonatomic) enum TSPSBillingDetailsCollectionConfigurationAddressCollectionMode address;
		[Export ("address", ArgumentSemantic.Assign)]
		TSPSBillingDetailsCollectionConfigurationAddressCollectionMode Address { get; set; }

		// @property (nonatomic) BOOL attachDefaultsToPaymentMethod;
		[Export ("attachDefaultsToPaymentMethod")]
		bool AttachDefaultsToPaymentMethod { get; set; }
	}

	// @interface TSPSConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface TSPSConfiguration
	{
		// @property (nonatomic) BOOL allowsDelayedPaymentMethods;
		[Export ("allowsDelayedPaymentMethods")]
		bool AllowsDelayedPaymentMethods { get; set; }

		// @property (nonatomic) BOOL allowsPaymentMethodsRequiringShippingAddress;
		[Export ("allowsPaymentMethodsRequiringShippingAddress")]
		bool AllowsPaymentMethodsRequiringShippingAddress { get; set; }

		// @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
		[Export ("apiClient", ArgumentSemantic.Strong)]
		STPAPIClient ApiClient { get; set; }

		// @property (nonatomic, strong) TSPSApplePayConfiguration * _Nullable applePay;
		[NullAllowed, Export ("applePay", ArgumentSemantic.Strong)]
		TSPSApplePayConfiguration ApplePay { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable primaryButtonColor;
		[NullAllowed, Export ("primaryButtonColor", ArgumentSemantic.Strong)]
		UIColor PrimaryButtonColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable primaryButtonLabel;
		[NullAllowed, Export ("primaryButtonLabel")]
		string PrimaryButtonLabel { get; set; }

		// @property (nonatomic) enum TSPSUserInterfaceStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		TSPSUserInterfaceStyle Style { get; set; }

		// @property (nonatomic, strong) TSPSCustomerConfiguration * _Nullable customer;
		[NullAllowed, Export ("customer", ArgumentSemantic.Strong)]
		TSPSCustomerConfiguration Customer { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable merchantDisplayName;
		[NullAllowed, Export ("merchantDisplayName")]
		string MerchantDisplayName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable returnURL;
		[NullAllowed, Export ("returnURL")]
		string ReturnURL { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodBillingDetails * _Nullable defaultBillingDetails;
		[NullAllowed, Export ("defaultBillingDetails", ArgumentSemantic.Strong)]
		STPPaymentMethodBillingDetails DefaultBillingDetails { get; set; }

		// @property (nonatomic) enum TSPSSavePaymentMethodOptInBehavior savePaymentMethodOptInBehavior;
		[Export ("savePaymentMethodOptInBehavior", ArgumentSemantic.Assign)]
		TSPSSavePaymentMethodOptInBehavior SavePaymentMethodOptInBehavior { get; set; }

		// @property (nonatomic, strong) TSPSAppearance * _Nullable appearance;
		[NullAllowed, Export ("appearance", ArgumentSemantic.Strong)]
		TSPSAppearance Appearance { get; set; }

		// @property (copy, nonatomic) TSPSAddressDetails * _Nullable (^ _Nonnull)(void) shippingDetails;
		[Export ("shippingDetails", ArgumentSemantic.Copy)]
		Func<TSPSAddressDetails> ShippingDetails { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nullable preferredNetworks;
		[NullAllowed, Export ("preferredNetworks", ArgumentSemantic.Copy)]
		NSNumber[] PreferredNetworks { get; set; }

		// @property (nonatomic, strong) TSPSBillingDetailsCollectionConfiguration * _Nullable billingDetailsCollectionConfiguration;
		[NullAllowed, Export ("billingDetailsCollectionConfiguration", ArgumentSemantic.Strong)]
		TSPSBillingDetailsCollectionConfiguration BillingDetailsCollectionConfiguration { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable removeSavedPaymentMethodMessage;
		[NullAllowed, Export ("removeSavedPaymentMethodMessage")]
		string RemoveSavedPaymentMethodMessage { get; set; }

		// @property (nonatomic, strong) TSPSExternalPaymentMethodConfiguration * _Nullable externalPaymentMethodConfiguration;
		[NullAllowed, Export ("externalPaymentMethodConfiguration", ArgumentSemantic.Strong)]
		TSPSExternalPaymentMethodConfiguration ExternalPaymentMethodConfiguration { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nullable paymentMethodOrder;
		[NullAllowed, Export ("paymentMethodOrder", ArgumentSemantic.Copy)]
		string[] PaymentMethodOrder { get; set; }
	}

	// @interface TSPSCustomerConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TSPSCustomerConfiguration
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull ephemeralKeySecret;
		[Export ("ephemeralKeySecret")]
		string EphemeralKeySecret { get; }

		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id ephemeralKeySecret:(NSString * _Nonnull)ephemeralKeySecret __attribute__((objc_designated_initializer));
		[Export ("initWithId:ephemeralKeySecret:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string id, string ephemeralKeySecret);
	}

	// @interface TSPSExternalPaymentMethodConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface TSPSExternalPaymentMethodConfiguration
	{
		// -(instancetype _Nonnull)initWithExternalPaymentMethods:(NSArray<NSString *> * _Nonnull)externalPaymentMethods externalPaymentMethodConfirmHandler:(void (^ _Nonnull)(NSString * _Nonnull, STPPaymentMethodBillingDetails * _Nonnull, void (^ _Nonnull)(enum TSPSPaymentSheetResult, NSError * _Nullable)))externalPaymentMethodConfirmHandler;
		[Export ("initWithExternalPaymentMethods:externalPaymentMethodConfirmHandler:")]
		NativeHandle Constructor (string[] externalPaymentMethods, Action<NSString, STPPaymentMethodBillingDetails, OnPaymentSheetResult> externalPaymentMethodConfirmHandler);

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull externalPaymentMethods;
		[Export ("externalPaymentMethods", ArgumentSemantic.Copy)]
		string[] ExternalPaymentMethods { get; set; }

		// @property (copy, nonatomic) void (^ _Nonnull)(NSString * _Nonnull, STPPaymentMethodBillingDetails * _Nonnull, void (^ _Nonnull)(enum TSPSPaymentSheetResult, NSError * _Nullable)) externalPaymentMethodConfirmHandler;
		[Export ("externalPaymentMethodConfirmHandler", ArgumentSemantic.Copy)]
		Action<NSString, STPPaymentMethodBillingDetails, OnPaymentSheetResult> ExternalPaymentMethodConfirmHandler { get; set; }
	}

	// @interface TSPSPaymentSheet : NSObject
	[BaseType (typeof(NSObject))]
	interface TSPSPaymentSheet
	{
		// -(instancetype _Nonnull)initWithPaymentIntentClientSecret:(NSString * _Nonnull)paymentIntentClientSecret configuration:(TSPSConfiguration * _Nonnull)configuration;
		[Export ("initWithPaymentIntentClientSecret:configuration:")]
		NativeHandle Constructor (string paymentIntentClientSecret, TSPSConfiguration configuration);

        // -(instancetype _Nonnull)initWithSetupIntentClientSecret:(NSString * _Nonnull)setupIntentClientSecret configuration:(TSPSConfiguration * _Nonnull)configuration differentiator:(NSString * _Nonnull)differentiator;
        [Export ("initWithSetupIntentClientSecret:configuration:differentiator:")]
		NativeHandle Constructor (string setupIntentClientSecret, TSPSConfiguration configuration, string differentiator);

		// +(void)resetCustomer;
		[Static]
		[Export ("resetCustomer")]
		void ResetCustomer ();

		// -(void)presentFrom:(UIViewController * _Nonnull)presentingViewController completion:(void (^ _Nonnull)(enum TSPSPaymentSheetResult, NSError * _Nullable))completion;
		[Export ("presentFrom:completion:")]
		void PresentFrom (UIViewController presentingViewController, OnPaymentSheetResult completion);
	}
}
