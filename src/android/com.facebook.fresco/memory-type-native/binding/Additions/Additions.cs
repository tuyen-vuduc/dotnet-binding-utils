using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Imagepipeline.Memory
{
    partial class NativeMemoryChunkPool
    {
        protected override Java.Lang.Object? Alloc(int p0)
            => Alloc_(p0);

        protected override void Free(Java.Lang.Object? p0)
            => Free(p0 as global::Com.Facebook.Imagepipeline.Memory.IMemoryChunk);

        protected override int GetBucketedSizeForValue(Java.Lang.Object? p0)
            => GetBucketedSizeForValue(p0 as global::Com.Facebook.Imagepipeline.Memory.IMemoryChunk);
    }
}