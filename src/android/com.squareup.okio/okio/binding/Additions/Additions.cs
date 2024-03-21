using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;
using Java.Nio.Charset;

namespace Okio
{
    partial class Options
    {
        public override Java.Lang.Object Get(int index) => GetX(index);
    }

    partial class ByteString : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as ByteString);
    }

    partial class Path : global::Java.Lang.IComparable
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
            => CompareTo(o as Path);
    }

    partial interface IBufferedSink
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSink']/method[@name='close' and count(parameter)=0]"
        [Register("close", "()V", "GetCloseHandler:Okio.IBufferedSinkInvoker, Square.OkIO")]
        void Close();
    }

    partial interface IBufferedSource
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='BufferedSource']/method[@name='close' and count(parameter)=0]"
        [Register("close", "()V", "GetCloseHandler:Okio.IBufferedSourceInvoker, Square.OkIO")]
        void Close();
    }

    partial class Buffer : global::Okio.IBufferedSink
    {
        IBufferedSink IBufferedSink.Emit() => Emit();

        IBufferedSink IBufferedSink.EmitCompleteSegments() => EmitCompleteSegments();

        IBufferedSink IBufferedSink.Write(byte[] source) => Write(source);

        IBufferedSink IBufferedSink.Write(byte[] source, int offset, int byteCount)
            => Write(source, offset, byteCount);

        IBufferedSink IBufferedSink.Write(ByteString byteString)
            => Write(byteString);

        IBufferedSink IBufferedSink.Write(ByteString byteString, int offset, int byteCount)
            => Write(byteString, offset, byteCount);

        IBufferedSink IBufferedSink.Write(ISource source, long byteCount)
            => Write(source, byteCount);

        IBufferedSink IBufferedSink.WriteByte(int b)
            => WriteByte(b);

        IBufferedSink IBufferedSink.WriteDecimalLong(long v)
            => WriteDecimalLong(v);

        IBufferedSink IBufferedSink.WriteHexadecimalUnsignedLong(long v)
            => WriteHexadecimalUnsignedLong(v);

        IBufferedSink IBufferedSink.WriteInt(int i)
            => WriteInt(i);

        IBufferedSink IBufferedSink.WriteIntLe(int i)
            => WriteIntLe(i);

        IBufferedSink IBufferedSink.WriteLong(long v)
            => WriteLong(v);

        IBufferedSink IBufferedSink.WriteLongLe(long v)
            => WriteLongLe(v);

        IBufferedSink IBufferedSink.WriteShort(int s)
            => WriteShort(s);

        IBufferedSink IBufferedSink.WriteShortLe(int s)
            => WriteShortLe(s);

        IBufferedSink IBufferedSink.WriteString(string @string, int beginIndex, int endIndex, Charset charset)
            => WriteString(@string, beginIndex, endIndex, charset); 

        IBufferedSink IBufferedSink.WriteString(string @string, Charset charset)
            => WriteString(@string, charset);

        IBufferedSink IBufferedSink.WriteUtf8(string @string)
            => WriteUtf8(@string);

        IBufferedSink IBufferedSink.WriteUtf8(string @string, int beginIndex, int endIndex)
            => WriteUtf8(@string, beginIndex, endIndex);

        IBufferedSink IBufferedSink.WriteUtf8CodePoint(int codePoint)
            => WriteUtf8CodePoint(codePoint);
    }
}