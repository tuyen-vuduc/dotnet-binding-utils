using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Security.Cert;
using Org.Bouncycastle.Util;

namespace Org.Bouncycastle.X509
{
    partial interface IX509AttributeCertificate : global::Java.Security.Cert.IX509Extension
    {

    }

    partial class IX509AttributeCertificateInvoker
    {
        static Delegate? cb_getCriticalExtensionOIDs;
#pragma warning disable 0169
        static Delegate GetGetCriticalExtensionOIDsHandler()
        {
            if (cb_getCriticalExtensionOIDs == null)
                cb_getCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetCriticalExtensionOIDs);
            return cb_getCriticalExtensionOIDs;
        }

        static IntPtr n_GetCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.X509.IX509AttributeCertificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle(__this.CriticalExtensionOIDs);
        }
#pragma warning restore 0169

        IntPtr id_getCriticalExtensionOIDs;
        public unsafe global::System.Collections.Generic.ICollection<global::System.String>? CriticalExtensionOIDs
        {
            get
            {
                if (id_getCriticalExtensionOIDs == IntPtr.Zero)
                    id_getCriticalExtensionOIDs = JNIEnv.GetMethodID(java_class_ref, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
                return global::Android.Runtime.JavaSet<string>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getCriticalExtensionOIDs), JniHandleOwnership.TransferLocalRef);
            }
        }

        static Delegate? cb_hasUnsupportedCriticalExtension;
#pragma warning disable 0169
        static Delegate GetGetHasUnsupportedCriticalExtensionHandler()
        {
            if (cb_hasUnsupportedCriticalExtension == null)
                cb_hasUnsupportedCriticalExtension = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_Z)n_GetHasUnsupportedCriticalExtension);
            return cb_hasUnsupportedCriticalExtension;
        }

        static bool n_GetHasUnsupportedCriticalExtension(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.X509.IX509AttributeCertificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.HasUnsupportedCriticalExtension;
        }
#pragma warning restore 0169

        IntPtr id_hasUnsupportedCriticalExtension;
        public unsafe bool HasUnsupportedCriticalExtension
        {
            get
            {
                if (id_hasUnsupportedCriticalExtension == IntPtr.Zero)
                    id_hasUnsupportedCriticalExtension = JNIEnv.GetMethodID(java_class_ref, "hasUnsupportedCriticalExtension", "()Z");
                return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_hasUnsupportedCriticalExtension);
            }
        }

        static Delegate? cb_getNonCriticalExtensionOIDs;
#pragma warning disable 0169
        static Delegate GetGetNonCriticalExtensionOIDsHandler()
        {
            if (cb_getNonCriticalExtensionOIDs == null)
                cb_getNonCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetNonCriticalExtensionOIDs);
            return cb_getNonCriticalExtensionOIDs;
        }

        static IntPtr n_GetNonCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.X509.IX509AttributeCertificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle(__this.NonCriticalExtensionOIDs);
        }
#pragma warning restore 0169

        IntPtr id_getNonCriticalExtensionOIDs;
        public unsafe global::System.Collections.Generic.ICollection<global::System.String>? NonCriticalExtensionOIDs
        {
            get
            {
                if (id_getNonCriticalExtensionOIDs == IntPtr.Zero)
                    id_getNonCriticalExtensionOIDs = JNIEnv.GetMethodID(java_class_ref, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
                return global::Android.Runtime.JavaSet<string>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getNonCriticalExtensionOIDs), JniHandleOwnership.TransferLocalRef);
            }
        }

        static Delegate? cb_getExtensionValue_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetGetExtensionValue_Ljava_lang_String_Handler()
        {
            if (cb_getExtensionValue_Ljava_lang_String_ == null)
                cb_getExtensionValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_GetExtensionValue_Ljava_lang_String_);
            return cb_getExtensionValue_Ljava_lang_String_;
        }

        static IntPtr n_GetExtensionValue_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_oid)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.X509.IX509AttributeCertificate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var oid = JNIEnv.GetString(native_oid, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.NewArray(__this.GetExtensionValue(oid));
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_getExtensionValue_Ljava_lang_String_;
        public unsafe global::System.Byte[]? GetExtensionValue(string? oid)
        {
            if (id_getExtensionValue_Ljava_lang_String_ == IntPtr.Zero)
                id_getExtensionValue_Ljava_lang_String_ = JNIEnv.GetMethodID(java_class_ref, "getExtensionValue", "(Ljava/lang/String;)[B");
            IntPtr native_oid = JNIEnv.NewString((string?)oid);
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(native_oid);
            var __ret = (byte[]?)JNIEnv.GetArray(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getExtensionValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof(byte));
            JNIEnv.DeleteLocalRef(native_oid);
            return __ret;
        }
    }

    partial class X509V2AttributeCertificate
    {
        ICollection<string>? IX509Extension.CriticalExtensionOIDs => CriticalExtensionOIDs?.Cast<string>().ToList();

        ICollection<string>? IX509Extension.NonCriticalExtensionOIDs => NonCriticalExtensionOIDs?.Cast<string>().ToList();
    }
}

namespace Org.Bouncycastle.Jce.Provider
{
    partial class PKIXPolicyNode : global::Java.Security.Cert.IPolicyNode
    {
        ICollection<string>? global::Java.Security.Cert.IPolicyNode.ExpectedPolicies
            => ExpectedPolicies?.Cast<String>().ToList();

        ICollection<global::Java.Security.Cert.PolicyQualifierInfo>? global::Java.Security.Cert.IPolicyNode.PolicyQualifiers
            => PolicyQualifiers?.Cast<global::Java.Security.Cert.PolicyQualifierInfo>().ToList();
    }

    partial class X509CertificateObject
    {

        static Delegate? cb_getNonCriticalExtensionOIDs;
#pragma warning disable 0169
        static Delegate GetGetNonCriticalExtensionOIDsHandler()
        {
            if (cb_getNonCriticalExtensionOIDs == null)
                cb_getNonCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetNonCriticalExtensionOIDs);
            return cb_getNonCriticalExtensionOIDs;
        }

        static IntPtr n_GetNonCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509CertificateObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle(__this.NonCriticalExtensionOIDs);
        }
