using System.Linq;
using Com.Izettle.Android.Commons.State;
using Com.Izettle.Payments.Android.Payment.Refunds;

namespace Com.Izettle.Payments.Android.Payment.Refunds
{
    partial class RetrieveCardPaymentFailureReason
    {
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
        partial class NotFound
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
    partial class RefundPayload
    {
        partial class CREATOR
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }
    partial class RefundInfo
    {
        partial class CREATOR
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }
    partial class CardPaymentPayload
    {
        partial class CREATOR
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }
    partial class RefundFailureReason
    {
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
        partial class AmountTooHigh
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
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
        partial class InsufficientFunds
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class AlreadyRefunded
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
        partial class NotFound
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class NotRefundable
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class PartialRefundNotSupported
        {
            partial class CREATOR
            {
                public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                    => DoCreateFromParcel(source);

                public unsafe Java.Lang.Object[] NewArray(int size)
                    => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
        partial class RefundExpired
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
    }
}

namespace Com.Izettle.Payments.Android.Payment
{
    partial interface ITransactionAnalyticsReporter
    {
        partial class Companion
        {
            public unsafe global::Java.Lang.Object Invoke(global::Java.Lang.Object obj)
             => (global::Java.Lang.Object)Invoke(obj as global::Com.Izettle.Payments.Android.Analytics.IAnalytics);
        }
    }
}

namespace Com.Izettle.Payments.Android.Payment.Configuration
{
    partial interface IPaymentConfigurationAnalyticsReporter
    {
        partial class Companion
        {
            public unsafe global::Java.Lang.Object Invoke(global::Java.Lang.Object obj)
             => (global::Java.Lang.Object)Invoke(obj as global::Com.Izettle.Payments.Android.Analytics.IAnalytics);
        }
    }
}

namespace Com.Izettle.Payments.Android.Payment.Vendors.Datecs
{
    partial interface ITransactionPaymentMessagesManager
    {
        partial class Companion
        {
            public unsafe global::Java.Lang.Object Invoke(global::Java.Lang.Object obj)
             => (global::Java.Lang.Object)Invoke(obj as global::Com.Izettle.Android.Commons.Thread.IEventsLoop);
        }
    }

    partial interface IDatecsLedLightsManager
    {
        partial class Companion
        {
            public unsafe global::Java.Lang.Object Invoke(global::Java.Lang.Object obj1, global::Java.Lang.Object obj2)
             => (global::Java.Lang.Object)Invoke(obj1 as global::Kotlin.Jvm.Functions.IFunction1, obj2 as global::Com.Izettle.Android.Commons.Thread.IEventsLoop);
        }
    }

    partial interface ISystemUiLocker
    {
        partial class Companion
        {
            public unsafe global::Java.Lang.Object Invoke(global::Java.Lang.Object obj1, global::Java.Lang.Object obj2)
             => (global::Java.Lang.Object)Invoke(obj1 as global::Com.Izettle.Payments.Android.Payment.Vendors.Datecs.ISystemUi, obj2 as global::Com.Izettle.Android.Commons.Thread.IEventsLoop);
        }
    }
}

namespace Com.Izettle.Payments.Android.Payment.Devmode
{
    partial class DevModeRefundManagerImpl : global::Com.Izettle.Payments.Android.Payment.Refunds.IRefundsManager
    {
        IState IRefundsManager.GetState() => State;

        void IRefundsManager.InvokeAction(IRefundsManager.Action action)
            => Action(action);
    }
}