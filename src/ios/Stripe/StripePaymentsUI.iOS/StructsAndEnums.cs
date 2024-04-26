using ObjCRuntime;

namespace StripePaymentsUI
{
	[Native]
	public enum STPCardFormViewStyle : long
	{
		Standard = 0,
		Borderless = 1
	}

	[Native]
	public enum STPPostalCodeRequirement : long
	{
		Standard = 0,
		Upe = 1
	}
}
