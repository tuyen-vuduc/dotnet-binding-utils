using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace iZettleQs
{
    [Register("AmountWheel")]
    public class AmountWheel : UIImageView
    {
        public NSDecimalNumber Amount { get; set; }
        public Action<NSDecimalNumber> AmountUpdated { get; set; }

        double rotation;
        double amountIncrementor;

        public AmountWheel(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        public AmountWheel(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        void Initialize() {
			Amount = new NSDecimalNumber(1, 1, amountIncrementor < 0);

			AddGestureRecognizer(new RotationGestureRecognizer(this, new ObjCRuntime.Selector("handleRotate:")));
        }

        [Export("handleRotate:")]
        void HandleRotate(RotationGestureRecognizer rotationGesture)
        {
            if (rotationGesture.Rotation < 0 && Amount == NSDecimalNumber.Zero)
			{
				return;
			}

			rotation += rotationGesture.Rotation;

            Transform = CGAffineTransform.MakeRotation((System.nfloat)rotation);

			amountIncrementor += rotationGesture.Rotation;
			if (amountIncrementor < -0.05 || amountIncrementor > 0.05)
			{
				NSDecimalNumber change = new NSDecimalNumber(1, 1, amountIncrementor < 0);
                Amount = Amount.Add(change);

				amountIncrementor = 0;

                AmountUpdated?.Invoke(Amount);
			}
        }
    }

    public class RotationGestureRecognizer : UIGestureRecognizer
    {
        public double Rotation { get; set; }

        public RotationGestureRecognizer(NSObject target, ObjCRuntime.Selector action) : base(target, action)
        {

        }

        public RotationGestureRecognizer(Action action) : base(action)
        {

        }

        public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
        {
            if (evt.TouchesForGestureRecognizer(this).Count == 1)
            {
                State = UIGestureRecognizerState.Began;
            }
            else
            {
                State = UIGestureRecognizerState.Failed;
            }
        }

        public override void TouchesMoved(Foundation.NSSet touches, UIEvent evt)
        {
            State = UIGestureRecognizerState.Changed;
            var touch = (UITouch)touches.AnyObject;
            var view = View;
            var center = new CGPoint(view.Bounds.GetMidX(), view.Bounds.GetMinY());

            var currentTouchPoint = touch.LocationInView(view);
            var previousTouchPoint = touch.PreviousLocationInView(view);

            var angleInRadians = Math.Atan2(currentTouchPoint.Y - center.Y, currentTouchPoint.X - center.X)
                                        - Math.Atan2(previousTouchPoint.Y - center.Y, previousTouchPoint.X - center.X);

            if (angleInRadians > Math.PI) {
                angleInRadians -= Math.PI;
            }

            Rotation = angleInRadians;
        }

        public override void TouchesEnded(Foundation.NSSet touches, UIEvent evt)
        {
            State = UIGestureRecognizerState.Ended;
        }

        public override void TouchesCancelled(Foundation.NSSet touches, UIEvent evt)
        {
            State = UIGestureRecognizerState.Cancelled;
        }
    }
}
