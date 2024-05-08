using Foundation;

namespace StripeIdentity
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double StripeIdentityVersionNumber;
		[Field ("StripeIdentityVersionNumber", "__Internal")]
		double StripeIdentityVersionNumber { get; }

		// extern const unsigned char[] StripeIdentityVersionString;
		[Field ("StripeIdentityVersionString", "__Internal")]
		byte[] StripeIdentityVersionString { get; }
	}
}
