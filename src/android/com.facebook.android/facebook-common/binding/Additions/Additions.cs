using System;
using System.Linq;
using Android.Content;
using Android.Runtime;

namespace Com.Facebook.Login
{
    partial class LoginManager
    {
        partial class FacebookLoginActivityResultContract
        {
            public unsafe override global::Android.Content.Intent CreateIntent(
                global::Android.Content.Context context, 
                global::Java.Lang.Object data)
            {
                System.IntPtr __ret = global::Android.Runtime.JNIEnv.ToLocalJniHandle(data);
                var items = global::Android.Runtime.JavaCollection<string>.FromJniHandle(
                    __ret, 
                    global::Android.Runtime.JniHandleOwnership.DoNotTransfer);
                return CreateIntent(context, items);
            }

            public override global::Java.Lang.Object? ParseResult(int resultCode, Intent? intent)
                => ParseActivityResult(resultCode, intent);
        }
    }
}

namespace Com.Facebook.Share.Model {
    partial class ShareMedia
    {
        partial class Builder
        {

            static Delegate? cb_build;
#pragma warning disable 0169
            static Delegate GetBuildHandler()
            {
                if (cb_build == null)
                    cb_build = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_Build);
                return cb_build;
            }

            static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Share.Model.ShareMedia.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
                return JNIEnv.ToLocalJniHandle(__this.Build());
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.share.model']/class[@name='ShareMedia.Builder']/method[@name='build' and count(parameter)=0]"
            [Register("build", "()Lcom/facebook/share/model/ShareMedia;", "GetBuildHandler")]
            public abstract global::Java.Lang.Object? Build();
        }
        partial class BuilderInvoker
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.share.model']/class[@name='ShareMedia.Builder']/method[@name='build' and count(parameter)=0]"
            [Register("build", "()Lcom/facebook/share/model/ShareMedia;", "GetBuildHandler")]
            public override unsafe global::Java.Lang.Object? Build()
            {
                const string __id = "build.()Lcom/facebook/share/model/ShareMedia;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return (global::Java.Lang.Object?)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }

    partial class ShareContent
    {
        partial class Builder
        {

            static Delegate? cb_build;
#pragma warning disable 0169
            static Delegate GetBuildHandler()
            {
                if (cb_build == null)
                    cb_build = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_Build);
                return cb_build;
            }

            static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Share.Model.ShareMedia.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
                return JNIEnv.ToLocalJniHandle(__this.Build());
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.share.model']/class[@name='ShareMedia.Builder']/method[@name='build' and count(parameter)=0]"
            [Register("build", "()Lcom/facebook/share/model/ShareMedia;", "GetBuildHandler")]
            public abstract global::Java.Lang.Object? Build();
        }
        partial class BuilderInvoker
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.share.model']/class[@name='ShareMedia.Builder']/method[@name='build' and count(parameter)=0]"
            [Register("build", "()Lcom/facebook/share/model/ShareMedia;", "GetBuildHandler")]
            public override unsafe global::Java.Lang.Object? Build()
            {
                const string __id = "build.()Lcom/facebook/share/model/ShareMedia;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return (global::Java.Lang.Object?)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }

    partial class ShareMessengerActionButton
    {
        partial class Builder
        {

            static Delegate? cb_build;
#pragma warning disable 0169
            static Delegate GetBuildHandler()
            {
                if (cb_build == null)
                    cb_build = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_Build);
                return cb_build;
            }

            static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Share.Model.ShareMedia.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
                return JNIEnv.ToLocalJniHandle(__this.Build());
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.share.model']/class[@name='ShareMedia.Builder']/method[@name='build' and count(parameter)=0]"
            [Register("build", "()Lcom/facebook/share/model/ShareMedia;", "GetBuildHandler")]
            public abstract global::Java.Lang.Object? Build();
        }
        partial class BuilderInvoker
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.share.model']/class[@name='ShareMedia.Builder']/method[@name='build' and count(parameter)=0]"
            [Register("build", "()Lcom/facebook/share/model/ShareMedia;", "GetBuildHandler")]
            public override unsafe global::Java.Lang.Object? Build()
            {
                const string __id = "build.()Lcom/facebook/share/model/ShareMedia;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return (global::Java.Lang.Object?)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }

    partial class AppGroupCreationContent
    {
        partial class Builder
        {
            public unsafe global::Java.Lang.Object Build()
                => BuildAppGroupCreationContent();
        }
    }
    partial class CameraEffectArguments
    {
        partial class Builder
        {
            public unsafe global::Java.Lang.Object Build()
                => BuildCameraEffectArguments();
        }
    }
    partial class CameraEffectTextures
    {
        partial class Builder
        {
            public unsafe global::Java.Lang.Object Build()
                => BuildCameraEffectTextures();
        }
    }
    partial class GameRequestContent
    {
        partial class Builder
        {
            public unsafe global::Java.Lang.Object Build()
                => BuildGameRequestContent();
        }
    }
    partial class ShareHashtag
    {
        partial class Builder
        {
            public unsafe global::Java.Lang.Object Build()
                => BuildShareHashtag();
        }
    }
    partial class ShareCameraEffectContent
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildShareCameraEffectContent();
        }
    }
    partial class ShareLinkContent
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildShareLinkContent();
        }
    }
    partial class ShareMediaContent
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildShareMediaContent();
        }
    }
    partial class SharePhoto
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildSharePhoto();
        }
    }
    partial class ShareMessengerURLActionButton
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildShareMessengerURLActionButton();
        }
    }
    partial class SharePhotoContent
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildSharePhotoContent();
        }
    }
    partial class ShareStoryContent
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildShareStoryContent();
        }
    }
    partial class ShareVideoContent
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildShareVideoContent();
        }
    }
    partial class ShareVideo
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildShareVideo();
        }
    }
}

namespace Com.Facebook.Share.Widget {
    partial class ShareDialog
    {
        static Delegate cb_getOrderedModeHandlers;
#pragma warning disable 0169
        static Delegate GetGetOrderedModeHandlersHandler()
        {
            if (cb_getOrderedModeHandlers == null)
                cb_getOrderedModeHandlers = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetOrderedModeHandlers);
            return cb_getOrderedModeHandlers;
        }

        static IntPtr n_GetOrderedModeHandlers(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Share.Widget.ShareDialog>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return global::Android.Runtime.JavaList<global::Com.Facebook.Internal.FacebookDialogBase>.ToLocalJniHandle(__this.OrderedModeHandlersX);
        }
#pragma warning restore 0169

        protected unsafe global::System.Collections.Generic.IList<global::Com.Facebook.Internal.FacebookDialogBase> OrderedModeHandlersX
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.share.widget']/class[@name='ShareDialog']/method[@name='getOrderedModeHandlers' and count(parameter)=0]"
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

namespace Com.Facebook.Share.Internal {
    partial class ShareFeedContent
    {
        partial class Builder
        {
            public override unsafe global::Java.Lang.Object Build()
                => BuildShareFeedContent();
        }
    }
}