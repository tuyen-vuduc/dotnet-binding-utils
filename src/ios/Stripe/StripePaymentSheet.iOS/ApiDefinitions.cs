using Foundation;
using UIKit;

namespace StripePaymentSheet
{
	// @interface STPAddressViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	partial interface STPAddressViewController
	{
	}

	// @interface StripePaymentSheet_Swift_323 (STPAddressViewController) <UIGestureRecognizerDelegate>
	partial interface STPAddressViewController : IUIGestureRecognizerDelegate
	{
		// -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldReceiveTouch:(UITouch * _Nonnull)touch __attribute__((warn_unused_result("")));
		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		bool ShouldReceiveTouch(UIGestureRecognizer gestureRecognizer, UITouch touch);
	}

	// @interface LinkPaymentController : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC18StripePaymentSheet21LinkPaymentController")]
	[DisableDefaultCtor]
	interface LinkPaymentController
	{
	}
}
