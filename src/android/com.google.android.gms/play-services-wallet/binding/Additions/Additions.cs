#nullable restore
using System;
using System.Collections.Generic;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Android.Gms.Wallet.Contract
{
    partial class TaskResultContracts
    {
        partial class ResolveApiTaskResult
        {
            public override unsafe global::Android.Content.Intent CreateIntent(global::Android.Content.Context p0, global::Java.Lang.Object p1)
                => CreateIntent(p0, p1 as global::Android.Gms.Tasks.Task);
        }

        partial class GetPaymentData
        {
            public override Java.Lang.Object? ParseResult(int resultCode, global::Android.Content.Intent? intent)
                => ParseResultX(resultCode, intent);
        }

        partial class GetApiTaskResult
        {
            public override Java.Lang.Object? ParseResult(int resultCode, global::Android.Content.Intent? intent)
                => ParseResultX(resultCode, intent);
            protected override Java.Lang.Object? OutputFromTask(global::Android.Gms.Tasks.Task p0)
                => OutputFromTaskX(p0);
        }

        partial class GetPaymentDataResult
        {
            protected override Java.Lang.Object? TaskResultFromIntent(global::Android.Content.Intent p0)
                => TaskResultFromIntentX(p0);
        }
    }
}