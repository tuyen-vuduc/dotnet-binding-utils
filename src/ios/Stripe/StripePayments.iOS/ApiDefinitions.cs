using System;
using Contacts;
using Foundation;
using ObjCRuntime;
using AuthenticationServices;
using PassKit;
using SafariServices;
using StripePayments;
using UIKit;
using StripeCore;

namespace StripePayments
{
	// @protocol STPAPIResponseDecodable <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ISTPAPIResponseDecodable { }


    [Protocol (Name = "_TtP14StripePayments23STPAPIResponseDecodable_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP14StripePayments23STPAPIResponseDecodable_")]
	interface STPAPIResponseDecodable
	{
		// @required +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static, Abstract]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPAPIResponseDecodable DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);

		// @required @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Abstract]
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }
	}

	// @interface STP_Internal_LinkAccountSession : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STP_Internal_LinkAccountSession : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STP_Internal_LinkAccountSession DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STP_Internal_LinkSettings : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STP_Internal_LinkSettings : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STP_Internal_LinkSettings DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface StripePayments_Swift_347 (NSDecimalNumber)
	[Category]
	[BaseType (typeof(NSDecimalNumber))]
	interface NSDecimalNumber_StripePayments_Swift_347
	{
		// +(NSDecimalNumber * _Nonnull)stp_decimalNumberWithAmount:(NSInteger)amount currency:(NSString * _Nullable)currency __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_decimalNumberWithAmount:currency:")]
		NSDecimalNumber Stp_decimalNumberWithAmount (nint amount, [NullAllowed] string currency);

		// -(NSInteger)stp_amountWithCurrency:(NSString * _Nullable)currency __attribute__((warn_unused_result("")));
		[Export ("stp_amountWithCurrency:")]
		nint Stp_amountWithCurrency ([NullAllowed] string currency);
	}

	// @interface StripePayments_Swift_357
	interface StripePayments_Swift_357
	{
		// -(void)createRadarSessionWithCompletion:(void (^ _Nonnull)(STPRadarSession * _Nullable, NSError * _Nullable))completion;
		[Export ("createRadarSessionWithCompletion:")]
		void CreateRadarSessionWithCompletion (Action<STPRadarSession, NSError> completion);
	}

	// @interface StripePayments_Swift_374
	interface StripePayments_Swift_374
	{
		// -(void)createTokenWithBankAccount:(STPBankAccountParams * _Nonnull)bankAccount completion:(void (^ _Nonnull)(STPToken * _Nullable, NSError * _Nullable))completion;
		[Export ("createTokenWithBankAccount:completion:")]
		void CreateTokenWithBankAccount (STPBankAccountParams bankAccount, Action<STPToken, NSError> completion);
	}

	// @interface StripePayments_Swift_387
	interface StripePayments_Swift_387
	{
		// -(void)uploadImage:(UIImage * _Nonnull)image purpose:(enum STPFilePurpose)purpose completion:(void (^ _Nullable)(STPFile * _Nullable, NSError * _Nullable))completion;
		[Export ("uploadImage:purpose:completion:")]
		void UploadImage (UIImage image, STPFilePurpose purpose, [NullAllowed] Action<STPFile, NSError> completion);
	}

	// @interface StripePayments_Swift_409
	interface StripePayments_Swift_409
	{
		// -(void)createTokenWithConnectAccount:(STPConnectAccountParams * _Nonnull)account completion:(void (^ _Nullable)(STPToken * _Nullable, NSError * _Nullable))completion;
		[Export ("createTokenWithConnectAccount:completion:")]
		void CreateTokenWithConnectAccount (STPConnectAccountParams account, [NullAllowed] Action<STPToken, NSError> completion);
	}

	// @interface StripePayments_Swift_420
	interface StripePayments_Swift_420
	{
		// -(void)createTokenWithPersonalIDNumber:(NSString * _Nonnull)pii completion:(void (^ _Nullable)(STPToken * _Nullable, NSError * _Nullable))completion;
		[Export ("createTokenWithPersonalIDNumber:completion:")]
		void CreateTokenWithPersonalIDNumber (string pii, [NullAllowed] Action<STPToken, NSError> completion);

		// -(void)createTokenWithSSNLast4:(NSString * _Nonnull)ssnLast4 completion:(void (^ _Nonnull)(STPToken * _Nullable, NSError * _Nullable))completion;
		[Export ("createTokenWithSSNLast4:completion:")]
		void CreateTokenWithSSNLast4 (string ssnLast4, Action<STPToken, NSError> completion);
	}

	// @interface StripePayments_Swift_437
	interface StripePayments_Swift_437
	{
		// -(void)createTokenWithCard:(STPCardParams * _Nonnull)cardParams completion:(void (^ _Nonnull)(STPToken * _Nullable, NSError * _Nullable))completion;
		[Export ("createTokenWithCard:completion:")]
		void CreateTokenWithCard (STPCardParams cardParams, Action<STPToken, NSError> completion);

		// -(void)createTokenForCVCUpdate:(NSString * _Nonnull)cvc completion:(void (^ _Nullable)(STPToken * _Nullable, NSError * _Nullable))completion;
		[Export ("createTokenForCVCUpdate:completion:")]
		void CreateTokenForCVCUpdate (string cvc, [NullAllowed] Action<STPToken, NSError> completion);
	}

	// @interface StripePayments_Swift_456
	interface StripePayments_Swift_456
	{
		// -(void)createSourceWithParams:(STPSourceParams * _Nonnull)sourceParams completion:(void (^ _Nonnull)(STPSource * _Nullable, NSError * _Nullable))completion;
		[Export ("createSourceWithParams:completion:")]
		void CreateSourceWithParams (STPSourceParams sourceParams, Action<STPSource, NSError> completion);

		// -(void)retrieveSourceWithId:(NSString * _Nonnull)identifier clientSecret:(NSString * _Nonnull)secret completion:(void (^ _Nonnull)(STPSource * _Nullable, NSError * _Nullable))completion;
		[Export ("retrieveSourceWithId:clientSecret:completion:")]
		void RetrieveSourceWithId (string identifier, string secret, Action<STPSource, NSError> completion);

		// -(void)startPollingSourceWithId:(NSString * _Nonnull)identifier clientSecret:(NSString * _Nonnull)secret timeout:(NSTimeInterval)timeout completion:(void (^ _Nonnull)(STPSource * _Nullable, NSError * _Nullable))completion;
		[Export ("startPollingSourceWithId:clientSecret:timeout:completion:")]
		void StartPollingSourceWithId (string identifier, string secret, double timeout, Action<STPSource, NSError> completion);

		// -(void)stopPollingSourceWithId:(NSString * _Nonnull)identifier;
		[Export ("stopPollingSourceWithId:")]
		void StopPollingSourceWithId (string identifier);
	}

	// @interface StripePayments_Swift_503
	interface StripePayments_Swift_503
	{
		// -(void)createPaymentMethodWithParams:(STPPaymentMethodParams * _Nonnull)paymentMethodParams completion:(void (^ _Nonnull)(STPPaymentMethod * _Nullable, NSError * _Nullable))completion;
		[Export ("createPaymentMethodWithParams:completion:")]
		void CreatePaymentMethodWithParams (STPPaymentMethodParams paymentMethodParams, Action<STPPaymentMethod, NSError> completion);
	}

	// @interface StripePayments_Swift_516
	interface StripePayments_Swift_516
	{
		// -(void)createTokenWithPayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(STPToken * _Nullable, NSError * _Nullable))completion;
		[Export ("createTokenWithPayment:completion:")]
		void CreateTokenWithPayment (PKPayment payment, Action<STPToken, NSError> completion);

		// -(void)createSourceWithPayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(STPSource * _Nullable, NSError * _Nullable))completion;
		[Export ("createSourceWithPayment:completion:")]
		void CreateSourceWithPayment (PKPayment payment, Action<STPSource, NSError> completion);

		// -(void)createPaymentMethodWithPayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(STPPaymentMethod * _Nullable, NSError * _Nullable))completion;
		[Export ("createPaymentMethodWithPayment:completion:")]
		void CreatePaymentMethodWithPayment (PKPayment payment, Action<STPPaymentMethod, NSError> completion);

		// -(void)createPaymentMethodWithPayment:(PKPayment * _Nonnull)payment metadata:(NSDictionary<NSString *,NSString *> * _Nonnull)metadata completion:(void (^ _Nonnull)(STPPaymentMethod * _Nullable, NSError * _Nullable))completion;
		[Export ("createPaymentMethodWithPayment:metadata:completion:")]
		void CreatePaymentMethodWithPayment (PKPayment payment, NSDictionary<NSString, NSString> metadata, Action<STPPaymentMethod, NSError> completion);
	}

	// @interface StripePayments_Swift_550
	interface StripePayments_Swift_550
	{
		// -(void)retrievePaymentIntentWithClientSecret:(NSString * _Nonnull)secret completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("retrievePaymentIntentWithClientSecret:completion:")]
		void RetrievePaymentIntentWithClientSecret (string secret, Action<STPPaymentIntent, NSError> completion);

		// -(void)retrievePaymentIntentWithClientSecret:(NSString * _Nonnull)secret expand:(NSArray<NSString *> * _Nullable)expand completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("retrievePaymentIntentWithClientSecret:expand:completion:")]
		void RetrievePaymentIntentWithClientSecret (string secret, [NullAllowed] string[] expand, Action<STPPaymentIntent, NSError> completion);

		// -(void)confirmPaymentIntentWithParams:(STPPaymentIntentParams * _Nonnull)paymentIntentParams completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("confirmPaymentIntentWithParams:completion:")]
		void ConfirmPaymentIntentWithParams (STPPaymentIntentParams paymentIntentParams, Action<STPPaymentIntent, NSError> completion);

		// -(void)confirmPaymentIntentWithParams:(STPPaymentIntentParams * _Nonnull)paymentIntentParams expand:(NSArray<NSString *> * _Nullable)expand completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("confirmPaymentIntentWithParams:expand:completion:")]
		void ConfirmPaymentIntentWithParams (STPPaymentIntentParams paymentIntentParams, [NullAllowed] string[] expand, Action<STPPaymentIntent, NSError> completion);
	}

	// @interface StripePayments_Swift_594
	interface StripePayments_Swift_594
	{
		// -(void)retrieveSetupIntentWithClientSecret:(NSString * _Nonnull)secret completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("retrieveSetupIntentWithClientSecret:completion:")]
		void RetrieveSetupIntentWithClientSecret (string secret, Action<STPSetupIntent, NSError> completion);

		// -(void)retrieveSetupIntentWithClientSecret:(NSString * _Nonnull)secret expand:(NSArray<NSString *> * _Nullable)expand completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("retrieveSetupIntentWithClientSecret:expand:completion:")]
		void RetrieveSetupIntentWithClientSecret (string secret, [NullAllowed] string[] expand, Action<STPSetupIntent, NSError> completion);

		// -(void)confirmSetupIntentWithParams:(STPSetupIntentConfirmParams * _Nonnull)setupIntentParams completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("confirmSetupIntentWithParams:completion:")]
		void ConfirmSetupIntentWithParams (STPSetupIntentConfirmParams setupIntentParams, Action<STPSetupIntent, NSError> completion);

		// -(void)confirmSetupIntentWithParams:(STPSetupIntentConfirmParams * _Nonnull)setupIntentParams expand:(NSArray<NSString *> * _Nullable)expand completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("confirmSetupIntentWithParams:expand:completion:")]
		void ConfirmSetupIntentWithParams (STPSetupIntentConfirmParams setupIntentParams, [NullAllowed] string[] expand, Action<STPSetupIntent, NSError> completion);
	}

	// @interface STPAddress : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments10STPAddress")]
	partial interface STPAddress
	{
		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable line1;
		[NullAllowed, Export ("line1")]
		string Line1 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable line2;
		[NullAllowed, Export ("line2")]
		string Line2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable city;
		[NullAllowed, Export ("city")]
		string City { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable state;
		[NullAllowed, Export ("state")]
		string State { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSDictionary * _Nullable)shippingInfoForChargeWithAddress:(STPAddress * _Nullable)address shippingMethod:(PKShippingMethod * _Nullable)method __attribute__((warn_unused_result("")));
		[Static]
		[Export ("shippingInfoForChargeWithAddress:shippingMethod:")]
		[return: NullAllowed]
		NSDictionary ShippingInfoForChargeWithAddress ([NullAllowed] STPAddress address, [NullAllowed] PKShippingMethod method);

		// -(instancetype _Nonnull)initWithPaymentMethodBillingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails __attribute__((objc_designated_initializer));
		[Export ("initWithPaymentMethodBillingDetails:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPPaymentMethodBillingDetails billingDetails);

		// -(instancetype _Nonnull)initWithPKContact:(PKContact * _Nonnull)contact __attribute__((objc_designated_initializer));
		[Export ("initWithPKContact:")]
		[DesignatedInitializer]
		NativeHandle Constructor (PKContact contact);

		// -(PKContact * _Nonnull)PKContactValue __attribute__((warn_unused_result("")));
		[Export ("PKContactValue")]
		PKContact PKContactValue { get; }

		// -(instancetype _Nonnull)initWithCNContact:(CNContact * _Nonnull)contact __attribute__((objc_designated_initializer));
		[Export ("initWithCNContact:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CNContact contact);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }
	}

	// @interface StripePayments_Swift_708 (STPAddress) <STPAPIResponseDecodable>
	partial interface STPAddress : STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPAddress DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface StripePayments_Swift_713 (STPAddress) <NSCopying>
	partial interface STPAddress : INSCopying
	{
		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @protocol STPFormEncodable <NSObject>
	/*
	Check whether adding [Model] to this declaration is appropriate.
	[Model] is used to generate a C# class that implements this protocol,
	and might be useful for protocols that consumers are supposed to implement,
	since consumers can subclass the generated class instead of implementing
	the generated interface. If consumers are not supposed to implement this
	protocol, then [Model] is redundant and will generate code that will never
	be used.
*/	
	[Protocol (Name = "_TtP14StripePayments16STPFormEncodable_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP14StripePayments16STPFormEncodable_")]
	interface STPFormEncodable
	{
		// @required +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static, Abstract]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// @required +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static, Abstract]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// @required @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Abstract]
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }
	}

	// @interface StripePayments_Swift_735 (STPAddress) <STPFormEncodable>
	partial interface STPAddress : STPFormEncodable
	{
		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @protocol STPAuthenticationContext <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ISTPAuthenticationContext { }


    [Protocol (Name = "_TtP14StripePayments24STPAuthenticationContext_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP14StripePayments24STPAuthenticationContext_")]
	interface STPAuthenticationContext
	{
		// @required -(UIViewController * _Nonnull)authenticationPresentingViewController __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("authenticationPresentingViewController")]
		UIViewController AuthenticationPresentingViewController { get; }

		// @optional -(void)prepareAuthenticationContextForPresentation:(void (^ _Nonnull)(void))completion;
		[Export ("prepareAuthenticationContextForPresentation:")]
		void PrepareAuthenticationContextForPresentation (Action completion);

		// @optional -(void)configureSafariViewController:(SFSafariViewController * _Nonnull)viewController;
		[Export ("configureSafariViewController:")]
		void ConfigureSafariViewController (SFSafariViewController viewController);

		// @optional -(void)authenticationContextWillDismissViewController:(UIViewController * _Nonnull)viewController;
		[Export ("authenticationContextWillDismissViewController:")]
		void AuthenticationContextWillDismissViewController (UIViewController viewController);
	}

	// @protocol STPSourceProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ISTPSourceProtocol { }

    [Protocol (Name = "_TtP14StripePayments17STPSourceProtocol_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP14StripePayments17STPSourceProtocol_")]
	interface STPSourceProtocol
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
		[Abstract]
		[Export ("stripeID")]
		string StripeID { get; }
	}

	// @interface STPBankAccount : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments14STPBankAccount")]
	[DisableDefaultCtor]
	interface STPBankAccount : STPAPIResponseDecodable, STPSourceProtocol
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable routingNumber;
		[NullAllowed, Export ("routingNumber")]
		string RoutingNumber { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currency;
		[NullAllowed, Export ("currency")]
		string Currency { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable bankName;
		[NullAllowed, Export ("bankName")]
		string BankName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable accountHolderName;
		[NullAllowed, Export ("accountHolderName")]
		string AccountHolderName { get; }

		// @property (readonly, nonatomic) enum STPBankAccountHolderType accountHolderType;
		[Export ("accountHolderType")]
		STPBankAccountHolderType AccountHolderType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
		[NullAllowed, Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, nonatomic) enum STPBankAccountStatus status;
		[Export ("status")]
		STPBankAccountStatus Status { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use stripeID (defined in STPSourceProtocol)") NSString * bankAccountId __attribute__((deprecated("Use stripeID (defined in STPSourceProtocol)")));
		[Export ("bankAccountId")]
		string BankAccountId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
		[Export ("stripeID")]
		string StripeID { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// -(BOOL)isEqual:(id _Nullable)bankAccount __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject bankAccount);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPBankAccount DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPBankAccountCollector : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPBankAccountCollector")]
	interface STPBankAccountCollector
	{
		// -(void)collectBankAccountForPaymentWithClientSecret:(NSString * _Nonnull)clientSecret params:(STPCollectBankAccountParams * _Nonnull)params from:(UIViewController * _Nonnull)viewController completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("collectBankAccountForPaymentWithClientSecret:params:from:completion:")]
		void CollectBankAccountForPaymentWithClientSecret (string clientSecret, STPCollectBankAccountParams @params, UIViewController viewController, Action<STPPaymentIntent, NSError> completion);

		// -(void)collectBankAccountForPaymentWithClientSecret:(NSString * _Nonnull)clientSecret returnURL:(NSString * _Nullable)returnURL params:(STPCollectBankAccountParams * _Nonnull)params from:(UIViewController * _Nonnull)viewController completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("collectBankAccountForPaymentWithClientSecret:returnURL:params:from:completion:")]
		void CollectBankAccountForPaymentWithClientSecret (string clientSecret, [NullAllowed] string returnURL, STPCollectBankAccountParams @params, UIViewController viewController, Action<STPPaymentIntent, NSError> completion);

		// -(void)collectBankAccountForSetupWithClientSecret:(NSString * _Nonnull)clientSecret params:(STPCollectBankAccountParams * _Nonnull)params from:(UIViewController * _Nonnull)viewController completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("collectBankAccountForSetupWithClientSecret:params:from:completion:")]
		void CollectBankAccountForSetupWithClientSecret (string clientSecret, STPCollectBankAccountParams @params, UIViewController viewController, Action<STPSetupIntent, NSError> completion);

		// -(void)collectBankAccountForSetupWithClientSecret:(NSString * _Nonnull)clientSecret returnURL:(NSString * _Nullable)returnURL params:(STPCollectBankAccountParams * _Nonnull)params from:(UIViewController * _Nonnull)viewController completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("collectBankAccountForSetupWithClientSecret:returnURL:params:from:completion:")]
		void CollectBankAccountForSetupWithClientSecret (string clientSecret, [NullAllowed] string returnURL, STPCollectBankAccountParams @params, UIViewController viewController, Action<STPSetupIntent, NSError> completion);
	}

	// @interface STPBankAccountParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments20STPBankAccountParams")]
	interface STPBankAccountParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSString * _Nullable accountNumber;
		[NullAllowed, Export ("accountNumber")]
		string AccountNumber { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (copy, nonatomic) NSString * _Nullable routingNumber;
		[NullAllowed, Export ("routingNumber")]
		string RoutingNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable currency;
		[NullAllowed, Export ("currency")]
		string Currency { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountHolderName;
		[NullAllowed, Export ("accountHolderName")]
		string AccountHolderName { get; set; }

		// @property (nonatomic) enum STPBankAccountHolderType accountHolderType;
		[Export ("accountHolderType", ArgumentSemantic.Assign)]
		STPBankAccountHolderType AccountHolderType { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPCard : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments7STPCard")]
	[DisableDefaultCtor]
	interface STPCard : STPAPIResponseDecodable, STPSourceProtocol
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull last4;
		[Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable dynamicLast4;
		[NullAllowed, Export ("dynamicLast4")]
		string DynamicLast4 { get; }

		// @property (readonly, nonatomic) BOOL isApplePayCard;
		[Export ("isApplePayCard")]
		bool IsApplePayCard { get; }

		// @property (readonly, nonatomic) NSInteger expMonth;
		[Export ("expMonth")]
		nint ExpMonth { get; }

		// @property (readonly, nonatomic) NSInteger expYear;
		[Export ("expYear")]
		nint ExpYear { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic, strong) STPAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		STPAddress Address { get; }

		// @property (readonly, nonatomic) enum STPCardBrand brand;
		[Export ("brand")]
		STPCardBrand Brand { get; }

		// @property (readonly, nonatomic) enum STPCardFundingType funding;
		[Export ("funding")]
		STPCardFundingType Funding { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currency;
		[NullAllowed, Export ("currency")]
		string Currency { get; }

		// +(NSString * _Nonnull)stringFromBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stringFromBrand:")]
		string StringFromBrand (STPCardBrand brand);

		// +(enum STPCardBrand)brandFromString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export ("brandFromString:")]
		STPCardBrand BrandFromString (string @string);

		// -(instancetype _Nonnull)initWithID:(NSString * _Nonnull)cardID brand:(enum STPCardBrand)brand last4:(NSString * _Nonnull)last4 expMonth:(NSInteger)expMonth expYear:(NSInteger)expYear funding:(enum STPCardFundingType)funding __attribute__((objc_designated_initializer)) __attribute__((deprecated("You cannot directly instantiate an STPCard. You should only use one that has been returned from an STPAPIClient callback.")));
		[Export ("initWithID:brand:last4:expMonth:expYear:funding:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string cardID, STPCardBrand brand, string last4, nint expMonth, nint expYear, STPCardFundingType funding);

		// +(enum STPCardFundingType)fundingFromString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fundingFromString:")]
		STPCardFundingType FundingFromString (string @string);

		// @property (copy, nonatomic) NSString * _Nonnull stripeID;
		[Export ("stripeID")]
		string StripeID { get; set; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// -(BOOL)isEqual:(id _Nullable)other __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPCard DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using yoursecret key instead.") NSDictionary<NSString *,NSString *> * metadata __attribute__((deprecated("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using yoursecret key instead.")));
		[Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Metadata { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use stripeID (defined in STPSourceProtocol)") NSString * cardId __attribute__((deprecated("Use stripeID (defined in STPSourceProtocol)")));
		[Export ("cardId")]
		string CardId { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.line1") NSString * addressLine1 __attribute__((deprecated("Use address.line1")));
		[Export ("addressLine1")]
		string AddressLine1 { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.line2") NSString * addressLine2 __attribute__((deprecated("Use address.line2")));
		[Export ("addressLine2")]
		string AddressLine2 { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.city") NSString * addressCity __attribute__((deprecated("Use address.city")));
		[Export ("addressCity")]
		string AddressCity { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.state") NSString * addressState __attribute__((deprecated("Use address.state")));
		[Export ("addressState")]
		string AddressState { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.postalCode") NSString * addressZip __attribute__((deprecated("Use address.postalCode")));
		[Export ("addressZip")]
		string AddressZip { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.country") NSString * addressCountry __attribute__((deprecated("Use address.country")));
		[Export ("addressCountry")]
		string AddressCountry { get; }
	}

	// @interface STPCardBrandUtilities : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments21STPCardBrandUtilities")]
	interface STPCardBrandUtilities
	{
		// +(NSString * _Nullable)stringFromCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stringFromCardBrand:")]
		[return: NullAllowed]
		string StringFromCardBrand (STPCardBrand brand);

		// +(NSString * _Nonnull)apiValueFromCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("apiValueFromCardBrand:")]
		string ApiValueFromCardBrand (STPCardBrand brand);
	}

	// @interface STPCardParams : NSObject <NSCopying, STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments13STPCardParams")]
	interface STPCardParams : INSCopying, STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// -(instancetype _Nonnull)initWithPaymentMethodParams:(STPPaymentMethodParams * _Nonnull)paymentMethodParams;
		[Export ("initWithPaymentMethodParams:")]
		NativeHandle Constructor (STPPaymentMethodParams paymentMethodParams);

		// @property (copy, nonatomic) NSString * _Nullable number;
		[NullAllowed, Export ("number")]
		string Number { get; set; }

		// -(NSString * _Nullable)last4 __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (nonatomic) NSUInteger expMonth;
		[Export ("expMonth")]
		nuint ExpMonth { get; set; }

		// @property (nonatomic) NSUInteger expYear;
		[Export ("expYear")]
		nuint ExpYear { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable cvc;
		[NullAllowed, Export ("cvc")]
		string Cvc { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (nonatomic, strong) STPAddress * _Nonnull address;
		[Export ("address", ArgumentSemantic.Strong)]
		STPAddress Address { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable currency;
		[NullAllowed, Export ("currency")]
		string Currency { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable addressLine1;
		[NullAllowed, Export ("addressLine1")]
		string AddressLine1 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable addressLine2;
		[NullAllowed, Export ("addressLine2")]
		string AddressLine2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable addressCity;
		[NullAllowed, Export ("addressCity")]
		string AddressCity { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable addressState;
		[NullAllowed, Export ("addressState")]
		string AddressState { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable addressZip;
		[NullAllowed, Export ("addressZip")]
		string AddressZip { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable addressCountry;
		[NullAllowed, Export ("addressCountry")]
		string AddressCountry { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface STPCardValidator : NSObject
	[BaseType (typeof(NSObject))]
	interface STPCardValidator
	{
		// +(NSString * _Nonnull)sanitizedNumericStringForString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sanitizedNumericStringForString:")]
		string SanitizedNumericStringForString (string @string);

		// +(NSString * _Nonnull)sanitizedPostalStringForString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sanitizedPostalStringForString:")]
		string SanitizedPostalStringForString (string @string);

		// +(BOOL)stringIsNumeric:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stringIsNumeric:")]
		bool StringIsNumeric (string @string);

		// +(enum STPCardValidationState)validationStateForNumber:(NSString * _Nullable)cardNumber validatingCardBrand:(BOOL)validatingCardBrand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("validationStateForNumber:validatingCardBrand:")]
		STPCardValidationState ValidationStateForNumber ([NullAllowed] string cardNumber, bool validatingCardBrand);

		// +(enum STPCardBrand)brandForNumber:(NSString * _Nonnull)cardNumber __attribute__((warn_unused_result("")));
		[Static]
		[Export ("brandForNumber:")]
		STPCardBrand BrandForNumber (string cardNumber);

		// +(NSSet<NSNumber *> * _Nonnull)lengthsForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("lengthsForCardBrand:")]
		NSSet<NSNumber> LengthsForCardBrand (STPCardBrand brand);

		// +(NSInteger)maxLengthForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("maxLengthForCardBrand:")]
		nint MaxLengthForCardBrand (STPCardBrand brand);

		// +(NSInteger)fragmentLengthForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("fragmentLengthForCardBrand:")]
		nint FragmentLengthForCardBrand (STPCardBrand brand);

		// +(enum STPCardValidationState)validationStateForExpirationMonth:(NSString * _Nonnull)expirationMonth __attribute__((warn_unused_result("")));
		[Static]
		[Export ("validationStateForExpirationMonth:")]
		STPCardValidationState ValidationStateForExpirationMonth (string expirationMonth);

		// +(enum STPCardValidationState)validationStateForExpirationYear:(NSString * _Nonnull)expirationYear inMonth:(NSString * _Nonnull)expirationMonth __attribute__((warn_unused_result("")));
		[Static]
		[Export ("validationStateForExpirationYear:inMonth:")]
		STPCardValidationState ValidationStateForExpirationYear (string expirationYear, string expirationMonth);

		// +(NSUInteger)maxCVCLengthForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("maxCVCLengthForCardBrand:")]
		nuint MaxCVCLengthForCardBrand (STPCardBrand brand);

		// +(enum STPCardValidationState)validationStateForCVC:(NSString * _Nonnull)cvc cardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("validationStateForCVC:cardBrand:")]
		STPCardValidationState ValidationStateForCVC (string cvc, STPCardBrand brand);

		// +(enum STPCardValidationState)validationStateForCard:(STPCardParams * _Nonnull)card __attribute__((warn_unused_result("")));
		[Static]
		[Export ("validationStateForCard:")]
		STPCardValidationState ValidationStateForCard (STPCardParams card);
	}

	// @interface STPCollectBankAccountParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments27STPCollectBankAccountParams")]
	[DisableDefaultCtor]
	interface STPCollectBankAccountParams
	{
		// +(STPCollectBankAccountParams * _Nonnull)collectUSBankAccountParamsWithName:(NSString * _Nonnull)name email:(NSString * _Nullable)email __attribute__((warn_unused_result("")));
		[Static]
		[Export ("collectUSBankAccountParamsWithName:email:")]
		STPCollectBankAccountParams CollectUSBankAccountParamsWithName (string name, [NullAllowed] string email);

		// + (STPCollectBankAccountParams * _Nonnull)collectInstantDebitsParamsWithEmail:(NSString * _Nullable)email SWIFT_WARN_UNUSED_RESULT;
		[Static]
		[Export ("collectInstantDebitsParamsWithEmail:")]
		STPCollectBankAccountParams CollectInstantDebitsParamsWithEmail ([NullAllowed] string email);
	}

	// @interface STPConfirmAlipayOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPConfirmAlipayOptions")]
	partial interface STPConfirmAlipayOptions
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull appBundleID;
		[Export ("appBundleID")]
		string AppBundleID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appVersionKey;
		[Export ("appVersionKey")]
		string AppVersionKey { get; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_1389 (STPConfirmAlipayOptions) <STPFormEncodable>
	partial interface STPConfirmAlipayOptions: STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConfirmBLIKOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments21STPConfirmBLIKOptions")]
	[DisableDefaultCtor]
	partial interface STPConfirmBLIKOptions
	{
		// @property (copy, nonatomic) NSString * _Nonnull code;
		[Export ("code")]
		string Code { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(instancetype _Nonnull)initWithCode:(NSString * _Nonnull)code __attribute__((objc_designated_initializer));
		[Export ("initWithCode:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string code);
	}

	// @interface StripePayments_Swift_1414 (STPConfirmBLIKOptions) <STPFormEncodable>
	partial interface STPConfirmBLIKOptions : STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConfirmCardOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments21STPConfirmCardOptions")]
	partial interface STPConfirmCardOptions
	{
		// @property (copy, nonatomic) NSString * _Nullable cvc;
		[NullAllowed, Export ("cvc")]
		string Cvc { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable network;
		[NullAllowed, Export ("network")]
		string Network { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_1437 (STPConfirmCardOptions) <STPFormEncodable>
	partial interface STPConfirmCardOptions : STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConfirmKonbiniOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments24STPConfirmKonbiniOptions")]
	partial interface STPConfirmKonbiniOptions
	{
		// @property (copy, nonatomic) NSString * _Nullable confirmationNumber;
		[NullAllowed, Export ("confirmationNumber")]
		string ConfirmationNumber { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }
	}

	// @interface StripePayments_Swift_1458 (STPConfirmKonbiniOptions) <STPFormEncodable>
	partial interface STPConfirmKonbiniOptions : STPFormEncodable
	{
		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPConfirmPaymentMethodOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments30STPConfirmPaymentMethodOptions")]
	partial interface STPConfirmPaymentMethodOptions
	{
		// @property (nonatomic, strong) STPConfirmCardOptions * _Nullable cardOptions;
		[NullAllowed, Export ("cardOptions", ArgumentSemantic.Strong)]
		STPConfirmCardOptions CardOptions { get; set; }

		// @property (nonatomic, strong) STPConfirmAlipayOptions * _Nullable alipayOptions;
		[NullAllowed, Export ("alipayOptions", ArgumentSemantic.Strong)]
		STPConfirmAlipayOptions AlipayOptions { get; set; }

		// @property (nonatomic, strong) STPConfirmBLIKOptions * _Nullable blikOptions;
		[NullAllowed, Export ("blikOptions", ArgumentSemantic.Strong)]
		STPConfirmBLIKOptions BlikOptions { get; set; }

		// @property (nonatomic, strong) STPConfirmWeChatPayOptions * _Nullable weChatPayOptions;
		[NullAllowed, Export ("weChatPayOptions", ArgumentSemantic.Strong)]
		STPConfirmWeChatPayOptions WeChatPayOptions { get; set; }

		// @property (nonatomic, strong) STPConfirmUSBankAccountOptions * _Nullable usBankAccountOptions;
		[NullAllowed, Export ("usBankAccountOptions", ArgumentSemantic.Strong)]
		STPConfirmUSBankAccountOptions UsBankAccountOptions { get; set; }

		// @property (nonatomic, strong) STPConfirmKonbiniOptions * _Nullable konbiniOptions;
		[NullAllowed, Export ("konbiniOptions", ArgumentSemantic.Strong)]
		STPConfirmKonbiniOptions KonbiniOptions { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_1493 (STPConfirmPaymentMethodOptions) <STPFormEncodable>
	partial interface STPConfirmPaymentMethodOptions : STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConfirmUSBankAccountOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments30STPConfirmUSBankAccountOptions")]
	[DisableDefaultCtor]
	partial interface STPConfirmUSBankAccountOptions
	{
		// -(instancetype _Nonnull)initWithSetupFutureUsage:(enum STPPaymentIntentSetupFutureUsage)setupFutureUsage __attribute__((objc_designated_initializer));
		[Export ("initWithSetupFutureUsage:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPPaymentIntentSetupFutureUsage setupFutureUsage);

		// @property (nonatomic) enum STPPaymentIntentSetupFutureUsage setupFutureUsage;
		[Export ("setupFutureUsage", ArgumentSemantic.Assign)]
		STPPaymentIntentSetupFutureUsage SetupFutureUsage { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }
	}

	// @interface StripePayments_Swift_1522 (STPConfirmUSBankAccountOptions) <STPFormEncodable>
	partial interface STPConfirmUSBankAccountOptions: STPFormEncodable
	{
		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPConfirmWeChatPayOptions : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPConfirmWeChatPayOptions")]
	[DisableDefaultCtor]
	partial interface STPConfirmWeChatPayOptions
	{
		// @property (copy, nonatomic) NSString * _Nullable appId;
		[NullAllowed, Export ("appId")]
		string AppId { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(instancetype _Nonnull)initWithAppId:(NSString * _Nonnull)appId __attribute__((objc_designated_initializer));
		[Export ("initWithAppId:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string appId);
	}

	// @interface StripePayments_Swift_1549 (STPConfirmWeChatPayOptions) <STPFormEncodable>
	partial interface STPConfirmWeChatPayOptions: STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConnectAccountAddress : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments24STPConnectAccountAddress")]
	partial interface STPConnectAccountAddress
	{
		// @property (copy, nonatomic) NSString * _Nullable city;
		[NullAllowed, Export ("city")]
		string City { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable line1;
		[NullAllowed, Export ("line1")]
		string Line1 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable line2;
		[NullAllowed, Export ("line2")]
		string Line2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable state;
		[NullAllowed, Export ("state")]
		string State { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable town;
		[NullAllowed, Export ("town")]
		string Town { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_1587 (STPConnectAccountAddress) <STPFormEncodable>
	partial interface STPConnectAccountAddress: STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConnectAccountCompanyParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments30STPConnectAccountCompanyParams")]
	partial interface STPConnectAccountCompanyParams
	{
		// @property (nonatomic, strong) STPConnectAccountAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		STPConnectAccountAddress Address { get; set; }

		// @property (nonatomic, strong) STPConnectAccountAddress * _Nullable kanaAddress;
		[NullAllowed, Export ("kanaAddress", ArgumentSemantic.Strong)]
		STPConnectAccountAddress KanaAddress { get; set; }

		// @property (nonatomic, strong) STPConnectAccountAddress * _Nullable kanjiAddress;
		[NullAllowed, Export ("kanjiAddress", ArgumentSemantic.Strong)]
		STPConnectAccountAddress KanjiAddress { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable directorsProvided;
		[NullAllowed, Export ("directorsProvided", ArgumentSemantic.Strong)]
		NSNumber DirectorsProvided { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable kanaName;
		[NullAllowed, Export ("kanaName")]
		string KanaName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable kanjiName;
		[NullAllowed, Export ("kanjiName")]
		string KanjiName { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable ownersProvided;
		[NullAllowed, Export ("ownersProvided", ArgumentSemantic.Strong)]
		NSNumber OwnersProvided { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable taxID;
		[NullAllowed, Export ("taxID")]
		string TaxID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable taxIDRegistrar;
		[NullAllowed, Export ("taxIDRegistrar")]
		string TaxIDRegistrar { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable vatID;
		[NullAllowed, Export ("vatID")]
		string VatID { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_1647 (STPConnectAccountCompanyParams) <STPFormEncodable>
	partial interface STPConnectAccountCompanyParam  : STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConnectAccountIndividualParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments33STPConnectAccountIndividualParams")]
	partial interface STPConnectAccountIndividualParams
	{
		// @property (nonatomic, strong) STPConnectAccountAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		STPConnectAccountAddress Address { get; set; }

		// @property (nonatomic, strong) STPConnectAccountAddress * _Nullable kanaAddress;
		[NullAllowed, Export ("kanaAddress", ArgumentSemantic.Strong)]
		STPConnectAccountAddress KanaAddress { get; set; }

		// @property (nonatomic, strong) STPConnectAccountAddress * _Nullable kanjiAddress;
		[NullAllowed, Export ("kanjiAddress", ArgumentSemantic.Strong)]
		STPConnectAccountAddress KanjiAddress { get; set; }

		// @property (copy, nonatomic) NSDateComponents * _Nullable dateOfBirth;
		[NullAllowed, Export ("dateOfBirth", ArgumentSemantic.Copy)]
		NSDateComponents DateOfBirth { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable firstName;
		[NullAllowed, Export ("firstName")]
		string FirstName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable kanaFirstName;
		[NullAllowed, Export ("kanaFirstName")]
		string KanaFirstName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable kanjiFirstName;
		[NullAllowed, Export ("kanjiFirstName")]
		string KanjiFirstName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable gender;
		[NullAllowed, Export ("gender")]
		string Gender { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable idNumber;
		[NullAllowed, Export ("idNumber")]
		string IdNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable lastName;
		[NullAllowed, Export ("lastName")]
		string LastName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable kanaLastName;
		[NullAllowed, Export ("kanaLastName")]
		string KanaLastName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable kanjiLastName;
		[NullAllowed, Export ("kanjiLastName")]
		string KanjiLastName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable maidenName;
		[NullAllowed, Export ("maidenName")]
		string MaidenName { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable ssnLast4;
		[NullAllowed, Export ("ssnLast4")]
		string SsnLast4 { get; set; }

		// @property (nonatomic, strong) STPConnectAccountIndividualVerification * _Nullable verification;
		[NullAllowed, Export ("verification", ArgumentSemantic.Strong)]
		STPConnectAccountIndividualVerification Verification { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_1709 (STPConnectAccountIndividualParams) <STPFormEncodable>
	partial interface STPConnectAccountIndividualParams : STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConnectAccountIndividualVerification : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments39STPConnectAccountIndividualVerification")]
	partial interface STPConnectAccountIndividualVerification
	{
		// @property (nonatomic, strong) STPConnectAccountVerificationDocument * _Nullable document;
		[NullAllowed, Export ("document", ArgumentSemantic.Strong)]
		STPConnectAccountVerificationDocument Document { get; set; }

		// @property (nonatomic, strong) STPConnectAccountVerificationDocument * _Nullable additionalDocument;
		[NullAllowed, Export ("additionalDocument", ArgumentSemantic.Strong)]
		STPConnectAccountVerificationDocument AdditionalDocument { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }
	}

	// @interface StripePayments_Swift_1728 (STPConnectAccountIndividualVerification) <STPFormEncodable>
	partial interface STPConnectAccountIndividualVerification : STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPConnectAccountParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPConnectAccountParams")]
	partial interface STPConnectAccountParams
	{
		// @property (nonatomic, strong) NSNumber * _Nullable tosShownAndAccepted;
		[NullAllowed, Export ("tosShownAndAccepted", ArgumentSemantic.Strong)]
		NSNumber TosShownAndAccepted { get; set; }

		// @property (nonatomic) enum STPConnectAccountBusinessType businessType;
		[Export ("businessType", ArgumentSemantic.Assign)]
		STPConnectAccountBusinessType BusinessType { get; set; }

		// @property (nonatomic, strong) STPConnectAccountIndividualParams * _Nullable individual;
		[NullAllowed, Export ("individual", ArgumentSemantic.Strong)]
		STPConnectAccountIndividualParams Individual { get; set; }

		// @property (nonatomic, strong) STPConnectAccountCompanyParams * _Nullable company;
		[NullAllowed, Export ("company", ArgumentSemantic.Strong)]
		STPConnectAccountCompanyParams Company { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// -(instancetype _Nullable)initWithTosShownAndAccepted:(BOOL)wasAccepted individual:(STPConnectAccountIndividualParams * _Nonnull)individual __attribute__((objc_designated_initializer));
		[Export ("initWithTosShownAndAccepted:individual:")]
		[DesignatedInitializer]
		NativeHandle Constructor (bool wasAccepted, STPConnectAccountIndividualParams individual);

		// -(instancetype _Nullable)initWithTosShownAndAccepted:(BOOL)wasAccepted company:(STPConnectAccountCompanyParams * _Nonnull)company __attribute__((objc_designated_initializer));
		[Export ("initWithTosShownAndAccepted:company:")]
		[DesignatedInitializer]
		NativeHandle Constructor (bool wasAccepted, STPConnectAccountCompanyParams company);

		// -(instancetype _Nonnull)initWithIndividual:(STPConnectAccountIndividualParams * _Nonnull)individual __attribute__((objc_designated_initializer));
		[Export ("initWithIndividual:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPConnectAccountIndividualParams individual);

		// -(instancetype _Nonnull)initWithCompany:(STPConnectAccountCompanyParams * _Nonnull)company __attribute__((objc_designated_initializer));
		[Export ("initWithCompany:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPConnectAccountCompanyParams company);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_1785 (STPConnectAccountParams) <STPFormEncodable>
	partial interface STPConnectAccountParams: STPFormEncodable
	{
		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPConnectAccountVerificationDocument : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments37STPConnectAccountVerificationDocument")]
	partial interface STPConnectAccountVerificationDocument
	{
		// @property (copy, nonatomic) NSString * _Nullable back;
		[NullAllowed, Export ("back")]
		string Back { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable front;
		[NullAllowed, Export ("front")]
		string Front { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }
	}

	// @interface StripePayments_Swift_1807 (STPConnectAccountVerificationDocument) <STPFormEncodable>
	partial interface STPConnectAccountVerificationDocument: STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPContactField : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments15STPContactField")]
	[DisableDefaultCtor]
	interface STPContactField
	{
		// @property (readonly, nonatomic, strong, class) STPContactField * _Nonnull postalAddress;
		[Static]
		[Export ("postalAddress", ArgumentSemantic.Strong)]
		STPContactField PostalAddress { get; }

		// @property (readonly, nonatomic, strong, class) STPContactField * _Nonnull emailAddress;
		[Static]
		[Export ("emailAddress", ArgumentSemantic.Strong)]
		STPContactField EmailAddress { get; }

		// @property (readonly, nonatomic, strong, class) STPContactField * _Nonnull phoneNumber;
		[Static]
		[Export ("phoneNumber", ArgumentSemantic.Strong)]
		STPContactField PhoneNumber { get; }

		// @property (readonly, nonatomic, strong, class) STPContactField * _Nonnull name;
		[Static]
		[Export ("name", ArgumentSemantic.Strong)]
		STPContactField Name { get; }
	}

	// @interface STPCustomer : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments11STPCustomer")]
	[DisableDefaultCtor]
	partial interface STPCustomer
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
		[Export ("stripeID")]
		string StripeID { get; }

		// @property (readonly, nonatomic, strong) id<STPSourceProtocol> _Nullable defaultSource;
		[NullAllowed, Export ("defaultSource", ArgumentSemantic.Strong)]
		ISTPSourceProtocol DefaultSource { get; }

		// @property (readonly, copy, nonatomic) NSArray<id<STPSourceProtocol>> * _Nonnull sources;
		[Export ("sources", ArgumentSemantic.Copy)]
		ISTPSourceProtocol[] Sources { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

		// @property (nonatomic, strong) STPAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		STPAddress ShippingAddress { get; set; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// -(instancetype _Nonnull)initWithStripeID:(NSString * _Nonnull)stripeID defaultSource:(id<STPSourceProtocol> _Nullable)defaultSource sources:(NSArray<id<STPSourceProtocol>> * _Nonnull)sources;
		[Export ("initWithStripeID:defaultSource:sources:")]
		NativeHandle Constructor (string stripeID, [NullAllowed] ISTPSourceProtocol defaultSource, ISTPSourceProtocol[] sources);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(void)updateSourcesFilteringApplePay:(BOOL)filteringApplePay;
		[Export ("updateSourcesFilteringApplePay:")]
		void UpdateSourcesFilteringApplePay (bool filteringApplePay);
	}

	// @interface StripePayments_Swift_1872 (STPCustomer) <STPAPIResponseDecodable>
	partial interface STPCustomer : STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPCustomer DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPCustomerDeserializer : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPCustomerDeserializer")]
	[DisableDefaultCtor]
	interface STPCustomerDeserializer
	{
		// @property (readonly, nonatomic, strong) STPCustomer * _Nullable customer;
		[NullAllowed, Export ("customer", ArgumentSemantic.Strong)]
		STPCustomer Customer { get; }

		// @property (readonly, nonatomic) NSError * _Nullable error;
		[NullAllowed, Export ("error")]
		NSError Error { get; }

		// -(instancetype _Nonnull)initWithData:(NSData * _Nullable)data urlResponse:(NSURLResponse * _Nullable)urlResponse error:(NSError * _Nullable)error;
		[Export ("initWithData:urlResponse:error:")]
		NativeHandle Constructor ([NullAllowed] NSData data, [NullAllowed] NSUrlResponse urlResponse, [NullAllowed] NSError error);

		// -(instancetype _Nonnull)initWithJsonResponse:(id _Nullable)json;
		[Export ("initWithJsonResponse:")]
		NativeHandle Constructor ([NullAllowed] NSObject json);
	}

	// @interface STPDateOfBirth : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments14STPDateOfBirth")]
	partial interface STPDateOfBirth
	{
		// @property (nonatomic) NSInteger day;
		[Export ("day")]
		nint Day { get; set; }

		// @property (nonatomic) NSInteger month;
		[Export ("month")]
		nint Month { get; set; }

		// @property (nonatomic) NSInteger year;
		[Export ("year")]
		nint Year { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }
	}

	// @interface StripePayments_Swift_1926 (STPDateOfBirth) <STPFormEncodable>
	partial interface STPDateOfBirth: STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPEmptyStripeResponse : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPEmptyStripeResponse")]
	[DisableDefaultCtor]
	interface STPEmptyStripeResponse : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPEmptyStripeResponse DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPFPXBank : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments10STPFPXBank")]
	interface STPFPXBank
	{
		// +(NSString * _Nullable)stringFrom:(enum STPFPXBankBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stringFrom:")]
		[return: NullAllowed]
		string StringFrom (STPFPXBankBrand brand);

		// +(enum STPFPXBankBrand)brandFrom:(NSString * _Nullable)identifier __attribute__((warn_unused_result("")));
		[Static]
		[Export ("brandFrom:")]
		STPFPXBankBrand BrandFrom ([NullAllowed] string identifier);

		// +(NSString * _Nullable)identifierFrom:(enum STPFPXBankBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("identifierFrom:")]
		[return: NullAllowed]
		string IdentifierFrom (STPFPXBankBrand brand);

		// +(NSString * _Nullable)bankCodeFrom:(enum STPFPXBankBrand)brand :(BOOL)isBusiness __attribute__((warn_unused_result("")));
		[Static]
		[Export ("bankCodeFrom::")]
		[return: NullAllowed]
		string BankCodeFrom (STPFPXBankBrand brand, bool isBusiness);
	}

	// @interface STPFile : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments7STPFile")]
	[DisableDefaultCtor]
	interface STPFile : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable fileId;
		[NullAllowed, Export ("fileId")]
		string FileId { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable created;
		[NullAllowed, Export ("created", ArgumentSemantic.Copy)]
		NSDate Created { get; }

		// @property (readonly, nonatomic) enum STPFilePurpose purpose;
		[Export ("purpose")]
		STPFilePurpose Purpose { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable size;
		[NullAllowed, Export ("size", ArgumentSemantic.Strong)]
		NSNumber Size { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable type;
		[NullAllowed, Export ("type")]
		string Type { get; }

		// +(NSString * _Nullable)stringFromPurpose:(enum STPFilePurpose)purpose __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stringFromPurpose:")]
		[return: NullAllowed]
		string StringFromPurpose (STPFilePurpose purpose);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPFile DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPFormEncoder : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments14STPFormEncoder")]
	interface STPFormEncoder
	{
		// +(NSDictionary<NSString *,id> * _Nonnull)dictionaryForObject:(NSObject<STPFormEncodable> * _Nonnull)object __attribute__((warn_unused_result("")));
		[Static]
		[Export ("dictionaryForObject:")]
		NSDictionary<NSString, NSObject> DictionaryForObject (STPFormEncodable @object);
	}

	// @interface STPIntentAction : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments15STPIntentAction")]
	[DisableDefaultCtor]
	partial interface STPIntentAction
	{
		// @property (readonly, nonatomic) enum STPIntentActionType type;
		[Export ("type")]
		STPIntentActionType Type { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionRedirectToURL * _Nullable redirectToURL;
		[NullAllowed, Export ("redirectToURL", ArgumentSemantic.Strong)]
		STPIntentActionRedirectToURL RedirectToURL { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionOXXODisplayDetails * _Nullable oxxoDisplayDetails;
		[NullAllowed, Export ("oxxoDisplayDetails", ArgumentSemantic.Strong)]
		STPIntentActionOXXODisplayDetails OxxoDisplayDetails { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionAlipayHandleRedirect * _Nullable alipayHandleRedirect;
		[NullAllowed, Export ("alipayHandleRedirect", ArgumentSemantic.Strong)]
		STPIntentActionAlipayHandleRedirect AlipayHandleRedirect { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionWechatPayRedirectToApp * _Nullable weChatPayRedirectToApp;
		[NullAllowed, Export ("weChatPayRedirectToApp", ArgumentSemantic.Strong)]
		STPIntentActionWechatPayRedirectToApp WeChatPayRedirectToApp { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionBoletoDisplayDetails * _Nullable boletoDisplayDetails;
		[NullAllowed, Export ("boletoDisplayDetails", ArgumentSemantic.Strong)]
		STPIntentActionBoletoDisplayDetails BoletoDisplayDetails { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionVerifyWithMicrodeposits * _Nullable verifyWithMicrodeposits;
		[NullAllowed, Export ("verifyWithMicrodeposits", ArgumentSemantic.Strong)]
		STPIntentActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionCashAppRedirectToApp * _Nullable cashAppRedirectToApp;
		[NullAllowed, Export ("cashAppRedirectToApp", ArgumentSemantic.Strong)]
		STPIntentActionCashAppRedirectToApp CashAppRedirectToApp { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionPayNowDisplayQrCode * _Nullable payNowDisplayQrCode;
		[NullAllowed, Export ("payNowDisplayQrCode", ArgumentSemantic.Strong)]
		STPIntentActionPayNowDisplayQrCode PayNowDisplayQrCode { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionKonbiniDisplayDetails * _Nullable konbiniDisplayDetails;
		[NullAllowed, Export ("konbiniDisplayDetails", ArgumentSemantic.Strong)]
		STPIntentActionKonbiniDisplayDetails KonbiniDisplayDetails { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionPromptPayDisplayQrCode * _Nullable promptPayDisplayQrCode;
		[NullAllowed, Export ("promptPayDisplayQrCode", ArgumentSemantic.Strong)]
		STPIntentActionPromptPayDisplayQrCode PromptPayDisplayQrCode { get; }

		// @property (readonly, nonatomic, strong) STPIntentActionSwishHandleRedirect * _Nullable swishHandleRedirect;
		[NullAllowed, Export ("swishHandleRedirect", ArgumentSemantic.Strong)]
		STPIntentActionSwishHandleRedirect SwishHandleRedirect { get; }

		// @property (nonatomic, readonly, strong) STPIntentActionMultibancoDisplayDetails * _Nullable multibancoDisplayDetails;
		[NullAllowed, Export ("multibancoDisplayDetails", ArgumentSemantic.Strong)]
		STPIntentActionMultibancoDisplayDetails MultibancoDisplayDetails { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2131 (STPIntentAction) <STPAPIResponseDecodable>
	partial interface STPIntentAction : STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentAction DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface StripePayments_Swift_2136 (STPIntentAction)
	partial interface STPIntentAction
	{
		// @property (readonly, nonatomic, strong) SWIFT_DEPRECATED_MSG("Use `redirectToURL` instead.", "redirectToURL") STPIntentActionRedirectToURL * authorizeWithURL __attribute__((deprecated("Use `redirectToURL` instead.", "redirectToURL")));
		[Export ("authorizeWithURL", ArgumentSemantic.Strong)]
		STPIntentActionRedirectToURL AuthorizeWithURL { get; }
	}

	// @interface STPIntentActionAlipayHandleRedirect : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments35STPIntentActionAlipayHandleRedirect")]
	[DisableDefaultCtor]
	partial interface STPIntentActionAlipayHandleRedirect
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nullable nativeURL;
		[NullAllowed, Export ("nativeURL", ArgumentSemantic.Copy)]
		NSUrl NativeURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull returnURL;
		[Export ("returnURL", ArgumentSemantic.Copy)]
		NSUrl ReturnURL { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2163 (STPIntentActionAlipayHandleRedirect) <STPAPIResponseDecodable>
	partial interface STPIntentActionAlipayHandleRedirect: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionAlipayHandleRedirect DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIntentActionBoletoDisplayDetails : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments35STPIntentActionBoletoDisplayDetails")]
	[DisableDefaultCtor]
	interface STPIntentActionBoletoDisplayDetails : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull number;
		[Export ("number")]
		string Number { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull expiresAt;
		[Export ("expiresAt", ArgumentSemantic.Copy)]
		NSDate ExpiresAt { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull hostedVoucherURL;
		[Export ("hostedVoucherURL", ArgumentSemantic.Copy)]
		NSUrl HostedVoucherURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionBoletoDisplayDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIntentActionCashAppRedirectToApp : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments35STPIntentActionCashAppRedirectToApp")]
	[DisableDefaultCtor]
	partial interface STPIntentActionCashAppRedirectToApp
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nullable mobileAuthURL;
		[NullAllowed, Export ("mobileAuthURL", ArgumentSemantic.Copy)]
		NSUrl MobileAuthURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2203 (STPIntentActionCashAppRedirectToApp) <STPAPIResponseDecodable>
	partial interface STPIntentActionCashAppRedirectToApp : STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionCashAppRedirectToApp DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// SWIFT_CLASS("_TtC14StripePayments39STPIntentActionMultibancoDisplayDetails")
	// @interface STPIntentActionMultibancoDisplayDetails : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments39STPIntentActionMultibancoDisplayDetails")]
	[DisableDefaultCtor]
	interface STPIntentActionMultibancoDisplayDetails : STPAPIResponseDecodable
	{
		// /// The multibanco entity number
		// @property (nonatomic, readonly, copy) NSString * _Nonnull entity;
		[Export ("entity", ArgumentSemantic.Copy)]
		string Entity { get; }

		// /// Multibanco reference number
		// @property (nonatomic, readonly, copy) NSString * _Nonnull reference;
		[Export ("reference", ArgumentSemantic.Copy)]
		string Reference { get; }

		// /// The expiry date of the multibanco voucher.
		// @property (nonatomic, readonly, copy) NSDate * _Nonnull expiresAt;
		[Export ("expiresAt", ArgumentSemantic.Copy)]
		NSDate ExpiresAt { get; }

		// /// The URL to the hosted multibanco voucher page, which allows customers to view the multibanco voucher.
		// @property (nonatomic, readonly, copy) NSURL * _Nonnull hostedVoucherURL;
		[Export ("hostedVoucherURL", ArgumentSemantic.Copy)]
		NSUrl HostedVoucherURL { get; }

		// /// :nodoc:
		// @property (nonatomic, readonly, copy) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// /// :nodoc:
		// @property (nonatomic, readonly, copy) NSString * _Nonnull description;
		[Export ("description", ArgumentSemantic.Copy)]
		string Description { get; }

		// + (nullable instancetype)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response SWIFT_WARN_UNUSED_RESULT;
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionMultibancoDisplayDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIntentActionKonbiniDisplayDetails : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments36STPIntentActionKonbiniDisplayDetails")]
	[DisableDefaultCtor]
	interface STPIntentActionKonbiniDisplayDetails : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDate * _Nonnull expiresAt;
		[Export ("expiresAt", ArgumentSemantic.Copy)]
		NSDate ExpiresAt { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull hostedVoucherURL;
		[Export ("hostedVoucherURL", ArgumentSemantic.Copy)]
		NSUrl HostedVoucherURL { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionKonbiniDisplayDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }
	}

	// @interface STPIntentActionOXXODisplayDetails : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments33STPIntentActionOXXODisplayDetails")]
	[DisableDefaultCtor]
	interface STPIntentActionOXXODisplayDetails : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDate * _Nonnull expiresAfter;
		[Export ("expiresAfter", ArgumentSemantic.Copy)]
		NSDate ExpiresAfter { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull hostedVoucherURL;
		[Export ("hostedVoucherURL", ArgumentSemantic.Copy)]
		NSUrl HostedVoucherURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull number;
		[Export ("number")]
		string Number { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionOXXODisplayDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }
	}

	// @interface STPIntentActionPayNowDisplayQrCode : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments34STPIntentActionPayNowDisplayQrCode")]
	[DisableDefaultCtor]
	partial interface STPIntentActionPayNowDisplayQrCode
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nullable hostedInstructionsURL;
		[NullAllowed, Export ("hostedInstructionsURL", ArgumentSemantic.Copy)]
		NSUrl HostedInstructionsURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2255 (STPIntentActionPayNowDisplayQrCode) <STPAPIResponseDecodable>
	partial interface STPIntentActionPayNowDisplayQrCode: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionPayNowDisplayQrCode DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIntentActionPromptPayDisplayQrCode : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments37STPIntentActionPromptPayDisplayQrCode")]
	[DisableDefaultCtor]
	partial interface STPIntentActionPromptPayDisplayQrCode
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nullable hostedInstructionsURL;
		[NullAllowed, Export ("hostedInstructionsURL", ArgumentSemantic.Copy)]
		NSUrl HostedInstructionsURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2275 (STPIntentActionPromptPayDisplayQrCode) <STPAPIResponseDecodable>
	partial interface STPIntentActionPromptPayDisplayQrCode: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionPromptPayDisplayQrCode DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIntentActionRedirectToURL : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPIntentActionRedirectToURL")]
	[DisableDefaultCtor]
	partial interface STPIntentActionRedirectToURL
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable returnURL;
		[NullAllowed, Export ("returnURL", ArgumentSemantic.Copy)]
		NSUrl ReturnURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2299 (STPIntentActionRedirectToURL) <STPAPIResponseDecodable>
	partial interface STPIntentActionRedirectToURL: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionRedirectToURL DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIntentActionSwishHandleRedirect : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments34STPIntentActionSwishHandleRedirect")]
	[DisableDefaultCtor]
	partial interface STPIntentActionSwishHandleRedirect
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull mobileAuthURL;
		[Export ("mobileAuthURL", ArgumentSemantic.Copy)]
		NSUrl MobileAuthURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2319 (STPIntentActionSwishHandleRedirect) <STPAPIResponseDecodable>
	partial interface STPIntentActionSwishHandleRedirect: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionSwishHandleRedirect DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIntentActionVerifyWithMicrodeposits : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments38STPIntentActionVerifyWithMicrodeposits")]
	[DisableDefaultCtor]
	partial interface STPIntentActionVerifyWithMicrodeposits
	{
		// @property (readonly, copy, nonatomic) NSDate * _Nonnull arrivalDate;
		[Export ("arrivalDate", ArgumentSemantic.Copy)]
		NSDate ArrivalDate { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull hostedVerificationURL;
		[Export ("hostedVerificationURL", ArgumentSemantic.Copy)]
		NSUrl HostedVerificationURL { get; }

		// @property (readonly, nonatomic) enum STPMicrodepositType microdepositType;
		[Export ("microdepositType")]
		STPMicrodepositType MicrodepositType { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }
	}

	// @interface StripePayments_Swift_2381 (STPIntentActionVerifyWithMicrodeposits) <STPAPIResponseDecodable>
	partial interface STPIntentActionVerifyWithMicrodeposits: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionVerifyWithMicrodeposits DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIntentActionWechatPayRedirectToApp : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments37STPIntentActionWechatPayRedirectToApp")]
	[DisableDefaultCtor]
	partial interface STPIntentActionWechatPayRedirectToApp
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nullable nativeURL;
		[NullAllowed, Export ("nativeURL", ArgumentSemantic.Copy)]
		NSUrl NativeURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2401 (STPIntentActionWechatPayRedirectToApp) <STPAPIResponseDecodable>
	partial interface STPIntentActionWechatPayRedirectToApp: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIntentActionWechatPayRedirectToApp DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPIssuingCardPin : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments17STPIssuingCardPin")]
	[DisableDefaultCtor]
	partial interface STPIssuingCardPin
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable pin;
		[NullAllowed, Export ("pin")]
		string Pin { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Copy)]
		NSDictionary Error { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }
	}

	// @interface StripePayments_Swift_2419 (STPIssuingCardPin) <STPAPIResponseDecodable>
	partial interface STPIssuingCardPin: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPIssuingCardPin DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPKlarnaLineItem : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments17STPKlarnaLineItem")]
	[DisableDefaultCtor]
	interface STPKlarnaLineItem
	{
		// @property (nonatomic) enum STPKlarnaLineItemType itemType;
		[Export ("itemType", ArgumentSemantic.Assign)]
		STPKlarnaLineItemType ItemType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull itemDescription;
		[Export ("itemDescription")]
		string ItemDescription { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull quantity;
		[Export ("quantity", ArgumentSemantic.Strong)]
		NSNumber Quantity { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull totalAmount;
		[Export ("totalAmount", ArgumentSemantic.Strong)]
		NSNumber TotalAmount { get; set; }

		// -(instancetype _Nonnull)initWithItemType:(enum STPKlarnaLineItemType)itemType itemDescription:(NSString * _Nonnull)itemDescription quantity:(NSNumber * _Nonnull)quantity totalAmount:(NSNumber * _Nonnull)totalAmount __attribute__((objc_designated_initializer));
		[Export ("initWithItemType:itemDescription:quantity:totalAmount:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPKlarnaLineItemType itemType, string itemDescription, NSNumber quantity, NSNumber totalAmount);
	}

	// @interface STPMandateCustomerAcceptanceParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments34STPMandateCustomerAcceptanceParams")]
	interface STPMandateCustomerAcceptanceParams : STPFormEncodable
	{
		// @property (nonatomic) enum STPMandateCustomerAcceptanceType type;
		[Export ("type", ArgumentSemantic.Assign)]
		STPMandateCustomerAcceptanceType Type { get; set; }

		// @property (nonatomic, strong) STPMandateOnlineParams * _Nullable onlineParams;
		[NullAllowed, Export ("onlineParams", ArgumentSemantic.Strong)]
		STPMandateOnlineParams OnlineParams { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPMandateDataParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments20STPMandateDataParams")]
	[DisableDefaultCtor]
	partial interface STPMandateDataParams
	{
		// @property (readonly, nonatomic, strong) STPMandateCustomerAcceptanceParams * _Nonnull customerAcceptance;
		[Export ("customerAcceptance", ArgumentSemantic.Strong)]
		STPMandateCustomerAcceptanceParams CustomerAcceptance { get; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// -(instancetype _Nonnull)initWithCustomerAcceptance:(STPMandateCustomerAcceptanceParams * _Nonnull)customerAcceptance __attribute__((objc_designated_initializer));
		[Export ("initWithCustomerAcceptance:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPMandateCustomerAcceptanceParams customerAcceptance);
	}

	// @interface StripePayments_Swift_2519 (STPMandateDataParams) <STPFormEncodable>
	partial interface STPMandateDataParams : STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPMandateOnlineParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPMandateOnlineParams")]
	[DisableDefaultCtor]
	partial interface STPMandateOnlineParams
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull ipAddress;
		[Export ("ipAddress")]
		string IpAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull userAgent;
		[Export ("userAgent")]
		string UserAgent { get; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable inferFromClient;
		[NullAllowed, Export ("inferFromClient", ArgumentSemantic.Strong)]
		NSNumber InferFromClient { get; set; }

		// -(instancetype _Nonnull)initWithIPAddress:(NSString * _Nonnull)ipAddress userAgent:(NSString * _Nonnull)userAgent __attribute__((objc_designated_initializer));
		[Export ("initWithIPAddress:userAgent:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string ipAddress, string userAgent);
	}

	// @interface StripePayments_Swift_2548 (STPMandateOnlineParams) <STPFormEncodable>
	partial interface STPMandateOnlineParams : STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPPaymentHandler : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments17STPPaymentHandler")]
	[DisableDefaultCtor]
	partial interface STPPaymentHandler
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull errorDomain;
		[Static]
		[Export ("errorDomain")]
		string ErrorDomain { get; }

		// @property (readonly, nonatomic, strong, class) STPPaymentHandler * _Nonnull sharedHandler;
		[Static]
		[Export ("sharedHandler", ArgumentSemantic.Strong)]
		STPPaymentHandler SharedHandler { get; }

		// +(STPPaymentHandler * _Nonnull)shared __attribute__((warn_unused_result("")));
		[Static]
		[Export ("shared")]
		STPPaymentHandler Shared { get; }

		// @property (nonatomic, strong) int * _Nonnull apiClient;
		[Export ("apiClient", ArgumentSemantic.Strong)]
		unsafe STPAPIClient ApiClient { get; set; }

		// @property (nonatomic, strong) STPThreeDSCustomizationSettings * _Nonnull threeDSCustomizationSettings;
		[Export ("threeDSCustomizationSettings", ArgumentSemantic.Strong)]
		STPThreeDSCustomizationSettings ThreeDSCustomizationSettings { get; set; }

		// @property (nonatomic) BOOL simulateAppToAppRedirect;
		[Export ("simulateAppToAppRedirect")]
		bool SimulateAppToAppRedirect { get; set; }

		// -(void)confirmPayment:(STPPaymentIntentParams * _Nonnull)paymentParams withAuthenticationContext:(id<STPAuthenticationContext> _Nonnull)authenticationContext completion:(void (^ _Nonnull)(enum STPPaymentHandlerActionStatus, STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("confirmPayment:withAuthenticationContext:completion:")]
		void ConfirmPayment (STPPaymentIntentParams paymentParams, ISTPAuthenticationContext authenticationContext, Action<STPPaymentHandlerActionStatus, STPPaymentIntent, NSError> completion);

		// -(void)handleNextActionForPayment:(NSString * _Nonnull)paymentIntentClientSecret withAuthenticationContext:(id<STPAuthenticationContext> _Nonnull)authenticationContext returnURL:(NSString * _Nullable)returnURL completion:(void (^ _Nonnull)(enum STPPaymentHandlerActionStatus, STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("handleNextActionForPayment:withAuthenticationContext:returnURL:completion:")]
		void HandleNextActionForPayment (string paymentIntentClientSecret, ISTPAuthenticationContext authenticationContext, [NullAllowed] string returnURL, Action<STPPaymentHandlerActionStatus, STPPaymentIntent, NSError> completion);

		// -(void)confirmSetupIntent:(STPSetupIntentConfirmParams * _Nonnull)setupIntentConfirmParams withAuthenticationContext:(id<STPAuthenticationContext> _Nonnull)authenticationContext completion:(void (^ _Nonnull)(enum STPPaymentHandlerActionStatus, STPSetupIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("confirmSetupIntent:withAuthenticationContext:completion:")]
		void ConfirmSetupIntent (STPSetupIntentConfirmParams setupIntentConfirmParams, ISTPAuthenticationContext authenticationContext, Action<STPPaymentHandlerActionStatus, STPSetupIntent, NSError> completion);

		// -(void)handleNextActionForSetupIntent:(NSString * _Nonnull)setupIntentClientSecret withAuthenticationContext:(id<STPAuthenticationContext> _Nonnull)authenticationContext returnURL:(NSString * _Nullable)returnURL completion:(void (^ _Nonnull)(enum STPPaymentHandlerActionStatus, STPSetupIntent * _Nullable, NSError * _Nullable))completion;
		[Export ("handleNextActionForSetupIntent:withAuthenticationContext:returnURL:completion:")]
		void HandleNextActionForSetupIntent (string setupIntentClientSecret, ISTPAuthenticationContext authenticationContext, [NullAllowed] string returnURL, Action<STPPaymentHandlerActionStatus, STPSetupIntent, NSError> completion);
	}

	// @interface StripePayments_Swift_2643 (STPPaymentHandler)
	partial interface STPPaymentHandler
	{
		// -(BOOL)handleURLCallback:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("handleURLCallback:")]
		bool HandleURLCallback (NSUrl url);
	}

	// @interface StripePayments_Swift_2649 (STPPaymentHandler) <SFSafariViewControllerDelegate>
	partial interface STPPaymentHandler: ISFSafariViewControllerDelegate
	{
		// -(void)safariViewControllerDidFinish:(SFSafariViewController * _Nonnull)controller;
		[Export ("safariViewControllerDidFinish:")]
		void SafariViewControllerDidFinish (SFSafariViewController controller);
	}

	// @interface STPPaymentHandlerPaymentIntentActionParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments42STPPaymentHandlerPaymentIntentActionParams")]
	[DisableDefaultCtor]
	interface STPPaymentHandlerPaymentIntentActionParams
	{
		// - (ASPresentationAnchor _Nonnull)presentationAnchorForWebAuthenticationSession:(ASWebAuthenticationSession * _Nonnull)session SWIFT_WARN_UNUSED_RESULT;
		[Export ("presentationAnchorForWebAuthenticationSession:")]
        UIWindow PresentationAnchorForWebAuthenticationSession (ASWebAuthenticationSession session);
	}

	// @interface STPPaymentIntent : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments16STPPaymentIntent")]
	[DisableDefaultCtor]
	partial interface STPPaymentIntent
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull stripeId;
		[Export ("stripeId")]
		string StripeId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull clientSecret;
		[Export ("clientSecret")]
		string ClientSecret { get; }

		// @property (readonly, nonatomic) NSInteger amount;
		[Export ("amount")]
		nint Amount { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable canceledAt;
		[NullAllowed, Export ("canceledAt", ArgumentSemantic.Copy)]
		NSDate CanceledAt { get; }

		// @property (readonly, nonatomic) enum STPPaymentIntentCaptureMethod captureMethod;
		[Export ("captureMethod")]
		STPPaymentIntentCaptureMethod CaptureMethod { get; }

		// @property (readonly, nonatomic) enum STPPaymentIntentConfirmationMethod confirmationMethod;
		[Export ("confirmationMethod")]
		STPPaymentIntentConfirmationMethod ConfirmationMethod { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
		[Export ("created", ArgumentSemantic.Copy)]
		NSDate Created { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull currency;
		[Export ("currency")]
		string Currency { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable stripeDescription;
		[NullAllowed, Export ("stripeDescription")]
		string StripeDescription { get; }

		// @property (readonly, nonatomic) BOOL livemode;
		[Export ("livemode")]
		bool Livemode { get; }

		// @property (readonly, nonatomic, strong) STPIntentAction * _Nullable nextAction;
		[NullAllowed, Export ("nextAction", ArgumentSemantic.Strong)]
		STPIntentAction NextAction { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable receiptEmail;
		[NullAllowed, Export ("receiptEmail")]
		string ReceiptEmail { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sourceId;
		[NullAllowed, Export ("sourceId")]
		string SourceId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable paymentMethodId;
		[NullAllowed, Export ("paymentMethodId")]
		string PaymentMethodId { get; }

		// @property (readonly, nonatomic) enum STPPaymentIntentStatus status;
		[Export ("status")]
		STPPaymentIntentStatus Status { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull paymentMethodTypes;
		[Export ("paymentMethodTypes", ArgumentSemantic.Copy)]
		NSNumber[] PaymentMethodTypes { get; }

		// @property (readonly, nonatomic) enum STPPaymentIntentSetupFutureUsage setupFutureUsage;
		[Export ("setupFutureUsage")]
		STPPaymentIntentSetupFutureUsage SetupFutureUsage { get; }

		// @property (readonly, nonatomic, strong) STPPaymentIntentLastPaymentError * _Nullable lastPaymentError;
		[NullAllowed, Export ("lastPaymentError", ArgumentSemantic.Strong)]
		STPPaymentIntentLastPaymentError LastPaymentError { get; }

		// @property (readonly, nonatomic, strong) STPPaymentIntentShippingDetails * _Nullable shipping;
		[NullAllowed, Export ("shipping", ArgumentSemantic.Strong)]
		STPPaymentIntentShippingDetails Shipping { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
		[NullAllowed, Export ("paymentMethod", ArgumentSemantic.Strong)]
		STPPaymentMethod PaymentMethod { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2770 (STPPaymentIntent) <STPAPIResponseDecodable>
	partial interface STPPaymentIntent: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentIntent DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface StripePayments_Swift_2775 (STPPaymentIntent)
	partial interface STPPaymentIntent
	{
		// @property (readonly, nonatomic, strong) SWIFT_DEPRECATED_MSG("Use nextAction instead", "nextAction") STPIntentAction * nextSourceAction __attribute__((deprecated("Use nextAction instead", "nextAction")));
		[Export ("nextSourceAction", ArgumentSemantic.Strong)]
		STPIntentAction NextSourceAction { get; }
	}

	// @interface STPPaymentIntentAction : STPIntentAction
	[BaseType (typeof(STPIntentAction), Name = "_TtC14StripePayments22STPPaymentIntentAction")]
	interface STPPaymentIntentAction
	{
	}

	// @interface STPPaymentIntentLastPaymentError : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPPaymentIntentLastPaymentError")]
	[DisableDefaultCtor]
	partial interface STPPaymentIntentLastPaymentError
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull ErrorCodeAuthenticationFailure;
		[Static]
		[Export ("ErrorCodeAuthenticationFailure")]
		string ErrorCodeAuthenticationFailure { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable code;
		[NullAllowed, Export ("code")]
		string Code { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable declineCode;
		[NullAllowed, Export ("declineCode")]
		string DeclineCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable docURL;
		[NullAllowed, Export ("docURL")]
		string DocURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable message;
		[NullAllowed, Export ("message")]
		string Message { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable param;
		[NullAllowed, Export ("param")]
		string Param { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
		[NullAllowed, Export ("paymentMethod", ArgumentSemantic.Strong)]
		STPPaymentMethod PaymentMethod { get; }

		// @property (readonly, nonatomic) enum STPPaymentIntentLastPaymentErrorType type;
		[Export ("type")]
		STPPaymentIntentLastPaymentErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_2874 (STPPaymentIntentLastPaymentError) <STPAPIResponseDecodable>
	partial interface STPPaymentIntentLastPaymentError: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentIntentLastPaymentError DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentIntentParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPPaymentIntentParams")]
	[DisableDefaultCtor]
	partial interface STPPaymentIntentParams
	{
		// -(instancetype _Nonnull)initWithClientSecret:(NSString * _Nonnull)clientSecret __attribute__((objc_designated_initializer));
		[Export ("initWithClientSecret:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string clientSecret);

		// -(instancetype _Nonnull)initWithClientSecret:(NSString * _Nonnull)clientSecret paymentMethodType:(enum STPPaymentMethodType)paymentMethodType __attribute__((objc_designated_initializer));
		[Export ("initWithClientSecret:paymentMethodType:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string clientSecret, STPPaymentMethodType paymentMethodType);

		// @property (readonly, copy, nonatomic) NSString * _Nullable stripeId;
		[NullAllowed, Export ("stripeId")]
		string StripeId { get; }

		// @property (copy, nonatomic) NSString * _Nonnull clientSecret;
		[Export ("clientSecret")]
		string ClientSecret { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodParams * _Nullable paymentMethodParams;
		[NullAllowed, Export ("paymentMethodParams", ArgumentSemantic.Strong)]
		STPPaymentMethodParams PaymentMethodParams { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable paymentMethodId;
		[NullAllowed, Export ("paymentMethodId")]
		string PaymentMethodId { get; set; }

		// @property (nonatomic, strong) STPSourceParams * _Nullable sourceParams;
		[NullAllowed, Export ("sourceParams", ArgumentSemantic.Strong)]
		STPSourceParams SourceParams { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sourceId;
		[NullAllowed, Export ("sourceId")]
		string SourceId { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable receiptEmail;
		[NullAllowed, Export ("receiptEmail")]
		string ReceiptEmail { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable savePaymentMethod;
		[NullAllowed, Export ("savePaymentMethod", ArgumentSemantic.Strong)]
		NSNumber SavePaymentMethod { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable returnURL;
		[NullAllowed, Export ("returnURL")]
		string ReturnURL { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable setupFutureUsage;
		[NullAllowed, Export ("setupFutureUsage", ArgumentSemantic.Strong)]
		NSNumber SetupFutureUsage { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable useStripeSDK;
		[NullAllowed, Export ("useStripeSDK", ArgumentSemantic.Strong)]
		NSNumber UseStripeSDK { get; set; }

		// @property (nonatomic, strong) STPMandateDataParams * _Nullable mandateData;
		[NullAllowed, Export ("mandateData", ArgumentSemantic.Strong)]
		STPMandateDataParams MandateData { get; set; }

		// @property (nonatomic, strong) STPConfirmPaymentMethodOptions * _Nullable paymentMethodOptions;
		[NullAllowed, Export ("paymentMethodOptions", ArgumentSemantic.Strong)]
		STPConfirmPaymentMethodOptions PaymentMethodOptions { get; set; }

		// @property (nonatomic, strong) STPPaymentIntentShippingDetailsParams * _Nullable shipping;
		[NullAllowed, Export ("shipping", ArgumentSemantic.Strong)]
		STPPaymentIntentShippingDetailsParams Shipping { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("", "returnURL") NSString * returnUrl __attribute__((deprecated("", "returnURL")));
		[Export ("returnUrl")]
		string ReturnUrl { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("", "savePaymentMethod") NSNumber * saveSourceToCustomer __attribute__((deprecated("", "savePaymentMethod")));
		[Export ("saveSourceToCustomer", ArgumentSemantic.Strong)]
		NSNumber SaveSourceToCustomer { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_3000 (STPPaymentIntentParams) <NSCopying>
	partial interface STPPaymentIntentParams: INSCopying
	{
		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface StripePayments_Swift_3006 (STPPaymentIntentParams) <STPFormEncodable>
	partial interface STPPaymentIntentParams: STPFormEncodable
	{
		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentIntentShippingDetails : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments31STPPaymentIntentShippingDetails")]
	[DisableDefaultCtor]
	partial interface STPPaymentIntentShippingDetails
	{
		// @property (readonly, nonatomic, strong) STPPaymentIntentShippingDetailsAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		STPPaymentIntentShippingDetailsAddress Address { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable carrier;
		[NullAllowed, Export ("carrier")]
		string Carrier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable trackingNumber;
		[NullAllowed, Export ("trackingNumber")]
		string TrackingNumber { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_3054 (STPPaymentIntentShippingDetails) <STPAPIResponseDecodable>
	partial interface STPPaymentIntentShippingDetails: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentIntentShippingDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentIntentShippingDetailsAddress : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments38STPPaymentIntentShippingDetailsAddress")]
	[DisableDefaultCtor]
	partial interface STPPaymentIntentShippingDetailsAddress
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable city;
		[NullAllowed, Export ("city")]
		string City { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable line1;
		[NullAllowed, Export ("line1")]
		string Line1 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable line2;
		[NullAllowed, Export ("line2")]
		string Line2 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable state;
		[NullAllowed, Export ("state")]
		string State { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface StripePayments_Swift_3087 (STPPaymentIntentShippingDetailsAddress) <STPAPIResponseDecodable>
	partial interface STPPaymentIntentShippingDetailsAddress: STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentIntentShippingDetailsAddress DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentIntentShippingDetailsAddressParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments44STPPaymentIntentShippingDetailsAddressParams")]
	[DisableDefaultCtor]
	partial interface STPPaymentIntentShippingDetailsAddressParams
	{
		// @property (copy, nonatomic) NSString * _Nullable city;
		[NullAllowed, Export ("city")]
		string City { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull line1;
		[Export ("line1")]
		string Line1 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable line2;
		[NullAllowed, Export ("line2")]
		string Line2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable state;
		[NullAllowed, Export ("state")]
		string State { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// -(instancetype _Nonnull)initWithLine1:(NSString * _Nonnull)line1 __attribute__((objc_designated_initializer));
		[Export ("initWithLine1:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string line1);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);
	}

	// @interface StripePayments_Swift_3120 (STPPaymentIntentShippingDetailsAddressParams) <NSCopying>
	partial interface STPPaymentIntentShippingDetailsAddressParams : INSCopying
	{
		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface StripePayments_Swift_3126 (STPPaymentIntentShippingDetailsAddressParams) <STPFormEncodable>
	partial interface STPPaymentIntentShippingDetailsAddressParams: STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// @interface STPPaymentIntentShippingDetailsParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments37STPPaymentIntentShippingDetailsParams")]
	[DisableDefaultCtor]
	partial interface STPPaymentIntentShippingDetailsParams
	{
		// @property (nonatomic, strong) STPPaymentIntentShippingDetailsAddressParams * _Nonnull address;
		[Export ("address", ArgumentSemantic.Strong)]
		STPPaymentIntentShippingDetailsAddressParams Address { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable carrier;
		[NullAllowed, Export ("carrier")]
		string Carrier { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable trackingNumber;
		[NullAllowed, Export ("trackingNumber")]
		string TrackingNumber { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// -(instancetype _Nonnull)initWithAddress:(STPPaymentIntentShippingDetailsAddressParams * _Nonnull)address name:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
		[Export ("initWithAddress:name:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPPaymentIntentShippingDetailsAddressParams address, string name);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);
	}

	// @interface StripePayments_Swift_3159 (STPPaymentIntentShippingDetailsParams) <NSCopying>
	partial interface STPPaymentIntentShippingDetailsParams : INSCopying
	{
		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface StripePayments_Swift_3165 (STPPaymentIntentShippingDetailsParams) <STPFormEncodable>
	partial interface STPPaymentIntentShippingDetailsParams: STPFormEncodable
	{
		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }
	}

	// SWIFT_CLASS("_TtC14StripePayments25STPPaymentMethodMobilePay")
	// @interface STPPaymentMethodMobilePay : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPPaymentMethodMobilePay")]
	[DisableDefaultCtor]
	interface STPPaymentMethodMobilePay : STPAPIResponseDecodable
	{
		// /// :nodoc:
		// @property (nonatomic, readonly, copy) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields")]
		NSDictionary AllResponseFields { get; }

		// /// :nodoc:
		// @property (nonatomic, readonly, copy) NSString * _Nonnull description;
		[NullAllowed, Export ("description")]
		string Description { get; }

		// + (nullable instancetype)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response SWIFT_WARN_UNUSED_RESULT;
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodMobilePay DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethod : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments16STPPaymentMethod")]
	[DisableDefaultCtor]
	interface STPPaymentMethod : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull stripeId;
		[Export ("stripeId")]
		string StripeId { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable created;
		[NullAllowed, Export ("created", ArgumentSemantic.Copy)]
		NSDate Created { get; }

		// @property (readonly, nonatomic) BOOL liveMode;
		[Export ("liveMode")]
		bool LiveMode { get; }

		// @property (readonly, nonatomic) enum STPPaymentMethodType type;
		[Export ("type")]
		STPPaymentMethodType Type { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodBillingDetails * _Nullable billingDetails;
		[NullAllowed, Export ("billingDetails", ArgumentSemantic.Strong)]
		STPPaymentMethodBillingDetails BillingDetails { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAlipay * _Nullable alipay;
		[NullAllowed, Export ("alipay", ArgumentSemantic.Strong)]
		STPPaymentMethodAlipay Alipay { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodGrabPay * _Nullable grabPay;
		[NullAllowed, Export ("grabPay", ArgumentSemantic.Strong)]
		STPPaymentMethodGrabPay GrabPay { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodCard * _Nullable card;
		[NullAllowed, Export ("card", ArgumentSemantic.Strong)]
		STPPaymentMethodCard Card { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodiDEAL * _Nullable iDEAL;
		[NullAllowed, Export ("iDEAL", ArgumentSemantic.Strong)]
		STPPaymentMethodiDEAL IDEAL { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodFPX * _Nullable fpx;
		[NullAllowed, Export ("fpx", ArgumentSemantic.Strong)]
		STPPaymentMethodFPX Fpx { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodCardPresent * _Nullable cardPresent;
		[NullAllowed, Export ("cardPresent", ArgumentSemantic.Strong)]
		STPPaymentMethodCardPresent CardPresent { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodSEPADebit * _Nullable sepaDebit;
		[NullAllowed, Export ("sepaDebit", ArgumentSemantic.Strong)]
		STPPaymentMethodSEPADebit SepaDebit { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodBacsDebit * _Nullable bacsDebit;
		[NullAllowed, Export ("bacsDebit", ArgumentSemantic.Strong)]
		STPPaymentMethodBacsDebit BacsDebit { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAUBECSDebit * _Nullable auBECSDebit;
		[NullAllowed, Export ("auBECSDebit", ArgumentSemantic.Strong)]
		STPPaymentMethodAUBECSDebit AuBECSDebit { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodGiropay * _Nullable giropay;
		[NullAllowed, Export ("giropay", ArgumentSemantic.Strong)]
		STPPaymentMethodGiropay Giropay { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodEPS * _Nullable eps;
		[NullAllowed, Export ("eps", ArgumentSemantic.Strong)]
		STPPaymentMethodEPS Eps { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodPrzelewy24 * _Nullable przelewy24;
		[NullAllowed, Export ("przelewy24", ArgumentSemantic.Strong)]
		STPPaymentMethodPrzelewy24 Przelewy24 { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodBancontact * _Nullable bancontact;
		[NullAllowed, Export ("bancontact", ArgumentSemantic.Strong)]
		STPPaymentMethodBancontact Bancontact { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodNetBanking * _Nullable netBanking;
		[NullAllowed, Export ("netBanking", ArgumentSemantic.Strong)]
		STPPaymentMethodNetBanking NetBanking { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodOXXO * _Nullable oxxo;
		[NullAllowed, Export ("oxxo", ArgumentSemantic.Strong)]
		STPPaymentMethodOXXO Oxxo { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodSofort * _Nullable sofort;
		[NullAllowed, Export ("sofort", ArgumentSemantic.Strong)]
		STPPaymentMethodSofort Sofort { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodUPI * _Nullable upi;
		[NullAllowed, Export ("upi", ArgumentSemantic.Strong)]
		STPPaymentMethodUPI Upi { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodPayPal * _Nullable payPal;
		[NullAllowed, Export ("payPal", ArgumentSemantic.Strong)]
		STPPaymentMethodPayPal PayPal { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAfterpayClearpay * _Nullable afterpayClearpay;
		[NullAllowed, Export ("afterpayClearpay", ArgumentSemantic.Strong)]
		STPPaymentMethodAfterpayClearpay AfterpayClearpay { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodBLIK * _Nullable blik;
		[NullAllowed, Export ("blik", ArgumentSemantic.Strong)]
		STPPaymentMethodBLIK Blik { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodBoleto * _Nullable boleto;
		[NullAllowed, Export ("boleto", ArgumentSemantic.Strong)]
		STPPaymentMethodBoleto Boleto { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodLink * _Nullable link;
		[NullAllowed, Export ("link", ArgumentSemantic.Strong)]
		STPPaymentMethodLink Link { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodKlarna * _Nullable klarna;
		[NullAllowed, Export ("klarna", ArgumentSemantic.Strong)]
		STPPaymentMethodKlarna Klarna { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAffirm * _Nullable affirm;
		[NullAllowed, Export ("affirm", ArgumentSemantic.Strong)]
		STPPaymentMethodAffirm Affirm { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodUSBankAccount * _Nullable usBankAccount;
		[NullAllowed, Export ("usBankAccount", ArgumentSemantic.Strong)]
		STPPaymentMethodUSBankAccount UsBankAccount { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodCashApp * _Nullable cashApp;
		[NullAllowed, Export ("cashApp", ArgumentSemantic.Strong)]
		STPPaymentMethodCashApp CashApp { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodRevolutPay * _Nullable revolutPay;
		[NullAllowed, Export ("revolutPay", ArgumentSemantic.Strong)]
		STPPaymentMethodRevolutPay RevolutPay { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodSwish * _Nullable swish;
		[NullAllowed, Export ("swish", ArgumentSemantic.Strong)]
		STPPaymentMethodSwish Swish { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAmazonPay * _Nullable amazonPay;
		[NullAllowed, Export ("amazonPay", ArgumentSemantic.Strong)]
		STPPaymentMethodAmazonPay AmazonPay { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAlma * _Nullable alma;
		[NullAllowed, Export ("alma", ArgumentSemantic.Strong)]
		STPPaymentMethodAlma Alma { get; }

		// @property (nonatomic, readonly, strong) STPPaymentMethodMultibanco * _Nullable multibanco;
		[NullAllowed, Export ("multibanco", ArgumentSemantic.Strong)]
		STPPaymentMethodMultibanco Multibanco { get; }

		// @property (nonatomic, readonly, strong) STPPaymentMethodMobilePay * _Nullable mobilePay;
		[NullAllowed, Export ("mobilePay", ArgumentSemantic.Strong)]
		STPPaymentMethodMobilePay MobilePay { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerId;
		[NullAllowed, Export ("customerId")]
		string CustomerId { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.") NSDictionary<NSString *,NSString *> * metadata __attribute__((deprecated("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
		[Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Metadata { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(instancetype _Nonnull)initWithStripeId:(NSString * _Nonnull)stripeId type:(enum STPPaymentMethodType)type __attribute__((objc_designated_initializer));
		[Export ("initWithStripeId:type:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string stripeId, STPPaymentMethodType type);

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethod DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodAUBECSDebit : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments27STPPaymentMethodAUBECSDebit")]
	[DisableDefaultCtor]
	interface STPPaymentMethodAUBECSDebit : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull bsbNumber;
		[Export ("bsbNumber")]
		string BsbNumber { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fingerprint;
		[Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull last4;
		[Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodAUBECSDebit DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodAUBECSDebitParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments33STPPaymentMethodAUBECSDebitParams")]
	interface STPPaymentMethodAUBECSDebitParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountNumber;
		[NullAllowed, Export ("accountNumber")]
		string AccountNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable bsbNumber;
		[NullAllowed, Export ("bsbNumber")]
		string BsbNumber { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodAddress : NSObject <STPAPIResponseDecodable, STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPPaymentMethodAddress")]
	interface STPPaymentMethodAddress : STPAPIResponseDecodable, STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable city;
		[NullAllowed, Export ("city")]
		string City { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable line1;
		[NullAllowed, Export ("line1")]
		string Line1 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable line2;
		[NullAllowed, Export ("line2")]
		string Line2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable state;
		[NullAllowed, Export ("state")]
		string State { get; set; }

		// -(instancetype _Nonnull)initWithAddress:(STPAddress * _Nonnull)address __attribute__((objc_designated_initializer));
		[Export ("initWithAddress:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPAddress address);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// -(BOOL)isEqual:(id _Nullable)other __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodAddress DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodAffirm : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPPaymentMethodAffirm")]
	[DisableDefaultCtor]
	interface STPPaymentMethodAffirm : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodAffirm DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodAffirmParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPPaymentMethodAffirmParams")]
	interface STPPaymentMethodAffirmParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodAfterpayClearpay : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPPaymentMethodAfterpayClearpay")]
	[DisableDefaultCtor]
	interface STPPaymentMethodAfterpayClearpay : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodAfterpayClearpay DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodAfterpayClearpayParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments38STPPaymentMethodAfterpayClearpayParams")]
	interface STPPaymentMethodAfterpayClearpayParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodAlipay : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPPaymentMethodAlipay")]
	[DisableDefaultCtor]
	interface STPPaymentMethodAlipay : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodAlipay DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodAlipayParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPPaymentMethodAlipayParams")]
	interface STPPaymentMethodAlipayParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodAlma : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments20STPPaymentMethodAlma")]
	[DisableDefaultCtor]
	interface STPPaymentMethodAlma
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodAlma DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodAlmaParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodAlmaParams")]
	interface STPPaymentMethodAlmaParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodAmazonPay : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPPaymentMethodAmazonPay")]
	[DisableDefaultCtor]
	interface STPPaymentMethodAmazonPay
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodAmazonPay DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodAmazonPayParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments31STPPaymentMethodAmazonPayParams")]
	interface STPPaymentMethodAmazonPayParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodBLIK : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments20STPPaymentMethodBLIK")]
	[DisableDefaultCtor]
	interface STPPaymentMethodBLIK : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodBLIK DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodBLIKParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodBLIKParams")]
	interface STPPaymentMethodBLIKParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodBacsDebit : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPPaymentMethodBacsDebit")]
	[DisableDefaultCtor]
	interface STPPaymentMethodBacsDebit : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
		[NullAllowed, Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sortCode;
		[NullAllowed, Export ("sortCode")]
		string SortCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodBacsDebit DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodBacsDebitParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments31STPPaymentMethodBacsDebitParams")]
	interface STPPaymentMethodBacsDebitParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountNumber;
		[NullAllowed, Export ("accountNumber")]
		string AccountNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sortCode;
		[NullAllowed, Export ("sortCode")]
		string SortCode { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodBancontact : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodBancontact")]
	[DisableDefaultCtor]
	interface STPPaymentMethodBancontact : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodBancontact DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodBancontactParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPPaymentMethodBancontactParams")]
	interface STPPaymentMethodBancontactParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodBillingDetails : NSObject <STPAPIResponseDecodable, STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments30STPPaymentMethodBillingDetails")]
	interface STPPaymentMethodBillingDetails : STPAPIResponseDecodable, STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		STPPaymentMethodAddress Address { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; set; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// -(BOOL)isEqual:(id _Nullable)other __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodBillingDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodBoleto : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPPaymentMethodBoleto")]
	[DisableDefaultCtor]
	interface STPPaymentMethodBoleto : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull taxID;
		[Export ("taxID")]
		string TaxID { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodBoleto DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodBoletoParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPPaymentMethodBoletoParams")]
	interface STPPaymentMethodBoletoParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSString * _Nullable taxID;
		[NullAllowed, Export ("taxID")]
		string TaxID { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodCard : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments20STPPaymentMethodCard")]
	[DisableDefaultCtor]
	interface STPPaymentMethodCard : STPAPIResponseDecodable
	{
		// @property (readonly, nonatomic) enum STPCardBrand brand;
		[Export ("brand")]
		STPCardBrand Brand { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodCardChecks * _Nullable checks;
		[NullAllowed, Export ("checks", ArgumentSemantic.Strong)]
		STPPaymentMethodCardChecks Checks { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, nonatomic) NSInteger expMonth;
		[Export ("expMonth")]
		nint ExpMonth { get; }

		// @property (readonly, nonatomic) NSInteger expYear;
		[Export ("expYear")]
		nint ExpYear { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable funding;
		[NullAllowed, Export ("funding")]
		string Funding { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
		[NullAllowed, Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodCardNetworks * _Nullable networks;
		[NullAllowed, Export ("networks", ArgumentSemantic.Strong)]
		STPPaymentMethodCardNetworks Networks { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable displayBrand;
		[NullAllowed, Export ("displayBrand")]
		string DisplayBrand { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodThreeDSecureUsage * _Nullable threeDSecureUsage;
		[NullAllowed, Export ("threeDSecureUsage", ArgumentSemantic.Strong)]
		STPPaymentMethodThreeDSecureUsage ThreeDSecureUsage { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodCardWallet * _Nullable wallet;
		[NullAllowed, Export ("wallet", ArgumentSemantic.Strong)]
		STPPaymentMethodCardWallet Wallet { get; }

		// +(NSString * _Nonnull)stringFromBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stringFromBrand:")]
		string StringFromBrand (STPCardBrand brand);

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodCard DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodCardChecks : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodCardChecks")]
	[DisableDefaultCtor]
	interface STPPaymentMethodCardChecks : STPAPIResponseDecodable
	{
		// @property (readonly, nonatomic) enum STPPaymentMethodCardCheckResult addressLine1Check __attribute__((deprecated("Card check values are no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
		[Export ("addressLine1Check")]
		STPPaymentMethodCardCheckResult AddressLine1Check { get; }

		// @property (readonly, nonatomic) enum STPPaymentMethodCardCheckResult addressPostalCodeCheck __attribute__((deprecated("Card check values are no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
		[Export ("addressPostalCodeCheck")]
		STPPaymentMethodCardCheckResult AddressPostalCodeCheck { get; }

		// @property (readonly, nonatomic) enum STPPaymentMethodCardCheckResult cvcCheck __attribute__((deprecated("Card check values are no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
		[Export ("cvcCheck")]
		STPPaymentMethodCardCheckResult CvcCheck { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodCardChecks DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodCardNetworks : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPPaymentMethodCardNetworks")]
	[DisableDefaultCtor]
	interface STPPaymentMethodCardNetworks : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull available;
		[Export ("available", ArgumentSemantic.Copy)]
		string[] Available { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable preferred;
		[NullAllowed, Export ("preferred")]
		string Preferred { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodCardNetworks DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodCardNetworksParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments34STPPaymentMethodCardNetworksParams")]
	interface STPPaymentMethodCardNetworksParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable preferred;
		[NullAllowed, Export ("preferred")]
		string Preferred { get; set; }

		// -(instancetype _Nonnull)initWithPreferred:(NSString * _Nullable)preferred;
		[Export ("initWithPreferred:")]
		NativeHandle Constructor ([NullAllowed] string preferred);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodCardParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodCardParams")]
	interface STPPaymentMethodCardParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// -(instancetype _Nonnull)initWithCardSourceParams:(STPCardParams * _Nonnull)cardSourceParams;
		[Export ("initWithCardSourceParams:")]
		NativeHandle Constructor (STPCardParams cardSourceParams);

		// @property (copy, nonatomic) NSString * _Nullable number;
		[NullAllowed, Export ("number")]
		string Number { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable expMonth;
		[NullAllowed, Export ("expMonth", ArgumentSemantic.Strong)]
		NSNumber ExpMonth { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable expYear;
		[NullAllowed, Export ("expYear", ArgumentSemantic.Strong)]
		NSNumber ExpYear { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable token;
		[NullAllowed, Export ("token")]
		string Token { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable cvc;
		[NullAllowed, Export ("cvc")]
		string Cvc { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodCardNetworksParams * _Nullable networks;
		[NullAllowed, Export ("networks", ArgumentSemantic.Strong)]
		STPPaymentMethodCardNetworksParams Networks { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// -(BOOL)isEqual:(id _Nullable)other __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject other);
	}

	// @interface STPPaymentMethodCardPresent : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments27STPPaymentMethodCardPresent")]
	[DisableDefaultCtor]
	interface STPPaymentMethodCardPresent : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodCardPresent DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodCardWallet : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodCardWallet")]
	[DisableDefaultCtor]
	interface STPPaymentMethodCardWallet : STPAPIResponseDecodable
	{
		// @property (readonly, nonatomic) enum STPPaymentMethodCardWalletType type;
		[Export ("type")]
		STPPaymentMethodCardWalletType Type { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodCardWalletMasterpass * _Nullable masterpass;
		[NullAllowed, Export ("masterpass", ArgumentSemantic.Strong)]
		STPPaymentMethodCardWalletMasterpass Masterpass { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodCardWalletVisaCheckout * _Nullable visaCheckout;
		[NullAllowed, Export ("visaCheckout", ArgumentSemantic.Strong)]
		STPPaymentMethodCardWalletVisaCheckout VisaCheckout { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodCardWallet DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodCardWalletMasterpass : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments36STPPaymentMethodCardWalletMasterpass")]
	[DisableDefaultCtor]
	interface STPPaymentMethodCardWalletMasterpass : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Strong)]
		STPPaymentMethodAddress BillingAddress { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		STPPaymentMethodAddress ShippingAddress { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodCardWalletMasterpass DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodCardWalletVisaCheckout : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments38STPPaymentMethodCardWalletVisaCheckout")]
	[DisableDefaultCtor]
	interface STPPaymentMethodCardWalletVisaCheckout : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Strong)]
		STPPaymentMethodAddress BillingAddress { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		STPPaymentMethodAddress ShippingAddress { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodCardWalletVisaCheckout DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodCashApp : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPPaymentMethodCashApp")]
	[DisableDefaultCtor]
	interface STPPaymentMethodCashApp
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodCashApp DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodCashAppParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments29STPPaymentMethodCashAppParams")]
	interface STPPaymentMethodCashAppParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodEPS : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments19STPPaymentMethodEPS")]
	[DisableDefaultCtor]
	interface STPPaymentMethodEPS : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodEPS DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodEPSParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPPaymentMethodEPSParams")]
	interface STPPaymentMethodEPSParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodFPX : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments19STPPaymentMethodFPX")]
	[DisableDefaultCtor]
	interface STPPaymentMethodFPX : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable bankIdentifierCode;
		[NullAllowed, Export ("bankIdentifierCode")]
		string BankIdentifierCode { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodFPX DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodFPXParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPPaymentMethodFPXParams")]
	interface STPPaymentMethodFPXParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (nonatomic) enum STPFPXBankBrand bank;
		[Export ("bank", ArgumentSemantic.Assign)]
		STPFPXBankBrand Bank { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable rawBankString;
		[NullAllowed, Export ("rawBankString")]
		string RawBankString { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodGiropay : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPPaymentMethodGiropay")]
	[DisableDefaultCtor]
	interface STPPaymentMethodGiropay : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodGiropay DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodGiropayParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments29STPPaymentMethodGiropayParams")]
	interface STPPaymentMethodGiropayParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodGrabPay : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPPaymentMethodGrabPay")]
	[DisableDefaultCtor]
	interface STPPaymentMethodGrabPay : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodGrabPay DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodGrabPayParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments29STPPaymentMethodGrabPayParams")]
	interface STPPaymentMethodGrabPayParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodKlarna : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPPaymentMethodKlarna")]
	[DisableDefaultCtor]
	interface STPPaymentMethodKlarna : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodKlarna DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodKlarnaParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPPaymentMethodKlarnaParams")]
	interface STPPaymentMethodKlarnaParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodLink : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments20STPPaymentMethodLink")]
	[DisableDefaultCtor]
	interface STPPaymentMethodLink : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodLink DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodLinkParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodLinkParams")]
	interface STPPaymentMethodLinkParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSString * _Nullable paymentDetailsID;
		[NullAllowed, Export ("paymentDetailsID")]
		string PaymentDetailsID { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable credentials;
		[NullAllowed, Export ("credentials", ArgumentSemantic.Copy)]
		NSDictionary Credentials { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodListDeserializer : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPPaymentMethodListDeserializer")]
	[DisableDefaultCtor]
	interface STPPaymentMethodListDeserializer : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodListDeserializer DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodMobilePayParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments31STPPaymentMethodMobilePayParams")]
	[DisableDefaultCtor]
	interface STPPaymentMethodMobilePayParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// SWIFT_CLASS("_TtC14StripePayments26STPPaymentMethodMultibanco")
	// @interface STPPaymentMethodMultibanco : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodMultibanco")]
	[DisableDefaultCtor]
	interface STPPaymentMethodMultibanco : STPFormEncodable
	{
		// /// :nodoc:
		// @property (nonatomic, readonly, copy) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; set; }

		// /// :nodoc:
		// @property (nonatomic, readonly, copy) NSString * _Nonnull description;
		[Export ("description", ArgumentSemantic.Copy)]
		string description { get; set; }

		// + (nullable instancetype)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response SWIFT_WARN_UNUSED_RESULT;
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodMultibanco DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}


	// /// An object representing parameters used to create a Multibanco Payment Method
	// SWIFT_CLASS("_TtC14StripePayments32STPPaymentMethodMultibancoParams")
	// @interface STPPaymentMethodMultibancoParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPPaymentMethodMultibancoParams")]
	[DisableDefaultCtor]
	interface STPPaymentMethodMultibancoParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodNetBanking : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodNetBanking")]
	[DisableDefaultCtor]
	interface STPPaymentMethodNetBanking : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull bank;
		[Export ("bank")]
		string Bank { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodNetBanking DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodNetBankingParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPPaymentMethodNetBankingParams")]
	interface STPPaymentMethodNetBankingParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable bank;
		[NullAllowed, Export ("bank")]
		string Bank { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodOXXO : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments20STPPaymentMethodOXXO")]
	[DisableDefaultCtor]
	interface STPPaymentMethodOXXO : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodOXXO DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodOXXOParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodOXXOParams")]
	interface STPPaymentMethodOXXOParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodOptions : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments23STPPaymentMethodOptions")]
	[DisableDefaultCtor]
	partial interface STPPaymentMethodOptions : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodOptions DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface StripePayments_Swift_4223 (STPPaymentMethodOptions)
	partial interface STPPaymentMethodOptions
	{
	}

	// @interface StripePayments_Swift_4227 (STPPaymentMethodOptions)
	partial interface STPPaymentMethodOptions
	{
	}

	// @interface STPPaymentMethodParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPPaymentMethodParams")]
	partial interface STPPaymentMethodParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (nonatomic) enum STPPaymentMethodType type;
		[Export ("type", ArgumentSemantic.Assign)]
		STPPaymentMethodType Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable rawTypeString;
		[NullAllowed, Export ("rawTypeString")]
		string RawTypeString { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodBillingDetails * _Nullable billingDetails;
		[NullAllowed, Export ("billingDetails", ArgumentSemantic.Strong)]
		STPPaymentMethodBillingDetails BillingDetails { get; set; }

		// @property (nonatomic) enum STPPaymentMethodAllowRedisplay allowRedisplay;
		[NullAllowed, Export ("allowRedisplay", ArgumentSemantic.Strong)]
		STPPaymentMethodAllowRedisplay AllowRedisplay { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodCardParams * _Nullable card;
		[NullAllowed, Export ("card", ArgumentSemantic.Strong)]
		STPPaymentMethodCardParams Card { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodAlipayParams * _Nullable alipay;
		[NullAllowed, Export ("alipay", ArgumentSemantic.Strong)]
		STPPaymentMethodAlipayParams Alipay { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodiDEALParams * _Nullable iDEAL;
		[NullAllowed, Export ("iDEAL", ArgumentSemantic.Strong)]
		STPPaymentMethodiDEALParams IDEAL { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodFPXParams * _Nullable fpx;
		[NullAllowed, Export ("fpx", ArgumentSemantic.Strong)]
		STPPaymentMethodFPXParams Fpx { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodSEPADebitParams * _Nullable sepaDebit;
		[NullAllowed, Export ("sepaDebit", ArgumentSemantic.Strong)]
		STPPaymentMethodSEPADebitParams SepaDebit { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodBacsDebitParams * _Nullable bacsDebit;
		[NullAllowed, Export ("bacsDebit", ArgumentSemantic.Strong)]
		STPPaymentMethodBacsDebitParams BacsDebit { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodAUBECSDebitParams * _Nullable auBECSDebit;
		[NullAllowed, Export ("auBECSDebit", ArgumentSemantic.Strong)]
		STPPaymentMethodAUBECSDebitParams AuBECSDebit { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodGiropayParams * _Nullable giropay;
		[NullAllowed, Export ("giropay", ArgumentSemantic.Strong)]
		STPPaymentMethodGiropayParams Giropay { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodPayPalParams * _Nullable payPal;
		[NullAllowed, Export ("payPal", ArgumentSemantic.Strong)]
		STPPaymentMethodPayPalParams PayPal { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodPrzelewy24Params * _Nullable przelewy24;
		[NullAllowed, Export ("przelewy24", ArgumentSemantic.Strong)]
		STPPaymentMethodPrzelewy24Params Przelewy24 { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodEPSParams * _Nullable eps;
		[NullAllowed, Export ("eps", ArgumentSemantic.Strong)]
		STPPaymentMethodEPSParams Eps { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodBancontactParams * _Nullable bancontact;
		[NullAllowed, Export ("bancontact", ArgumentSemantic.Strong)]
		STPPaymentMethodBancontactParams Bancontact { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodNetBankingParams * _Nullable netBanking;
		[NullAllowed, Export ("netBanking", ArgumentSemantic.Strong)]
		STPPaymentMethodNetBankingParams NetBanking { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodOXXOParams * _Nullable oxxo;
		[NullAllowed, Export ("oxxo", ArgumentSemantic.Strong)]
		STPPaymentMethodOXXOParams Oxxo { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodSofortParams * _Nullable sofort;
		[NullAllowed, Export ("sofort", ArgumentSemantic.Strong)]
		STPPaymentMethodSofortParams Sofort { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodUPIParams * _Nullable upi;
		[NullAllowed, Export ("upi", ArgumentSemantic.Strong)]
		STPPaymentMethodUPIParams Upi { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodGrabPayParams * _Nullable grabPay;
		[NullAllowed, Export ("grabPay", ArgumentSemantic.Strong)]
		STPPaymentMethodGrabPayParams GrabPay { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodAfterpayClearpayParams * _Nullable afterpayClearpay;
		[NullAllowed, Export ("afterpayClearpay", ArgumentSemantic.Strong)]
		STPPaymentMethodAfterpayClearpayParams AfterpayClearpay { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodBLIKParams * _Nullable blik;
		[NullAllowed, Export ("blik", ArgumentSemantic.Strong)]
		STPPaymentMethodBLIKParams Blik { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodBoletoParams * _Nullable boleto;
		[NullAllowed, Export ("boleto", ArgumentSemantic.Strong)]
		STPPaymentMethodBoletoParams Boleto { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodLinkParams * _Nullable link;
		[NullAllowed, Export ("link", ArgumentSemantic.Strong)]
		STPPaymentMethodLinkParams Link { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodKlarnaParams * _Nullable klarna;
		[NullAllowed, Export ("klarna", ArgumentSemantic.Strong)]
		STPPaymentMethodKlarnaParams Klarna { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodAffirmParams * _Nullable affirm;
		[NullAllowed, Export ("affirm", ArgumentSemantic.Strong)]
		STPPaymentMethodAffirmParams Affirm { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodUSBankAccountParams * _Nullable usBankAccount;
		[NullAllowed, Export ("usBankAccount", ArgumentSemantic.Strong)]
		STPPaymentMethodUSBankAccountParams UsBankAccount { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodCashAppParams * _Nullable cashApp;
		[NullAllowed, Export ("cashApp", ArgumentSemantic.Strong)]
		STPPaymentMethodCashAppParams CashApp { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodRevolutPayParams * _Nullable revolutPay;
		[NullAllowed, Export ("revolutPay", ArgumentSemantic.Strong)]
		STPPaymentMethodRevolutPayParams RevolutPay { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodSwishParams * _Nullable swish;
		[NullAllowed, Export ("swish", ArgumentSemantic.Strong)]
		STPPaymentMethodSwishParams Swish { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodMobilePayParams * _Nullable mobilePay;
		[NullAllowed, Export ("mobilePay", ArgumentSemantic.Strong)]
		STPPaymentMethodMobilePayParams MobilePay { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodAmazonPayParams * _Nullable amazonPay;
		[NullAllowed, Export ("amazonPay", ArgumentSemantic.Strong)]
		STPPaymentMethodAmazonPayParams AmazonPay { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodAlmaParams * _Nullable alma;
		[NullAllowed, Export ("alma", ArgumentSemantic.Strong)]
		STPPaymentMethodAlmaParams Alma { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodMultibancoParams * _Nullable multibanco;
		[NullAllowed, Export ("multibanco", ArgumentSemantic.Strong)]
		STPPaymentMethodMultibancoParams Multibanco { get; set; }

		// @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable metadata;
		[NullAllowed, Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Metadata { get; set; }

		// - (nonnull instancetype)initWithCard:(STPPaymentMethodCardParams * _Nonnull)card billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails allowRedisplay:(enum STPPaymentMethodAllowRedisplay)allowRedisplay metadata:(NSDictionary<NSString *, NSString *> * _Nullable)metadata;
		[Export ("initWithCard:billingDetails:allowRedisplay:metadata:")]
		NativeHandle Constructor (STPPaymentMethodCardParams card, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, STPPaymentMethodAllowRedisplay allowRedisplay, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithIDEAL:(STPPaymentMethodiDEALParams * _Nonnull)iDEAL billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithIDEAL:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodiDEALParams iDEAL, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithFpx:(STPPaymentMethodFPXParams * _Nonnull)fpx billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithFpx:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodFPXParams fpx, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithSepaDebit:(STPPaymentMethodSEPADebitParams * _Nonnull)sepaDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithSepaDebit:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodSEPADebitParams sepaDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithBacsDebit:(STPPaymentMethodBacsDebitParams * _Nonnull)bacsDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithBacsDebit:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodBacsDebitParams bacsDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithAubecsDebit:(STPPaymentMethodAUBECSDebitParams * _Nonnull)auBECSDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithAubecsDebit:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodAUBECSDebitParams auBECSDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithGiropay:(STPPaymentMethodGiropayParams * _Nonnull)giropay billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithGiropay:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodGiropayParams giropay, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithEps:(STPPaymentMethodEPSParams * _Nonnull)eps billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithEps:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodEPSParams eps, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithPrzelewy24:(STPPaymentMethodPrzelewy24Params * _Nonnull)przelewy24 billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithPrzelewy24:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodPrzelewy24Params przelewy24, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithBancontact:(STPPaymentMethodBancontactParams * _Nonnull)bancontact billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithBancontact:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodBancontactParams bancontact, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithNetBanking:(STPPaymentMethodNetBankingParams * _Nonnull)netBanking billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithNetBanking:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodNetBankingParams netBanking, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithGrabPay:(STPPaymentMethodGrabPayParams * _Nonnull)grabPay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithGrabPay:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodGrabPayParams grabPay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithOxxo:(STPPaymentMethodOXXOParams * _Nonnull)oxxo billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithOxxo:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodOXXOParams oxxo, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithSofort:(STPPaymentMethodSofortParams * _Nonnull)sofort billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithSofort:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodSofortParams sofort, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithUpi:(STPPaymentMethodUPIParams * _Nonnull)upi billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithUpi:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodUPIParams upi, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithAlipay:(STPPaymentMethodAlipayParams * _Nonnull)alipay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithAlipay:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodAlipayParams alipay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithPayPal:(STPPaymentMethodPayPalParams * _Nonnull)payPal billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithPayPal:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodPayPalParams payPal, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithAfterpayClearpay:(STPPaymentMethodAfterpayClearpayParams * _Nonnull)afterpayClearpay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithAfterpayClearpay:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodAfterpayClearpayParams afterpayClearpay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithBlik:(STPPaymentMethodBLIKParams * _Nonnull)blik billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithBlik:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodBLIKParams blik, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithBoleto:(STPPaymentMethodBoletoParams * _Nonnull)boleto billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithBoleto:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodBoletoParams boleto, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithKlarna:(STPPaymentMethodKlarnaParams * _Nonnull)klarna billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithKlarna:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodKlarnaParams klarna, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithAffirm:(STPPaymentMethodAffirmParams * _Nonnull)affirm metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithAffirm:metadata:")]
		NativeHandle Constructor (STPPaymentMethodAffirmParams affirm, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithUsBankAccount:(STPPaymentMethodUSBankAccountParams * _Nonnull)usBankAccount billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithUsBankAccount:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodUSBankAccountParams usBankAccount, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithCashApp:(STPPaymentMethodCashAppParams * _Nonnull)cashApp billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithCashApp:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodCashAppParams cashApp, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithRevolutPay:(STPPaymentMethodRevolutPayParams * _Nonnull)revolutPay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithRevolutPay:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodRevolutPayParams revolutPay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithSwish:(STPPaymentMethodSwishParams * _Nonnull)swish billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithSwish:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodSwishParams swish, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithMobilePay:(STPPaymentMethodMobilePayParams * _Nonnull)mobilePay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithMobilePay:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodMobilePayParams mobilePay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithAmazonPay:(STPPaymentMethodAmazonPayParams * _Nonnull)amazonPay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithAmazonPay:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodAmazonPayParams amazonPay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nonnull)initWithAlma:(STPPaymentMethodAlmaParams * _Nonnull)alma billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
		[Export ("initWithAlma:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodAlmaParams alma, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// - (nonnull instancetype)initWithMultibanco:(STPPaymentMethodMultibancoParams * _Nonnull)multibanco billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *, NSString *> * _Nullable)metadata;
		[Export ("initWithMultibanco:billingDetails:metadata:")]
		NativeHandle Constructor (STPPaymentMethodMultibancoParams alma, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// -(instancetype _Nullable)initWithSingleUsePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod;
		[Export ("initWithSingleUsePaymentMethod:")]
		NativeHandle Constructor (STPPaymentMethod paymentMethod);

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface StripePayments_Swift_4563 (STPPaymentMethodParams)
	partial interface STPPaymentMethodParams
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label { get; }
	}

	// @interface StripePayments_Swift_4568 (STPPaymentMethodParams)
	partial interface STPPaymentMethodParams
	{
		// +(STPPaymentMethodParams * _Nonnull)paramsWithCard:(STPPaymentMethodCardParams * _Nonnull)card billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithCard:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithCard (STPPaymentMethodCardParams card, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithiDEAL:(STPPaymentMethodiDEALParams * _Nonnull)iDEAL billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithiDEAL:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithiDEAL (STPPaymentMethodiDEALParams iDEAL, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithFPX:(STPPaymentMethodFPXParams * _Nonnull)fpx billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithFPX:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithFPX (STPPaymentMethodFPXParams fpx, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithSEPADebit:(STPPaymentMethodSEPADebitParams * _Nonnull)sepaDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithSEPADebit:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithSEPADebit (STPPaymentMethodSEPADebitParams sepaDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithBacsDebit:(STPPaymentMethodBacsDebitParams * _Nonnull)bacsDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithBacsDebit:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithBacsDebit (STPPaymentMethodBacsDebitParams bacsDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithAUBECSDebit:(STPPaymentMethodAUBECSDebitParams * _Nonnull)auBECSDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithAUBECSDebit:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithAUBECSDebit (STPPaymentMethodAUBECSDebitParams auBECSDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithGiropay:(STPPaymentMethodGiropayParams * _Nonnull)giropay billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithGiropay:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithGiropay (STPPaymentMethodGiropayParams giropay, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithEPS:(STPPaymentMethodEPSParams * _Nonnull)eps billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithEPS:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithEPS (STPPaymentMethodEPSParams eps, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithPrzelewy24:(STPPaymentMethodPrzelewy24Params * _Nonnull)przelewy24 billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithPrzelewy24:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithPrzelewy24 (STPPaymentMethodPrzelewy24Params przelewy24, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithBancontact:(STPPaymentMethodBancontactParams * _Nonnull)bancontact billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithBancontact:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithBancontact (STPPaymentMethodBancontactParams bancontact, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithNetBanking:(STPPaymentMethodNetBankingParams * _Nonnull)netBanking billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithNetBanking:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithNetBanking (STPPaymentMethodNetBankingParams netBanking, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithOXXO:(STPPaymentMethodOXXOParams * _Nonnull)oxxo billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithOXXO:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithOXXO (STPPaymentMethodOXXOParams oxxo, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithGrabPay:(STPPaymentMethodGrabPayParams * _Nonnull)grabPay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithGrabPay:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithGrabPay (STPPaymentMethodGrabPayParams grabPay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithSofort:(STPPaymentMethodSofortParams * _Nonnull)sofort billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithSofort:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithSofort (STPPaymentMethodSofortParams sofort, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithUPI:(STPPaymentMethodUPIParams * _Nonnull)upi billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithUPI:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithUPI (STPPaymentMethodUPIParams upi, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithAlipay:(STPPaymentMethodAlipayParams * _Nonnull)alipay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithAlipay:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithAlipay (STPPaymentMethodAlipayParams alipay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithPayPal:(STPPaymentMethodPayPalParams * _Nonnull)payPal billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithPayPal:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithPayPal (STPPaymentMethodPayPalParams payPal, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithAfterpayClearpay:(STPPaymentMethodAfterpayClearpayParams * _Nonnull)afterpayClearpay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithAfterpayClearpay:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithAfterpayClearpay (STPPaymentMethodAfterpayClearpayParams afterpayClearpay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithBLIK:(STPPaymentMethodBLIKParams * _Nonnull)blik billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithBLIK:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithBLIK (STPPaymentMethodBLIKParams blik, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithKlarna:(STPPaymentMethodKlarnaParams * _Nonnull)klarna billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithKlarna:billingDetails:metadata:")]
		STPPaymentMethodParams ParamsWithKlarna (STPPaymentMethodKlarnaParams klarna, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

		// +(STPPaymentMethodParams * _Nonnull)paramsWithAffirm:(STPPaymentMethodAffirmParams * _Nonnull)affirm metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paramsWithAffirm:metadata:")]
		STPPaymentMethodParams ParamsWithAffirm (STPPaymentMethodAffirmParams affirm, [NullAllowed] NSDictionary<NSString, NSString> metadata);
	}

	// @interface STPPaymentMethodPayPal : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPPaymentMethodPayPal")]
	[DisableDefaultCtor]
	interface STPPaymentMethodPayPal : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodPayPal DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodPayPalParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPPaymentMethodPayPalParams")]
	interface STPPaymentMethodPayPalParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodPrzelewy24 : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodPrzelewy24")]
	[DisableDefaultCtor]
	interface STPPaymentMethodPrzelewy24 : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodPrzelewy24 DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodPrzelewy24Params : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPPaymentMethodPrzelewy24Params")]
	interface STPPaymentMethodPrzelewy24Params : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodRevolutPay : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments26STPPaymentMethodRevolutPay")]
	[DisableDefaultCtor]
	interface STPPaymentMethodRevolutPay
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodRevolutPay DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodRevolutPayParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPPaymentMethodRevolutPayParams")]
	interface STPPaymentMethodRevolutPayParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodSEPADebit : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPPaymentMethodSEPADebit")]
	[DisableDefaultCtor]
	interface STPPaymentMethodSEPADebit : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable bankCode;
		[NullAllowed, Export ("bankCode")]
		string BankCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable branchCode;
		[NullAllowed, Export ("branchCode")]
		string BranchCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
		[NullAllowed, Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable mandate;
		[NullAllowed, Export ("mandate")]
		string Mandate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodSEPADebit DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodSEPADebitParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments31STPPaymentMethodSEPADebitParams")]
	interface STPPaymentMethodSEPADebitParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable iban;
		[NullAllowed, Export ("iban")]
		string Iban { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodSofort : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPPaymentMethodSofort")]
	[DisableDefaultCtor]
	interface STPPaymentMethodSofort : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodSofort DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodSofortParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPPaymentMethodSofortParams")]
	interface STPPaymentMethodSofortParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodSwish : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments21STPPaymentMethodSwish")]
	[DisableDefaultCtor]
	interface STPPaymentMethodSwish : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodSwish DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodSwishParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments27STPPaymentMethodSwishParams")]
	interface STPPaymentMethodSwishParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodThreeDSecureUsage : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments33STPPaymentMethodThreeDSecureUsage")]
	[DisableDefaultCtor]
	interface STPPaymentMethodThreeDSecureUsage : STPAPIResponseDecodable
	{
		// @property (readonly, nonatomic) BOOL supported;
		[Export ("supported")]
		bool Supported { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodThreeDSecureUsage DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodUPI : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments19STPPaymentMethodUPI")]
	[DisableDefaultCtor]
	interface STPPaymentMethodUPI : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull vpa;
		[Export ("vpa")]
		string Vpa { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodUPI DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodUPIParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPPaymentMethodUPIParams")]
	interface STPPaymentMethodUPIParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable vpa;
		[NullAllowed, Export ("vpa")]
		string Vpa { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodUSBankAccount : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments29STPPaymentMethodUSBankAccount")]
	[DisableDefaultCtor]
	partial interface STPPaymentMethodUSBankAccount
	{
		// @property (readonly, nonatomic) enum STPPaymentMethodUSBankAccountHolderType accountHolderType;
		[Export ("accountHolderType")]
		STPPaymentMethodUSBankAccountHolderType AccountHolderType { get; }

		// @property (readonly, nonatomic) enum STPPaymentMethodUSBankAccountType accountType;
		[Export ("accountType")]
		STPPaymentMethodUSBankAccountType AccountType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull bankName;
		[Export ("bankName")]
		string BankName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull fingerprint;
		[Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull last4;
		[Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable linkedAccount;
		[NullAllowed, Export ("linkedAccount")]
		string LinkedAccount { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodUSBankAccountNetworks * _Nullable networks;
		[NullAllowed, Export ("networks", ArgumentSemantic.Strong)]
		STPPaymentMethodUSBankAccountNetworks Networks { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull routingNumber;
		[Export ("routingNumber")]
		string RoutingNumber { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }
	}

	// @interface StripePayments_Swift_5056 (STPPaymentMethodUSBankAccount) <STPAPIResponseDecodable>
	partial interface STPPaymentMethodUSBankAccount : STPAPIResponseDecodable
	{
		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodUSBankAccount DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodUSBankAccountNetworks : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments37STPPaymentMethodUSBankAccountNetworks")]
	[DisableDefaultCtor]
	interface STPPaymentMethodUSBankAccountNetworks
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable preferred;
		[NullAllowed, Export ("preferred")]
		string Preferred { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull supported;
		[Export ("supported", ArgumentSemantic.Copy)]
		string[] Supported { get; }
	}

	// @interface STPPaymentMethodUSBankAccountParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments35STPPaymentMethodUSBankAccountParams")]
	partial interface STPPaymentMethodUSBankAccountParams
	{
		// @property (copy, nonatomic) NSString * _Nullable accountHolderTypeString;
		[NullAllowed, Export ("accountHolderTypeString")]
		string AccountHolderTypeString { get; set; }

		// @property (nonatomic) enum STPPaymentMethodUSBankAccountHolderType accountHolderType;
		[Export ("accountHolderType", ArgumentSemantic.Assign)]
		STPPaymentMethodUSBankAccountHolderType AccountHolderType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountNumber;
		[NullAllowed, Export ("accountNumber")]
		string AccountNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountTypeString;
		[NullAllowed, Export ("accountTypeString")]
		string AccountTypeString { get; set; }

		// @property (nonatomic) enum STPPaymentMethodUSBankAccountType accountType;
		[Export ("accountType", ArgumentSemantic.Assign)]
		STPPaymentMethodUSBankAccountType AccountType { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable routingNumber;
		[NullAllowed, Export ("routingNumber")]
		string RoutingNumber { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable linkAccountSessionID;
		[NullAllowed, Export ("linkAccountSessionID")]
		string LinkAccountSessionID { get; set; }
	}

	// @interface StripePayments_Swift_5117 (STPPaymentMethodUSBankAccountParams) <STPFormEncodable>
	partial interface STPPaymentMethodUSBankAccountParams : STPFormEncodable
	{
		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodUpdateParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPPaymentMethodUpdateParams")]
	partial interface STPPaymentMethodUpdateParams
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodBillingDetails * _Nullable billingDetails;
		[NullAllowed, Export ("billingDetails", ArgumentSemantic.Strong)]
		STPPaymentMethodBillingDetails BillingDetails { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodCardParams * _Nullable card;
		[NullAllowed, Export ("card", ArgumentSemantic.Strong)]
		STPPaymentMethodCardParams Card { get; set; }

		// -(instancetype _Nonnull)initWithCard:(STPPaymentMethodCardParams * _Nonnull)card billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails;
		[Export ("initWithCard:billingDetails:")]
		NativeHandle Constructor (STPPaymentMethodCardParams card, [NullAllowed] STPPaymentMethodBillingDetails billingDetails);
	}

	// @interface StripePayments_Swift_5153 (STPPaymentMethodUpdateParams) <STPFormEncodable>
	partial interface STPPaymentMethodUpdateParams : STPFormEncodable
	{
		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPPaymentMethodiDEAL : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments21STPPaymentMethodiDEAL")]
	[DisableDefaultCtor]
	interface STPPaymentMethodiDEAL : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable bankName;
		[NullAllowed, Export ("bankName")]
		string BankName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable bankIdentifierCode;
		[NullAllowed, Export ("bankIdentifierCode")]
		string BankIdentifierCode { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPPaymentMethodiDEAL DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPPaymentMethodiDEALParams : NSObject <STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments27STPPaymentMethodiDEALParams")]
	interface STPPaymentMethodiDEALParams : STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable bankName;
		[NullAllowed, Export ("bankName")]
		string BankName { get; set; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPRadarSession : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments15STPRadarSession")]
	[DisableDefaultCtor]
	interface STPRadarSession : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(STPRadarSession * _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPRadarSession DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPRedirectContext : NSObject <UIViewControllerTransitioningDelegate>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments18STPRedirectContext")]
	[DisableDefaultCtor]
	partial interface STPRedirectContext : IUIViewControllerTransitioningDelegate
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull STPRedirectContextErrorDomain;
		[Static]
		[Export ("STPRedirectContextErrorDomain")]
		string STPRedirectContextErrorDomain { get; }

		// @property (readonly, nonatomic) enum STPRedirectContextState state;
		[Export ("state")]
		STPRedirectContextState State { get; }

		// -(instancetype _Nullable)initWithSource:(STPSource * _Nonnull)source completion:(void (^ _Nonnull)(NSString * _Nonnull, NSString * _Nullable, NSError * _Nullable))completion;
		[Export ("initWithSource:completion:")]
		NativeHandle Constructor (STPSource source, Action<NSString, NSString, NSError> completion);

		// -(instancetype _Nullable)initWithPaymentIntent:(STPPaymentIntent * _Nonnull)paymentIntent completion:(void (^ _Nonnull)(NSString * _Nonnull, NSError * _Nullable))completion;
		[Export ("initWithPaymentIntent:completion:")]
		NativeHandle Constructor (STPPaymentIntent paymentIntent, Action<NSString, NSError> completion);

		// -(void)startRedirectFlowFromViewController:(UIViewController * _Nonnull)presentingViewController;
		[Export ("startRedirectFlowFromViewController:")]
		void StartRedirectFlowFromViewController (UIViewController presentingViewController);

		// -(void)startSafariViewControllerRedirectFlowFromViewController:(UIViewController * _Nonnull)presentingViewController;
		[Export ("startSafariViewControllerRedirectFlowFromViewController:")]
		void StartSafariViewControllerRedirectFlowFromViewController (UIViewController presentingViewController);

		// -(void)startSafariAppRedirectFlow;
		[Export ("startSafariAppRedirectFlow")]
		void StartSafariAppRedirectFlow ();

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(UIPresentationController * _Nullable)presentationControllerForPresentedViewController:(UIViewController * _Nonnull)presented presentingViewController:(UIViewController * _Nullable)presenting sourceViewController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
		[Export ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:")]
		[return: NullAllowed]
		UIPresentationController PresentationControllerForPresentedViewController (UIViewController presented, [NullAllowed] UIViewController presenting, UIViewController source);
	}

	// @interface StripePayments_Swift_5342 (STPRedirectContext)
	partial interface STPRedirectContext
	{
		// -(BOOL)handleURLCallback:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Export ("handleURLCallback:")]
		bool HandleURLCallback (NSUrl url);
	}

	// @interface StripePayments_Swift_5348 (STPRedirectContext) <SFSafariViewControllerDelegate>
	partial interface STPRedirectContext : ISFSafariViewControllerDelegate
	{
		// -(void)safariViewControllerDidFinish:(SFSafariViewController * _Nonnull)controller;
		[Export ("safariViewControllerDidFinish:")]
		void SafariViewControllerDidFinish (SFSafariViewController controller);

		// -(void)safariViewController:(SFSafariViewController * _Nonnull)controller didCompleteInitialLoad:(BOOL)didLoadSuccessfully;
		[Export ("safariViewController:didCompleteInitialLoad:")]
		void SafariViewController (SFSafariViewController controller, bool didLoadSuccessfully);

		// -(void)safariViewController:(SFSafariViewController * _Nonnull)controller initialLoadDidRedirectToURL:(NSURL * _Nonnull)URL;
		[Export ("safariViewController:initialLoadDidRedirectToURL:")]
		void SafariViewController (SFSafariViewController controller, NSUrl URL);
	}

	// @interface STPSetupIntent : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments14STPSetupIntent")]
	[DisableDefaultCtor]
	interface STPSetupIntent : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
		[Export ("stripeID")]
		string StripeID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull clientSecret;
		[Export ("clientSecret")]
		string ClientSecret { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
		[Export ("created", ArgumentSemantic.Copy)]
		NSDate Created { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customerID;
		[NullAllowed, Export ("customerID")]
		string CustomerID { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable stripeDescription;
		[NullAllowed, Export ("stripeDescription")]
		string StripeDescription { get; }

		// @property (readonly, nonatomic) BOOL livemode;
		[Export ("livemode")]
		bool Livemode { get; }

		// @property (readonly, nonatomic, strong) STPIntentAction * _Nullable nextAction;
		[NullAllowed, Export ("nextAction", ArgumentSemantic.Strong)]
		STPIntentAction NextAction { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable paymentMethodID;
		[NullAllowed, Export ("paymentMethodID")]
		string PaymentMethodID { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
		[NullAllowed, Export ("paymentMethod", ArgumentSemantic.Strong)]
		STPPaymentMethod PaymentMethod { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull paymentMethodTypes;
		[Export ("paymentMethodTypes", ArgumentSemantic.Copy)]
		NSNumber[] PaymentMethodTypes { get; }

		// @property (readonly, nonatomic) enum STPSetupIntentStatus status;
		[Export ("status")]
		STPSetupIntentStatus Status { get; }

		// @property (readonly, nonatomic) enum STPSetupIntentUsage usage;
		[Export ("usage")]
		STPSetupIntentUsage Usage { get; }

		// @property (readonly, nonatomic, strong) STPSetupIntentLastSetupError * _Nullable lastSetupError;
		[NullAllowed, Export ("lastSetupError", ArgumentSemantic.Strong)]
		STPSetupIntentLastSetupError LastSetupError { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Metadata is not returned to clients using publishable keys. Retrieve them on your server using your secret key instead.") NSDictionary<NSString *,NSString *> * metadata __attribute__((deprecated("Metadata is not returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
		[Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Metadata { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(NSString * _Nullable)idFromClientSecret:(NSString * _Nonnull)clientSecret __attribute__((warn_unused_result("")));
		[Static]
		[Export ("idFromClientSecret:")]
		[return: NullAllowed]
		string IdFromClientSecret (string clientSecret);

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSetupIntent DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPSetupIntentConfirmParams : NSObject <NSCopying, STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments27STPSetupIntentConfirmParams")]
	[DisableDefaultCtor]
	interface STPSetupIntentConfirmParams : INSCopying, STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// -(instancetype _Nonnull)initWithClientSecret:(NSString * _Nonnull)clientSecret __attribute__((objc_designated_initializer));
		[Export ("initWithClientSecret:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string clientSecret);

		// -(instancetype _Nonnull)initWithClientSecret:(NSString * _Nonnull)clientSecret paymentMethodType:(enum STPPaymentMethodType)paymentMethodType __attribute__((objc_designated_initializer));
		[Export ("initWithClientSecret:paymentMethodType:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string clientSecret, STPPaymentMethodType paymentMethodType);

		// @property (copy, nonatomic) NSString * _Nonnull clientSecret;
		[Export ("clientSecret")]
		string ClientSecret { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodParams * _Nullable paymentMethodParams;
		[NullAllowed, Export ("paymentMethodParams", ArgumentSemantic.Strong)]
		STPPaymentMethodParams PaymentMethodParams { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable paymentMethodID;
		[NullAllowed, Export ("paymentMethodID")]
		string PaymentMethodID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable returnURL;
		[NullAllowed, Export ("returnURL")]
		string ReturnURL { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable useStripeSDK;
		[NullAllowed, Export ("useStripeSDK", ArgumentSemantic.Strong)]
		NSNumber UseStripeSDK { get; set; }

		// @property (nonatomic, strong) STPMandateDataParams * _Nullable mandateData;
		[NullAllowed, Export ("mandateData", ArgumentSemantic.Strong)]
		STPMandateDataParams MandateData { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
	}

	// @interface STPSetupIntentLastSetupError : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPSetupIntentLastSetupError")]
	[DisableDefaultCtor]
	partial interface STPSetupIntentLastSetupError : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable code;
		[NullAllowed, Export ("code")]
		string Code { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable declineCode;
		[NullAllowed, Export ("declineCode")]
		string DeclineCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable docURL;
		[NullAllowed, Export ("docURL")]
		string DocURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable message;
		[NullAllowed, Export ("message")]
		string Message { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable param;
		[NullAllowed, Export ("param")]
		string Param { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
		[NullAllowed, Export ("paymentMethod", ArgumentSemantic.Strong)]
		STPPaymentMethod PaymentMethod { get; }

		// @property (readonly, nonatomic) enum STPSetupIntentLastSetupErrorType type;
		[Export ("type")]
		STPSetupIntentLastSetupErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSetupIntentLastSetupError DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface StripePayments_Swift_5516 (STPSetupIntentLastSetupError)
	partial interface STPSetupIntentLastSetupError
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull CodeAuthenticationFailure;
		[Static]
		[Export ("CodeAuthenticationFailure")]
		string CodeAuthenticationFailure { get; }
	}

	// @interface STPSource : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments9STPSource")]
	[DisableDefaultCtor]
	interface STPSource : STPAPIResponseDecodable, STPSourceProtocol
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable amount;
		[NullAllowed, Export ("amount", ArgumentSemantic.Strong)]
		NSNumber Amount { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable clientSecret;
		[NullAllowed, Export ("clientSecret")]
		string ClientSecret { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable created;
		[NullAllowed, Export ("created", ArgumentSemantic.Copy)]
		NSDate Created { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable currency;
		[NullAllowed, Export ("currency")]
		string Currency { get; }

		// @property (readonly, nonatomic) enum STPSourceFlow flow;
		[Export ("flow")]
		STPSourceFlow Flow { get; }

		// @property (readonly, nonatomic) BOOL livemode;
		[Export ("livemode")]
		bool Livemode { get; }

		// @property (readonly, nonatomic, strong) STPSourceOwner * _Nullable owner;
		[NullAllowed, Export ("owner", ArgumentSemantic.Strong)]
		STPSourceOwner Owner { get; }

		// @property (readonly, nonatomic, strong) STPSourceReceiver * _Nullable receiver;
		[NullAllowed, Export ("receiver", ArgumentSemantic.Strong)]
		STPSourceReceiver Receiver { get; }

		// @property (readonly, nonatomic, strong) STPSourceRedirect * _Nullable redirect;
		[NullAllowed, Export ("redirect", ArgumentSemantic.Strong)]
		STPSourceRedirect Redirect { get; }

		// @property (readonly, nonatomic) enum STPSourceStatus status;
		[Export ("status")]
		STPSourceStatus Status { get; }

		// @property (readonly, nonatomic) enum STPSourceType type;
		[Export ("type")]
		STPSourceType Type { get; }

		// @property (readonly, nonatomic) enum STPSourceUsage usage;
		[Export ("usage")]
		STPSourceUsage Usage { get; }

		// @property (readonly, nonatomic, strong) STPSourceVerification * _Nullable verification;
		[NullAllowed, Export ("verification", ArgumentSemantic.Strong)]
		STPSourceVerification Verification { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable details;
		[NullAllowed, Export ("details", ArgumentSemantic.Copy)]
		NSDictionary Details { get; }

		// @property (readonly, nonatomic, strong) STPSourceCardDetails * _Nullable cardDetails;
		[NullAllowed, Export ("cardDetails", ArgumentSemantic.Strong)]
		STPSourceCardDetails CardDetails { get; }

		// @property (readonly, nonatomic, strong) STPSourceKlarnaDetails * _Nullable klarnaDetails;
		[NullAllowed, Export ("klarnaDetails", ArgumentSemantic.Strong)]
		STPSourceKlarnaDetails KlarnaDetails { get; }

		// @property (readonly, nonatomic, strong) STPSourceSEPADebitDetails * _Nullable sepaDebitDetails;
		[NullAllowed, Export ("sepaDebitDetails", ArgumentSemantic.Strong)]
		STPSourceSEPADebitDetails SepaDebitDetails { get; }

		// @property (readonly, nonatomic, strong) STPSourceWeChatPayDetails * _Nullable weChatPayDetails;
		[NullAllowed, Export ("weChatPayDetails", ArgumentSemantic.Strong)]
		STPSourceWeChatPayDetails WeChatPayDetails { get; }

		// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using yoursecret key instead.") NSDictionary<NSString *,NSString *> * metadata __attribute__((deprecated("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using yoursecret key instead.")));
		[Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Metadata { get; }

		// @property (copy, nonatomic) NSString * _Nonnull stripeID;
		[Export ("stripeID")]
		string StripeID { get; set; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSource DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPSourceCardDetails : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments20STPSourceCardDetails")]
	[DisableDefaultCtor]
	interface STPSourceCardDetails : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (readonly, nonatomic) NSUInteger expMonth;
		[Export ("expMonth")]
		nuint ExpMonth { get; }

		// @property (readonly, nonatomic) NSUInteger expYear;
		[Export ("expYear")]
		nuint ExpYear { get; }

		// @property (readonly, nonatomic) enum STPCardBrand brand;
		[Export ("brand")]
		STPCardBrand Brand { get; }

		// @property (readonly, nonatomic) enum STPCardFundingType funding;
		[Export ("funding")]
		STPCardFundingType Funding { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, nonatomic) enum STPSourceCard3DSecureStatus threeDSecure;
		[Export ("threeDSecure")]
		STPSourceCard3DSecureStatus ThreeDSecure { get; }

		// @property (readonly, nonatomic) BOOL isApplePayCard;
		[Export ("isApplePayCard")]
		bool IsApplePayCard { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSourceCardDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }
	}

	// @interface STPSourceKlarnaDetails : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPSourceKlarnaDetails")]
	[DisableDefaultCtor]
	interface STPSourceKlarnaDetails : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable clientToken;
		[NullAllowed, Export ("clientToken")]
		string ClientToken { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable purchaseCountry;
		[NullAllowed, Export ("purchaseCountry")]
		string PurchaseCountry { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSourceKlarnaDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPSourceOwner : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments14STPSourceOwner")]
	[DisableDefaultCtor]
	interface STPSourceOwner : STPAPIResponseDecodable
	{
		// @property (readonly, nonatomic, strong) STPAddress * _Nullable address;
		[NullAllowed, Export ("address", ArgumentSemantic.Strong)]
		STPAddress Address { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export ("email")]
		string Email { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export ("phone")]
		string Phone { get; }

		// @property (readonly, nonatomic, strong) STPAddress * _Nullable verifiedAddress;
		[NullAllowed, Export ("verifiedAddress", ArgumentSemantic.Strong)]
		STPAddress VerifiedAddress { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable verifiedEmail;
		[NullAllowed, Export ("verifiedEmail")]
		string VerifiedEmail { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable verifiedName;
		[NullAllowed, Export ("verifiedName")]
		string VerifiedName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable verifiedPhone;
		[NullAllowed, Export ("verifiedPhone")]
		string VerifiedPhone { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSourceOwner DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPSourceParams : NSObject <NSCopying, STPFormEncodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments15STPSourceParams")]
	partial interface STPSourceParams : INSCopying, STPFormEncodable
	{
		// @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
		[Export ("additionalAPIParameters", ArgumentSemantic.Copy)]
		NSDictionary AdditionalAPIParameters { get; set; }

		// @property (nonatomic) enum STPSourceType type;
		[Export ("type", ArgumentSemantic.Assign)]
		STPSourceType Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable rawTypeString;
		[NullAllowed, Export ("rawTypeString")]
		string RawTypeString { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable amount;
		[NullAllowed, Export ("amount", ArgumentSemantic.Strong)]
		NSNumber Amount { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable currency;
		[NullAllowed, Export ("currency")]
		string Currency { get; set; }

		// @property (nonatomic) enum STPSourceFlow flow;
		[Export ("flow", ArgumentSemantic.Assign)]
		STPSourceFlow Flow { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable owner;
		[NullAllowed, Export ("owner", ArgumentSemantic.Copy)]
		NSDictionary Owner { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nullable redirect;
		[NullAllowed, Export ("redirect", ArgumentSemantic.Copy)]
		NSDictionary Redirect { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable token;
		[NullAllowed, Export ("token")]
		string Token { get; set; }

		// @property (nonatomic) enum STPSourceUsage usage;
		[Export ("usage", ArgumentSemantic.Assign)]
		STPSourceUsage Usage { get; set; }
	}

	// @interface StripePayments_Swift_5812 (STPSourceParams)
	partial interface STPSourceParams
	{
		// +(STPSourceParams * _Nonnull)bancontactParamsWithAmount:(NSInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("bancontactParamsWithAmount:name:returnURL:statementDescriptor:")]
		STPSourceParams BancontactParamsWithAmount (nint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

		// +(STPSourceParams * _Nonnull)cardParamsWithCard:(STPCardParams * _Nonnull)card __attribute__((warn_unused_result("")));
		[Static]
		[Export ("cardParamsWithCard:")]
		STPSourceParams CardParamsWithCard (STPCardParams card);

		// +(STPSourceParams * _Nonnull)giropayParamsWithAmount:(NSInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("giropayParamsWithAmount:name:returnURL:statementDescriptor:")]
		STPSourceParams GiropayParamsWithAmount (nint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

		// +(STPSourceParams * _Nonnull)idealParamsWithAmount:(NSInteger)amount name:(NSString * _Nullable)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor bank:(NSString * _Nullable)bank __attribute__((warn_unused_result("")));
		[Static]
		[Export ("idealParamsWithAmount:name:returnURL:statementDescriptor:bank:")]
		STPSourceParams IdealParamsWithAmount (nint amount, [NullAllowed] string name, string returnURL, [NullAllowed] string statementDescriptor, [NullAllowed] string bank);

		// +(STPSourceParams * _Nonnull)sepaDebitParamsWithName:(NSString * _Nonnull)name iban:(NSString * _Nonnull)iban addressLine1:(NSString * _Nullable)addressLine1 city:(NSString * _Nullable)city postalCode:(NSString * _Nullable)postalCode country:(NSString * _Nullable)country __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sepaDebitParamsWithName:iban:addressLine1:city:postalCode:country:")]
		STPSourceParams SepaDebitParamsWithName (string name, string iban, [NullAllowed] string addressLine1, [NullAllowed] string city, [NullAllowed] string postalCode, [NullAllowed] string country);

		// +(STPSourceParams * _Nonnull)sofortParamsWithAmount:(NSInteger)amount returnURL:(NSString * _Nonnull)returnURL country:(NSString * _Nonnull)country statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sofortParamsWithAmount:returnURL:country:statementDescriptor:")]
		STPSourceParams SofortParamsWithAmount (nint amount, string returnURL, string country, [NullAllowed] string statementDescriptor);

		// +(STPSourceParams * _Nonnull)klarnaParamsWithReturnURL:(NSString * _Nonnull)returnURL currency:(NSString * _Nonnull)currency purchaseCountry:(NSString * _Nonnull)purchaseCountry items:(NSArray<STPKlarnaLineItem *> * _Nonnull)items customPaymentMethods:(NSArray<NSNumber *> * _Nonnull)customPaymentMethods billingAddress:(STPAddress * _Nullable)address billingFirstName:(NSString * _Nullable)firstName billingLastName:(NSString * _Nullable)lastName billingDOB:(STPDateOfBirth * _Nullable)dateOfBirth __attribute__((warn_unused_result("")));
		[Static]
		[Export ("klarnaParamsWithReturnURL:currency:purchaseCountry:items:customPaymentMethods:billingAddress:billingFirstName:billingLastName:billingDOB:")]
		STPSourceParams KlarnaParamsWithReturnURL (string returnURL, string currency, string purchaseCountry, STPKlarnaLineItem[] items, NSNumber[] customPaymentMethods, [NullAllowed] STPAddress address, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] STPDateOfBirth dateOfBirth);

		// +(STPSourceParams * _Nonnull)klarnaParamsWithReturnURL:(NSString * _Nonnull)returnURL currency:(NSString * _Nonnull)currency purchaseCountry:(NSString * _Nonnull)purchaseCountry items:(NSArray<STPKlarnaLineItem *> * _Nonnull)items customPaymentMethods:(NSArray<NSNumber *> * _Nonnull)customPaymentMethods __attribute__((warn_unused_result("")));
		[Static]
		[Export ("klarnaParamsWithReturnURL:currency:purchaseCountry:items:customPaymentMethods:")]
		STPSourceParams KlarnaParamsWithReturnURL (string returnURL, string currency, string purchaseCountry, STPKlarnaLineItem[] items, NSNumber[] customPaymentMethods);

		// +(STPSourceParams * _Nonnull)threeDSecureParamsWithAmount:(NSInteger)amount currency:(NSString * _Nonnull)currency returnURL:(NSString * _Nonnull)returnURL card:(NSString * _Nonnull)card __attribute__((warn_unused_result("")));
		[Static]
		[Export ("threeDSecureParamsWithAmount:currency:returnURL:card:")]
		STPSourceParams ThreeDSecureParamsWithAmount (nint amount, string currency, string returnURL, string card);

		// +(STPSourceParams * _Nonnull)alipayParamsWithAmount:(NSInteger)amount currency:(NSString * _Nonnull)currency returnURL:(NSString * _Nonnull)returnURL __attribute__((warn_unused_result("")));
		[Static]
		[Export ("alipayParamsWithAmount:currency:returnURL:")]
		STPSourceParams AlipayParamsWithAmount (nint amount, string currency, string returnURL);

		// +(STPSourceParams * _Nonnull)alipayReusableParamsWithCurrency:(NSString * _Nonnull)currency returnURL:(NSString * _Nonnull)returnURL __attribute__((warn_unused_result("")));
		[Static]
		[Export ("alipayReusableParamsWithCurrency:returnURL:")]
		STPSourceParams AlipayReusableParamsWithCurrency (string currency, string returnURL);

		// +(STPSourceParams * _Nonnull)p24ParamsWithAmount:(NSInteger)amount currency:(NSString * _Nonnull)currency email:(NSString * _Nonnull)email name:(NSString * _Nullable)name returnURL:(NSString * _Nonnull)returnURL __attribute__((warn_unused_result("")));
		[Static]
		[Export ("p24ParamsWithAmount:currency:email:name:returnURL:")]
		STPSourceParams P24ParamsWithAmount (nint amount, string currency, string email, [NullAllowed] string name, string returnURL);

		// +(STPSourceParams * _Nonnull)visaCheckoutParamsWithCallId:(NSString * _Nonnull)callId __attribute__((warn_unused_result("")));
		[Static]
		[Export ("visaCheckoutParamsWithCallId:")]
		STPSourceParams VisaCheckoutParamsWithCallId (string callId);

		// +(STPSourceParams * _Nonnull)masterpassParamsWithCartId:(NSString * _Nonnull)cartId transactionId:(NSString * _Nonnull)transactionId __attribute__((warn_unused_result("")));
		[Static]
		[Export ("masterpassParamsWithCartId:transactionId:")]
		STPSourceParams MasterpassParamsWithCartId (string cartId, string transactionId);

		// +(STPSourceParams * _Nonnull)epsParamsWithAmount:(NSInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("epsParamsWithAmount:name:returnURL:statementDescriptor:")]
		STPSourceParams EpsParamsWithAmount (nint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

		// +(STPSourceParams * _Nonnull)multibancoParamsWithAmount:(NSInteger)amount returnURL:(NSString * _Nonnull)returnURL email:(NSString * _Nonnull)email __attribute__((warn_unused_result("")));
		[Static]
		[Export ("multibancoParamsWithAmount:returnURL:email:")]
		STPSourceParams MultibancoParamsWithAmount (nint amount, string returnURL, string email);

		// +(STPSourceParams * _Nonnull)wechatPayParamsWithAmount:(NSInteger)amount currency:(NSString * _Nonnull)currency appId:(NSString * _Nonnull)appId statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
		[Static]
		[Export ("wechatPayParamsWithAmount:currency:appId:statementDescriptor:")]
		STPSourceParams WechatPayParamsWithAmount (nint amount, string currency, string appId, [NullAllowed] string statementDescriptor);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(NSDictionary * _Nonnull)redirectDictionaryWithMerchantNameIfNecessary __attribute__((warn_unused_result("")));
		[Export ("redirectDictionaryWithMerchantNameIfNecessary")]
		NSDictionary RedirectDictionaryWithMerchantNameIfNecessary { get; }

		// +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("rootObjectName")]
		string RootObjectName { get; }

		// +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
		[Static]
		[Export ("propertyNamesToFormFieldNamesMapping")]
		NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface STPSourceReceiver : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments17STPSourceReceiver")]
	[DisableDefaultCtor]
	interface STPSourceReceiver : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable address;
		[NullAllowed, Export ("address")]
		string Address { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable amountCharged;
		[NullAllowed, Export ("amountCharged", ArgumentSemantic.Strong)]
		NSNumber AmountCharged { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable amountReceived;
		[NullAllowed, Export ("amountReceived", ArgumentSemantic.Strong)]
		NSNumber AmountReceived { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable amountReturned;
		[NullAllowed, Export ("amountReturned", ArgumentSemantic.Strong)]
		NSNumber AmountReturned { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSourceReceiver DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPSourceRedirect : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments17STPSourceRedirect")]
	[DisableDefaultCtor]
	interface STPSourceRedirect : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSURL * _Nonnull returnURL;
		[Export ("returnURL", ArgumentSemantic.Copy)]
		NSUrl ReturnURL { get; }

		// @property (readonly, nonatomic) enum STPSourceRedirectStatus status;
		[Export ("status")]
		STPSourceRedirectStatus Status { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nonnull url;
		[Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSourceRedirect DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPSourceSEPADebitDetails : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPSourceSEPADebitDetails")]
	[DisableDefaultCtor]
	interface STPSourceSEPADebitDetails : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable last4;
		[NullAllowed, Export ("last4")]
		string Last4 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable bankCode;
		[NullAllowed, Export ("bankCode")]
		string BankCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
		[NullAllowed, Export ("fingerprint")]
		string Fingerprint { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable mandateReference;
		[NullAllowed, Export ("mandateReference")]
		string MandateReference { get; }

		// @property (readonly, copy, nonatomic) NSURL * _Nullable mandateURL;
		[NullAllowed, Export ("mandateURL", ArgumentSemantic.Copy)]
		NSUrl MandateURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSourceSEPADebitDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPSourceVerification : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments21STPSourceVerification")]
	[DisableDefaultCtor]
	interface STPSourceVerification : STPAPIResponseDecodable
	{
		// @property (readonly, nonatomic, strong) NSNumber * _Nullable attemptsRemaining;
		[NullAllowed, Export ("attemptsRemaining", ArgumentSemantic.Strong)]
		NSNumber AttemptsRemaining { get; }

		// @property (readonly, nonatomic) enum STPSourceVerificationStatus status;
		[Export ("status")]
		STPSourceVerificationStatus Status { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSourceVerification DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPSourceWeChatPayDetails : NSObject <STPAPIResponseDecodable>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPSourceWeChatPayDetails")]
	[DisableDefaultCtor]
	interface STPSourceWeChatPayDetails : STPAPIResponseDecodable
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable weChatAppURL;
		[NullAllowed, Export ("weChatAppURL")]
		string WeChatAppURL { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPSourceWeChatPayDetails DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface STPStringFromCardBrand : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments22STPStringFromCardBrand")]
	interface STPStringFromCardBrand
	{
	}

	// @interface STPThreeDSButtonCustomization : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments29STPThreeDSButtonCustomization")]
	[DisableDefaultCtor]
	interface STPThreeDSButtonCustomization
	{
		// +(STPThreeDSButtonCustomization * _Nonnull)defaultSettingsForButtonType:(enum STPThreeDSCustomizationButtonType)type __attribute__((warn_unused_result("")));
		[Static]
		[Export ("defaultSettingsForButtonType:")]
		STPThreeDSButtonCustomization DefaultSettingsForButtonType (STPThreeDSCustomizationButtonType type);

		// -(instancetype _Nonnull)initWithBackgroundColor:(UIColor * _Nonnull)backgroundColor cornerRadius:(CGFloat)cornerRadius __attribute__((objc_designated_initializer));
		[Export ("initWithBackgroundColor:cornerRadius:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UIColor backgroundColor, nfloat cornerRadius);

		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic) enum STPThreeDSButtonTitleStyle titleStyle;
		[Export ("titleStyle", ArgumentSemantic.Assign)]
		STPThreeDSButtonTitleStyle TitleStyle { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable font;
		[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }
	}

	// @interface STPThreeDSCustomizationSettings : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments31STPThreeDSCustomizationSettings")]
	interface STPThreeDSCustomizationSettings
	{
		// +(STPThreeDSCustomizationSettings * _Nonnull)defaultSettings __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use STPThreeDSCustomizationSettings() instead of STPThreeDSCustomizationSettings.defaultSettings().")));
		[Static]
		[Export ("defaultSettings")]
		STPThreeDSCustomizationSettings DefaultSettings { get; }

		// @property (nonatomic, strong) STPThreeDSUICustomization * _Nonnull uiCustomization;
		[Export ("uiCustomization", ArgumentSemantic.Strong)]
		STPThreeDSUICustomization UiCustomization { get; set; }

		// @property (nonatomic) NSInteger authenticationTimeout;
		[Export ("authenticationTimeout")]
		nint AuthenticationTimeout { get; set; }
	}

	// @interface STPThreeDSFooterCustomization : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments29STPThreeDSFooterCustomization")]
	interface STPThreeDSFooterCustomization
	{
		// +(STPThreeDSFooterCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
		[Static]
		[Export ("defaultSettings")]
		STPThreeDSFooterCustomization DefaultSettings { get; }

		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull chevronColor;
		[Export ("chevronColor", ArgumentSemantic.Strong)]
		UIColor ChevronColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull headingTextColor;
		[Export ("headingTextColor", ArgumentSemantic.Strong)]
		UIColor HeadingTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull headingFont;
		[Export ("headingFont", ArgumentSemantic.Strong)]
		UIFont HeadingFont { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable font;
		[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }
	}

	// @interface STPThreeDSLabelCustomization : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments28STPThreeDSLabelCustomization")]
	interface STPThreeDSLabelCustomization
	{
		// +(STPThreeDSLabelCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
		[Static]
		[Export ("defaultSettings")]
		STPThreeDSLabelCustomization DefaultSettings { get; }

		// @property (nonatomic, strong) UIFont * _Nonnull headingFont;
		[Export ("headingFont", ArgumentSemantic.Strong)]
		UIFont HeadingFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull headingTextColor;
		[Export ("headingTextColor", ArgumentSemantic.Strong)]
		UIColor HeadingTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable font;
		[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }
	}

	// @interface STPThreeDSNavigationBarCustomization : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments36STPThreeDSNavigationBarCustomization")]
	interface STPThreeDSNavigationBarCustomization
	{
		// +(STPThreeDSNavigationBarCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
		[Static]
		[Export ("defaultSettings")]
		STPThreeDSNavigationBarCustomization DefaultSettings { get; }

		// @property (nonatomic, strong) UIColor * _Nullable barTintColor;
		[NullAllowed, Export ("barTintColor", ArgumentSemantic.Strong)]
		UIColor BarTintColor { get; set; }

		// @property (nonatomic) UIBarStyle barStyle;
		[Export ("barStyle", ArgumentSemantic.Assign)]
		UIBarStyle BarStyle { get; set; }

		// @property (nonatomic) BOOL translucent;
		[Export ("translucent")]
		bool Translucent { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull headerText;
		[Export ("headerText")]
		string HeaderText { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull buttonText;
		[Export ("buttonText")]
		string ButtonText { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable font;
		[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }
	}

	// @interface STPThreeDSSelectionCustomization : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPThreeDSSelectionCustomization")]
	interface STPThreeDSSelectionCustomization
	{
		// +(STPThreeDSSelectionCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
		[Static]
		[Export ("defaultSettings")]
		STPThreeDSSelectionCustomization DefaultSettings { get; }

		// @property (nonatomic, strong) UIColor * _Nonnull primarySelectedColor;
		[Export ("primarySelectedColor", ArgumentSemantic.Strong)]
		UIColor PrimarySelectedColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull secondarySelectedColor;
		[Export ("secondarySelectedColor", ArgumentSemantic.Strong)]
		UIColor SecondarySelectedColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull unselectedBackgroundColor;
		[Export ("unselectedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor UnselectedBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull unselectedBorderColor;
		[Export ("unselectedBorderColor", ArgumentSemantic.Strong)]
		UIColor UnselectedBorderColor { get; set; }
	}

	// @interface STPThreeDSTextFieldCustomization : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments32STPThreeDSTextFieldCustomization")]
	interface STPThreeDSTextFieldCustomization
	{
		// +(STPThreeDSTextFieldCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
		[Static]
		[Export ("defaultSettings")]
		STPThreeDSTextFieldCustomization DefaultSettings { get; }

		// @property (nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull borderColor;
		[Export ("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic) UIKeyboardAppearance keyboardAppearance;
		[Export ("keyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance KeyboardAppearance { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull placeholderTextColor;
		[Export ("placeholderTextColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderTextColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable font;
		[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }
	}

	// @interface STPThreeDSUICustomization : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments25STPThreeDSUICustomization")]
	interface STPThreeDSUICustomization
	{
		// +(STPThreeDSUICustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
		[Static]
		[Export ("defaultSettings")]
		STPThreeDSUICustomization DefaultSettings { get; }

		// @property (nonatomic, strong) STPThreeDSNavigationBarCustomization * _Nonnull navigationBarCustomization;
		[Export ("navigationBarCustomization", ArgumentSemantic.Strong)]
		STPThreeDSNavigationBarCustomization NavigationBarCustomization { get; set; }

		// @property (nonatomic, strong) STPThreeDSLabelCustomization * _Nonnull labelCustomization;
		[Export ("labelCustomization", ArgumentSemantic.Strong)]
		STPThreeDSLabelCustomization LabelCustomization { get; set; }

		// @property (nonatomic, strong) STPThreeDSTextFieldCustomization * _Nonnull textFieldCustomization;
		[Export ("textFieldCustomization", ArgumentSemantic.Strong)]
		STPThreeDSTextFieldCustomization TextFieldCustomization { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) STPThreeDSFooterCustomization * _Nonnull footerCustomization;
		[Export ("footerCustomization", ArgumentSemantic.Strong)]
		STPThreeDSFooterCustomization FooterCustomization { get; set; }

		// -(void)setButtonCustomization:(STPThreeDSButtonCustomization * _Nonnull)buttonCustomization forType:(enum STPThreeDSCustomizationButtonType)buttonType;
		[Export ("setButtonCustomization:forType:")]
		void SetButtonCustomization (STPThreeDSButtonCustomization buttonCustomization, STPThreeDSCustomizationButtonType buttonType);

		// -(STPThreeDSButtonCustomization * _Nonnull)buttonCustomizationForButtonType:(enum STPThreeDSCustomizationButtonType)buttonType __attribute__((warn_unused_result("")));
		[Export ("buttonCustomizationForButtonType:")]
		STPThreeDSButtonCustomization ButtonCustomizationForButtonType (STPThreeDSCustomizationButtonType buttonType);

		// @property (nonatomic, strong) STPThreeDSSelectionCustomization * _Nonnull selectionCustomization;
		[Export ("selectionCustomization", ArgumentSemantic.Strong)]
		STPThreeDSSelectionCustomization SelectionCustomization { get; set; }

		// @property (nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
		[Export ("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
		UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }

		// @property (nonatomic) UIBlurEffectStyle blurStyle;
		[Export ("blurStyle", ArgumentSemantic.Assign)]
		UIBlurEffectStyle BlurStyle { get; set; }
	}

	// @interface STPToken : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
	[BaseType (typeof(NSObject), Name = "_TtC14StripePayments8STPToken")]
	[DisableDefaultCtor]
	interface STPToken : STPAPIResponseDecodable, STPSourceProtocol
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull tokenId;
		[Export ("tokenId")]
		string TokenId { get; }

		// @property (readonly, nonatomic) BOOL livemode;
		[Export ("livemode")]
		bool Livemode { get; }

		// @property (readonly, nonatomic) enum STPTokenType type;
		[Export ("type")]
		STPTokenType Type { get; }

		// @property (readonly, nonatomic, strong) STPCard * _Nullable card;
		[NullAllowed, Export ("card", ArgumentSemantic.Strong)]
		STPCard Card { get; }

		// @property (readonly, nonatomic, strong) STPBankAccount * _Nullable bankAccount;
		[NullAllowed, Export ("bankAccount", ArgumentSemantic.Strong)]
		STPBankAccount BankAccount { get; }

		// @property (readonly, copy, nonatomic) NSDate * _Nullable created;
		[NullAllowed, Export ("created", ArgumentSemantic.Copy)]
		NSDate Created { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
		[Export ("allResponseFields", ArgumentSemantic.Copy)]
		NSDictionary AllResponseFields { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
		[Export ("debugDescription")]
		string DebugDescription { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
		[Export ("stripeID")]
		string StripeID { get; }

		// +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
		[Static]
		[Export ("decodedObjectFromAPIResponse:")]
		[return: NullAllowed]
		STPToken DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);
	}

	// @interface StripePayments_Swift_6618
	interface StripePayments_Swift_6618
	{
		// +(PKPaymentRequest * _Nonnull)paymentRequestWithMerchantIdentifier:(NSString * _Nonnull)merchantIdentifier __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `paymentRequestWithMerchantIdentifier:country:currency:` instead.")));
		[Static]
		[Export ("paymentRequestWithMerchantIdentifier:")]
		PKPaymentRequest PaymentRequestWithMerchantIdentifier (string merchantIdentifier);
	}
}