#pragma warning restore 0169

        public override unsafe global::System.Collections.Generic.ICollection<string>? NonCriticalExtensionOIDs
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509CertificateObject']/method[@name='getNonCriticalExtensionOIDs' and count(parameter)=0]"
            [Register("getNonCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetNonCriticalExtensionOIDsHandler")]
            get
            {
                const string __id = "getNonCriticalExtensionOIDs.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<string>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
        static Delegate? cb_getCriticalExtensionOIDs;
#pragma warning disable 0169
        static Delegate GetGetCriticalExtensionOIDsHandler()
        {
            if (cb_getCriticalExtensionOIDs == null)
                cb_getCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetCriticalExtensionOIDs);
            return cb_getCriticalExtensionOIDs;
        }

        static IntPtr n_GetCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509CertificateObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle(__this.CriticalExtensionOIDs);
        }
#pragma warning restore 0169

        public override unsafe global::System.Collections.Generic.ICollection<string>? CriticalExtensionOIDs
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509CertificateObject']/method[@name='getCriticalExtensionOIDs' and count(parameter)=0]"
            [Register("getCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetCriticalExtensionOIDsHandler")]
            get
            {
                const string __id = "getCriticalExtensionOIDs.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<string>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }

    partial class X509CRLObject
    {

        static Delegate? cb_getRevokedCertificates;
#pragma warning disable 0169
        static Delegate GetGetRevokedCertificatesHandler()
        {
            if (cb_getRevokedCertificates == null)
                cb_getRevokedCertificates = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetRevokedCertificates);
            return cb_getRevokedCertificates;
        }

        static IntPtr n_GetRevokedCertificates(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509CRLObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<Java.Security.Cert.X509CRLEntry>.ToLocalJniHandle(__this.RevokedCertificates);
        }
#pragma warning restore 0169

        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.X509CRLEntry>? RevokedCertificates
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509CRLObject']/method[@name='getRevokedCertificates' and count(parameter)=0]"
            [Register("getRevokedCertificates", "()Ljava/util/Set;", "GetGetRevokedCertificatesHandler")]
            get
            {
                const string __id = "getRevokedCertificates.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<Java.Security.Cert.X509CRLEntry>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static Delegate? cb_getNonCriticalExtensionOIDs;
#pragma warning disable 0169
        static Delegate GetGetNonCriticalExtensionOIDsHandler()
        {
            if (cb_getNonCriticalExtensionOIDs == null)
                cb_getNonCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetNonCriticalExtensionOIDs);
            return cb_getNonCriticalExtensionOIDs;
        }

        static IntPtr n_GetNonCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509CRLObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle(__this.NonCriticalExtensionOIDs);
        }
#pragma warning restore 0169

        public override unsafe global::System.Collections.Generic.ICollection<string>? NonCriticalExtensionOIDs
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509CRLObject']/method[@name='getNonCriticalExtensionOIDs' and count(parameter)=0]"
            [Register("getNonCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetNonCriticalExtensionOIDsHandler")]
            get
            {
                const string __id = "getNonCriticalExtensionOIDs.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<string>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
        static Delegate? cb_getCriticalExtensionOIDs;
#pragma warning disable 0169
        static Delegate GetGetCriticalExtensionOIDsHandler()
        {
            if (cb_getCriticalExtensionOIDs == null)
                cb_getCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetCriticalExtensionOIDs);
            return cb_getCriticalExtensionOIDs;
        }

        static IntPtr n_GetCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509CRLObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle(__this.CriticalExtensionOIDs);
        }
#pragma warning restore 0169

        public override unsafe global::System.Collections.Generic.ICollection<string>? CriticalExtensionOIDs
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509CRLObject']/method[@name='getCriticalExtensionOIDs' and count(parameter)=0]"
            [Register("getCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetCriticalExtensionOIDsHandler")]
            get
            {
                const string __id = "getCriticalExtensionOIDs.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<string>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }

    partial class X509CRLEntryObject
    {

        static Delegate? cb_getNonCriticalExtensionOIDs;
#pragma warning disable 0169
        static Delegate GetGetNonCriticalExtensionOIDsHandler()
        {
            if (cb_getNonCriticalExtensionOIDs == null)
                cb_getNonCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetNonCriticalExtensionOIDs);
            return cb_getNonCriticalExtensionOIDs;
        }

        static IntPtr n_GetNonCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509CRLEntryObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle(__this.NonCriticalExtensionOIDs);
        }
#pragma warning restore 0169

        public override unsafe global::System.Collections.Generic.ICollection<string>? NonCriticalExtensionOIDs
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509CRLEntryObject']/method[@name='getNonCriticalExtensionOIDs' and count(parameter)=0]"
            [Register("getNonCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetNonCriticalExtensionOIDsHandler")]
            get
            {
                const string __id = "getNonCriticalExtensionOIDs.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<string>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
        static Delegate? cb_getCriticalExtensionOIDs;
#pragma warning disable 0169
        static Delegate GetGetCriticalExtensionOIDsHandler()
        {
            if (cb_getCriticalExtensionOIDs == null)
                cb_getCriticalExtensionOIDs = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetCriticalExtensionOIDs);
            return cb_getCriticalExtensionOIDs;
        }

        static IntPtr n_GetCriticalExtensionOIDs(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509CRLEntryObject>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle(__this.CriticalExtensionOIDs);
        }
