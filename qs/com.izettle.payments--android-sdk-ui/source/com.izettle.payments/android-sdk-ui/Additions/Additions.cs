using System.Linq;

namespace Com.Izettle.Payments.Android.UI.Readers
{
    partial class CardReadersViewModel
    {
        public unsafe global::Com.Izettle.Android.Commons.State.IState GetState() => MutableState;

        public unsafe void Intent(global::Java.Lang.Object intent)
            => Intent(intent as global::Com.Izettle.Payments.Android.Models.Readers.ReadersSettingsViewModel.ViewIntent);
    }
}

namespace Com.Izettle.Payments.Android.UI.Payment
{
    partial class RationaleFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
}

namespace Com.Izettle.Payments.Android.UI.Payment
{
    partial class CardPaymentResult
    {
        partial class Failed
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Canceled
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Completed
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
    partial class FailureReason
    {
        partial class AboveMaximum
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class IllegalArguments
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class BelowMinimum
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NotAuthorized
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NetworkError
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class TechnicalError
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
}

namespace Com.Izettle.Payments.Android.UI.Refunds
{
    partial class RefundResult
    {
        partial class Failed
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Canceled
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class Completed
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
}

namespace Com.Izettle.Payments.Android.UI.Payment.Onreader
{
    partial class AuthorizingFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class InAppTippingFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class OnReaderMessageFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class RemoveCardFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class SpinnerFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class AccessibilityHighContrastSelectorFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class WaitingCustomerConfirmation
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class InsertFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class PresentCardFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
}

namespace Com.Izettle.Payments.Android.UI.Payment.Ondevice
{
    partial class PresentCardFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class ConnectingToReaderFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class UpdatingReaderFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class PinFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class TransactionApprovedFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class TippingNotSupportedFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class TippingFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class SignatureFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class ProcessingFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }

    partial class PowerOnReaderFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class ConnectReaderFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class InstallmentsFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
    partial class PaymentFailedFragment
    {
        partial class Factory
        {
            public unsafe global::Java.Lang.Object Invoke()
                => DoInvoke();
        }
    }
}