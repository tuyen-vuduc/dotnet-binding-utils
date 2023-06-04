using Android.Runtime;
using Java.Interop;
using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace Androidx.Datastore.Preferences.Protobuf
{
    partial class GeneratedMessageLite
    {
        public override IMessageLite DefaultInstanceForType
            => GetDefaultInstanceForType() as IMessageLite;

        public override unsafe IMessageLite.IBuilder NewBuilderForType()
            => NewBuilderForTypeX() as IMessageLite.IBuilder;

        public override unsafe IMessageLite.IBuilder ToBuilder()
            => ToBuilderX() as IMessageLite.IBuilder;

        partial class GeneratedMessageLiteBuilder
        {
            public override IMessageLite DefaultInstanceForType
                => GetDefaultInstanceForType() as IMessageLite;

            public override unsafe IMessageLite.IBuilder Clear()
                => ClearX() as IMessageLite.IBuilder;

            public override unsafe IMessageLite Build()
                => BuildX() as IMessageLite;

            public override IMessageLite BuildPartial()
                => BuildXPartial() as IMessageLite;
        }

        partial class GeneratedExtension
        {
            protected override Java.Lang.Object RawDefaultValue => DefaultValue;
        }

        partial class ExtendableBuilder
        {
            public override IMessageLite BuildPartial()
                => BuildXPartial() as IMessageLite;
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

    partial class Internal
    {
        partial class MapAdapter
        {

            static Delegate cb_entrySet;
#pragma warning disable 0169
            static Delegate GetEntrySetXHandler()
            {
                if (cb_entrySet == null)
                    cb_entrySet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_EntrySetX));
                return cb_entrySet;
            }

            static IntPtr n_EntrySetX(IntPtr jnienv, IntPtr native__this)
            {
                var __this = global::Java.Lang.Object.GetObject<global::Androidx.Datastore.Preferences.Protobuf.Internal.MapAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.ToLocalJniHandle(__this.EntrySet());
            }
#pragma warning restore 0169

            // Metadata.xml XPath method reference: path="/api/package[@name='androidx.datastore.preferences.protobuf']/class[@name='Internal.MapAdapter']/method[@name='entrySet' and count(parameter)=0]"
            [Register("entrySet", "()Ljava/util/Set;", "GetEntrySetXHandler")]
            protected unsafe global::System.Collections.Generic.ICollection<global::Java.Util.IMapEntry> EntrySetX()
            {
                const string __id = "entrySet.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }

            public override ICollection EntrySet()
            {
                var mapEntrySet = EntrySetX();

                return mapEntrySet.ToList();
            }
        }
    }
}