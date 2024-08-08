#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Java_websocket.Handshake
{
    partial class HandshakeImpl1Client
    {
        void global::Org.Java_websocket.Handshake.IClientHandshakeBuilder.SetResourceDescriptor(string? value) => ResourceDescriptor = value;
    }
    partial class HandshakeImpl1Server
    {
        void global::Org.Java_websocket.Handshake.IServerHandshakeBuilder.SetHttpStatus(short value) => HttpStatus = value;
        void global::Org.Java_websocket.Handshake.IServerHandshakeBuilder.SetHttpStatusMessage(string? value) => HttpStatusMessage = value;
    }
}
namespace Org.Java_websocket.Server
{
    partial class DefaultSSLWebSocketServerFactory
    {
        unsafe global::Org.Java_websocket.IWebSocket? global::Org.Java_websocket.IWebSocketFactory.CreateWebSocket(global::Org.Java_websocket.WebSocketAdapter? a, global::Org.Java_websocket.Drafts.Draft? d)
            => CreateWebSocket(a, d);
        unsafe global::Org.Java_websocket.IWebSocket? global::Org.Java_websocket.IWebSocketFactory.CreateWebSocket(global::Org.Java_websocket.WebSocketAdapter? a, global::System.Collections.Generic.IList<global::Org.Java_websocket.Drafts.Draft>? d)
            => CreateWebSocket(a, d);
    }
    partial class DefaultWebSocketServerFactory
    {
        unsafe global::Org.Java_websocket.IWebSocket? global::Org.Java_websocket.IWebSocketFactory.CreateWebSocket(global::Org.Java_websocket.WebSocketAdapter? a, global::Org.Java_websocket.Drafts.Draft? d)
            => CreateWebSocket(a, d);
        unsafe global::Org.Java_websocket.IWebSocket? global::Org.Java_websocket.IWebSocketFactory.CreateWebSocket(global::Org.Java_websocket.WebSocketAdapter? a, global::System.Collections.Generic.IList<global::Org.Java_websocket.Drafts.Draft>? d)
            => CreateWebSocket(a, d);
        unsafe global::Java.Nio.Channels.IByteChannel? global::Org.Java_websocket.IWebSocketServerFactory.WrapChannel(global::Java.Nio.Channels.SocketChannel? channel, global::Java.Nio.Channels.SelectionKey? key)
            => WrapChannel(channel, key);
    }
}