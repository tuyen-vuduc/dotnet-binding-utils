using System;
using Foundation;
using ObjCRuntime;
using Stripe3DS2;
using UIKit;

namespace Stripe3DS2
{
	// @interface STDSException : NSException
	[BaseType (typeof(NSException))]
	interface STDSException
	{
		// @property (readonly, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface STDSAlreadyInitializedException : STDSException
	[BaseType (typeof(STDSException))]
	interface STDSAlreadyInitializedException
	{
	}

	// @protocol STDSJSONEncodable <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface STDSJSONEncodable
	{
		// @required +(NSDictionary * _Nonnull)propertyNamesToJSONKeysMapping;
		[Static, Abstract]
		[Export ("propertyNamesToJSONKeysMapping")]
		[Verify (MethodToProperty)]
		NSDictionary PropertyNamesToJSONKeysMapping { get; }
	}

	// @interface STDSAuthenticationRequestParameters : NSObject <STDSJSONEncodable>
	[BaseType (typeof(NSObject))]
	interface STDSAuthenticationRequestParameters : ISTDSJSONEncodable
	{
		// -(instancetype _Nonnull)initWithSDKTransactionIdentifier:(NSString * _Nonnull)sdkTransactionIdentifier deviceData:(NSString * _Nullable)deviceData sdkEphemeralPublicKey:(NSString * _Nonnull)sdkEphemeralPublicKey sdkAppIdentifier:(NSString * _Nonnull)sdkAppIdentifier sdkReferenceNumber:(NSString * _Nonnull)sdkReferenceNumber messageVersion:(NSString * _Nonnull)messageVersion;
		[Export ("initWithSDKTransactionIdentifier:deviceData:sdkEphemeralPublicKey:sdkAppIdentifier:sdkReferenceNumber:messageVersion:")]
		NativeHandle Constructor (string sdkTransactionIdentifier, [NullAllowed] string deviceData, string sdkEphemeralPublicKey, string sdkAppIdentifier, string sdkReferenceNumber, string messageVersion);

