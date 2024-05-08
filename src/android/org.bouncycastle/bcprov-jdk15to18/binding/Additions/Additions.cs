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
                    id_getCriticalExtensionOIDs = JNIEnv.GetMethodID(class_ref, "getCriticalExtensionOIDs", "()Ljava/util/Set;");
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
                    id_hasUnsupportedCriticalExtension = JNIEnv.GetMethodID(class_ref, "hasUnsupportedCriticalExtension", "()Z");
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
                    id_getNonCriticalExtensionOIDs = JNIEnv.GetMethodID(class_ref, "getNonCriticalExtensionOIDs", "()Ljava/util/Set;");
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
                id_getExtensionValue_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "getExtensionValue", "(Ljava/lang/String;)[B");
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
    partial class CFBBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
    partial class G3413CFBBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
    partial class G3413CTRBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
    partial class G3413OFBBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
    partial class GCFBBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
    partial class GOFBBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
    partial class KCTRBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
    partial class OFBBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
    partial class SICBlockCipher
    {
        public override int BlockSize => GetBlockSize();
        public override int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
            => DoProcessBlock(p0, p1, p2, p3);
    }
}

namespace Org.Bouncycastle.Crypto
{
    partial class StreamBlockCipher : global::Org.Bouncycastle.Crypto.IBlockCipher
    {
        static Delegate? cb_getBlockSize;
#pragma warning disable 0169
        static Delegate GetGetBlockSizeHandler()
        {
            if (cb_getBlockSize == null)
                cb_getBlockSize = JNINativeWrapper.CreateDelegate((_JniMarshal_PP_I)n_GetBlockSize);
            return cb_getBlockSize;
        }

        static int n_GetBlockSize(IntPtr jnienv, IntPtr native__this)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.StreamBlockCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
            return __this.BlockSize;
        }
#pragma warning restore 0169

        public abstract int BlockSize
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.crypto']/class[@name='StreamBlockCipher']/method[@name='getBlockSize' and count(parameter)=0]"
            [Register("getBlockSize", "()I", "GetGetBlockSizeHandler")]
            get;
        }

        static Delegate? cb_processBlock_arrayBIarrayBI;
#pragma warning disable 0169
        static Delegate GetProcessBlock_arrayBIarrayBIHandler()
        {
            if (cb_processBlock_arrayBIarrayBI == null)
                cb_processBlock_arrayBIarrayBI = JNINativeWrapper.CreateDelegate((_JniMarshal_PPLILI_I)n_ProcessBlock_arrayBIarrayBI);
            return cb_processBlock_arrayBIarrayBI;
        }

        static int n_ProcessBlock_arrayBIarrayBI(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3)
        {
            var __this = global::Java.Lang.Object.GetObject<global::Org.Bouncycastle.Crypto.StreamBlockCipher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.crypto']/class[@name='StreamBlockCipher']/method[@name='processBlock' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
        [Register("processBlock", "([BI[BI)I", "GetProcessBlock_arrayBIarrayBIHandler")]
        public abstract int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3);
    }

    partial class StreamBlockCipherInvoker
    {
        public override unsafe int BlockSize
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.crypto']/class[@name='StreamBlockCipher']/method[@name='getBlockSize' and count(parameter)=0]"
            [Register("getBlockSize", "()I", "GetGetBlockSizeHandler")]
            get
            {
                const string __id = "getBlockSize.()I";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractInt32Method(__id, this, null);
                    return __rm;
                }
                finally
                {
                }
            }
        }

        // Metadata.xml XPath method reference: path="/api/package[@name='org.bouncycastle.crypto']/class[@name='StreamBlockCipher']/method[@name='processBlock' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
        [Register("processBlock", "([BI[BI)I", "GetProcessBlock_arrayBIarrayBIHandler")]
        public override unsafe int ProcessBlock(byte[]? p0, int p1, byte[]? p2, int p3)
        {
            const string __id = "processBlock.([BI[BI)I";
            IntPtr native_p0 = JNIEnv.NewArray(p0);
            IntPtr native_p2 = JNIEnv.NewArray(p2);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[4];
                __args[0] = new JniArgumentValue(native_p0);
                __args[1] = new JniArgumentValue(p1);
                __args[2] = new JniArgumentValue(native_p2);
                __args[3] = new JniArgumentValue(p3);
                var __rm = _members.InstanceMethods.InvokeAbstractInt32Method(__id, this, __args);
                return __rm;
            }
            finally
            {
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
                global::System.GC.KeepAlive(p0);
                global::System.GC.KeepAlive(p2);
            }
        }
    }
}