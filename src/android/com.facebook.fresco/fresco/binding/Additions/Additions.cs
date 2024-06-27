
#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Facebook.Common.Internal;
using Com.Facebook.Datasource;
using Com.Facebook.Drawee.Controller;
using Com.Facebook.Drawee.Interfaces;
using Com.Facebook.Fresco.UI.Common;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline
{
    partial class PipelineDraweeControllerBuilderSupplier : global::Com.Facebook.Common.Internal.ISupplier
    {
        Java.Lang.Object? ISupplier.Get() => Get();
    }

    partial class PipelineDraweeController
    {
        public override IDictionary<string, Java.Lang.Object>? ObtainExtrasFromImage(Java.Lang.Object? p0)
            => ObtainExtrasFromImage(p0 as global::Com.Facebook.Imagepipeline.Image.IImageInfo);

        protected override Android.Graphics.Drawables.Drawable? CreateDrawable(Java.Lang.Object? p0)
            => CreateDrawable(p0 as global::Com.Facebook.Common.References.CloseableReference);

        protected override Java.Lang.Object? GetImageInfo(Java.Lang.Object? p0)
            => GetImageInfo(p0 as global::Com.Facebook.Common.References.CloseableReference) as Java.Lang.Object;

        protected override void ReleaseImage(Java.Lang.Object? p0)
            => ReleaseImage(p0 as global::Com.Facebook.Common.References.CloseableReference);
    }

    partial class PipelineDraweeControllerBuilder
    {
        public override ISimpleDraweeControllerBuilder? SetUri(Android.Net.Uri? p0)
            => SetUri_(p0);

        public override ISimpleDraweeControllerBuilder? SetUri(string? p0)
            => SetUri_(p0);

        protected override IDataSource? GetDataSourceForRequest(IDraweeController? p0, string? p1, Java.Lang.Object? p2, Java.Lang.Object? p3, CacheLevel? p4)
            => GetDataSourceForRequest(
                p0, p1, 
                p2 as global::Com.Facebook.Imagepipeline.Request.ImageRequest, p3, p4);

        protected override AbstractDraweeController? ObtainController()
            => ObtainController_();
    }
}

namespace Com.Facebook.Drawee.Backends.Pipeline.Info.Internal
{
    partial class ImagePerfControllerListener2 : global::Com.Facebook.Fresco.UI.Common.IOnDrawControllerListener
    {
        void IOnDrawControllerListener.OnImageDrawn(string id, Java.Lang.Object? imageInfo, DimensionsInfo dimensionsInfo)
            => OnImageDrawn(id, imageInfo as Imagepipeline.Image.IImageInfo, dimensionsInfo);
    }
    partial class ImagePerfControllerListener : global::Com.Facebook.Fresco.UI.Common.IOnDrawControllerListener
    {
        void IOnDrawControllerListener.OnImageDrawn(string id, Java.Lang.Object? imageInfo, DimensionsInfo dimensionsInfo)
            => OnImageDrawn(id, imageInfo as Imagepipeline.Image.IImageInfo, dimensionsInfo);
    }
}  
