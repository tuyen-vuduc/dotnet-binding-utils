#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Pusher.Client.Channel.Impl {
    partial class ChannelImpl {
        int global::Java.Lang.IComparable.CompareTo(global::Java.Lang.Object o)
            => o is global::Com.Pusher.Client.Channel.Impl.IInternalChannel s ? CompareTo(s) : -1;
    }
}
namespace Com.Pusher.Client.Channel { 
    partial class PusherEventDeserializer {
        
        Java.Lang.Object? global::GoogleGson.IJsonDeserializer.Deserialize(global::GoogleGson.JsonElement? p0, Java.Lang.Reflect.IType? p1, global::GoogleGson.IJsonDeserializationContext? p2)
            => Deserialize(p0, p1, p2);
    }
}