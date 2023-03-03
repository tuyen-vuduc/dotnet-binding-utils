using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AWSCore
{
	[Flags]
	[Native]
	public enum AWSDDLogFlag : ulong
	{
		Error = (1uL << 0),
		Warning = (1uL << 1),
		Info = (1uL << 2),
		Debug = (1uL << 3),
		Verbose = (1uL << 4)
	}

	[Native]
	public enum AWSDDLogLevel : ulong
	{
		Off = 0,
		Error = (AWSDDLogFlagError),
		Warning = (Error | AWSDDLogFlagWarning),
		Info = (Warning | AWSDDLogFlagInfo),
		Debug = (Info | AWSDDLogFlagDebug),
		Verbose = (Debug | AWSDDLogFlagVerbose),
		All = (9223372036854775807L * 2 + 1)
	}

	static class CFunctions
	{
		// extern NSString * _Nullable AWSDDExtractFileNameWithoutExtension (const char * _Nonnull filePath, BOOL copy);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern unsafe NSString AWSDDExtractFileNameWithoutExtension (sbyte* filePath, bool copy);

		// AWSDDColor * AWSDDMakeColor (CGFloat r, CGFloat g, CGFloat b);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern UIColor AWSDDMakeColor (nfloat r, nfloat g, nfloat b);

		// extern void awsmtl_loadMTLNSCoding ();
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void awsmtl_loadMTLNSCoding ();

		// extern BOOL AWSMTLEqualObjects (id obj1, id obj2);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern bool AWSMTLEqualObjects (NSObject obj1, NSObject obj2);

		// extern void awsmtl_loadMTLPredefinedTransformerAdditions ();
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void awsmtl_loadMTLPredefinedTransformerAdditions ();

		// extern void awsgzip_loadGZIP ();
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void awsgzip_loadGZIP ();
	}

	[Flags]
	[Native]
	public enum AWSDDLogMessageOptions : long
	{
		CopyFile = 1L << 0,
		CopyFunction = 1L << 1,
		DontCopyMessage = 1L << 2
	}

	[Native]
	public enum AWSRegionType : long
	{
		Unknown,
		USEast1,
		USEast2,
		USWest1,
		USWest2,
		EUWest1,
		EUWest2,
		EUCentral1,
		EUCentral2,
		APSoutheast1,
		APNortheast1,
		APNortheast2,
		APSoutheast2,
		APSoutheast3,
		APSoutheast4,
		APSouth1,
		APSouth2,
		SAEast1,
		CNNorth1,
		CACentral1,
		USGovWest1,
		CNNorthWest1,
		EUWest3,
		USGovEast1,
		EUNorth1,
		APEast1,
		MECentral1,
		MESouth1,
		AFSouth1,
		EUSouth1,
		EUSouth2
	}

	[Native]
	public enum AWSServiceType : long
	{
		Unknown,
		APIGateway,
		AutoScaling,
		CloudWatch,
		CognitoIdentity,
		CognitoIdentityProvider,
		CognitoSync,
		Comprehend,
		Connect,
		ConnectParticipant,
		DynamoDB,
		Ec2,
		ElasticLoadBalancing,
		IoT,
		IoTData,
		Firehose,
		Kinesis,
		KinesisVideo,
		KinesisVideoArchivedMedia,
		KinesisVideoSignaling,
		Kms,
		Lambda,
		LexRuntime,
		Logs,
		MachineLearning,
		MobileAnalytics,
		MobileTargeting,
		Polly,
		Rekognition,
		S3,
		SageMakerRuntime,
		Ses,
		SimpleDB,
		Sns,
		Sqs,
		Sts,
		Textract,
		Transcribe,
		TranscribeStreaming,
		Translate,
		Location,
		ChimeSDKMessaging,
		ChimeSDKIdentity
	}

	[Native]
	public enum AWSMTLModelEncodingBehavior : ulong
	{
		Excluded = 0,
		Unconditional,
		Conditional
	}

	[Native]
	public enum AWSNetworkingErrorType : long
	{
		Unknown,
		Cancelled,
		SessionInvalid
	}

	[Native]
	public enum AWSNetworkingRetryType : long
	{
		Unknown,
		ShouldNotRetry,
		ShouldRetry,
		ShouldRefreshCredentialsAndRetry,
		ShouldCorrectClockSkewAndRetry,
		ResetStreamAndRetry
	}

	[Native]
	public enum AWSHTTPMethod : long
	{
		Unknown,
		Get,
		Head,
		Post,
		Put,
		Patch,
		Delete
	}

	[Native]
	public enum AWSCognitoCredentialsProviderHelperErrorType : long
	{
		IdentityIsNil,
		TokenRefreshTimeout
	}

	[Native]
	public enum AWSCognitoCredentialsProviderErrorType : long
	{
		ErrorUnknown,
		IdentityIdIsNil,
		InvalidConfiguration,
		InvalidCognitoIdentityToken,
		CredentialsRefreshTimeout
	}

	[Native]
	public enum AWSServiceErrorType : long
	{
		Unknown,
		RequestTimeTooSkewed,
		InvalidSignatureException,
		SignatureDoesNotMatch,
		RequestExpired,
		AuthFailure,
		AccessDeniedException,
		UnrecognizedClientException,
		IncompleteSignature,
		InvalidClientTokenId,
		MissingAuthenticationToken,
		AccessDenied,
		ExpiredToken,
		InvalidAccessKeyId,
		InvalidToken,
		TokenRefreshRequired,
		AccessFailure,
		AuthMissingFailure,
		Throttling,
		ThrottlingException
	}

	[Native]
	public enum AWSLogLevel : long
	{
		Unknown = -1,
		None = 0,
		Error = 1,
		Warn = 2,
		Info = 3,
		Debug = 4,
		Verbose = 5
	}

	[Native]
	public enum AWSXMLDictionaryAttributesMode : long
	{
		Prefixed = 0,
		Dictionary,
		Unprefixed,
		Discard
	}

	[Native]
	public enum AWSXMLDictionaryNodeNameMode : long
	{
		RootOnly = 0,
		Always,
		Never
	}

	[Native]
	public enum AWSXMLBuilderErrorType : long
	{
		UnknownError = 900,
		DefinitionFileIsEmpty = 901,
		UndefinedXMLNamespace = 902,
		UndefinedActionRule = 903,
		MissingRequiredXMLElements = 904,
		InvalidXMLValue = 905,
		UnCatchedRuleTypeInDifinitionFile = 906
	}

	[Native]
	public enum AWSXMLParserErrorType : long
	{
		UnknownError,
		NoTypeDefinitionInRule,
		UnHandledType,
		UnExpectedType,
		DefinitionFileIsEmpty,
		UnexpectedXMLElement,
		XMLNameNotFoundInDefinition,
		MissingRequiredXMLElements,
		InvalidXMLValue
	}

	[Native]
	public enum AWSQueryParamBuilderErrorType : long
	{
		UnknownError,
		DefinitionFileIsEmpty,
		UndefinedActionRule,
		InternalError,
		InvalidParameter
	}

	[Native]
	public enum AWSEC2ParamBuilderErrorType : long
	{
		UnknownError,
		DefinitionFileIsEmpty,
		UndefinedActionRule,
		InternalError,
		InvalidParameter
	}

	[Native]
	public enum AWSJSONBuilderErrorType : long
	{
		UnknownError,
		DefinitionFileIsEmpty,
		UndefinedActionRule,
		InternalError,
		InvalidParameter
	}

	[Native]
	public enum AWSJSONParserErrorType : long
	{
		UnknownError,
		DefinitionFileIsEmpty,
		UndefinedActionRule,
		InternalError,
		InvalidParameter
	}

	[Native]
	public enum AWSTimestampSerializationError : long
	{
		AWSTimestampParserError
	}

	[Native]
	public enum AWSValidationErrorType : long
	{
		UnknownError,
		UnexpectedParameter,
		UnhandledType,
		MissingRequiredParameter,
		OutOfRangeParameter,
		InvalidStringParameter,
		UnexpectedStringParameter,
		InvalidParameterType,
		InvalidBase64Data,
		HeaderTargetInvalid,
		HeaderAPIActionIsUndefined,
		HeaderDefinitionFileIsNotFound,
		HeaderDefinitionFileIsEmpty,
		HeaderAPIActionIsInvalid,
		URIIsInvalid
	}

	[Native]
	public enum AWSUICKeyChainStoreErrorCode : long
	{
		AWSUICKeyChainStoreErrorInvalidArguments = 1
	}

	[Native]
	public enum AWSUICKeyChainStoreItemClass : long
	{
		GenericPassword = 1,
		InternetPassword
	}

	[Native]
	public enum AWSUICKeyChainStoreProtocolType : long
	{
		Ftp = 1,
		FTPAccount,
		Http,
		Irc,
		Nntp,
		Pop3,
		Smtp,
		Socks,
		Imap,
		Ldap,
		AppleTalk,
		Afp,
		Telnet,
		Ssh,
		Ftps,
		Https,
		HTTPProxy,
		HTTPSProxy,
		FTPProxy,
		Smb,
		Rtsp,
		RTSPProxy,
		Daap,
		Eppc,
		Nntps,
		Ldaps,
		TelnetS,
		Ircs,
		Pop3s
	}

	[Native]
	public enum AWSUICKeyChainStoreAuthenticationType : long
	{
		Ntlm = 1,
		Msn,
		Dpa,
		Rpa,
		HTTPBasic,
		HTTPDigest,
		HTMLForm,
		Default
	}

	[iOS (4,0)]
	[Native]
	public enum AWSUICKeyChainStoreAccessibility : long
	{
		WhenUnlocked = 1,
		AfterFirstUnlock,
		Always,
		WhenPasscodeSetThisDeviceOnly,
		WhenUnlockedThisDeviceOnly,
		AfterFirstUnlockThisDeviceOnly,
		AlwaysThisDeviceOnly
	}

	[Native]
	public enum AWSUICKeyChainStoreAuthenticationPolicy : long
	{
		AWSUICKeyChainStoreAuthenticationPolicyUserPresence = kSecAccessControlUserPresence
	}

	[Native]
	public enum AWSSTSErrorType : long
	{
		Unknown,
		ExpiredToken,
		IDPCommunicationError,
		IDPRejectedClaim,
		InvalidAuthorizationMessage,
		InvalidIdentityToken,
		MalformedPolicyDocument,
		PackedPolicyTooLarge,
		RegionDisabled
	}

	[Native]
	public enum AWSCognitoIdentityErrorType : long
	{
		Unknown,
		ConcurrentModification,
		DeveloperUserAlreadyRegistered,
		ExternalService,
		InternalError,
		InvalidIdentityPoolConfiguration,
		InvalidParameter,
		LimitExceeded,
		NotAuthorized,
		ResourceConflict,
		ResourceNotFound,
		TooManyRequests
	}

	[Native]
	public enum AWSCognitoIdentityAmbiguousRoleResolutionType : long
	{
		Unknown,
		AuthenticatedRole,
		Deny
	}

	[Native]
	public enum AWSCognitoIdentityErrorCode : long
	{
		Unknown,
		AccessDenied,
		InternalServerError
	}

	[Native]
	public enum AWSCognitoIdentityMappingRuleMatchType : long
	{
		Unknown,
		Equals,
		Contains,
		StartsWith,
		NotEqual
	}

	[Native]
	public enum AWSCognitoIdentityRoleMappingType : long
	{
		Unknown,
		Token,
		Rules
	}
}
