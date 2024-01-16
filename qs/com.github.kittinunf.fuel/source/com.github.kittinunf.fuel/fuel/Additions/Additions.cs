namespace Com.Github.Kittinunf.Fuel.Core.Requests
{
    partial class UploadRequest
    {
        global::Com.Github.Kittinunf.Fuel.Core.IRequest global::Com.Github.Kittinunf.Fuel.Core.IRequestFactory.IRequestConvertible.Request => Request;
    }
    partial class DownloadRequest
    {
        global::Com.Github.Kittinunf.Fuel.Core.IRequest global::Com.Github.Kittinunf.Fuel.Core.IRequestFactory.IRequestConvertible.Request => Request;
    }
    partial class CancellableRequest
    {
        global::Com.Github.Kittinunf.Fuel.Core.IRequest global::Com.Github.Kittinunf.Fuel.Core.IRequestFactory.IRequestConvertible.Request => Request;
        global::Java.Lang.Object global::Java.Util.Concurrent.IFuture.Get() => Get();
        global::Java.Lang.Object global::Java.Util.Concurrent.IFuture.Get(long p0, global::Java.Util.Concurrent.TimeUnit p1) => Get(p0, p1);
    }
}

namespace Com.Github.Kittinunf.Fuel.Core.Extensions
{
    partial class AuthenticatedRequest
    {
        global::Com.Github.Kittinunf.Fuel.Core.IRequest global::Com.Github.Kittinunf.Fuel.Core.IRequestFactory.IRequestConvertible.Request => Request;
    }
}

namespace Com.Github.Kittinunf.Fuel.Core
{
    partial class InlineDataPart
    {
        public unsafe override global::System.IO.Stream InputStream()
        {
            return InvokeInputStream();
        }
    }
    partial class BlobDataPart
    {
        public unsafe override global::System.IO.Stream InputStream()
        {
            return InvokeInputStream();
        }
    }
}