#pragma warning restore 0169

        public override unsafe global::System.Collections.Generic.ICollection<string>? CriticalExtensionOIDs
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509CRLEntryObject']/method[@name='getCriticalExtensionOIDs' and count(parameter)=0]"
            [Register("getCriticalExtensionOIDs", "()Ljava/util/Set;", "GetGetCriticalExtensionOIDsHandler")]
            get
            {
                const string __id = "getCriticalExtensionOIDs.()Ljava/util/Set;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaSet<string>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }

    partial class X509LDAPCertStoreSpi
    {
        static Delegate? cb_engineGetCRLs_Ljava_security_cert_CRLSelector_;
#pragma warning disable 0169
        static Delegate GetEngineGetCRLs_Ljava_security_cert_CRLSelector_Handler()
        {
            if (cb_engineGetCRLs_Ljava_security_cert_CRLSelector_ == null)
                cb_engineGetCRLs_Ljava_security_cert_CRLSelector_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_EngineGetCRLs_Ljava_security_cert_CRLSelector_);
            return cb_engineGetCRLs_Ljava_security_cert_CRLSelector_;
        }

        static IntPtr n_EngineGetCRLs_Ljava_security_cert_CRLSelector_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509LDAPCertStoreSpi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (global::Java.Security.Cert.ICRLSelector?)global::Java.Lang.Object.GetObject<global::Java.Security.Cert.ICRLSelector>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaCollection<Java.Security.Cert.CRL>.ToLocalJniHandle(__this.EngineGetCRLs(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509LDAPCertStoreSpi']/method[@name='engineGetCRLs' and count(parameter)=1 and parameter[1][@type='java.security.cert.CRLSelector']]"
        [Register("engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", "GetEngineGetCRLs_Ljava_security_cert_CRLSelector_Handler")]
        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.CRL>? EngineGetCRLs(global::Java.Security.Cert.ICRLSelector? p0)
        {
            const string __id = "engineGetCRLs.(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Android.Runtime.JavaCollection<Java.Security.Cert.CRL>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(p0);
            }
        }

        static Delegate? cb_engineGetCertificates_Ljava_security_cert_CertSelector_;
#pragma warning disable 0169
        static Delegate GetEngineGetCertificates_Ljava_security_cert_CertSelector_Handler()
        {
            if (cb_engineGetCertificates_Ljava_security_cert_CertSelector_ == null)
                cb_engineGetCertificates_Ljava_security_cert_CertSelector_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_EngineGetCertificates_Ljava_security_cert_CertSelector_);
            return cb_engineGetCertificates_Ljava_security_cert_CertSelector_;
        }

        static IntPtr n_EngineGetCertificates_Ljava_security_cert_CertSelector_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.X509LDAPCertStoreSpi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (global::Java.Security.Cert.ICertSelector?)global::Java.Lang.Object.GetObject<global::Java.Security.Cert.ICertSelector>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaCollection<Java.Security.Cert.Certificate>.ToLocalJniHandle(__this.EngineGetCertificates(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='X509LDAPCertStoreSpi']/method[@name='engineGetCertificates' and count(parameter)=1 and parameter[1][@type='java.security.cert.CertSelector']]"
        [Register("engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", "GetEngineGetCertificates_Ljava_security_cert_CertSelector_Handler")]
        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.Certificate>? EngineGetCertificates(global::Java.Security.Cert.ICertSelector? p0)
        {
            const string __id = "engineGetCertificates.(Ljava/security/cert/CertSelector;)Ljava/util/Collection;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Android.Runtime.JavaCollection<Java.Security.Cert.Certificate>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(p0);
            }
        }
    }
    partial class MultiCertStoreSpi
    {

        static Delegate? cb_engineGetCRLs_Ljava_security_cert_CRLSelector_;
#pragma warning disable 0169
        static Delegate GetEngineGetCRLs_Ljava_security_cert_CRLSelector_Handler()
        {
            if (cb_engineGetCRLs_Ljava_security_cert_CRLSelector_ == null)
                cb_engineGetCRLs_Ljava_security_cert_CRLSelector_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_EngineGetCRLs_Ljava_security_cert_CRLSelector_);
            return cb_engineGetCRLs_Ljava_security_cert_CRLSelector_;
        }

        static IntPtr n_EngineGetCRLs_Ljava_security_cert_CRLSelector_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.MultiCertStoreSpi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (global::Java.Security.Cert.ICRLSelector?)global::Java.Lang.Object.GetObject<global::Java.Security.Cert.ICRLSelector>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaCollection<Java.Security.Cert.CRL>.ToLocalJniHandle(__this.EngineGetCRLs(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='MultiCertStoreSpi']/method[@name='engineGetCRLs' and count(parameter)=1 and parameter[1][@type='java.security.cert.CRLSelector']]"
        [Register("engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", "GetEngineGetCRLs_Ljava_security_cert_CRLSelector_Handler")]
        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.CRL>? EngineGetCRLs(global::Java.Security.Cert.ICRLSelector? p0)
        {
            const string __id = "engineGetCRLs.(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Android.Runtime.JavaCollection<Java.Security.Cert.CRL>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(p0);
            }
        }

        static Delegate? cb_engineGetCertificates_Ljava_security_cert_CertSelector_;
#pragma warning disable 0169
        static Delegate GetEngineGetCertificates_Ljava_security_cert_CertSelector_Handler()
        {
            if (cb_engineGetCertificates_Ljava_security_cert_CertSelector_ == null)
                cb_engineGetCertificates_Ljava_security_cert_CertSelector_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_EngineGetCertificates_Ljava_security_cert_CertSelector_);
            return cb_engineGetCertificates_Ljava_security_cert_CertSelector_;
        }

        static IntPtr n_EngineGetCertificates_Ljava_security_cert_CertSelector_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.MultiCertStoreSpi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (global::Java.Security.Cert.ICertSelector?)global::Java.Lang.Object.GetObject<global::Java.Security.Cert.ICertSelector>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaCollection<Java.Security.Cert.Certificate>.ToLocalJniHandle(__this.EngineGetCertificates(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='MultiCertStoreSpi']/method[@name='engineGetCertificates' and count(parameter)=1 and parameter[1][@type='java.security.cert.CertSelector']]"
        [Register("engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", "GetEngineGetCertificates_Ljava_security_cert_CertSelector_Handler")]
        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.Certificate>? EngineGetCertificates(global::Java.Security.Cert.ICertSelector? p0)
        {
            const string __id = "engineGetCertificates.(Ljava/security/cert/CertSelector;)Ljava/util/Collection;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Android.Runtime.JavaCollection<Java.Security.Cert.Certificate>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(p0);
            }
        }
    }

    partial class CertStoreCollectionSpi
    {

        static Delegate? cb_engineGetCRLs_Ljava_security_cert_CRLSelector_;
#pragma warning disable 0169
        static Delegate GetEngineGetCRLs_Ljava_security_cert_CRLSelector_Handler()
        {
            if (cb_engineGetCRLs_Ljava_security_cert_CRLSelector_ == null)
                cb_engineGetCRLs_Ljava_security_cert_CRLSelector_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_EngineGetCRLs_Ljava_security_cert_CRLSelector_);
            return cb_engineGetCRLs_Ljava_security_cert_CRLSelector_;
        }

        static IntPtr n_EngineGetCRLs_Ljava_security_cert_CRLSelector_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.CertStoreCollectionSpi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (global::Java.Security.Cert.ICRLSelector?)global::Java.Lang.Object.GetObject<global::Java.Security.Cert.ICRLSelector>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaCollection<Java.Security.Cert.CRL>.ToLocalJniHandle(__this.EngineGetCRLs(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='CertStoreCollectionSpi']/method[@name='engineGetCRLs' and count(parameter)=1 and parameter[1][@type='java.security.cert.CRLSelector']]"
        [Register("engineGetCRLs", "(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;", "GetEngineGetCRLs_Ljava_security_cert_CRLSelector_Handler")]
        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.CRL>? EngineGetCRLs(global::Java.Security.Cert.ICRLSelector? p0)
        {
            const string __id = "engineGetCRLs.(Ljava/security/cert/CRLSelector;)Ljava/util/Collection;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Android.Runtime.JavaCollection<Java.Security.Cert.CRL>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(p0);
            }
        }

        static Delegate? cb_engineGetCertificates_Ljava_security_cert_CertSelector_;
