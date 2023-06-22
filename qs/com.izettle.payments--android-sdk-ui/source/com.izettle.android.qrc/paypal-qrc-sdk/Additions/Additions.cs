using System.Linq;
namespace Com.Izettle.Android.Qrc.Paypal.UI.Payment
{
    //partial class PayPalQrcPaymentActivity
    //{
    //    public override global::AndroidX.Fragment.App.Fragment OnCreatePaymentFragment()
    //        => OnCreatePaymentFragmentX();
    //}
}

namespace Com.Izettle.Android.Qrc.Paypal.UI.Refund
{
    partial class PayPalQrcRefund
    {
        partial class Creator
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }
    partial class PayPalQrcRefundResult
    {
        partial class Canceled
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Completed
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Failed
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
}
namespace Com.Izettle.Android.Qrc.Paypal.Refund
{
    partial class PayPalQrcRetrieveFailureReason
    {
        partial class NotAuthenticated
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NotFound
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NotAuthorized
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class TechnicalError
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NetworkError
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
    partial class PayPalQrcRefundFailureReason
    {
        partial class AlreadyRefunded
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class AmountTooHigh
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Cancelled
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Failed
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class InsufficientFunds
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class TechnicalError
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class RefundExpired
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class PartialRefundNotSupported
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NotFound
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NotAuthorized
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NotAuthenticated
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NetworkError
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
}
namespace Com.Izettle.Android.Qrc.Paypal.UI.Payment
{
    partial class PayPalQrcPayment
    {
        partial class Creator
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }
    partial class PayPalQrcPaymentFailureReason
    {
        partial class Timeout
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class AboveMaximum
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class ActivationNotCompleted
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class BelowMinimum
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class FeatureNotEnabled
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NetworkError
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class LocationFetchFailed
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class SellerDataError
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class TechnicalError
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
    partial class PayPalQrcPaymentResult
    {
        partial class Canceled
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Failed
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Completed
        {
            partial class Creator
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
}