using System;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace Com.Google.Android.Material.Animation
{
    partial class ChildrenAlphaProperty
    {
        public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
            => this.Get(source as global::Android.Views.ViewGroup);
    }
    partial class DrawableAlphaProperty
    {
        public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
                => this.Get(source as global::Android.Graphics.Drawables.Drawable);
    }
    partial class ImageMatrixProperty
    {
        public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
                => this.Get(source as global::Android.Widget.ImageView);
    }
}
namespace Com.Google.Android.Material.Circularreveal
{
    partial interface ICircularRevealWidget
    {
        partial class CircularRevealProperty
        {
            public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
                => this.Get(source as global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget);
        }
    }
    partial interface ICircularRevealWidget
    {
        partial class CircularRevealScrimColorProperty
        {
            public override global::Java.Lang.Object? Get(global::Java.Lang.Object? source)
                => this.Get(source as global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget);
        }
    }
}

namespace Com.Google.Android.Material.Animation
{
    partial class ArgbEvaluatorCompat
    {
        Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
            => Evaluate(fraction, startValue as Java.Lang.Integer, endValue as Java.Lang.Integer);
    }
}
namespace Com.Google.Android.Material.Animation
{
    partial class MatrixEvaluator
    {
        Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
    => this.Evaluate(fraction, startValue as global::Android.Graphics.Matrix, endValue as global::Android.Graphics.Matrix);
    }
}
namespace Com.Google.Android.Material.Circularreveal
{
    partial interface ICircularRevealWidget
    {
        partial class CircularRevealEvaluator
        {
            Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
                => this.Evaluate(fraction, startValue as global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo, endValue as global::Com.Google.Android.Material.Circularreveal.ICircularRevealWidget.RevealInfo);
        }
    }
}
namespace Com.Google.Android.Material.Internal
{
    partial class RectEvaluator
    {
        Java.Lang.Object? global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object? startValue, Java.Lang.Object? endValue)
            => this.Evaluate(fraction, startValue as global::Android.Graphics.Rect, endValue as global::Android.Graphics.Rect);
    }
}