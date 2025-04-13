using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Altbeacon.Beacon
{
    partial class Identifier
    {
        int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
        {
            return o is global::Org.Altbeacon.Beacon.Identifier s ? CompareTo(s) : -1;
        }
    }
    partial class Settings
    {
        partial class ForegroundServiceScanStrategy
        {
            Settings.IScanStrategy Settings.IScanStrategy.Clone() => Clone();
            int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
            {
                return o is global::Org.Altbeacon.Beacon.Settings.ForegroundServiceScanStrategy s ? CompareTo(s) : -1;
            }
        }
        partial class BackgroundServiceScanStrategy
        {
            Settings.IScanStrategy Settings.IScanStrategy.Clone() => Clone();
            int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
            {
                return o is global::Org.Altbeacon.Beacon.Settings.BackgroundServiceScanStrategy s ? CompareTo(s) : -1;
            }
        }
        partial class IntentScanStrategy
        {
            Settings.IScanStrategy Settings.IScanStrategy.Clone() => Clone();
            int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
            {
                return o is global::Org.Altbeacon.Beacon.Settings.IntentScanStrategy s ? CompareTo(s) : -1;
            }
        }
        partial class JobServiceScanStrategy
        {
            Settings.IScanStrategy Settings.IScanStrategy.Clone() => Clone();
            int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
            {
                return o is global::Org.Altbeacon.Beacon.Settings.JobServiceScanStrategy s ? CompareTo(s) : -1;
            }
        }
    }
}
namespace Org.Altbeacon.Beacon.Distance
{

    partial class ModelSpecificDistanceUpdater
    {
        protected override unsafe global::Java.Lang.Object DoInBackground(params global::Java.Lang.Object[] @params)
        {
            return DoInBackground(new Java.Lang.Void[0]);
        }
    }
}