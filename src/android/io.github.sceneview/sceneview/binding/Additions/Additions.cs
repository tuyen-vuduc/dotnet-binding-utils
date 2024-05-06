using System.Linq;

namespace Com.Google.AR.Sceneform.Rendering
{
    partial class ModelRenderable : global::Com.Google.AR.Sceneform.Rendering.Renderable
    {
        public override global::Com.Google.AR.Sceneform.Rendering.Renderable MakeCopy()
        {
            return MakeModelRenderableCopy();
        }

        partial class Builder
        {
            protected override global::Java.Lang.Object MakeRenderable(global::Com.Google.Android.Filament.Engine p0)
            {
                return MakeModelRenderable(p0);
            }
            protected override global::Java.Lang.Object RawSelf => Self;
            protected override global::Com.Google.AR.Sceneform.Resources.ResourceRegistry RawRenderableRegistry => this.RenderableRegistry;
        }
    }

    partial class ViewRenderable
    {
        public override global::Com.Google.AR.Sceneform.Rendering.Renderable MakeCopy()
        {
            return MakeViewRenderableCopy();
        }

        partial class Builder
        {
            protected override global::Java.Lang.Object MakeRenderable(global::Com.Google.Android.Filament.Engine p0)
            {
                return MakeViewRenderable(p0);
            }
            protected override global::Java.Lang.Object RawSelf => Self;
            protected override global::Com.Google.AR.Sceneform.Resources.ResourceRegistry RawRenderableRegistry => this.RenderableRegistry;
        }
    }
}


namespace IO.Github.Sceneview.Collision
{
    partial class Box
    {
        public override global::IO.Github.Sceneview.Collision.CollisionShape MakeCopy() => MakeBoxCopy();
    }
    partial class Sphere
    {
        public override global::IO.Github.Sceneview.Collision.CollisionShape MakeCopy() => MakeSphereCopy();
    }

    partial class QuaternionEvaluator : global::Android.Animation.ITypeEvaluator
    {
        Java.Lang.Object global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object startValue, Java.Lang.Object endValue)
        {
            return Evaluate(fraction, startValue as Quaternion, endValue as Quaternion);
        }
    }

    partial class Vector3Evaluator : global::Android.Animation.ITypeEvaluator
    {
        Java.Lang.Object global::Android.Animation.ITypeEvaluator.Evaluate(float fraction, Java.Lang.Object startValue, Java.Lang.Object endValue)
        {
            return Evaluate(fraction, startValue as Vector3, endValue as Vector3);
        }
    }
}

