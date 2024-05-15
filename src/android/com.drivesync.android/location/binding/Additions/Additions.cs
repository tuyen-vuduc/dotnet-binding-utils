using Android.Runtime;
using System;

delegate bool _JniMarshal_PPL_Z(IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L(IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);

namespace Com.Drivesync.Android.Location.Mobile
{
    partial class GmsGeofenceProvider : Com.Drivesync.Android.Location.IGeofenceProvider
    {
    }
}