#pragma warning disable 0169
        static Delegate GetEngineGetCertificates_Ljava_security_cert_CertSelector_Handler()
        {
            if (cb_engineGetCertificates_Ljava_security_cert_CertSelector_ == null)
                cb_engineGetCertificates_Ljava_security_cert_CertSelector_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_EngineGetCertificates_Ljava_security_cert_CertSelector_);
            return cb_engineGetCertificates_Ljava_security_cert_CertSelector_;
        }

        static IntPtr n_EngineGetCertificates_Ljava_security_cert_CertSelector_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jce.Provider.CertStoreCollectionSpi>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (global::Java.Security.Cert.ICertSelector?)global::Java.Lang.Object.GetObject<global::Java.Security.Cert.ICertSelector>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaCollection<Java.Security.Cert.Certificate>.ToLocalJniHandle(__this.EngineGetCertificates(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jce.provider']/class[@name='CertStoreCollectionSpi']/method[@name='engineGetCertificates' and count(parameter)=1 and parameter[1][@type='java.security.cert.CertSelector']]"
        [Register("engineGetCertificates", "(Ljava/security/cert/CertSelector;)Ljava/util/Collection;", "GetEngineGetCertificates_Ljava_security_cert_CertSelector_Handler")]
        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.Certificate>? EngineGetCertificates(global::Java.Security.Cert.ICertSelector? p0)
        {
            const string __id = "engineGetCertificates.(Ljava/security/cert/CertSelector;)Ljava/util/Collection;";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Android.Runtime.JavaCollection<Java.Security.Cert.Certificate>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                global::System.GC.KeepAlive(p0);
            }
        }
    }
}

namespace Org.Bouncycastle.Jcajce.Provider.Asymmetric.X509
{
    partial class PKIXCertPath
    {
        static Delegate? cb_getCertificates;
#pragma warning disable 0169
        static Delegate GetGetCertificatesHandler()
        {
            if (cb_getCertificates == null)
                cb_getCertificates = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_L)n_GetCertificates);
            return cb_getCertificates;
        }

        static IntPtr n_GetCertificates(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jcajce.Provider.Asymmetric.X509.PKIXCertPath>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return global::Android.Runtime.JavaList<Java.Security.Cert.Certificate>.ToLocalJniHandle(__this.Certificates);
        }
#pragma warning restore 0169

        public override unsafe global::System.Collections.Generic.IList<Java.Security.Cert.Certificate>? Certificates
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jcajce.provider.asymmetric.x509']/class[@name='PKIXCertPath']/method[@name='getCertificates' and count(parameter)=0]"
            [Register("getCertificates", "()Ljava/util/List;", "GetGetCertificatesHandler")]
            get
            {
                const string __id = "getCertificates.()Ljava/util/List;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                    return global::Android.Runtime.JavaList<Java.Security.Cert.Certificate>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }
}

namespace Org.Bouncycastle.Jcajce.Provider.Asymmetric.X509
{
    partial class CertificateFactory
    {
        static Delegate? cb_engineGenerateCRLs_Ljava_io_InputStream_;
#pragma warning disable 0169
        static Delegate GetDoEngineGenerateCRLs_Ljava_io_InputStream_Handler()
        {
            if (cb_engineGenerateCRLs_Ljava_io_InputStream_ == null)
                cb_engineGenerateCRLs_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_DoEngineGenerateCRLs_Ljava_io_InputStream_);
            return cb_engineGenerateCRLs_Ljava_io_InputStream_;
        }

        static IntPtr n_DoEngineGenerateCRLs_Ljava_io_InputStream_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jcajce.Provider.Asymmetric.X509.CertificateFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaCollection<Java.Security.Cert.CRL>.ToLocalJniHandle(__this.EngineGenerateCRLs(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jcajce.provider.asymmetric.x509']/class[@name='CertificateFactory']/method[@name='engineGenerateCRLs' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
        [Register("engineGenerateCRLs", "(Ljava/io/InputStream;)Ljava/util/Collection;", "GetDoEngineGenerateCRLs_Ljava_io_InputStream_Handler")]
        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.CRL>? EngineGenerateCRLs(global::System.IO.Stream? p0)
        {
            const string __id = "engineGenerateCRLs.(Ljava/io/InputStream;)Ljava/util/Collection;";
            IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle(p0);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_p0);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Android.Runtime.JavaCollection<Java.Security.Cert.CRL>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
                global::System.GC.KeepAlive(p0);
            }
        }


        static Delegate? cb_engineGenerateCertificates_Ljava_io_InputStream_;
#pragma warning disable 0169
        static Delegate GetEngineGenerateCertificates_Ljava_io_InputStream_Handler()
        {
            if (cb_engineGenerateCertificates_Ljava_io_InputStream_ == null)
                cb_engineGenerateCertificates_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate((_JniMarshal_PPL_L)n_EngineGenerateCertificates_Ljava_io_InputStream_);
            return cb_engineGenerateCertificates_Ljava_io_InputStream_;
        }

        static IntPtr n_EngineGenerateCertificates_Ljava_io_InputStream_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Jcajce.Provider.Asymmetric.X509.CertificateFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = global::Android.Runtime.JavaCollection<Java.Security.Cert.Certificate>.ToLocalJniHandle(__this.EngineGenerateCertificates(p0));
            return __ret;
        }
#pragma warning restore 0169

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.jcajce.provider.asymmetric.x509']/class[@name='CertificateFactory']/method[@name='engineGenerateCertificates' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
        [Register("engineGenerateCertificates", "(Ljava/io/InputStream;)Ljava/util/Collection;", "GetEngineGenerateCertificates_Ljava_io_InputStream_Handler")]
        public override unsafe global::System.Collections.Generic.ICollection<Java.Security.Cert.Certificate>? EngineGenerateCertificates(global::System.IO.Stream? p0)
        {
            const string __id = "engineGenerateCertificates.(Ljava/io/InputStream;)Ljava/util/Collection;";
            IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle(p0);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_p0);
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
                return global::Android.Runtime.JavaCollection<Java.Security.Cert.Certificate>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
                global::System.GC.KeepAlive(p0);
            }
        }
    }
}