		// @property (readonly, nonatomic) NSString * _Nullable deviceData;
		[NullAllowed, Export ("deviceData")]
		string DeviceData { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull sdkTransactionIdentifier;
		[Export ("sdkTransactionIdentifier")]
		string SdkTransactionIdentifier { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull sdkAppIdentifier;
		[Export ("sdkAppIdentifier")]
		string SdkAppIdentifier { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull sdkReferenceNumber;
		[Export ("sdkReferenceNumber")]
		string SdkReferenceNumber { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull sdkEphemeralPublicKey;
		[Export ("sdkEphemeralPublicKey")]
		string SdkEphemeralPublicKey { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull messageVersion;
		[Export ("messageVersion")]
		string MessageVersion { get; }
	}

	// @protocol STDSJSONDecodable <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface STDSJSONDecodable
	{
		// @required +(instancetype _Nullable)decodedObjectFromJSON:(NSDictionary * _Nullable)json error:(NSError * _Nullable * _Nullable)outError;
		[Static, Abstract]
		[Export ("decodedObjectFromJSON:error:")]
		[return: NullAllowed]
		STDSJSONDecodable Error ([NullAllowed] NSDictionary json, [NullAllowed] out NSError outError);
	}

	// @protocol STDSAuthenticationResponse <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface STDSAuthenticationResponse
	{
		// @required @property (readonly, nonatomic) NSString * _Nonnull threeDSServerTransactionID;
		[Abstract]
		[Export ("threeDSServerTransactionID")]
		string ThreeDSServerTransactionID { get; }

		// @required @property (readonly, nonatomic) STDSACSStatusType status;
		[Abstract]
		[Export ("status")]
		STDSACSStatusType Status { get; }

		// @required @property (readonly, getter = isChallengeRequired, nonatomic) BOOL challengeRequired;
		[Abstract]
		[Export ("challengeRequired")]
		bool ChallengeRequired { [Bind ("isChallengeRequired")] get; }

		// @required @property (readonly, nonatomic) BOOL willUseDecoupledAuthentication;
		[Abstract]
		[Export ("willUseDecoupledAuthentication")]
		bool WillUseDecoupledAuthentication { get; }

		// @required @property (readonly, nonatomic) NSString * _Nullable acsOperatorID;
		[Abstract]
		[NullAllowed, Export ("acsOperatorID")]
		string AcsOperatorID { get; }

		// @required @property (readonly, nonatomic) NSString * _Nullable acsReferenceNumber;
		[Abstract]
		[NullAllowed, Export ("acsReferenceNumber")]
		string AcsReferenceNumber { get; }

		// @required @property (readonly, nonatomic) NSString * _Nullable acsSignedContent;
		[Abstract]
		[NullAllowed, Export ("acsSignedContent")]
		string AcsSignedContent { get; }

		// @required @property (readonly, nonatomic) NSString * _Nonnull acsTransactionID;
		[Abstract]
		[Export ("acsTransactionID")]
		string AcsTransactionID { get; }

		// @required @property (readonly, nonatomic) NSURL * _Nullable acsURL;
		[Abstract]
		[NullAllowed, Export ("acsURL")]
		NSUrl AcsURL { get; }

		// @required @property (readonly, nonatomic) NSString * _Nullable cardholderInfo;
		[Abstract]
		[NullAllowed, Export ("cardholderInfo")]
		string CardholderInfo { get; }

		// @required @property (readonly, nonatomic) NSString * _Nullable directoryServerReferenceNumber;
		[Abstract]
		[NullAllowed, Export ("directoryServerReferenceNumber")]
		string DirectoryServerReferenceNumber { get; }

		// @required @property (readonly, nonatomic) NSString * _Nullable directoryServerTransactionID;
		[Abstract]
		[NullAllowed, Export ("directoryServerTransactionID")]
		string DirectoryServerTransactionID { get; }

		// @required @property (readonly, nonatomic) NSString * _Nonnull protocolVersion;
		[Abstract]
		[Export ("protocolVersion")]
		string ProtocolVersion { get; }

		// @required @property (readonly, nonatomic) NSString * _Nonnull sdkTransactionID;
		[Abstract]
		[Export ("sdkTransactionID")]
		string SdkTransactionID { get; }
	}

	// @interface STDSCustomization : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface STDSCustomization : INSCopying
	{
		// @property (nonatomic) UIFont * _Nullable font;
		[NullAllowed, Export ("font", ArgumentSemantic.Assign)]
		UIFont Font { get; set; }

		// @property (nonatomic) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Assign)]
		UIColor TextColor { get; set; }
	}

	// @interface STDSButtonCustomization : STDSCustomization
	[BaseType (typeof(STDSCustomization))]
	[DisableDefaultCtor]
	interface STDSButtonCustomization
	{
		// +(instancetype _Nonnull)defaultSettingsForButtonType:(STDSUICustomizationButtonType)type;
		[Static]
		[Export ("defaultSettingsForButtonType:")]
		STDSButtonCustomization DefaultSettingsForButtonType (STDSUICustomizationButtonType type);

		// -(instancetype _Nonnull)initWithBackgroundColor:(UIColor * _Nonnull)backgroundColor cornerRadius:(CGFloat)cornerRadius;
		[Export ("initWithBackgroundColor:cornerRadius:")]
		NativeHandle Constructor (UIColor backgroundColor, nfloat cornerRadius);

		// @property (nonatomic) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Assign)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic) STDSButtonTitleStyle titleStyle;
		[Export ("titleStyle", ArgumentSemantic.Assign)]
		STDSButtonTitleStyle TitleStyle { get; set; }
	}

	// @interface STDSChallengeParameters : NSObject
	[BaseType (typeof(NSObject))]
	interface STDSChallengeParameters
	{
		// -(instancetype _Nonnull)initWithAuthenticationResponse:(id<STDSAuthenticationResponse> _Nonnull)authResponse;
		[Export ("initWithAuthenticationResponse:")]
		NativeHandle Constructor (STDSAuthenticationResponse authResponse);

		// @property (copy, nonatomic) NSString * _Nonnull threeDSServerTransactionID;
		[Export ("threeDSServerTransactionID")]
		string ThreeDSServerTransactionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull acsTransactionID;
		[Export ("acsTransactionID")]
		string AcsTransactionID { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull acsReferenceNumber;
		[Export ("acsReferenceNumber")]
		string AcsReferenceNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull acsSignedContent;
		[Export ("acsSignedContent")]
		string AcsSignedContent { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable threeDSRequestorAppURL;
		[NullAllowed, Export ("threeDSRequestorAppURL")]
		string ThreeDSRequestorAppURL { get; set; }
	}

	// @protocol STDSChallengeStatusReceiver <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface STDSChallengeStatusReceiver
	{
		// @required -(void)transaction:(STDSTransaction * _Nonnull)transaction didCompleteChallengeWithCompletionEvent:(STDSCompletionEvent * _Nonnull)completionEvent;
		[Abstract]
		[Export ("transaction:didCompleteChallengeWithCompletionEvent:")]
		void Transaction (STDSTransaction transaction, STDSCompletionEvent completionEvent);

		// @required -(void)transactionDidCancel:(STDSTransaction * _Nonnull)transaction;
		[Abstract]
		[Export ("transactionDidCancel:")]
		void TransactionDidCancel (STDSTransaction transaction);

		// @required -(void)transactionDidTimeOut:(STDSTransaction * _Nonnull)transaction;
		[Abstract]
		[Export ("transactionDidTimeOut:")]
		void TransactionDidTimeOut (STDSTransaction transaction);

		// @required -(void)transaction:(STDSTransaction * _Nonnull)transaction didErrorWithProtocolErrorEvent:(STDSProtocolErrorEvent * _Nonnull)protocolErrorEvent;
		[Abstract]
		[Export ("transaction:didErrorWithProtocolErrorEvent:")]
		void Transaction (STDSTransaction transaction, STDSProtocolErrorEvent protocolErrorEvent);

		// @required -(void)transaction:(STDSTransaction * _Nonnull)transaction didErrorWithRuntimeErrorEvent:(STDSRuntimeErrorEvent * _Nonnull)runtimeErrorEvent;
		[Abstract]
		[Export ("transaction:didErrorWithRuntimeErrorEvent:")]
		void Transaction (STDSTransaction transaction, STDSRuntimeErrorEvent runtimeErrorEvent);

		// @optional -(void)transactionDidPresentChallengeScreen:(STDSTransaction * _Nonnull)transaction;
		[Export ("transactionDidPresentChallengeScreen:")]
		void TransactionDidPresentChallengeScreen (STDSTransaction transaction);

		// @optional -(void)dismissChallengeViewController:(UIViewController * _Nonnull)challengeViewController forTransaction:(STDSTransaction * _Nonnull)transaction;
		[Export ("dismissChallengeViewController:forTransaction:")]
		void DismissChallengeViewController (UIViewController challengeViewController, STDSTransaction transaction);
	}

	// @interface STDSCompletionEvent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STDSCompletionEvent
	{
		// -(instancetype _Nonnull)initWithSDKTransactionIdentifier:(NSString * _Nonnull)identifier transactionStatus:(NSString * _Nonnull)transactionStatus __attribute__((objc_designated_initializer));
		[Export ("initWithSDKTransactionIdentifier:transactionStatus:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string identifier, string transactionStatus);

		// @property (readonly, nonatomic) NSString * _Nonnull sdkTransactionIdentifier;
		[Export ("sdkTransactionIdentifier")]
		string SdkTransactionIdentifier { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull transactionStatus;
		[Export ("transactionStatus")]
		string TransactionStatus { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull kSTDSConfigDefaultGroupName;
		[Field ("kSTDSConfigDefaultGroupName", "__Internal")]
		NSString kSTDSConfigDefaultGroupName { get; }
	}

	// @interface STDSConfigParameters : NSObject
	[BaseType (typeof(NSObject))]
	interface STDSConfigParameters
	{
		// -(void)addParameterNamed:(NSString * _Nonnull)paramName withValue:(NSString * _Nonnull)paramValue toGroup:(NSString * _Nullable)paramGroup;
		[Export ("addParameterNamed:withValue:toGroup:")]
		void AddParameterNamed (string paramName, string paramValue, [NullAllowed] string paramGroup);

		// -(void)addParameterNamed:(NSString * _Nonnull)paramName withValue:(NSString * _Nonnull)paramValue;
		[Export ("addParameterNamed:withValue:")]
		void AddParameterNamed (string paramName, string paramValue);

		// -(NSString * _Nullable)parameterValue:(NSString * _Nonnull)paramName inGroup:(NSString * _Nullable)paramGroup;
		[Export ("parameterValue:inGroup:")]
		[return: NullAllowed]
		string ParameterValue (string paramName, [NullAllowed] string paramGroup);

		// -(NSString * _Nullable)parameterValue:(NSString * _Nonnull)paramName;
		[Export ("parameterValue:")]
		[return: NullAllowed]
		string ParameterValue (string paramName);

		// -(NSString * _Nullable)removeParameterNamed:(NSString * _Nonnull)paramName fromGroup:(NSString * _Nullable)paramGroup;
		[Export ("removeParameterNamed:fromGroup:")]
		[return: NullAllowed]
		string RemoveParameterNamed (string paramName, [NullAllowed] string paramGroup);

		// -(NSString * _Nullable)removeParameterNamed:(NSString * _Nonnull)paramName;
		[Export ("removeParameterNamed:")]
		[return: NullAllowed]
		string RemoveParameterNamed (string paramName);
	}

	// @interface STDSErrorMessage : NSObject <STDSJSONEncodable, STDSJSONDecodable>
	[BaseType (typeof(NSObject))]
	interface STDSErrorMessage : ISTDSJSONEncodable, ISTDSJSONDecodable
	{
		// -(instancetype _Nonnull)initWithErrorCode:(NSString * _Nonnull)errorCode errorComponent:(NSString * _Nonnull)errorComponent errorDescription:(NSString * _Nonnull)errorDescription errorDetails:(NSString * _Nullable)errorDetails messageVersion:(NSString * _Nonnull)messageVersion acsTransactionIdentifier:(NSString * _Nullable)acsTransactionIdentifier errorMessageType:(NSString * _Nonnull)errorMessageType;
		[Export ("initWithErrorCode:errorComponent:errorDescription:errorDetails:messageVersion:acsTransactionIdentifier:errorMessageType:")]
		NativeHandle Constructor (string errorCode, string errorComponent, string errorDescription, [NullAllowed] string errorDetails, string messageVersion, [NullAllowed] string acsTransactionIdentifier, string errorMessageType);

		// @property (readonly, nonatomic) NSString * _Nonnull errorCode;
		[Export ("errorCode")]
		string ErrorCode { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull errorComponent;
		[Export ("errorComponent")]
		string ErrorComponent { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull errorDescription;
		[Export ("errorDescription")]
		string ErrorDescription { get; }

		// @property (readonly, nonatomic) NSString * _Nullable errorDetails;
		[NullAllowed, Export ("errorDetails")]
		string ErrorDetails { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull messageVersion;
		[Export ("messageVersion")]
		string MessageVersion { get; }

		// @property (readonly, nonatomic) NSString * _Nullable acsTransactionIdentifier;
		[NullAllowed, Export ("acsTransactionIdentifier")]
		string AcsTransactionIdentifier { get; }

		// @property (readonly, nonatomic) NSString * _Nullable errorMessageType;
		[NullAllowed, Export ("errorMessageType")]
		string ErrorMessageType { get; }

		// -(NSError * _Nonnull)NSErrorValue;
		[Export ("NSErrorValue")]
		[Verify (MethodToProperty)]
		NSError NSErrorValue { get; }
	}

	// @interface STDSFooterCustomization : STDSCustomization
	[BaseType (typeof(STDSCustomization))]
	interface STDSFooterCustomization
	{
		// +(instancetype _Nonnull)defaultSettings;
		[Static]
		[Export ("defaultSettings")]
		STDSFooterCustomization DefaultSettings ();

		// @property (nonatomic) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Assign)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull chevronColor;
		[Export ("chevronColor", ArgumentSemantic.Assign)]
		UIColor ChevronColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull headingTextColor;
		[Export ("headingTextColor", ArgumentSemantic.Assign)]
		UIColor HeadingTextColor { get; set; }

		// @property (nonatomic) UIFont * _Nonnull headingFont;
		[Export ("headingFont", ArgumentSemantic.Assign)]
		UIFont HeadingFont { get; set; }
	}

	// @interface STDSInvalidInputException : STDSException
	[BaseType (typeof(STDSException))]
	interface STDSInvalidInputException
	{
	}

	// @interface STDSJSONEncoder : NSObject
	[BaseType (typeof(NSObject))]
	interface STDSJSONEncoder
	{
		// +(NSDictionary * _Nonnull)dictionaryForObject:(NSObject<STDSJSONEncodable> * _Nonnull)object;
		[Static]
		[Export ("dictionaryForObject:")]
		NSDictionary DictionaryForObject (STDSJSONEncodable @object);
	}

	// @interface STDSLabelCustomization : STDSCustomization
	[BaseType (typeof(STDSCustomization))]
	interface STDSLabelCustomization
	{
		// +(instancetype _Nonnull)defaultSettings;
		[Static]
		[Export ("defaultSettings")]
		STDSLabelCustomization DefaultSettings ();

		// @property (nonatomic) UIColor * _Nonnull headingTextColor;
		[Export ("headingTextColor", ArgumentSemantic.Assign)]
		UIColor HeadingTextColor { get; set; }

		// @property (nonatomic) UIFont * _Nonnull headingFont;
		[Export ("headingFont", ArgumentSemantic.Assign)]
		UIFont HeadingFont { get; set; }
	}

	// @interface STDSNavigationBarCustomization : STDSCustomization
	[BaseType (typeof(STDSCustomization))]
	interface STDSNavigationBarCustomization
	{
		// +(instancetype _Nonnull)defaultSettings;
		[Static]
		[Export ("defaultSettings")]
		STDSNavigationBarCustomization DefaultSettings ();

		// @property (nonatomic) UIColor * _Nullable barTintColor;
		[NullAllowed, Export ("barTintColor", ArgumentSemantic.Assign)]
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
	}

	// @interface STDSNotInitializedException : STDSException
	[BaseType (typeof(STDSException))]
	interface STDSNotInitializedException
	{
	}

	// @interface STDSProtocolErrorEvent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STDSProtocolErrorEvent
	{
		// -(instancetype _Nonnull)initWithSDKTransactionIdentifier:(NSString * _Nonnull)identifier errorMessage:(STDSErrorMessage * _Nonnull)errorMessage;
		[Export ("initWithSDKTransactionIdentifier:errorMessage:")]
		NativeHandle Constructor (string identifier, STDSErrorMessage errorMessage);

		// @property (readonly, nonatomic) STDSErrorMessage * _Nonnull errorMessage;
		[Export ("errorMessage")]
		STDSErrorMessage ErrorMessage { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull sdkTransactionIdentifier;
		[Export ("sdkTransactionIdentifier")]
		string SdkTransactionIdentifier { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull kSTDSRuntimeErrorCodeParsingError;
		[Field ("kSTDSRuntimeErrorCodeParsingError", "__Internal")]
		NSString kSTDSRuntimeErrorCodeParsingError { get; }

		// extern NSString *const _Nonnull kSTDSRuntimeErrorCodeEncryptionError;
		[Field ("kSTDSRuntimeErrorCodeEncryptionError", "__Internal")]
		NSString kSTDSRuntimeErrorCodeEncryptionError { get; }
	}

	// @interface STDSRuntimeErrorEvent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STDSRuntimeErrorEvent
	{
		// @property (readonly, nonatomic) NSString * _Nonnull errorCode;
		[Export ("errorCode")]
		string ErrorCode { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull errorMessage;
		[Export ("errorMessage")]
		string ErrorMessage { get; }

		// -(instancetype _Nonnull)initWithErrorCode:(NSString * _Nonnull)errorCode errorMessage:(NSString * _Nonnull)errorMessage __attribute__((objc_designated_initializer));
		[Export ("initWithErrorCode:errorMessage:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string errorCode, string errorMessage);

		// -(NSError * _Nonnull)NSErrorValue;
		[Export ("NSErrorValue")]
		[Verify (MethodToProperty)]
		NSError NSErrorValue { get; }
	}

	// @interface STDSRuntimeException : STDSException
	[BaseType (typeof(STDSException))]
	interface STDSRuntimeException
	{
	}

	// @interface STDSSelectionCustomization : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface STDSSelectionCustomization : INSCopying
	{
		// +(instancetype _Nonnull)defaultSettings;
		[Static]
		[Export ("defaultSettings")]
		STDSSelectionCustomization DefaultSettings ();

		// @property (nonatomic) UIColor * _Nonnull primarySelectedColor;
		[Export ("primarySelectedColor", ArgumentSemantic.Assign)]
		UIColor PrimarySelectedColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull secondarySelectedColor;
		[Export ("secondarySelectedColor", ArgumentSemantic.Assign)]
		UIColor SecondarySelectedColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull unselectedBackgroundColor;
		[Export ("unselectedBackgroundColor", ArgumentSemantic.Assign)]
		UIColor UnselectedBackgroundColor { get; set; }

		// @property (nonatomic) UIColor * _Nonnull unselectedBorderColor;
		[Export ("unselectedBorderColor", ArgumentSemantic.Assign)]
		UIColor UnselectedBorderColor { get; set; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull STDSStripe3DS2ErrorDomain;
		[Field ("STDSStripe3DS2ErrorDomain", "__Internal")]
		NSString STDSStripe3DS2ErrorDomain { get; }

		// extern NSString *const _Nonnull STDSStripe3DS2ErrorMessageErrorKey;
		[Field ("STDSStripe3DS2ErrorMessageErrorKey", "__Internal")]
		NSString STDSStripe3DS2ErrorMessageErrorKey { get; }

		// extern NSString *const _Nonnull STDSStripe3DS2ErrorFieldKey;
		[Field ("STDSStripe3DS2ErrorFieldKey", "__Internal")]
		NSString STDSStripe3DS2ErrorFieldKey { get; }

		// extern NSString *const _Nonnull STDSStripe3DS2UnrecognizedCriticalMessageExtensionsKey;
		[Field ("STDSStripe3DS2UnrecognizedCriticalMessageExtensionsKey", "__Internal")]
		NSString STDSStripe3DS2UnrecognizedCriticalMessageExtensionsKey { get; }
	}

	// @interface STDSSwiftTryCatch : NSObject
	[BaseType (typeof(NSObject))]
	interface STDSSwiftTryCatch
	{
		// +(void)tryBlock:(void (^ _Nonnull)(void))tryBlock catchBlock:(void (^ _Nonnull)(NSException * _Nonnull))catchBlock finallyBlock:(void (^ _Nonnull)(void))finallyBlock;
		[Static]
		[Export ("tryBlock:catchBlock:finallyBlock:")]
		void TryBlock (Action tryBlock, Action<NSException> catchBlock, Action finallyBlock);

		// +(void)throwString:(NSString * _Nonnull)s;
		[Static]
		[Export ("throwString:")]
		void ThrowString (string s);

		// +(void)throwException:(NSException * _Nonnull)e;
		[Static]
		[Export ("throwException:")]
		void ThrowException (NSException e);
	}

	// @interface STDSTextFieldCustomization : STDSCustomization
	[BaseType (typeof(STDSCustomization))]
	interface STDSTextFieldCustomization
	{
		// +(instancetype _Nonnull)defaultSettings;
		[Static]
		[Export ("defaultSettings")]
		STDSTextFieldCustomization DefaultSettings ();

		// @property (nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (nonatomic) UIColor * _Nonnull borderColor;
		[Export ("borderColor", ArgumentSemantic.Assign)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic) UIKeyboardAppearance keyboardAppearance;
		[Export ("keyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance KeyboardAppearance { get; set; }

		// @property (nonatomic) UIColor * _Nonnull placeholderTextColor;
		[Export ("placeholderTextColor", ArgumentSemantic.Assign)]
		UIColor PlaceholderTextColor { get; set; }
	}

	// @interface STDSThreeDS2Service : NSObject
	[BaseType (typeof(NSObject))]
	interface STDSThreeDS2Service
	{
		// @property (readonly, nonatomic) NSArray<STDSWarning *> * _Nullable warnings;
		[NullAllowed, Export ("warnings")]
		STDSWarning[] Warnings { get; }

		// -(void)initializeWithConfig:(STDSConfigParameters * _Nonnull)config locale:(NSLocale * _Nullable)locale uiSettings:(STDSUICustomization * _Nullable)uiSettings;
		[Export ("initializeWithConfig:locale:uiSettings:")]
		void InitializeWithConfig (STDSConfigParameters config, [NullAllowed] NSLocale locale, [NullAllowed] STDSUICustomization uiSettings);

		// -(STDSTransaction * _Nonnull)createTransactionForDirectoryServer:(NSString * _Nonnull)directoryServerID withProtocolVersion:(NSString * _Nullable)protocolVersion;
		[Export ("createTransactionForDirectoryServer:withProtocolVersion:")]
		STDSTransaction CreateTransactionForDirectoryServer (string directoryServerID, [NullAllowed] string protocolVersion);

		// -(STDSTransaction * _Nullable)createTransactionForDirectoryServer:(NSString * _Nonnull)directoryServerID serverKeyID:(NSString * _Nullable)serverKeyID certificateString:(NSString * _Nonnull)certificateString rootCertificateStrings:(NSArray<NSString *> * _Nonnull)rootCertificateStrings withProtocolVersion:(NSString * _Nullable)protocolVersion;
		[Export ("createTransactionForDirectoryServer:serverKeyID:certificateString:rootCertificateStrings:withProtocolVersion:")]
		[return: NullAllowed]
		STDSTransaction CreateTransactionForDirectoryServer (string directoryServerID, [NullAllowed] string serverKeyID, string certificateString, string[] rootCertificateStrings, [NullAllowed] string protocolVersion);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull Stripe3DS2ProtocolVersion;
		[Field ("Stripe3DS2ProtocolVersion", "__Internal")]
		NSString Stripe3DS2ProtocolVersion { get; }
	}

	// typedef void (^STDSTransactionVoidBlock)();
	delegate void STDSTransactionVoidBlock ();

	// @interface STDSTransaction : NSObject
	[BaseType (typeof(NSObject))]
	interface STDSTransaction
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull presentedChallengeUIType;
		[Export ("presentedChallengeUIType")]
		string PresentedChallengeUIType { get; }

		// -(STDSAuthenticationRequestParameters * _Nonnull)createAuthenticationRequestParameters;
		[Export ("createAuthenticationRequestParameters")]
		[Verify (MethodToProperty)]
		STDSAuthenticationRequestParameters CreateAuthenticationRequestParameters { get; }

		// -(UIViewController * _Nonnull)createProgressViewControllerWithDidCancel:(STDSTransactionVoidBlock _Nonnull)didCancel;
		[Export ("createProgressViewControllerWithDidCancel:")]
		UIViewController CreateProgressViewControllerWithDidCancel (STDSTransactionVoidBlock didCancel);

		// -(void)doChallengeWithViewController:(UIViewController * _Nonnull)presentingViewController challengeParameters:(STDSChallengeParameters * _Nonnull)challengeParameters challengeStatusReceiver:(id _Nonnull)challengeStatusReceiver timeout:(NSTimeInterval)timeout;
		[Export ("doChallengeWithViewController:challengeParameters:challengeStatusReceiver:timeout:")]
		void DoChallengeWithViewController (UIViewController presentingViewController, STDSChallengeParameters challengeParameters, NSObject challengeStatusReceiver, double timeout);

		// -(NSString * _Nonnull)sdkVersion;
		[Export ("sdkVersion")]
		[Verify (MethodToProperty)]
		string SdkVersion { get; }

		// -(void)close;
		[Export ("close")]
		void Close ();

		// -(void)doChallengeWithChallengeParameters:(STDSChallengeParameters * _Nonnull)challengeParameters challengeStatusReceiver:(id _Nonnull)challengeStatusReceiver timeout:(NSTimeInterval)timeout presentationBlock:(void (^ _Nonnull)(UIViewController * _Nonnull, void (^ _Nonnull)(void)))presentationBlock;
		[Export ("doChallengeWithChallengeParameters:challengeStatusReceiver:timeout:presentationBlock:")]
		void DoChallengeWithChallengeParameters (STDSChallengeParameters challengeParameters, NSObject challengeStatusReceiver, double timeout, Action<UIViewController, Action> presentationBlock);

		// -(void)cancelChallengeFlow;
		[Export ("cancelChallengeFlow")]
		void CancelChallengeFlow ();
	}

	// @interface STDSUICustomization : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface STDSUICustomization : INSCopying
	{
		// +(instancetype _Nonnull)defaultSettings;
		[Static]
		[Export ("defaultSettings")]
		STDSUICustomization DefaultSettings ();

		// @property (nonatomic) STDSNavigationBarCustomization * _Nonnull navigationBarCustomization;
		[Export ("navigationBarCustomization", ArgumentSemantic.Assign)]
		STDSNavigationBarCustomization NavigationBarCustomization { get; set; }

		// @property (nonatomic) STDSLabelCustomization * _Nonnull labelCustomization;
		[Export ("labelCustomization", ArgumentSemantic.Assign)]
		STDSLabelCustomization LabelCustomization { get; set; }

		// @property (nonatomic) STDSTextFieldCustomization * _Nonnull textFieldCustomization;
		[Export ("textFieldCustomization", ArgumentSemantic.Assign)]
		STDSTextFieldCustomization TextFieldCustomization { get; set; }

		// @property (nonatomic) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Assign)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) STDSFooterCustomization * _Nonnull footerCustomization;
		[Export ("footerCustomization", ArgumentSemantic.Assign)]
		STDSFooterCustomization FooterCustomization { get; set; }

		// -(void)setButtonCustomization:(STDSButtonCustomization * _Nonnull)buttonCustomization forType:(STDSUICustomizationButtonType)buttonType;
		[Export ("setButtonCustomization:forType:")]
		void SetButtonCustomization (STDSButtonCustomization buttonCustomization, STDSUICustomizationButtonType buttonType);

		// -(STDSButtonCustomization * _Nonnull)buttonCustomizationForButtonType:(STDSUICustomizationButtonType)buttonType;
		[Export ("buttonCustomizationForButtonType:")]
		STDSButtonCustomization ButtonCustomizationForButtonType (STDSUICustomizationButtonType buttonType);

		// @property (nonatomic) STDSSelectionCustomization * _Nonnull selectionCustomization;
		[Export ("selectionCustomization", ArgumentSemantic.Assign)]
		STDSSelectionCustomization SelectionCustomization { get; set; }

		// @property (nonatomic) UIStatusBarStyle preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle", ArgumentSemantic.Assign)]
		UIStatusBarStyle PreferredStatusBarStyle { get; set; }

		// @property (nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
		[Export ("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
		UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }

		// @property (nonatomic) UIBlurEffectStyle blurStyle;
		[Export ("blurStyle", ArgumentSemantic.Assign)]
		UIBlurEffectStyle BlurStyle { get; set; }
	}

	// @interface STDSWarning : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STDSWarning
	{
		// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier message:(NSString * _Nonnull)message severity:(STDSWarningSeverity)severity __attribute__((objc_designated_initializer));
		[Export ("initWithIdentifier:message:severity:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string identifier, string message, STDSWarningSeverity severity);

		// @property (readonly, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }

		// @property (readonly, nonatomic) STDSWarningSeverity severity;
		[Export ("severity")]
		STDSWarningSeverity Severity { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double Stripe3DS2VersionNumber;
		[Field ("Stripe3DS2VersionNumber", "__Internal")]
		double Stripe3DS2VersionNumber { get; }

		// extern const unsigned char[] Stripe3DS2VersionString;
		[Field ("Stripe3DS2VersionString", "__Internal")]
		byte[] Stripe3DS2VersionString { get; }
	}
}
