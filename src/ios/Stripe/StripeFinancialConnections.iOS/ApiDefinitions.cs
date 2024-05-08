using Foundation;

namespace StripeFinancialConnections
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double StripeFinancialConnectionsVersionNumber;
		[Field ("StripeFinancialConnectionsVersionNumber", "__Internal")]
		double StripeFinancialConnectionsVersionNumber { get; }

		// extern const unsigned char[] StripeFinancialConnectionsVersionString;
		[Field ("StripeFinancialConnectionsVersionString", "__Internal")]
		byte[] StripeFinancialConnectionsVersionString { get; }
	}
}