namespace Org.Bouncycastle.Jcajce
{
    partial class PKIXCertStoreSelector : global::Org.Bouncycastle.Util.ISelector
    {
        bool ISelector.Match(Java.Lang.Object? p0)
            => Match(p0 as Java.Security.Cert.Certificate);
    }
    partial class PKIXCRLStoreSelector : global::Org.Bouncycastle.Util.ISelector
    {
        bool ISelector.Match(Java.Lang.Object? p0)
            => Match(p0 as Java.Security.Cert.CRL);
    }
}

namespace Org.Bouncycastle.Crypto.Modes
{
    partial interface ICFBModeCipher : global::Org.Bouncycastle.Crypto.IMultiBlockCipher, global::Org.Bouncycastle.Crypto.IStreamCipher
    {

    }

    partial class ICFBModeCipherInvoker
    {
        static Delegate? cb_getMultiBlockSize;
#pragma warning disable 0169
        static Delegate GetGetMultiBlockSizeHandler()
        {
            if (cb_getMultiBlockSize == null)
                cb_getMultiBlockSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(n_GetMultiBlockSize));
            return cb_getMultiBlockSize;
        }

        static int n_GetMultiBlockSize(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICFBModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.MultiBlockSize;
        }
#pragma warning restore 0169

        IntPtr id_getMultiBlockSize;
        public unsafe int MultiBlockSize
        {
            get
            {
                if (id_getMultiBlockSize == IntPtr.Zero)
                    id_getMultiBlockSize = JNIEnv.GetMethodID(java_class_ref, "getMultiBlockSize", "()I");
                return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_getMultiBlockSize);
            }
        }

        static Delegate? cb_processBlocks_arrayBIIarrayBI;
#pragma warning disable 0169
        static Delegate GetProcessBlocks_arrayBIIarrayBIHandler()
        {
            if (cb_processBlocks_arrayBIIarrayBI == null)
                cb_processBlocks_arrayBIIarrayBI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILI_I(n_ProcessBlocks_arrayBIIarrayBI));
            return cb_processBlocks_arrayBIIarrayBI;
        }

        static int n_ProcessBlocks_arrayBIIarrayBI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, int p4)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICFBModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (byte[]?)JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
            var p3 = (byte[]?)JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(byte));
            int __ret = __this.ProcessBlocks(p0, p1, p2, p3, p4);
            if (p0 != null)
                JNIEnv.CopyArray(p0, native_p0);
            if (p3 != null)
                JNIEnv.CopyArray(p3, native_p3);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_processBlocks_arrayBIIarrayBI;
        public unsafe int ProcessBlocks(byte[]? p0, int p1, int p2, byte[]? p3, int p4)
        {
            if (id_processBlocks_arrayBIIarrayBI == IntPtr.Zero)
                id_processBlocks_arrayBIIarrayBI = JNIEnv.GetMethodID(java_class_ref, "processBlocks", "([BII[BI)I");
            IntPtr native_p0 = JNIEnv.NewArray(p0);
            IntPtr native_p3 = JNIEnv.NewArray(p3);
            JValue* __args = stackalloc JValue[5];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(p2);
            __args[3] = new JValue(native_p3);
            __args[4] = new JValue(p4);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_processBlocks_arrayBIIarrayBI, __args);
            if (p0 != null)
            {
                JNIEnv.CopyArray(native_p0, p0);
                JNIEnv.DeleteLocalRef(native_p0);
            }
            if (p3 != null)
            {
                JNIEnv.CopyArray(native_p3, p3);
                JNIEnv.DeleteLocalRef(native_p3);
            }
            return __ret;
        }

        static Delegate? cb_getAlgorithmName;
#pragma warning disable 0169
        static Delegate GetGetAlgorithmNameHandler()
        {
            if (cb_getAlgorithmName == null)
                cb_getAlgorithmName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetAlgorithmName));
            return cb_getAlgorithmName;
        }

        static IntPtr n_GetAlgorithmName(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.IMultiBlockCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return JNIEnv.NewString(__this.AlgorithmName);
        }
#pragma warning restore 0169

        IntPtr id_getAlgorithmName;
        public unsafe string? AlgorithmName
        {
            get
            {
                if (id_getAlgorithmName == IntPtr.Zero)
                    id_getAlgorithmName = JNIEnv.GetMethodID(java_class_ref, "getAlgorithmName", "()Ljava/lang/String;");
                return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getAlgorithmName), JniHandleOwnership.TransferLocalRef);
            }
        }

        static Delegate? cb_getBlockSize;
#pragma warning disable 0169
        static Delegate GetGetBlockSizeHandler()
        {
            if (cb_getBlockSize == null)
                cb_getBlockSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(n_GetBlockSize));
            return cb_getBlockSize;
        }

        static int n_GetBlockSize(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICFBModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.BlockSize;
        }
#pragma warning restore 0169

        IntPtr id_getBlockSize;
        public unsafe int BlockSize
        {
            get
            {
                if (id_getBlockSize == IntPtr.Zero)
                    id_getBlockSize = JNIEnv.GetMethodID(java_class_ref, "getBlockSize", "()I");
                return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_getBlockSize);
            }
        }

        static Delegate? cb_init_ZLorg_bouncycastle_crypto_CipherParameters_;
#pragma warning disable 0169
        static Delegate GetInit_ZLorg_bouncycastle_crypto_CipherParameters_Handler()
        {
            if (cb_init_ZLorg_bouncycastle_crypto_CipherParameters_ == null)
                cb_init_ZLorg_bouncycastle_crypto_CipherParameters_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZL_V(n_Init_ZLorg_bouncycastle_crypto_CipherParameters_));
            return cb_init_ZLorg_bouncycastle_crypto_CipherParameters_;
        }

        static void n_Init_ZLorg_bouncycastle_crypto_CipherParameters_(IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.IMultiBlockCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p1 = (global::Org.Bouncycastle.Crypto.ICipherParameters?)global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.ICipherParameters>(native_p1, JniHandleOwnership.DoNotTransfer);
            __this.Init(p0, p1);
        }
