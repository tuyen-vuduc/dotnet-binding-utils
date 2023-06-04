using Android.Runtime;
using Java.Interop;
using System;
using System.IO;

namespace Androidx.Datastore.Preferences.Protobuf
{
    partial class GeneratedMessageLite
    {
        public override unsafe IMessageLite DefaultInstanceForType
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='androidx.datastore.preferences.protobuf']/class[@name='GeneratedMessageLite']/method[@name='getDefaultInstanceForType' and count(parameter)=0]"
            [Register("getDefaultInstanceForType", "()Landroidx/datastore/preferences/protobuf/GeneratedMessageLite;", "")]
            get
            {
                const string __id = "getDefaultInstanceForType.()Landroidx/datastore/preferences/protobuf/GeneratedMessageLite;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, null);
                    return (global::Androidx.Datastore.Preferences.Protobuf.IMessageLite)global::Java.Lang.Object.GetObject<global::Androidx.Datastore.Preferences.Protobuf.IMessageLite>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }


        public override unsafe IMessageLite.IBuilder NewBuilderForType()
            => NewGeneratedMessageLiteBuilderForType();

        public override unsafe IMessageLite.IBuilder ToBuilder()
            => ToGeneratedMessageLiteBuilder();

        partial class GeneratedMessageLiteBuilder
        {
            public override unsafe IMessageLite.IBuilder Clear()
                => ClearX() as IMessageLite.IBuilder;

            public override unsafe IMessageLite Build()
                => BuildX() as IMessageLite;

            public override IMessageLite BuildPartial()
                => BuildXPartial() as IMessageLite;

            //public override Androidx.Datastore.Preferences.Protobuf.IMessageLite.IBuilder Clone()
            //    => CloneX() as Androidx.Datastore.Preferences.Protobuf.IMessageLite.IBuilder;

            //public override Androidx.Datastore.Preferences.Protobuf.IMessageLite.IBuilder MergeFrom(ByteString data)
            //    => MergeXFrom(data) as Androidx.Datastore.Preferences.Protobuf.IMessageLite.IBuilder;

            //public override Androidx.Datastore.Preferences.Protobuf.IMessageLite.IBuilder MergeFrom(CodedInputStream p0, ExtensionRegistryLite p1)
            //    => MergeXFrom(p0, p1) as Androidx.Datastore.Preferences.Protobuf.IMessageLite.IBuilder;
        }

        partial class GeneratedExtension
        {
            protected override Java.Lang.Object RawDefaultValue => DefaultValue;
        }
    }

    partial class LazyStringArrayList
    {
        public override Java.Lang.Object Get(int index)
            => GetX(index);
    }

    partial class UnmodifiableLazyStringList
    {
        public override Java.Lang.Object Get(int index)
            => GetX(index);
    }

    partial class LazyStringArrayList
    {

        static Delegate cb_removeString_I;
#pragma warning disable 0169
        static Delegate GetRemoveString_IHandler()
        {
            if (cb_removeString_I == null)
                cb_removeString_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(n_RemoveString_I));
            return cb_removeString_I;
        }

        static IntPtr n_RemoveString_I(IntPtr jnienv, IntPtr native__this, int index)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Androidx.Datastore.Preferences.Protobuf.LazyStringArrayList>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.NewString(__this.RemoveString(index));
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='androidx.datastore.preferences.protobuf']/class[@name='LazyStringArrayList']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
        [Register("remove", "(I)Ljava/lang/String;", "GetRemoveString_IHandler")]
        public virtual unsafe string RemoveString(int index)
        {
            const string __id = "remove.(I)Ljava/lang/String;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(index);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return JNIEnv.GetString(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    partial class AbstractMessageLite
    {
        partial class Builder : IMessageLite.IBuilder
        {
            IMessageLite.IBuilder IMessageLite.IBuilder.Clone() => Clone() as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(ByteString p0)
                => MergeFrom(p0) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(ByteString p0, ExtensionRegistryLite p1)
                => MergeFrom(p0, p1) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(CodedInputStream p0)
                => MergeFrom(p0) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(CodedInputStream p0, ExtensionRegistryLite p1)
                => MergeFrom(p0, p1) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(IMessageLite p0)
                => MergeFrom(p0) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(byte[] p0)
                => MergeFrom(p0) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(byte[] p0, ExtensionRegistryLite p1)
                => MergeFrom(p0, p1) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(byte[] p0, int p1, int p2)
                => MergeFrom(p0, p1, p2) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(byte[] p0, int p1, int p2, ExtensionRegistryLite p3)
                => MergeFrom(p0, p1, p2, p3) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(Stream p0)
                => MergeFrom(p0) as IMessageLite.IBuilder;

            IMessageLite.IBuilder IMessageLite.IBuilder.MergeFrom(Stream p0, ExtensionRegistryLite p1)
                => MergeFrom(p0, p1) as IMessageLite.IBuilder;
        }
    }
}