#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Squareup.Wire {
    partial class ProtoAdapter {
        partial class Companion {
            partial class UnsupportedTypeProtoAdapter
            {
                public override Java.Lang.Object? Decode(ProtoReader reader)
                    => Decode_(reader);

                public override void Encode(ProtoWriter writer, Java.Lang.Object? value)
                    => Encode_(writer, value as Java.Lang.Void);

                public override int EncodedSize(Java.Lang.Object? value)
                {
                    EncodedSize_(value as Java.Lang.Void);
                    return 0;
                }

                public override Java.Lang.Object? Redact(Java.Lang.Object? value)
                    => Redact_(value as Java.Lang.Void);
            }
        }
    }
    partial class AnyMessage
    {
        public override Java.Lang.Object NewBuilder()
            => NewBuilder_();
    }
}

namespace Com.Squareup.Wire.Internal {
    partial class EnumJsonFormatter : global::Com.Squareup.Wire.Internal.IJsonFormatter
    {
        Java.Lang.Object? IJsonFormatter.FromString(string value)
            => FromString(value);

        Java.Lang.Object IJsonFormatter.ToStringOrNumber(Java.Lang.Object value)
            => ToStringOrNumber(value);
    }
}