using ObjCRuntime;

namespace StripePayments
{
	[Native]
	public enum STPBankAccountHolderType : long
	{
		Individual = 0,
		Company = 1
	}

	[Native]
	public enum STPBankAccountStatus : long
	{
		New = 0,
		Validated = 1,
		Verified = 2,
		VerificationFailed = 3,
		Errored = 4
	}

	[Native]
	public enum STPCardBrand : long
	{
		Visa = 0,
		Amex = 1,
		Mastercard = 2,
		Discover = 3,
		Jcb = 4,
		DinersClub = 5,
		UnionPay = 6,
		CartesBancaires = 7,
		Unknown = 8
	}

	[Native]
	public enum STPCardFundingType : long
	{
		Debit = 0,
		Credit = 1,
		Prepaid = 2,
		Other = 3
	}

	[Native]
	public enum STPCardValidationState : long
	{
		Valid = 0,
		Invalid = 1,
		Incomplete = 2
	}

	[Native]
	public enum STPCollectBankAccountError : long
	{
		FinancialConnectionsSDKNotLinked = 0,
		InvalidClientSecret = 1,
		UnexpectedError = 2
	}

	[Native]
	public enum STPConnectAccountBusinessType : long
	{
		Individual = 0,
		Company = 1,
		None = 2
	}

	[Native]
	public enum STPFPXBankBrand : long
	{
		Maybank2U = 0,
		Cimb = 1,
		PublicBank = 2,
		Rhb = 3,
		HongLeongBank = 4,
		Ambank = 5,
		AffinBank = 6,
		AllianceBank = 7,
		BankIslam = 8,
		BankMuamalat = 9,
		BankRakyat = 10,
		Bsn = 11,
		Hsbc = 12,
		Kfh = 13,
		Maybank2E = 14,
		Ocbc = 15,
		StandardChartered = 16,
		Uob = 17,
		Unknown = 18
	}

	[Native]
	public enum STPFilePurpose : long
	{
		IdentityDocument = 0,
		DisputeEvidence = 1,
		Unknown = 2
	}

	[Native]
	public enum STPIntentActionType : long
	{
		Unknown = 0,
		RedirectToURL = 1,
		UseStripeSDK = 2,
		OXXODisplayDetails = 3,
		AlipayHandleRedirect = 4,
		BLIKAuthorize = 5,
		WeChatPayRedirectToApp = 6,
		BoletoDisplayDetails = 7,
		VerifyWithMicrodeposits = 8,
		UpiAwaitNotification = 9,
		CashAppRedirectToApp = 10,
		PayNowDisplayQrCode = 11,
		KonbiniDisplayDetails = 12,
		PromptpayDisplayQrCode = 13,
		SwishHandleRedirect = 14
	}

	[Native]
	public enum STPKlarnaLineItemType : long
	{
		Sku = 0,
		Tax = 1,
		Shipping = 2
	}

	[Native]
	public enum STPKlarnaPaymentMethods : long
	{
		None = 0,
		PayIn4 = 1,
		Installments = 2,
		PayIn4OrInstallments = 3
	}

	[Native]
	public enum STPMandateCustomerAcceptanceType : long
	{
		nline = 0,
		ffline = 1
	}

	[Native]
	public enum STPMicrodepositType : long
	{
		Unknown = 0,
		Amounts = 1,
		DescriptorCode = 2
	}

	[Native]
	public enum STPPaymentHandlerActionStatus : long
	{
		Succeeded = 0,
		Canceled = 1,
		Failed = 2
	}

	[Native]
	public enum STPPaymentHandlerErrorCode : long
	{
		UnsupportedAuthenticationErrorCode = 0,
		RequiredAppNotAvailableErrorCode = 1,
		RequiresPaymentMethodErrorCode = 2,
		IntentStatusErrorCode = 3,
		TimedOutErrorCode = 4,
		Stripe3DS2ErrorCode = 5,
		NotAuthenticatedErrorCode = 6,
		NoConcurrentActionsErrorCode = 7,
		RequiresAuthenticationContextErrorCode = 8,
		PaymentErrorCode = 9,
		InvalidClientSecret = 10,
		MissingReturnURL = 11,
		UnexpectedErrorCode = 12
	}

	[Native]
	public enum STPPaymentIntentActionType : long
	{
		Unknown = 0,
		RedirectToURL = 1
	}

	[Native]
	public enum STPPaymentIntentCaptureMethod : long
	{
		Unknown = 0,
		Automatic = 1,
		Manual = 2
	}

	[Native]
	public enum STPPaymentIntentConfirmationMethod : long
	{
		Unknown = 0,
		Manual = 1,
		Automatic = 2
	}

	[Native]
	public enum STPPaymentIntentLastPaymentErrorType : long
	{
		Unknown = 0,
		APIConnection = 1,
		Api = 2,
		Authentication = 3,
		Card = 4,
		Idempotency = 5,
		InvalidRequest = 6,
		RateLimit = 7
	}

	[Native]
	public enum STPPaymentIntentSetupFutureUsage : long
	{
		Unknown = 0,
		None = 1,
		OnSession = 2,
		OffSession = 3
	}

	[Native]
	public enum STPPaymentIntentSourceActionType : long
	{
		Unknown = 0,
		AuthorizeWithURL = 1
	}

	[Native]
	public enum STPPaymentIntentStatus : long
	{
		Unknown = 0,
		RequiresPaymentMethod = 1,
		RequiresSource = 2,
		RequiresConfirmation = 3,
		RequiresAction = 4,
		RequiresSourceAction = 5,
		Processing = 6,
		Succeeded = 7,
		RequiresCapture = 8,
		Canceled = 9
	}

