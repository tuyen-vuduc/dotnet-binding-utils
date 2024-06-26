#nullable restore
using System;
using System.Collections.Generic;
using Android.Runtime;
using Com.Facebook.Drawee.Interfaces;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable
{
    partial class AutoRotateDrawable : global::Com.Facebook.Drawee.Drawable.ICloneableDrawable
    {
        Android.Graphics.Drawables.Drawable? ICloneableDrawable.CloneDrawable()
            => CloneDrawable();
    }
}

namespace Com.Facebook.Drawee.Controller {
    partial class AbstractDraweeControllerBuilder : global::Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder
    {
        IDraweeController? ISimpleDraweeControllerBuilder.Build()
            => Build();

        ISimpleDraweeControllerBuilder? ISimpleDraweeControllerBuilder.SetCallerContext(Java.Lang.Object? p0)
            => SetCallerContext(p0) as ISimpleDraweeControllerBuilder;

        ISimpleDraweeControllerBuilder? ISimpleDraweeControllerBuilder.SetOldController(IDraweeController? p0)
            => SetOldController(p0) as ISimpleDraweeControllerBuilder;
    }
}