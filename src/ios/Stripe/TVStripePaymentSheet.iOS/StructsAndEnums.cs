using ObjCRuntime;

namespace TVStripePaymentSheet
{
	[Native]
	public enum TSPSBillingDetailsCollectionConfigurationAddressCollectionMode : long
	{
		Automatic = 0,
		Never = 1,
		Full = 2
	}

	[Native]
	public enum TSPSBillingDetailsCollectionConfigurationCollectionMode : long
	{
		Automatic = 0,
		Never = 1,
		Always = 2
	}

	[Native]
	public enum TSPSInitializationMode : long
	{
		PaymentIntentClientSecret = 0,
		SetupIntentClientSecret = 1,
		DeferredIntent = 2
	}

	[Native]
	public enum TSPSPaymentSheetResult : long
	{
		Completed = 0,
		Canceled = 1,
		Failed = 2
	}

	[Native]
	public enum TSPSSavePaymentMethodOptInBehavior : long
	{
		Automatic = 0,
		RequiresOptIn = 1,
		RequiresOptOut = 2
	}

	[Native]
	public enum TSPSUserInterfaceStyle : long
	{
		utomatic = 0,
		lwaysLight = 1,
		lwaysDark = 2
	}
}
