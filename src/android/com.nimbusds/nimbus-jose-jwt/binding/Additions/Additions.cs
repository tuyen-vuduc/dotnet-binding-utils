using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Nimbusds.Jose.Crypto.Factories
{
    partial class DefaultJWEDecrypterFactory
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class DefaultJWSSignerFactory
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class DefaultJWSVerifierFactory
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
}

namespace Com.Nimbusds.Jose.Crypto
{
    partial class X25519Decrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class X25519Encrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class AESDecrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class AESEncrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class DirectDecrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class DirectEncrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class ECDH1PUDecrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class ECDH1PUEncrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class ECDH1PUX25519Decrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class ECDH1PUX25519Encrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class ECDHDecrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class ECDHEncrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class PasswordBasedDecrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class PasswordBasedEncrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class RSADecrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class RSAEncrypter
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
}

namespace Com.Nimbusds.Jose.Crypto.Impl
{
    partial class BaseJWSProvider
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class BaseJWEProvider
    {
        global::Java.Lang.Object global::Com.Nimbusds.Jose.Jca.IJCAAware.JCAContext => JCAContext;
    }
    partial class AESCryptoProvider
    {
        static Delegate? cb_supportedEncryptionMethods;
#pragma warning disable 0169
        static Delegate GetSupportedEncryptionMethodsHandler()
        {
            if (cb_supportedEncryptionMethods == null)
                cb_supportedEncryptionMethods = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_SupportedEncryptionMethods);
            return cb_supportedEncryptionMethods;
        }

        static IntPtr n_SupportedEncryptionMethods(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Nimbusds.Jose.Crypto.Impl.AESCryptoProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<global::Com.Nimbusds.Jose.EncryptionMethod>.ToLocalJniHandle(__this.SupportedEncryptionMethods());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.nimbusds.jose.crypto.impl']/class[@name='AESCryptoProvider']/method[@name='supportedEncryptionMethods' and count(parameter)=0]"
        [Register("supportedEncryptionMethods", "()Ljava/util/Set;", "GetSupportedEncryptionMethodsHandler")]
        public override unsafe global::System.Collections.Generic.ICollection<global::Com.Nimbusds.Jose.EncryptionMethod>? SupportedEncryptionMethods()
        {
            const string __id = "supportedEncryptionMethods.()Ljava/util/Set;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Android.Runtime.JavaSet<global::Com.Nimbusds.Jose.EncryptionMethod>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate? cb_supportedJWEAlgorithms;
#pragma warning disable 0169
        static Delegate GetSupportedJWEAlgorithmsHandler()
        {
            if (cb_supportedJWEAlgorithms == null)
                cb_supportedJWEAlgorithms = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_SupportedJWEAlgorithms);
            return cb_supportedJWEAlgorithms;
        }

        static IntPtr n_SupportedJWEAlgorithms(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Nimbusds.Jose.Crypto.Impl.AESCryptoProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<global::Com.Nimbusds.Jose.JWEAlgorithm>.ToLocalJniHandle(__this.SupportedJWEAlgorithms());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.nimbusds.jose.crypto.impl']/class[@name='AESCryptoProvider']/method[@name='supportedJWEAlgorithms' and count(parameter)=0]"
        [Register("supportedJWEAlgorithms", "()Ljava/util/Set;", "GetSupportedJWEAlgorithmsHandler")]
        public override unsafe global::System.Collections.Generic.ICollection<global::Com.Nimbusds.Jose.JWEAlgorithm>? SupportedJWEAlgorithms()
        {
            const string __id = "supportedJWEAlgorithms.()Ljava/util/Set;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Android.Runtime.JavaSet<global::Com.Nimbusds.Jose.JWEAlgorithm>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

    partial class DirectCryptoProvider
    {
        static Delegate? cb_supportedEncryptionMethods;
#pragma warning disable 0169
        static Delegate GetSupportedEncryptionMethodsHandler()
        {
            if (cb_supportedEncryptionMethods == null)
                cb_supportedEncryptionMethods = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_SupportedEncryptionMethods);
            return cb_supportedEncryptionMethods;
        }

        static IntPtr n_SupportedEncryptionMethods(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Nimbusds.Jose.Crypto.Impl.DirectCryptoProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<global::Com.Nimbusds.Jose.EncryptionMethod>.ToLocalJniHandle(__this.SupportedEncryptionMethods());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.nimbusds.jose.crypto.impl']/class[@name='DirectCryptoProvider']/method[@name='supportedEncryptionMethods' and count(parameter)=0]"
        [Register("supportedEncryptionMethods", "()Ljava/util/Set;", "GetSupportedEncryptionMethodsHandler")]
        public override unsafe global::System.Collections.Generic.ICollection<global::Com.Nimbusds.Jose.EncryptionMethod>? SupportedEncryptionMethods()
        {
            const string __id = "supportedEncryptionMethods.()Ljava/util/Set;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Android.Runtime.JavaSet<global::Com.Nimbusds.Jose.EncryptionMethod>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }

        static Delegate? cb_supportedJWEAlgorithms;
#pragma warning disable 0169
        static Delegate GetSupportedJWEAlgorithmsHandler()
        {
            if (cb_supportedJWEAlgorithms == null)
                cb_supportedJWEAlgorithms = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_SupportedJWEAlgorithms);
            return cb_supportedJWEAlgorithms;
        }

        static IntPtr n_SupportedJWEAlgorithms(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Com.Nimbusds.Jose.Crypto.Impl.DirectCryptoProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<global::Com.Nimbusds.Jose.JWEAlgorithm>.ToLocalJniHandle(__this.SupportedJWEAlgorithms());
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='com.nimbusds.jose.crypto.impl']/class[@name='DirectCryptoProvider']/method[@name='supportedJWEAlgorithms' and count(parameter)=0]"
        [Register("supportedJWEAlgorithms", "()Ljava/util/Set;", "GetSupportedJWEAlgorithmsHandler")]
        public override unsafe global::System.Collections.Generic.ICollection<global::Com.Nimbusds.Jose.JWEAlgorithm>? SupportedJWEAlgorithms()
        {
            const string __id = "supportedJWEAlgorithms.()Ljava/util/Set;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Android.Runtime.JavaSet<global::Com.Nimbusds.Jose.JWEAlgorithm>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }

}

namespace Com.Nimbusds.Jose.Shaded.Gson
{
    partial class JsonStreamParser
    {
        global::Java.Lang.Object global::Java.Util.IIterator.Next() => Next();
    }
}