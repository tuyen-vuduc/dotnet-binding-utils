using Foundation;

namespace StripeCardScan
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double StripeCardScanVersionNumber;
		[Field ("StripeCardScanVersionNumber", "__Internal")]
		double StripeCardScanVersionNumber { get; }

		// extern const unsigned char[] StripeCardScanVersionString;
		[Field ("StripeCardScanVersionString", "__Internal")]
		byte[] StripeCardScanVersionString { get; }
	}
}
