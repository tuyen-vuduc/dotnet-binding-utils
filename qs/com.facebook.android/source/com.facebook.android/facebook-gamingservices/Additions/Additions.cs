using System;
using System.Linq;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Android.Content;

namespace Com.Facebook.Gamingservices
{
    partial class TournamentJoinDialog
    {
        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.gamingservices']/class[@name='TournamentJoinDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }

    partial class TournamentShareDialog
    {
        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.gamingservices']/class[@name='TournamentShareDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }

    partial class ContextChooseDialog
    {
        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.gamingservices']/class[@name='ContextChooseDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }

    partial class ContextCreateDialog
    {
        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.gamingservices']/class[@name='ContextCreateDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }

    partial class ContextSwitchDialog
    {
        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.gamingservices']/class[@name='ContextSwitchDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }

    partial class GameRequestDialog
    {
        static Delegate cb_getOrderedModeHandlers;
#pragma warning disable 0169
        static Delegate GetGetOrderedModeHandlersHandler()
        {
            if (cb_getOrderedModeHandlers == null)
                cb_getOrderedModeHandlers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetOrderedModeHandlers));
            return cb_getOrderedModeHandlers;
        }

        static IntPtr n_GetOrderedModeHandlers(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Gamingservices.GameRequestDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.ToLocalJniHandle(__this.OrderedModeHandlersX);
        }
#pragma warning restore 0169

        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.gamingservices']/class[@name='GameRequestDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "GetGetOrderedModeHandlersHandler")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }

    partial class GamingGroupIntegration
    {
        static Delegate cb_getOrderedModeHandlers;
#pragma warning disable 0169
        static Delegate GetGetOrderedModeHandlersHandler()
        {
            if (cb_getOrderedModeHandlers == null)
                cb_getOrderedModeHandlers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetOrderedModeHandlers));
            return cb_getOrderedModeHandlers;
        }

        static IntPtr n_GetOrderedModeHandlers(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Gamingservices.GamingGroupIntegration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.ToLocalJniHandle(__this.OrderedModeHandlersX);
        }
#pragma warning restore 0169

        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.gamingservices']/class[@name='GamingGroupIntegration']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "GetGetOrderedModeHandlersHandler")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }

    partial class FriendFinderDialog
    {
        static Delegate cb_getOrderedModeHandlers;
#pragma warning disable 0169
        static Delegate GetGetOrderedModeHandlersHandler()
        {
            if (cb_getOrderedModeHandlers == null)
                cb_getOrderedModeHandlers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetOrderedModeHandlers));
            return cb_getOrderedModeHandlers;
        }

        static IntPtr n_GetOrderedModeHandlers(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Gamingservices.FriendFinderDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.ToLocalJniHandle(__this.OrderedModeHandlersX);
        }
#pragma warning restore 0169

        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.gamingservices']/class[@name='FriendFinderDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
            [Register("getOrderedModeHandlers", "()Ljava/util/List;", "GetGetOrderedModeHandlersHandler")]
            get
            {
                const string __id = "getOrderedModeHandlers.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        protected override global::System.Collections.IList OrderedModeHandlers
        {
            get => OrderedModeHandlersX.ToArray();
        }
    }
}

namespace Com.Facebook.Gamingservices.Model
{
    partial class ContextChooseContent
    {
        partial class Builder
        {
            unsafe global::Java.Lang.Object global::Com.Facebook.Share.IShareBuilder.Build()
                => Build();
            global::Java.Lang.Object global::Com.Facebook.Share.Model.IShareModelBuilder.ReadFrom(global::Java.Lang.Object model)
                => ReadFrom(model as ContextChooseContent);
        }
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class ContextCreateContent
    {
        partial class Builder
        {
            unsafe global::Java.Lang.Object global::Com.Facebook.Share.IShareBuilder.Build()
                => Build();
            global::Java.Lang.Object global::Com.Facebook.Share.Model.IShareModelBuilder.ReadFrom(global::Java.Lang.Object model)
                => ReadFrom(model as ContextCreateContent);
        }
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
    partial class ContextSwitchContent
    {
        partial class Builder
        {
            unsafe global::Java.Lang.Object global::Com.Facebook.Share.IShareBuilder.Build()
                => Build();
            global::Java.Lang.Object global::Com.Facebook.Share.Model.IShareModelBuilder.ReadFrom(global::Java.Lang.Object model)
                => ReadFrom(model as ContextSwitchContent);
        }
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
}

namespace Com.Facebook.Gamingservices
{
    partial class Tournament
    {
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }

    partial class TournamentConfig
    {
        partial class Builder
        {
            unsafe global::Java.Lang.Object global::Com.Facebook.Share.IShareBuilder.Build()
                => Build();
            global::Java.Lang.Object global::Com.Facebook.Share.Model.IShareModelBuilder.ReadFrom(global::Java.Lang.Object model)
                => ReadFrom(model as TournamentConfig);
        }
        partial class Creator
        {
            unsafe global::Java.Lang.Object global::Android.OS.IParcelableCreator.CreateFromParcel(global::Android.OS.Parcel parcel)
                => CreateFromParcel(parcel);

            unsafe global::Java.Lang.Object[] global::Android.OS.IParcelableCreator.NewArray(int size)
                => NewArray(size).Cast<global::Java.Lang.Object>().ToArray();
        }
    }
}