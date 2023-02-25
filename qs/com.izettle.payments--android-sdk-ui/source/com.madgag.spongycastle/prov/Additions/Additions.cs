
namespace Org.Spongycastle.Jcajce
{
    partial class PKIXCertStoreSelector
    {
        Java.Security.Cert.CertPath x;

        public virtual unsafe bool Match(global::Java.Lang.Object cert)
            => Match(cert as global::Java.Security.Cert.Certificate);
    }
    partial class PKIXCRLStoreSelector
    {
        public virtual unsafe bool Match(global::Java.Lang.Object cert)
            => Match(cert as global::Java.Security.Cert.Certificate);
    }
}