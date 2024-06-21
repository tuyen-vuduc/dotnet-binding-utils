using System;
using Foundation;
using ObjCRuntime;
using PassKit;
using StripeCore;

namespace StripeCore
{
    // @interface StripeCore_Swift_319 (NSError)
    [BaseType(typeof(NSObject))]
    partial interface StripeErrors
    {
        // +(NSError * _Nullable)stp_errorFromStripeResponse:(NSDictionary * _Nullable)jsonDictionary __attribute__((warn_unused_result("")));
        [Static]
		[Export ("stp_errorFromStripeResponse:")]
		[return: NullAllowed]
		NSError Stp_errorFromStripeResponse ([NullAllowed] NSDictionary jsonDictionary);
	}

	// @interface StripeCore_Swift_332 (NSError)
	partial interface StripeErrors
	{
		// +(NSError * _Nonnull)stp_genericConnectionError __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_genericConnectionError")]
		NSError Stp_genericConnectionError ();

		// +(NSError * _Nonnull)stp_genericFailedToParseResponseError __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_genericFailedToParseResponseError")]
		NSError Stp_genericFailedToParseResponseError ();

		// +(NSError * _Nonnull)stp_ephemeralKeyDecodingError __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_ephemeralKeyDecodingError")]
		
		NSError Stp_ephemeralKeyDecodingError ();

		// +(NSError * _Nonnull)stp_clientSecretError __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_clientSecretError")]
		
		NSError Stp_clientSecretError ();

		// +(NSString * _Nonnull)stp_cardErrorInvalidNumberUserMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_cardErrorInvalidNumberUserMessage")]
		
		string Stp_cardErrorInvalidNumberUserMessage ();

		// +(NSString * _Nonnull)stp_cardInvalidCVCUserMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_cardInvalidCVCUserMessage")]
		
		string Stp_cardInvalidCVCUserMessage ();

		// +(NSString * _Nonnull)stp_cardErrorInvalidExpMonthUserMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_cardErrorInvalidExpMonthUserMessage")]
		
		string Stp_cardErrorInvalidExpMonthUserMessage ();

		// +(NSString * _Nonnull)stp_cardErrorInvalidExpYearUserMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_cardErrorInvalidExpYearUserMessage")]
		
		string Stp_cardErrorInvalidExpYearUserMessage ();

		// +(NSString * _Nonnull)stp_cardErrorExpiredCardUserMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_cardErrorExpiredCardUserMessage")]
		
		string Stp_cardErrorExpiredCardUserMessage ();

		// +(NSString * _Nonnull)stp_cardErrorDeclinedUserMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_cardErrorDeclinedUserMessage")]
		
		string Stp_cardErrorDeclinedUserMessage ();

		// +(NSString * _Nonnull)stp_genericDeclineErrorUserMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_genericDeclineErrorUserMessage")]
		
		string Stp_genericDeclineErrorUserMessage ();

		// +(NSString * _Nonnull)stp_cardErrorProcessingErrorUserMessage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("stp_cardErrorProcessingErrorUserMessage")]
		
		string Stp_cardErrorProcessingErrorUserMessage ();
	}

	// @interface STPAPIClient : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10StripeCore12STPAPIClient")]
	interface STPAPIClient
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull STPSDKVersion;
		[Static]
		[Export ("STPSDKVersion")]
		string STPSDKVersion { get; }

		// @property (readonly, nonatomic, strong, class) STPAPIClient * _Nonnull sharedClient;
		[Static]
		[Export ("sharedClient", ArgumentSemantic.Strong)]
		STPAPIClient SharedClient { get; }