#pragma warning restore 0169

        IntPtr id_init_ZLorg_bouncycastle_crypto_CipherParameters_;
        public unsafe void Init(bool p0, global::Org.Bouncycastle.Crypto.ICipherParameters? p1)
        {
            if (id_init_ZLorg_bouncycastle_crypto_CipherParameters_ == IntPtr.Zero)
                id_init_ZLorg_bouncycastle_crypto_CipherParameters_ = JNIEnv.GetMethodID(java_class_ref, "init", "(ZLorg/bouncycastle/crypto/CipherParameters;)V");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(p0);
            __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_init_ZLorg_bouncycastle_crypto_CipherParameters_, __args);
        }

        static Delegate? cb_processBlock_arrayBIarrayBI;
#pragma warning disable 0169
        static Delegate GetProcessBlock_arrayBIarrayBIHandler()
        {
            if (cb_processBlock_arrayBIarrayBI == null)
                cb_processBlock_arrayBIarrayBI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLILI_I(n_ProcessBlock_arrayBIarrayBI));
            return cb_processBlock_arrayBIarrayBI;
        }

        static int n_ProcessBlock_arrayBIarrayBI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICFBModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (byte[]?)JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
            var p2 = (byte[]?)JNIEnv.GetArray(native_p2, JniHandleOwnership.DoNotTransfer, typeof(byte));
            int __ret = __this.ProcessBlock(p0, p1, p2, p3);
            if (p0 != null)
                JNIEnv.CopyArray(p0, native_p0);
            if (p2 != null)
                JNIEnv.CopyArray(p2, native_p2);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_processBlock_arrayBIarrayBI;
        public unsafe int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
        {
            if (id_processBlock_arrayBIarrayBI == IntPtr.Zero)
                id_processBlock_arrayBIarrayBI = JNIEnv.GetMethodID(java_class_ref, "processBlock", "([BI[BI)I");
            IntPtr native_p0 = JNIEnv.NewArray(p0);
            IntPtr native_p2 = JNIEnv.NewArray(p2);
            JValue* __args = stackalloc JValue[4];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(native_p2);
            __args[3] = new JValue(p3);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_processBlock_arrayBIarrayBI, __args);
            if (p0 != null)
            {
                JNIEnv.CopyArray(native_p0, p0);
                JNIEnv.DeleteLocalRef(native_p0);
            }
            if (p2 != null)
            {
                JNIEnv.CopyArray(native_p2, p2);
                JNIEnv.DeleteLocalRef(native_p2);
            }
            return __ret;
        }

        static Delegate? cb_reset;
#pragma warning disable 0169
        static Delegate GetResetHandler()
        {
            if (cb_reset == null)
                cb_reset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(n_Reset));
            return cb_reset;
        }

        static void n_Reset(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.IMultiBlockCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            __this.Reset();
        }
#pragma warning restore 0169

        IntPtr id_reset;
        public unsafe void Reset()
        {
            if (id_reset == IntPtr.Zero)
                id_reset = JNIEnv.GetMethodID(java_class_ref, "reset", "()V");
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_reset);
        }

        static Delegate? cb_processBytes_arrayBIIarrayBI;
#pragma warning disable 0169
        static Delegate GetProcessBytes_arrayBIIarrayBIHandler()
        {
            if (cb_processBytes_arrayBIIarrayBI == null)
                cb_processBytes_arrayBIIarrayBI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILI_I(n_ProcessBytes_arrayBIIarrayBI));
            return cb_processBytes_arrayBIIarrayBI;
        }

        static int n_ProcessBytes_arrayBIIarrayBI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, int p4)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICFBModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (byte[]?)JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
            var p3 = (byte[]?)JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(byte));
            int __ret = __this.ProcessBytes(p0, p1, p2, p3, p4);
            if (p0 != null)
                JNIEnv.CopyArray(p0, native_p0);
            if (p3 != null)
                JNIEnv.CopyArray(p3, native_p3);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_processBytes_arrayBIIarrayBI;
        public unsafe int ProcessBytes(byte[]? p0, int p1, int p2, byte[]? p3, int p4)
        {
            if (id_processBytes_arrayBIIarrayBI == IntPtr.Zero)
                id_processBytes_arrayBIIarrayBI = JNIEnv.GetMethodID(java_class_ref, "processBytes", "([BII[BI)I");
            IntPtr native_p0 = JNIEnv.NewArray(p0);
            IntPtr native_p3 = JNIEnv.NewArray(p3);
            JValue* __args = stackalloc JValue[5];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(p2);
            __args[3] = new JValue(native_p3);
            __args[4] = new JValue(p4);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_processBytes_arrayBIIarrayBI, __args);
            if (p0 != null)
            {
                JNIEnv.CopyArray(native_p0, p0);
                JNIEnv.DeleteLocalRef(native_p0);
            }
            if (p3 != null)
            {
                JNIEnv.CopyArray(native_p3, p3);
                JNIEnv.DeleteLocalRef(native_p3);
            }
            return __ret;
        }

        static Delegate? cb_returnByte_B;
#pragma warning disable 0169
        static Delegate GetReturnByte_BHandler()
        {
            if (cb_returnByte_B == null)
                cb_returnByte_B = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPB_B(n_ReturnByte_B));
            return cb_returnByte_B;
        }

        static sbyte n_ReturnByte_B(IntPtr jnienv, IntPtr native__this, sbyte p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICFBModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.ReturnByte(p0);
        }
#pragma warning restore 0169

        IntPtr id_returnByte_B;
        public unsafe sbyte ReturnByte(sbyte p0)
        {
            if (id_returnByte_B == IntPtr.Zero)
                id_returnByte_B = JNIEnv.GetMethodID(java_class_ref, "returnByte", "(B)B");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(p0);
            return JNIEnv.CallByteMethod(((global::Java.Lang.Object)this).Handle, id_returnByte_B, __args);
        }

    }
}

namespace Org.Bouncycastle.Crypto.Modes
{
    partial interface ICTRModeCipher : global::Org.Bouncycastle.Crypto.IMultiBlockCipher, global::Org.Bouncycastle.Crypto.ISkippingStreamCipher { }

    partial class ICTRModeCipherInvoker
    {
        static Delegate? cb_getMultiBlockSize;
#pragma warning disable 0169
        static Delegate GetGetMultiBlockSizeHandler()
        {
            if (cb_getMultiBlockSize == null)
                cb_getMultiBlockSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(n_GetMultiBlockSize));
            return cb_getMultiBlockSize;
        }

        static int n_GetMultiBlockSize(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.MultiBlockSize;
        }
#pragma warning restore 0169

        IntPtr id_getMultiBlockSize;
        public unsafe int MultiBlockSize
        {
            get
            {
                if (id_getMultiBlockSize == IntPtr.Zero)
                    id_getMultiBlockSize = JNIEnv.GetMethodID(java_class_ref, "getMultiBlockSize", "()I");
                return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_getMultiBlockSize);
            }
        }

        static Delegate? cb_processBlocks_arrayBIIarrayBI;
