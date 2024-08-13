#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Androidx.Media3.Extractor.Text.Cea {
    partial class CeaDecoder : global::Androidx.Media3.Extractor.Text.ISubtitleDecoder {
        global::Java.Lang.Object Androidx.Media3.Decoder.IDecoder.DequeueOutputBuffer () => DequeueOutputBuffer ();
        global::Java.Lang.Object Androidx.Media3.Decoder.IDecoder.DequeueInputBuffer () => DequeueInputBuffer ();
        void Androidx.Media3.Decoder.IDecoder.QueueInputBuffer (global::Java.Lang.Object? p0)
            => QueueInputBuffer (p0 as global::Androidx.Media3.Extractor.Text.SubtitleInputBuffer);
    }
}