		// @property (copy, nonatomic) NSString * _Nullable publishableKey;
		[NullAllowed, Export ("publishableKey")]
		string PublishableKey { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable stripeAccount;
		[NullAllowed, Export ("stripeAccount")]
		string StripeAccount { get; set; }

		// @property (nonatomic, strong) STPAppInfo * _Nullable appInfo;
		[NullAllowed, Export ("appInfo", ArgumentSemantic.Strong)]
		STPAppInfo AppInfo { get; set; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull apiVersion;
		[Static]
		[Export ("apiVersion")]
		string ApiVersion { get; }

		// -(instancetype _Nonnull)initWithPublishableKey:(NSString * _Nonnull)publishableKey;
		[Export ("initWithPublishableKey:")]
		NativeHandle Constructor (string publishableKey);
	}

	// @interface STPAnalyticsClient : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10StripeCore18STPAnalyticsClient")]
	interface STPAnalyticsClient
	{
		// @property (readonly, nonatomic, strong, class) STPAnalyticsClient * _Nonnull sharedClient;
		[Static]
		[Export ("sharedClient", ArgumentSemantic.Strong)]
		STPAnalyticsClient SharedClient { get; }

		// @property (copy, nonatomic) NSSet<NSString *> * _Nonnull productUsage;
		[Export ("productUsage", ArgumentSemantic.Copy)]
		NSSet<NSString> ProductUsage { get; set; }

		// +(NSString * _Nullable)tokenTypeFromParameters:(NSDictionary * _Nonnull)parameters __attribute__((warn_unused_result("")));
		[Static]
		[Export ("tokenTypeFromParameters:")]
		[return: NullAllowed]
		string TokenTypeFromParameters (NSDictionary parameters);
	}

	// @interface STPAppInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10StripeCore10STPAppInfo")]
	[DisableDefaultCtor]
	interface STPAppInfo
	{
		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name partnerId:(NSString * _Nullable)partnerId version:(NSString * _Nullable)version url:(NSString * _Nullable)url __attribute__((objc_designated_initializer));
		[Export ("initWithName:partnerId:version:url:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, [NullAllowed] string partnerId, [NullAllowed] string version, [NullAllowed] string url);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable partnerId;
		[NullAllowed, Export ("partnerId")]
		string PartnerId { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable version;
		[NullAllowed, Export ("version")]
		string Version { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable url;
		[NullAllowed, Export ("url")]
		string Url { get; }
	}

	// @interface STPError : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10StripeCore8STPError")]
	partial interface STPError
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull stripeDomain;
		[Static]
		[Export ("stripeDomain")]
		string StripeDomain { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull STPPaymentHandlerErrorDomain;
		[Static]
		[Export ("STPPaymentHandlerErrorDomain")]
		string STPPaymentHandlerErrorDomain { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull errorMessageKey;
		[Static]
		[Export ("errorMessageKey")]
		string ErrorMessageKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull hintKey;
		[Static]
		[Export ("hintKey")]
		string HintKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull cardErrorCodeKey;
		[Static]
		[Export ("cardErrorCodeKey")]
		string CardErrorCodeKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull errorParameterKey;
		[Static]
		[Export ("errorParameterKey")]
		string ErrorParameterKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull stripeErrorCodeKey;
		[Static]
		[Export ("stripeErrorCodeKey")]
		string StripeErrorCodeKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull stripeErrorTypeKey;
		[Static]
		[Export ("stripeErrorTypeKey")]
		string StripeErrorTypeKey { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull stripeDeclineCodeKey;
		[Static]
		[Export ("stripeDeclineCodeKey")]
		string StripeDeclineCodeKey { get; }
	}

	// @interface StripeCore_Swift_482 (STPError)
	partial interface STPError
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull invalidNumber;
		[Static]
		[Export ("invalidNumber")]
		string InvalidNumber { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull invalidExpMonth;
		[Static]
		[Export ("invalidExpMonth")]
		string InvalidExpMonth { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull invalidExpYear;
		[Static]
		[Export ("invalidExpYear")]
		string InvalidExpYear { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull invalidCVC;
		[Static]
		[Export ("invalidCVC")]
		string InvalidCVC { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull incorrectNumber;
		[Static]
		[Export ("incorrectNumber")]
		string IncorrectNumber { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull expiredCard;
		[Static]
		[Export ("expiredCard")]
		string ExpiredCard { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull cardDeclined;
		[Static]
		[Export ("cardDeclined")]
		string CardDeclined { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull processingError;
		[Static]
		[Export ("processingError")]
		string ProcessingError { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull incorrectCVC;
		[Static]
		[Export ("incorrectCVC")]
		string IncorrectCVC { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull incorrectZip;
		[Static]
		[Export ("incorrectZip")]
		string IncorrectZip { get; }
	}

	// @interface STPNumericStringValidator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10StripeCore25STPNumericStringValidator")]
	interface STPNumericStringValidator
	{
	}

	// @interface STPTelemetryClient : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10StripeCore18STPTelemetryClient")]
	[DisableDefaultCtor]
	interface STPTelemetryClient
	{
	}

	// @interface STPURLCallbackHandler : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10StripeCore21STPURLCallbackHandler")]
	interface STPURLCallbackHandler
	{
		// +(STPURLCallbackHandler * _Nonnull)shared __attribute__((warn_unused_result("")));
		[Static]
		[Export ("shared")]
		STPURLCallbackHandler Shared { get; }

		// -(BOOL)handleURLCallback:(NSURL * _Nonnull)url;
		[Export ("handleURLCallback:")]
		bool HandleURLCallback (NSUrl url);

		// -(void)registerListener:(id<STPURLCallbackListener> _Nonnull)listener forURL:(NSURL * _Nonnull)url;
		[Export ("registerListener:forURL:")]
		void RegisterListener (ISTPURLCallbackListener listener, NSUrl url);

		// -(void)unregisterListener:(id<STPURLCallbackListener> _Nonnull)listener;
		[Export ("unregisterListener:")]
		void UnregisterListener (ISTPURLCallbackListener listener);
	}

	// @protocol STPURLCallbackListener <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ISTPURLCallbackListener { }

    [Protocol, Model]
	[BaseType (typeof(NSObject), Name = "_TtP10StripeCore22STPURLCallbackListener_")]
	interface STPURLCallbackListener
	{
		// @required -(BOOL)handleURLCallback:(NSURL * _Nonnull)url __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("handleURLCallback:")]
		bool HandleURLCallback (NSUrl url);
	}

	// @interface StripeAPI : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC10StripeCore9StripeAPI")]
	interface StripeAPI
	{
		// @property (copy, nonatomic, class) NSString * _Nullable defaultPublishableKey;
		[Static]
		[NullAllowed, Export ("defaultPublishableKey")]
		string DefaultPublishableKey { get; set; }

		// -(void)setDefaultPublishableKey:(NSString * _Nonnull)publishableKey;
		[Export ("setDefaultPublishableKey:")]
		void SetDefaultPublishableKey (string publishableKey);

		// @property (nonatomic, class) BOOL advancedFraudSignalsEnabled;
		[Static]
		[Export ("advancedFraudSignalsEnabled")]
		bool AdvancedFraudSignalsEnabled { get; set; }

		// @property (nonatomic, class) NSInteger maxRetries;
		[Static]
		[Export ("maxRetries")]
		nint MaxRetries { get; set; }

		// @property (nonatomic, class) BOOL jcbPaymentNetworkSupported;
		[Static]
		[Export ("jcbPaymentNetworkSupported")]
		bool JcbPaymentNetworkSupported { get; set; }

		// @property (copy, nonatomic, class) NSArray<PKPaymentNetwork> * _Nonnull additionalEnabledApplePayNetworks;
		[Static]
		[Export ("additionalEnabledApplePayNetworks", ArgumentSemantic.Copy)]
		string[] AdditionalEnabledApplePayNetworks { get; set; }

		// +(BOOL)canSubmitPaymentRequest:(PKPaymentRequest * _Nonnull)paymentRequest __attribute__((warn_unused_result("")));
		[Static]
		[Export ("canSubmitPaymentRequest:")]
		bool CanSubmitPaymentRequest (PKPaymentRequest paymentRequest);

		// +(BOOL)deviceSupportsApplePay __attribute__((warn_unused_result("")));
		[Static]
		[Export ("deviceSupportsApplePay")]
		bool DeviceSupportsApplePay { get; }

		// +(PKPaymentRequest * _Nonnull)paymentRequestWithMerchantIdentifier:(NSString * _Nonnull)merchantIdentifier country:(NSString * _Nonnull)countryCode currency:(NSString * _Nonnull)currencyCode __attribute__((warn_unused_result("")));
		[Static]
		[Export ("paymentRequestWithMerchantIdentifier:country:currency:")]
		PKPaymentRequest PaymentRequestWithMerchantIdentifier (string merchantIdentifier, string countryCode, string currencyCode);

		// +(BOOL)handleStripeURLCallbackWithURL:(NSURL * _Nonnull)url;
		[Static]
		[Export ("handleStripeURLCallbackWithURL:")]
		bool HandleStripeURLCallbackWithURL (NSUrl url);
	}
}