	[Native]
	public enum STPPaymentMethodCardCheckResult : long
	{
		Pass = 0,
		Failed = 1,
		Unavailable = 2,
		Unchecked = 3,
		Unknown = 4
	}

	[Native]
	public enum STPPaymentMethodCardWalletType : long
	{
		AmexExpressCheckout = 0,
		ApplePay = 1,
		GooglePay = 2,
		Masterpass = 3,
		SamsungPay = 4,
		VisaCheckout = 5,
		Link = 6,
		Unknown = 7
	}

	[Native]
	public enum STPPaymentMethodType : long
	{
		Card = 0,
		Alipay = 1,
		GrabPay = 2,
		iDEAL = 3,
		Fpx = 4,
		CardPresent = 5,
		SEPADebit = 6,
		AUBECSDebit = 7,
		BacsDebit = 8,
		Giropay = 9,
		Przelewy24 = 10,
		Eps = 11,
		Bancontact = 12,
		NetBanking = 13,
		Oxxo = 14,
		Sofort = 15,
		Upi = 16,
		PayPal = 17,
		AfterpayClearpay = 18,
		Blik = 19,
		WeChatPay = 20,
		Boleto = 21,
		Link = 22,
		Klarna = 23,
		LinkInstantDebit = 24,
		Affirm = 25,
		USBankAccount = 26,
		CashApp = 27,
		Paynow = 28,
		Zip = 29,
		RevolutPay = 30,
		AmazonPay = 31,
		Alma = 32,
		MobilePay = 33,
		Konbini = 34,
		PromptPay = 35,
		Swish = 36,
		Twint = 37,
		Unknown = 38
	}

	[Native]
	public enum STPPaymentMethodUSBankAccountHolderType : long
	{
		Unknown = 0,
		Individual = 1,
		Company = 2
	}

	[Native]
	public enum STPPaymentMethodUSBankAccountType : long
	{
		Unknown = 0,
		Checking = 1,
		Savings = 2
	}

	[Native]
	public enum STPPaymentStatus : long
	{
		Success = 0,
		Error = 1,
		UserCancellation = 2
	}

	[Native]
	public enum STPPinStatus : long
	{
		Success = 0,
		ErrorVerificationAlreadyRedeemed = 1,
		ErrorVerificationCodeIncorrect = 2,
		ErrorVerificationExpired = 3,
		ErrorVerificationTooManyAttempts = 4,
		EphemeralKeyError = 5,
		UnknownError = 6
	}

	[Native]
	public enum STPRedirectContextError : long
	{
		STPRedirectContextAppRedirectError = 0
	}

	[Native]
	public enum STPRedirectContextState : long
	{
		NotStarted = 0,
		InProgress = 1,
		Cancelled = 2,
		Completed = 3
	}

	[Native]
	public enum STPSetupIntentLastSetupErrorType : ulong
	{
		Unknown = 0,
		APIConnection = 1,
		Api = 2,
		Authentication = 3,
		Card = 4,
		Idempotency = 5,
		InvalidRequest = 6,
		RateLimit = 7
	}

	[Native]
	public enum STPSetupIntentStatus : long
	{
		Unknown = 0,
		RequiresPaymentMethod = 1,
		RequiresConfirmation = 2,
		RequiresAction = 3,
		Processing = 4,
		Succeeded = 5,
		Canceled = 6
	}

	[Native]
	public enum STPSetupIntentUsage : long
	{
		Unknown = 0,
		None = 1,
		OnSession = 2,
		OffSession = 3
	}

	[Native]
	public enum STPSourceCard3DSecureStatus : long
	{
		Required = 0,
		Optional = 1,
		NotSupported = 2,
		Recommended = 3,
		Unknown = 4
	}

	[Native]
	public enum STPSourceFlow : long
	{
		None = 0,
		Redirect = 1,
		CodeVerification = 2,
		Receiver = 3,
		Unknown = 4
	}

	[Native]
	public enum STPSourceRedirectStatus : long
	{
		Pending = 0,
		Succeeded = 1,
		Failed = 2,
		NotRequired = 3,
		Unknown = 4
	}

	[Native]
	public enum STPSourceStatus : long
	{
		Pending = 0,
		Chargeable = 1,
		Consumed = 2,
		Canceled = 3,
		Failed = 4,
		Unknown = 5
	}

	[Native]
	public enum STPSourceType : long
	{
		Bancontact = 0,
		Card = 1,
		Giropay = 2,
		iDEAL = 3,
		SEPADebit = 4,
		Sofort = 5,
		ThreeDSecure = 6,
		Alipay = 7,
		P24 = 8,
		Eps = 9,
		Multibanco = 10,
		WeChatPay = 11,
		Klarna = 12,
		Unknown = 13
	}

	[Native]
	public enum STPSourceUsage : long
	{
		Reusable = 0,
		SingleUse = 1,
		Unknown = 2
	}

	[Native]
	public enum STPSourceVerificationStatus : long
	{
		Pending = 0,
		Succeeded = 1,
		Failed = 2,
		Unknown = 3
	}

	[Native]
	public enum STPThreeDSButtonTitleStyle : long
	{
		Default = 0,
		Uppercase = 1,
		Lowercase = 2,
		SentenceCapitalized = 3
	}

	[Native]
	public enum STPThreeDSCustomizationButtonType : long
	{
		Submit = 0,
		Continue = 1,
		Next = 2,
		Cancel = 3,
		Resend = 4
	}

	[Native]
	public enum STPTokenType : long
	{
		Account = 0,
		BankAccount = 1,
		Card = 2,
		Pii = 3,
		CvcUpdate = 4
	}
}