namespace IO.Github.Sceneview.Node
{
    partial class Node : global::Android.Views.GestureDetector.IOnContextClickListener
    {
        bool global::Android.Views.GestureDetector.IOnContextClickListener.OnContextClick(global::Android.Views.MotionEvent? e)
        {
            return InvokeOnContextClick(e);
        }
    }
    partial class Node : global::Android.Views.GestureDetector.IOnDoubleTapListener
    {
        bool global::Android.Views.GestureDetector.IOnDoubleTapListener.OnDoubleTap(global::Android.Views.MotionEvent? e)
        {
            return InvokeOnDoubleTap(e);
        }
        bool global::Android.Views.GestureDetector.IOnDoubleTapListener.OnDoubleTapEvent(global::Android.Views.MotionEvent? e)
        {
            return InvokeOnDoubleTapEvent(e);
        }
        bool global::Android.Views.GestureDetector.IOnDoubleTapListener.OnSingleTapConfirmed(global::Android.Views.MotionEvent? e)
        {
            return InvokeOnSingleTapConfirmed(e);
        }
    }
    partial class Node : global::Android.Views.GestureDetector.IOnGestureListener
    {
        bool global::Android.Views.GestureDetector.IOnGestureListener.OnDown(global::Android.Views.MotionEvent? e)
        {
            return InvokeOnDown(e);
        }
        bool global::Android.Views.GestureDetector.IOnGestureListener.OnFling(global::Android.Views.MotionEvent? e1, global::Android.Views.MotionEvent? e2, float velocityX, float velocityY)
        {
            return InvokeOnFling(e1, e2, velocityX, velocityY);
        }
        void global::Android.Views.GestureDetector.IOnGestureListener.OnLongPress(global::Android.Views.MotionEvent? e)
        {
            InvokeOnLongPress(e);
        }
        bool global::Android.Views.GestureDetector.IOnGestureListener.OnScroll(global::Android.Views.MotionEvent? e1, global::Android.Views.MotionEvent? e2, float distanceX, float distanceY)
        {
            return InvokeOnScroll(e1, e2, distanceX, distanceY);
        }
        void global::Android.Views.GestureDetector.IOnGestureListener.OnShowPress(global::Android.Views.MotionEvent? e)
        {
            InvokeOnShowPress(e);
        }
        bool global::Android.Views.GestureDetector.IOnGestureListener.OnSingleTapUp(global::Android.Views.MotionEvent? e)
        {
            return InvokeOnSingleTapUp(e);
        }
    }
    partial class Node : IO.Github.Sceneview.Gesture.MoveGestureDetector.IOnMoveListener
    {
        bool IO.Github.Sceneview.Gesture.MoveGestureDetector.IOnMoveListener.OnMove(global::IO.Github.Sceneview.Gesture.MoveGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            if (!PositionEditable) return false;

            var first = CollisionSystem.HitTest(e).FirstOrDefault();
            if (first == null) return false;

            return InvokeOnMove(detector, e, first.WorldPosition);
        }

        bool IO.Github.Sceneview.Gesture.MoveGestureDetector.IOnMoveListener.OnMoveBegin(global::IO.Github.Sceneview.Gesture.MoveGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            return InvokeOnMoveBegin(detector, e);
        }

        void IO.Github.Sceneview.Gesture.MoveGestureDetector.IOnMoveListener.OnMoveEnd(global::IO.Github.Sceneview.Gesture.MoveGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            InvokeOnMoveEnd(detector, e);
        }
    }
    partial class Node : global::IO.Github.Sceneview.Gesture.RotateGestureDetector.IOnRotateListener
    {
        bool global::IO.Github.Sceneview.Gesture.RotateGestureDetector.IOnRotateListener.OnRotate(global::IO.Github.Sceneview.Gesture.RotateGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            return InvokeOnRotate(detector, e);
        }

        bool global::IO.Github.Sceneview.Gesture.RotateGestureDetector.IOnRotateListener.OnRotateBegin(global::IO.Github.Sceneview.Gesture.RotateGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            return InvokeOnRotateBegin(detector, e);
        }

        void global::IO.Github.Sceneview.Gesture.RotateGestureDetector.IOnRotateListener.OnRotateEnd(global::IO.Github.Sceneview.Gesture.RotateGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            InvokeOnRotateEnd(detector, e);
        }
    }
    partial class Node : global::IO.Github.Sceneview.Gesture.ScaleGestureDetector.IOnScaleListener
    {
        bool global::IO.Github.Sceneview.Gesture.ScaleGestureDetector.IOnScaleListener.OnScale(global::IO.Github.Sceneview.Gesture.ScaleGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            return InvokeOnScale(detector, e);
        }

        bool global::IO.Github.Sceneview.Gesture.ScaleGestureDetector.IOnScaleListener.OnScaleBegin(global::IO.Github.Sceneview.Gesture.ScaleGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            return InvokeOnScale(detector, e);
        }

        void global::IO.Github.Sceneview.Gesture.ScaleGestureDetector.IOnScaleListener.OnScaleEnd(global::IO.Github.Sceneview.Gesture.ScaleGestureDetector detector, global::Android.Views.MotionEvent e)
        {
            InvokeOnScaleEnd(detector, e);
        }
    }
}