using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Stripe3DS2
{
	[Native]
	public enum STDSACSStatusType : long
	{
		Unknown = 0,
		Authenticated = 1,
		ChallengeRequired = 2,
		DecoupledAuthentication = 3,
		NotAuthenticated = 4,
		ProofGenerated = 5,
		Error = 6,
		Rejected = 7,
		InformationalOnly = 8
	}

	[Native]
	public enum STDSUICustomizationButtonType : long
	{
		Submit = 0,
		Continue = 1,
		Next = 2,
		Cancel = 3,
		Resend = 4
	}

	[Native]
	public enum STDSButtonTitleStyle : long
	{
		Default,
		Uppercase,
		Lowercase,
		SentenceCapitalized
	}

	[Native]
	public enum STDSErrorMessageCode : long
	{
		CodeInvalidMessage = 101,
		CodeRequiredDataElementMissing = 201,
		CodeUnrecognizedCriticalMessageExtension = 202,
		ErrorInvalidDataElement = 203,
		ErrorTransactionIDNotRecognized = 301,
		ErrorDataDecryptionFailure = 302,
		ErrorTimeout = 402
	}

	[Native]
	public enum STDSErrorCode : long
	{
		AssertionFailed = 204,
		JSONFieldInvalid = 203,
		JSONFieldMissing = 201,
		UnrecognizedCriticalMessageExtension = 202,
		DecryptionVerification = 302,
		RuntimeParsing = 400,
		RuntimeEncryption = 401,
		ReceivedErrorMessage = 1000,
		UnknownMessageType = 1001,
		Timeout = 1002,
		UnknownError = 2000
	}

	[Native]
	public enum STDSWarningSeverity : long
	{
		Low = 0,
		Medium,
		High
	}
}
