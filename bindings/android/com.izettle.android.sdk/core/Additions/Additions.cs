using Android.Runtime;
using System;
using System.Linq;

namespace Com.Izettle.UI.Components.Actionpanel
{
    partial class OttoActionPanelComponentClickListeners
    {
        partial class CREATOR
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }

    partial class OttoActionPanelOption
    {
        partial class Creator
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }

    partial class OttoActionPanelOptionList
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

namespace Com.Izettle.Android.Auth.Model
{
    partial class AuthData
    {
        partial class CREATOR
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }

    partial class OAuthTokens
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

namespace Com.Izettle.UI.Components.Modal
{
    partial class OttoDialogComponent
    {
        partial class DialogComponentClickListeners
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

namespace Com.Izettle.UI.Components.Selectcomponent
{
    partial class SelectOptionList
    {
        partial class Creator
        {
            public Java.Lang.Object CreateFromParcel(global::Android.OS.Parcel source)
                => DoCreateFromParcel(source);

            public unsafe Java.Lang.Object[] NewArray(int size)
                => CreateArray(size).Cast<Java.Lang.Object>().ToArray();
        }
    }
    partial class SelectOption
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

namespace Com.Izettle.Android.Net
{
    partial class FormUrlEncodedBody
    {
        partial class Builder
        {
            public unsafe global::Com.Izettle.Android.Net.IRequestBody Build()
                => DoBuild();
        }
    }
    partial class JsonBody
    {
        partial class Builder
        {
            public unsafe global::Com.Izettle.Android.Net.IRequestBody Build()
                => DoBuild();
        }
    }
    partial class TextBody
    {
        partial class Builder
        {
            public unsafe global::Com.Izettle.Android.Net.IRequestBody Build()
                => DoBuild();
        }
    }
    partial class MultiPartBody
    {
        partial class Builder : global::Com.Izettle.Android.Net.IRequestBody.IBuilder
        {
            public virtual unsafe global::Com.Izettle.Android.Net.IRequestBody Build()
                => DoBuild();

//            static Delegate cb_build;
//#pragma warning disable 0169
//            static Delegate GetDoBuildHandler()
//            {
//                if (cb_build == null)
//                    cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_DoBuild));
//                return cb_build;
//            }

//            static IntPtr n_DoBuild(IntPtr jnienv, IntPtr native__this)
//            {
//                var __this = global::Java.Lang.Object.GetObject<global::Com.Izettle.Android.Net.MultiPartBody.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//                return JNIEnv.ToLocalJniHandle(__this.DoBuild());
//            }
//#pragma warning restore 0169

//            // Metadata.xml XPath method reference: path="/api/package[@name='com.izettle.android.net']/class[@name='MultiPartBody.Builder']/method[@name='build' and count(parameter)=0]"
//            [Register("build", "()Lcom/izettle/android/net/MultiPartBody;", "GetDoBuildHandler")]
//            public virtual unsafe global::Com.Izettle.Android.Net.MultiPartBody DoBuild()
//            {
//                const string __id = "build.()Lcom/izettle/android/net/MultiPartBody;";
//                try
//                {
//                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
//                    return global::Java.Lang.Object.GetObject<global::Com.Izettle.Android.Net.MultiPartBody>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
//                }
//                finally
//                {
//                }
//            }
        }
    }
}