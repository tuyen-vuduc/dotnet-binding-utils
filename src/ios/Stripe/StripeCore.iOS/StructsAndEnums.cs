using ObjCRuntime;

namespace StripeCore
{
	[Native]
	public enum STPErrorCode : long
	{
		ConnectionError = 40,
		InvalidRequestError = 50,
		AuthenticationError = 51,
		APIError = 60,
		CardError = 70,
		CancellationError = 80,
		EphemeralKeyDecodingError = 1000
	}
}
