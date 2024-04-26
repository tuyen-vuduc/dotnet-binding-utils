using Foundation;
using UIKit;

namespace StripePaymentSheet
{
	// @interface STPAddressViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface STPAddressViewController
	{
		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewDidAppear:(BOOL)animated;
		[Export ("viewDidAppear:")]
		void ViewDidAppear (bool animated);

		// -(void)viewWillDisappear:(BOOL)animated;
		[Export ("viewWillDisappear:")]
		void ViewWillDisappear (bool animated);
	}

	// @interface StripePaymentSheet_Swift_323 (STPAddressViewController) <UIGestureRecognizerDelegate>
	[Category]
	[BaseType (typeof(STPAddressViewController))]
	interface STPAddressViewController_StripePaymentSheet_Swift_323 : IUIGestureRecognizerDelegate
	{
		// -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldReceiveTouch:(UITouch * _Nonnull)touch __attribute__((warn_unused_result("")));
		[Export ("gestureRecognizer:shouldReceiveTouch:")]
		bool GestureRecognizer (UIGestureRecognizer gestureRecognizer, UITouch touch);
	}

	// @interface LinkPaymentController : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC18StripePaymentSheet21LinkPaymentController")]
	[DisableDefaultCtor]
	interface LinkPaymentController
	{
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double StripePaymentSheetVersionNumber;
		[Field ("StripePaymentSheetVersionNumber", "__Internal")]
		double StripePaymentSheetVersionNumber { get; }

		// extern const unsigned char[] StripePaymentSheetVersionString;
		[Field ("StripePaymentSheetVersionString", "__Internal")]
		byte[] StripePaymentSheetVersionString { get; }
	}
}
