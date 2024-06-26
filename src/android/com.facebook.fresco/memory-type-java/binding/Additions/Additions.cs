
namespace Com.Facebook.Imagepipeline.Memory {
    partial class BufferMemoryChunkPool
    {
        protected override Java.Lang.Object? Alloc(int p0)
            => Alloc_(p0);

        protected override void Free(Java.Lang.Object? p0)
            => Free(p0 as global::Com.Facebook.Imagepipeline.Memory.IMemoryChunk);

        protected override int GetBucketedSizeForValue(Java.Lang.Object? p0)
            => GetBucketedSizeForValue(p0 as global::Com.Facebook.Imagepipeline.Memory.IMemoryChunk);
    }
}