#pragma warning disable 0169
        static Delegate GetProcessBlocks_arrayBIIarrayBIHandler()
        {
            if (cb_processBlocks_arrayBIIarrayBI == null)
                cb_processBlocks_arrayBIIarrayBI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILI_I(n_ProcessBlocks_arrayBIIarrayBI));
            return cb_processBlocks_arrayBIIarrayBI;
        }

        static int n_ProcessBlocks_arrayBIIarrayBI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, int p4)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (byte[]?)JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
            var p3 = (byte[]?)JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(byte));
            int __ret = __this.ProcessBlocks(p0, p1, p2, p3, p4);
            if (p0 != null)
                JNIEnv.CopyArray(p0, native_p0);
            if (p3 != null)
                JNIEnv.CopyArray(p3, native_p3);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_processBlocks_arrayBIIarrayBI;
        public unsafe int ProcessBlocks(byte[]? p0, int p1, int p2, byte[]? p3, int p4)
        {
            if (id_processBlocks_arrayBIIarrayBI == IntPtr.Zero)
                id_processBlocks_arrayBIIarrayBI = JNIEnv.GetMethodID(java_class_ref, "processBlocks", "([BII[BI)I");
            IntPtr native_p0 = JNIEnv.NewArray(p0);
            IntPtr native_p3 = JNIEnv.NewArray(p3);
            JValue* __args = stackalloc JValue[5];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(p2);
            __args[3] = new JValue(native_p3);
            __args[4] = new JValue(p4);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_processBlocks_arrayBIIarrayBI, __args);
            if (p0 != null)
            {
                JNIEnv.CopyArray(native_p0, p0);
                JNIEnv.DeleteLocalRef(native_p0);
            }
            if (p3 != null)
            {
                JNIEnv.CopyArray(native_p3, p3);
                JNIEnv.DeleteLocalRef(native_p3);
            }
            return __ret;
        }

        static Delegate? cb_getAlgorithmName;
#pragma warning disable 0169
        static Delegate GetGetAlgorithmNameHandler()
        {
            if (cb_getAlgorithmName == null)
                cb_getAlgorithmName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(n_GetAlgorithmName));
            return cb_getAlgorithmName;
        }

        static IntPtr n_GetAlgorithmName(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.IMultiBlockCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return JNIEnv.NewString(__this.AlgorithmName);
        }
#pragma warning restore 0169

        IntPtr id_getAlgorithmName;
        public unsafe string? AlgorithmName
        {
            get
            {
                if (id_getAlgorithmName == IntPtr.Zero)
                    id_getAlgorithmName = JNIEnv.GetMethodID(java_class_ref, "getAlgorithmName", "()Ljava/lang/String;");
                return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getAlgorithmName), JniHandleOwnership.TransferLocalRef);
            }
        }

        static Delegate? cb_getBlockSize;
#pragma warning disable 0169
        static Delegate GetGetBlockSizeHandler()
        {
            if (cb_getBlockSize == null)
                cb_getBlockSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(n_GetBlockSize));
            return cb_getBlockSize;
        }

        static int n_GetBlockSize(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.BlockSize;
        }
#pragma warning restore 0169

        IntPtr id_getBlockSize;
        public unsafe int BlockSize
        {
            get
            {
                if (id_getBlockSize == IntPtr.Zero)
                    id_getBlockSize = JNIEnv.GetMethodID(java_class_ref, "getBlockSize", "()I");
                return JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_getBlockSize);
            }
        }

        static Delegate? cb_init_ZLorg_bouncycastle_crypto_CipherParameters_;
#pragma warning disable 0169
        static Delegate GetInit_ZLorg_bouncycastle_crypto_CipherParameters_Handler()
        {
            if (cb_init_ZLorg_bouncycastle_crypto_CipherParameters_ == null)
                cb_init_ZLorg_bouncycastle_crypto_CipherParameters_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZL_V(n_Init_ZLorg_bouncycastle_crypto_CipherParameters_));
            return cb_init_ZLorg_bouncycastle_crypto_CipherParameters_;
        }

        static void n_Init_ZLorg_bouncycastle_crypto_CipherParameters_(IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.IMultiBlockCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p1 = (global::Org.Bouncycastle.Crypto.ICipherParameters?)global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.ICipherParameters>(native_p1, JniHandleOwnership.DoNotTransfer);
            __this.Init(p0, p1);
        }
#pragma warning restore 0169

        IntPtr id_init_ZLorg_bouncycastle_crypto_CipherParameters_;
        public unsafe void Init(bool p0, global::Org.Bouncycastle.Crypto.ICipherParameters? p1)
        {
            if (id_init_ZLorg_bouncycastle_crypto_CipherParameters_ == IntPtr.Zero)
                id_init_ZLorg_bouncycastle_crypto_CipherParameters_ = JNIEnv.GetMethodID(java_class_ref, "init", "(ZLorg/bouncycastle/crypto/CipherParameters;)V");
            JValue* __args = stackalloc JValue[2];
            __args[0] = new JValue(p0);
            __args[1] = new JValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_init_ZLorg_bouncycastle_crypto_CipherParameters_, __args);
        }

        static Delegate? cb_processBlock_arrayBIarrayBI;
#pragma warning disable 0169
        static Delegate GetProcessBlock_arrayBIarrayBIHandler()
        {
            if (cb_processBlock_arrayBIarrayBI == null)
                cb_processBlock_arrayBIarrayBI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLILI_I(n_ProcessBlock_arrayBIarrayBI));
            return cb_processBlock_arrayBIarrayBI;
        }

        static int n_ProcessBlock_arrayBIarrayBI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (byte[]?)JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
            var p2 = (byte[]?)JNIEnv.GetArray(native_p2, JniHandleOwnership.DoNotTransfer, typeof(byte));
            int __ret = __this.ProcessBlock(p0, p1, p2, p3);
            if (p0 != null)
                JNIEnv.CopyArray(p0, native_p0);
            if (p2 != null)
                JNIEnv.CopyArray(p2, native_p2);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_processBlock_arrayBIarrayBI;
        public unsafe int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
        {
            if (id_processBlock_arrayBIarrayBI == IntPtr.Zero)
                id_processBlock_arrayBIarrayBI = JNIEnv.GetMethodID(java_class_ref, "processBlock", "([BI[BI)I");
            IntPtr native_p0 = JNIEnv.NewArray(p0);
            IntPtr native_p2 = JNIEnv.NewArray(p2);
            JValue* __args = stackalloc JValue[4];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(native_p2);
            __args[3] = new JValue(p3);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_processBlock_arrayBIarrayBI, __args);
            if (p0 != null)
            {
                JNIEnv.CopyArray(native_p0, p0);
                JNIEnv.DeleteLocalRef(native_p0);
            }
            if (p2 != null)
            {
                JNIEnv.CopyArray(native_p2, p2);
                JNIEnv.DeleteLocalRef(native_p2);
            }
            return __ret;
        }

        static Delegate? cb_reset;
