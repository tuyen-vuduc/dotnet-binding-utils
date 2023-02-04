
namespace Org.Spongycastle.Jcajce
{
    partial class PKIXCertStoreSelector
    {
        public virtual unsafe bool Match(global::Java.Lang.Object cert)
            => Match(cert as global::Java.Security.Cert.Certificate);
    }
    partial class PKIXCRLStoreSelector
    {
        public virtual unsafe bool Match(global::Java.Lang.Object cert)
            => Match(cert as global::Java.Security.Cert.Certificate);
    }
}