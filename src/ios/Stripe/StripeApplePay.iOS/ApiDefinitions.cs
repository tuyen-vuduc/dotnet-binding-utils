using System;
using Foundation;
using ObjCRuntime;
using PassKit;
using StripeApplePay;
using StripeCore;
using UIKit;

namespace StripeApplePay
{
	// // @interface StripeApplePay_Swift_307 (STPAPIClient)
	// [BaseType (typeof(NSObject))]
	// interface StripeErrors
	// {
	// 	// +(NSError * _Nullable)pkPaymentErrorForStripeError:(NSError * _Nullable)stripeError __attribute__((warn_unused_result("")));
	// 	[Static]
	// 	[Export ("pkPaymentErrorForStripeError:")]
	// 	[return: NullAllowed]
	// 	NSError PkPaymentErrorForStripeError ([NullAllowed] NSError stripeError);
	// }

	// @interface STPApplePayContext : NSObject <PKPaymentAuthorizationControllerDelegate>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STPApplePayContext : IPKPaymentAuthorizationControllerDelegate
	{
		// -(instancetype _Nullable)initWithPaymentRequest:(PKPaymentRequest * _Nonnull)paymentRequest delegate:(id<_stpinternal_STPApplePayContextDelegateBase> _Nullable)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithPaymentRequest:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (PKPaymentRequest paymentRequest, [NullAllowed] I_stpinternal_STPApplePayContextDelegateBase @delegate);

		// -(void)presentApplePayWithCompletion:(void (^ _Nullable)(void))completion __attribute__((availability(ios_app_extension, unavailable)));
		//[Unavailable (PlatformName.iOSAppExtension)]
		[Export ("presentApplePayWithCompletion:")]
		void PresentApplePayWithCompletion ([NullAllowed] Action completion);

		// -(void)presentApplePayFromWindow:(UIWindow * _Nullable)window completion:(void (^ _Nullable)(void))completion;
		[Export ("presentApplePayFromWindow:completion:")]
		void PresentApplePayFromWindow ([NullAllowed] UIWindow window, [NullAllowed] Action completion);

		// -(void)presentApplePayOnViewController:(UIViewController * _Nonnull)viewController completion:(void (^ _Nullable)(void))completion __attribute__((deprecated("Use `presentApplePay(completion:)` instead.", "presentApplePayWithCompletion:")));
		[Export ("presentApplePayOnViewController:completion:")]
		void PresentApplePayOnViewController (UIViewController viewController, [NullAllowed] Action completion);

		// @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
		[Export ("apiClient", ArgumentSemantic.Strong)]
		STPAPIClient ApiClient { get; set; }

		// -(BOOL)respondsToSelector:(SEL _Null_unspecified)aSelector __attribute__((warn_unused_result("")));
		[Export ("respondsToSelector:")]
		bool RespondsToSelector (Selector aSelector);

		// -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didAuthorizePayment:(PKPayment * _Nonnull)payment handler:(void (^ _Nonnull)(PKPaymentAuthorizationResult * _Nonnull))completion __attribute__((swift_attr("@UIActor")));
		[Export ("paymentAuthorizationController:didAuthorizePayment:handler:")]
		void DidAuthorizePayment (PKPaymentAuthorizationController controller, PKPayment payment, Action<PKPaymentAuthorizationResult> completion);

		// -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod handler:(void (^ _Nonnull)(PKPaymentRequestShippingMethodUpdate * _Nonnull))completion __attribute__((swift_attr("@UIActor")));
		[Export ("paymentAuthorizationController:didSelectShippingMethod:handler:")]
		void DidSelectShippingMethod (PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, Action<PKPaymentRequestShippingMethodUpdate> completion);

		// -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectShippingContact:(PKContact * _Nonnull)contact handler:(void (^ _Nonnull)(PKPaymentRequestShippingContactUpdate * _Nonnull))completion __attribute__((swift_attr("@UIActor")));
		[Export ("paymentAuthorizationController:didSelectShippingContact:handler:")]
		void DidSelectShippingContact (PKPaymentAuthorizationController controller, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> completion);

		// -(void)paymentAuthorizationControllerDidFinish:(PKPaymentAuthorizationController * _Nonnull)controller __attribute__((swift_attr("@UIActor")));
		[Export ("paymentAuthorizationControllerDidFinish:")]
		void DidFinish (PKPaymentAuthorizationController controller);

		// -(UIWindow * _Nullable)presentationWindowForPaymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller __attribute__((warn_unused_result("")));
		[Export ("presentationWindowForPaymentAuthorizationController:")]
		[return: NullAllowed]
		UIWindow PresentationWindowForPaymentAuthorizationController (PKPaymentAuthorizationController controller);
	}

	// @interface _stpinternal_ApplePayContextDidCompleteStorage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripeApplePay46_stpinternal_ApplePayContextDidCompleteStorage")]
	[DisableDefaultCtor]
	interface _stpinternal_ApplePayContextDidCompleteStorage
	{
	}

	// @interface _stpinternal_ApplePayContextDidCreatePaymentMethodStorage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripeApplePay57_stpinternal_ApplePayContextDidCreatePaymentMethodStorage")]
	[DisableDefaultCtor]
	interface _stpinternal_ApplePayContextDidCreatePaymentMethodStorage
	{
	}

    // @protocol _stpinternal_STPApplePayContextDelegateBase <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    partial interface I_stpinternal_STPApplePayContextDelegateBase { }

    [Protocol (Name = "_TtP14StripeApplePay43_stpinternal_STPApplePayContextDelegateBase_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP14StripeApplePay43_stpinternal_STPApplePayContextDelegateBase_")]
	interface _stpinternal_STPApplePayContextDelegateBase
	{
		// @optional -(void)applePayContext:(STPApplePayContext * _Nonnull)context didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod handler:(void (^ _Nonnull)(PKPaymentRequestShippingMethodUpdate * _Nonnull))handler;
		[Export ("applePayContext:didSelectShippingMethod:handler:")]
		void DidSelectShippingMethod (STPApplePayContext context, PKShippingMethod shippingMethod, Action<PKPaymentRequestShippingMethodUpdate> handler);

		// @optional -(void)applePayContext:(STPApplePayContext * _Nonnull)context didSelectShippingContact:(PKContact * _Nonnull)contact handler:(void (^ _Nonnull)(PKPaymentRequestShippingContactUpdate * _Nonnull))handler;
		[Export ("applePayContext:didSelectShippingContact:handler:")]
		void DidSelectShippingContact (STPApplePayContext context, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> handler);

		// @optional -(void)applePayContext:(STPApplePayContext * _Nonnull)context willCompleteWithResult:(PKPaymentAuthorizationResult * _Nonnull)authorizationResult handler:(void (^ _Nonnull)(PKPaymentAuthorizationResult * _Nonnull))handler;
		[Export ("applePayContext:willCompleteWithResult:handler:")]
		void WillCompleteWithResult (STPApplePayContext context, PKPaymentAuthorizationResult authorizationResult, Action<PKPaymentAuthorizationResult> handler);
	}
}