#pragma warning disable 0169
        static Delegate GetResetHandler()
        {
            if (cb_reset == null)
                cb_reset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(n_Reset));
            return cb_reset;
        }

        static void n_Reset(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.IMultiBlockCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            __this.Reset();
        }
#pragma warning restore 0169

        IntPtr id_reset;
        public unsafe void Reset()
        {
            if (id_reset == IntPtr.Zero)
                id_reset = JNIEnv.GetMethodID(java_class_ref, "reset", "()V");
            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_reset);
        }

        static Delegate? cb_getPosition;
#pragma warning disable 0169
        static Delegate GetGetPositionHandler()
        {
            if (cb_getPosition == null)
                cb_getPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(n_GetPosition));
            return cb_getPosition;
        }

        static long n_GetPosition(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.Position;
        }
#pragma warning restore 0169

        IntPtr id_getPosition;
        public unsafe long Position
        {
            get
            {
                if (id_getPosition == IntPtr.Zero)
                    id_getPosition = JNIEnv.GetMethodID(java_class_ref, "getPosition", "()J");
                return JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_getPosition);
            }
        }

        static Delegate? cb_seekTo_J;
#pragma warning disable 0169
        static Delegate GetSeekTo_JHandler()
        {
            if (cb_seekTo_J == null)
                cb_seekTo_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_J(n_SeekTo_J));
            return cb_seekTo_J;
        }

        static long n_SeekTo_J(IntPtr jnienv, IntPtr native__this, long p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.SeekTo(p0);
        }
#pragma warning restore 0169

        IntPtr id_seekTo_J;
        public unsafe long SeekTo(long p0)
        {
            if (id_seekTo_J == IntPtr.Zero)
                id_seekTo_J = JNIEnv.GetMethodID(java_class_ref, "seekTo", "(J)J");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(p0);
            return JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_seekTo_J, __args);
        }

        static Delegate? cb_skip_J;
#pragma warning disable 0169
        static Delegate GetSkip_JHandler()
        {
            if (cb_skip_J == null)
                cb_skip_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_J(n_Skip_J));
            return cb_skip_J;
        }

        static long n_Skip_J(IntPtr jnienv, IntPtr native__this, long p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.Skip(p0);
        }
#pragma warning restore 0169

        IntPtr id_skip_J;
        public unsafe long Skip(long p0)
        {
            if (id_skip_J == IntPtr.Zero)
                id_skip_J = JNIEnv.GetMethodID(java_class_ref, "skip", "(J)J");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(p0);
            return JNIEnv.CallLongMethod(((global::Java.Lang.Object)this).Handle, id_skip_J, __args);
        }

        static Delegate? cb_processBytes_arrayBIIarrayBI;
#pragma warning disable 0169
        static Delegate GetProcessBytes_arrayBIIarrayBIHandler()
        {
            if (cb_processBytes_arrayBIIarrayBI == null)
                cb_processBytes_arrayBIIarrayBI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILI_I(n_ProcessBytes_arrayBIIarrayBI));
            return cb_processBytes_arrayBIIarrayBI;
        }

        static int n_ProcessBytes_arrayBIIarrayBI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3, int p4)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            var p0 = (byte[]?)JNIEnv.GetArray(native_p0, JniHandleOwnership.DoNotTransfer, typeof(byte));
            var p3 = (byte[]?)JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(byte));
            int __ret = __this.ProcessBytes(p0, p1, p2, p3, p4);
            if (p0 != null)
                JNIEnv.CopyArray(p0, native_p0);
            if (p3 != null)
                JNIEnv.CopyArray(p3, native_p3);
            return __ret;
        }
#pragma warning restore 0169

        IntPtr id_processBytes_arrayBIIarrayBI;
        public unsafe int ProcessBytes(byte[]? p0, int p1, int p2, byte[]? p3, int p4)
        {
            if (id_processBytes_arrayBIIarrayBI == IntPtr.Zero)
                id_processBytes_arrayBIIarrayBI = JNIEnv.GetMethodID(java_class_ref, "processBytes", "([BII[BI)I");
            IntPtr native_p0 = JNIEnv.NewArray(p0);
            IntPtr native_p3 = JNIEnv.NewArray(p3);
            JValue* __args = stackalloc JValue[5];
            __args[0] = new JValue(native_p0);
            __args[1] = new JValue(p1);
            __args[2] = new JValue(p2);
            __args[3] = new JValue(native_p3);
            __args[4] = new JValue(p4);
            var __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_processBytes_arrayBIIarrayBI, __args);
            if (p0 != null)
            {
                JNIEnv.CopyArray(native_p0, p0);
                JNIEnv.DeleteLocalRef(native_p0);
            }
            if (p3 != null)
            {
                JNIEnv.CopyArray(native_p3, p3);
                JNIEnv.DeleteLocalRef(native_p3);
            }
            return __ret;
        }

        static Delegate? cb_returnByte_B;
#pragma warning disable 0169
        static Delegate GetReturnByte_BHandler()
        {
            if (cb_returnByte_B == null)
                cb_returnByte_B = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPB_B(n_ReturnByte_B));
            return cb_returnByte_B;
        }

        static sbyte n_ReturnByte_B(IntPtr jnienv, IntPtr native__this, sbyte p0)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.Modes.ICTRModeCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.ReturnByte(p0);
        }
#pragma warning restore 0169

        IntPtr id_returnByte_B;
        public unsafe sbyte ReturnByte(sbyte p0)
        {
            if (id_returnByte_B == IntPtr.Zero)
                id_returnByte_B = JNIEnv.GetMethodID(java_class_ref, "returnByte", "(B)B");
            JValue* __args = stackalloc JValue[1];
            __args[0] = new JValue(p0);
            return JNIEnv.CallByteMethod(((global::Java.Lang.Object)this).Handle, id_returnByte_B, __args);
        }

    }
}