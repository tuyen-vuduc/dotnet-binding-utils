using ObjCRuntime;

namespace Stripe
{
	[Native]
	public enum STPBankSelectionMethod : long
	{
		Fpx = 0,
		Unknown = 1
	}

	[Native]
	public enum STPBillingAddressFields : ulong
	{
		None = 0,
		PostalCode = 1,
		Full = 2,
		Name = 3,
		Zip = 4
	}

	[Native]
	public enum STPShippingStatus : long
	{
		Valid = 0,
		Invalid = 1
	}

	[Native]
	public enum STPShippingType : long
	{
		Shipping = 0,
		Delivery = 1
	}
}
