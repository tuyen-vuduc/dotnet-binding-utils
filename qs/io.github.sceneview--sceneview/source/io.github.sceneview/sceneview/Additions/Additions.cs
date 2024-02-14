
namespace IO.Github.Sceneview.Animation
{
    partial class TransformAnimator
    {
        partial class Float3Evaluator : global::Android.Animation.ITypeEvaluator
        {
            Java.Lang.Object global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object startValue, Java.Lang.Object endValue)
            {
                return Evaluate(fraction, startValue as global::Dev.Romainguy.Kotlin.Math.Float3, endValue as global::Dev.Romainguy.Kotlin.Math.Float3);
            }
        }

        partial class QuaternionEvaluator : global::Android.Animation.ITypeEvaluator
        {
            Java.Lang.Object global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object startValue, Java.Lang.Object endValue)
            {
                return Evaluate(fraction, startValue as global::Dev.Romainguy.Kotlin.Math.Quaternion, endValue as global::Dev.Romainguy.Kotlin.Math.Quaternion);
            }
        }

        partial class TransformEvaluator : global::Android.Animation.ITypeEvaluator
        {
            Java.Lang.Object global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object startValue, Java.Lang.Object endValue)
            {
                return Evaluate(fraction, startValue as global::Dev.Romainguy.Kotlin.Math.Mat4, endValue as global::Dev.Romainguy.Kotlin.Math.Mat4);
            }
        }
    }
}