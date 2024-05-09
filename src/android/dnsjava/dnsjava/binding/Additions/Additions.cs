using System.Collections.Generic;
using Android.Runtime;
using Java.Util.Concurrent;

namespace Org.Xbill.DNS
{
    partial class Record
    {
        [Register("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
        public virtual int CompareTo(global::Java.Lang.Object o)
        {
            return CompareTo(o as Record);
        }
    }

    partial class Name
    {
        [Register("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
        public virtual int CompareTo(global::Java.Lang.Object o)
        {
            return CompareTo(o as Name);
        }
    }

    partial class SimpleResolver : IResolver
    {
        ICompletionStage IResolver.SendAsync(Message query)
            => SendAsync(query);

        void IResolver.SetEDNS(int version, int payloadSize, int flags, IList<EDNSOption> options)
            => SetEDNS(version, payloadSize, flags, options);

        void IResolver.SetIgnoreTruncation(bool p0)
            => IgnoreTruncation = p0;

        void IResolver.SetPort(int p0)
            => Port = p0;

        void IResolver.SetTCP(bool p0)
            => TCP = p0;

        void IResolver.SetTSIGKey(TSIG p0)
            => TSIGKey = p0;
    }
}