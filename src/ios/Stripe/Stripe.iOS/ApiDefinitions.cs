using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

using PassKit;
using Stripe;
using UIKit;
using StripePayments;
using StripePaymentsUI;
using StripeCore;
using StripeApplePay;

namespace Stripe
{
    partial interface ISTPAddCardViewControllerDelegate { }

    partial interface ISTPApplePayContextDelegat { }

    partial interface ISTPPaymentOption { }

    partial interface ISTPBackendAPIAdapter { }

    partial interface ISTPBankSelectionViewControllerDelegate { }

    partial interface ISTPCustomerEphemeralKeyProvider { }

    partial interface ISTPEphemeralKeyProvider { }

    partial interface ISTPIssuingCardEphemeralKeyProvider { }

    partial interface ISTPShippingAddressViewControllerDelegate { }

    partial interface ISTPPaymentOptionsViewControllerDelegate { }

    partial interface ISTPPaymentContextDelegate { }

    // @interface Stripe_Swift_315
    [Category]
	[BaseType(typeof(STPAPIClient))]
	interface Stripe_Swift_315
	{
		// @property (nonatomic, strong) STPPaymentConfiguration * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		STPPaymentConfiguration Configuration();
	}

	// @interface STPCoreViewController : UIViewController
	[BaseType (typeof(UIViewController), Name = "_TtC6Stripe21STPCoreViewController")]
	interface STPCoreViewController
	{
		// -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nullable)theme __attribute__((objc_designated_initializer));
		[Export ("initWithTheme:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] STPTheme theme);

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)viewWillDisappear:(BOOL)animated;
		[Export ("viewWillDisappear:")]
		void ViewWillDisappear (bool animated);

		// @property (readonly, nonatomic) UIStatusBarStyle preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle")]
		UIStatusBarStyle PreferredStatusBarStyle { get; }
	}

	// @interface STPCoreScrollViewController : STPCoreViewController
	[BaseType (typeof(STPCoreViewController), Name = "_TtC6Stripe27STPCoreScrollViewController")]
	interface STPCoreScrollViewController
	{
		// @property (nonatomic, strong) UIScrollView * _Nonnull scrollView;
		[Export ("scrollView", ArgumentSemantic.Strong)]
		UIScrollView ScrollView { get; set; }

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewDidLayoutSubviews;
		[Export ("viewDidLayoutSubviews")]
		void ViewDidLayoutSubviews ();

		// -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nullable)theme __attribute__((objc_designated_initializer));
		[Export ("initWithTheme:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] STPTheme theme);

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);
	}

	// @interface STPCoreTableViewController : STPCoreScrollViewController
	[BaseType (typeof(STPCoreScrollViewController), Name = "_TtC6Stripe26STPCoreTableViewController")]
	interface STPCoreTableViewController
	{
		// @property (readonly, nonatomic, strong) UITableView * _Nullable tableView;
		[NullAllowed, Export ("tableView", ArgumentSemantic.Strong)]
		UITableView TableView { get; }

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nullable)theme __attribute__((objc_designated_initializer));
		[Export ("initWithTheme:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] STPTheme theme);

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);
	}

	// @interface STPAddCardViewController : STPCoreTableViewController
	[BaseType (typeof(STPCoreTableViewController), Name = "_TtC6Stripe24STPAddCardViewController")]
	interface STPAddCardViewController
	{
		// -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme __attribute__((objc_designated_initializer));
		[Export ("initWithConfiguration:theme:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPPaymentConfiguration configuration, STPTheme theme);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		STPAddCardViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<STPAddCardViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) STPUserInformation * _Nullable prefilledInformation;
		[NullAllowed, Export ("prefilledInformation", ArgumentSemantic.Strong)]
		STPUserInformation PrefilledInformation { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable customFooterView;
		[NullAllowed, Export ("customFooterView", ArgumentSemantic.Strong)]
		UIView CustomFooterView { get; set; }

		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView estimatedHeightForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
		[Export ("tableView:estimatedHeightForRowAtIndexPath:")]
		nfloat EstimatedHeight(UITableView tableView, NSIndexPath indexPath);

		// -(void)viewDidLayoutSubviews;
		[Export ("viewDidLayoutSubviews")]
		void ViewDidLayoutSubviews ();

		// -(void)updateAppearance;
		[Export ("updateAppearance")]
		void UpdateAppearance ();

		// -(void)viewDidAppear:(BOOL)animated;
		[Export ("viewDidAppear:")]
		void ViewDidAppear (bool animated);

		// -(void)handleCancelTapped:(id _Nullable)sender;
		[Export ("handleCancelTapped:")]
		void HandleCancelTapped ([NullAllowed] NSObject sender);

		// -(void)paymentCardTextFieldDidChange:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidChange:")]
		void PaymentCardTextFieldDidChange (STPPaymentCardTextField textField);

		// -(void)paymentCardTextFieldWillEndEditingForReturn:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldWillEndEditingForReturn:")]
		void PaymentCardTextFieldWillEndEditingForReturn (STPPaymentCardTextField textField);

		// -(void)paymentCardTextFieldDidBeginEditingCVC:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidBeginEditingCVC:")]
		void PaymentCardTextFieldDidBeginEditingCVC (STPPaymentCardTextField textField);

		// -(void)paymentCardTextFieldDidEndEditingCVC:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidEndEditingCVC:")]
		void PaymentCardTextFieldDidEndEditingCVC (STPPaymentCardTextField textField);

		// -(void)paymentCardTextFieldDidBeginEditing:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidBeginEditing:")]
		void PaymentCardTextFieldDidBeginEditing (STPPaymentCardTextField textField);

		// -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
		[Export ("numberOfSectionsInTableView:")]
		nint NumberOfSections (UITableView tableView);

		// -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:numberOfRowsInSection:")]
		nint RowsInSection (UITableView tableView, nint section);

		// -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
		[Export ("tableView:cellForRowAtIndexPath:")]
		UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath);

		// -(void)tableView:(UITableView * _Nonnull)tableView willDisplayCell:(UITableViewCell * _Nonnull)cell forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("tableView:willDisplayCell:forRowAtIndexPath:")]
		void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath);

		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:heightForFooterInSection:")]
		nfloat GetHeightForFooter (UITableView tableView, nint section);

		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:heightForHeaderInSection:")]
		nfloat GetHeightForHeader (UITableView tableView, nint section);

		// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:viewForHeaderInSection:")]
		[return: NullAllowed]
		UIView GetViewForHeader (UITableView tableView, nint section);

		// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:viewForFooterInSection:")]
		[return: NullAllowed]
		UIView GetViewForFooter (UITableView tableView, nint section);

		// -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		void ViewWillTransitionToSize (CGSize size, IUIViewControllerTransitionCoordinator coordinator);
	}

    // @protocol STPAddCardViewControllerDelegate <NSObject>
    [Protocol (Name = "_TtP6Stripe32STPAddCardViewControllerDelegate_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe32STPAddCardViewControllerDelegate_")]
	interface STPAddCardViewControllerDelegate
	{
		// @required -(void)addCardViewControllerDidCancel:(STPAddCardViewController * _Nonnull)addCardViewController;
		[Abstract]
		[Export ("addCardViewControllerDidCancel:")]
		void AddCardViewControllerDidCancel (STPAddCardViewController addCardViewController);

		// @required -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreatePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Abstract]
		[Export ("addCardViewController:didCreatePaymentMethod:completion:")]
		void AddCardViewController (STPAddCardViewController addCardViewController, STPPaymentMethod paymentMethod, Action<NSError> completion);

		// @optional -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreateToken:(STPToken * _Nonnull)token completion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((deprecated("Use addCardViewController(_:didCreatePaymentMethod:completion:) instead and migrate your integration to PaymentIntents. See https://stripe.com/docs/payments/payment-intents/migration/charges#read", "addCardViewController:didCreatePaymentMethod:completion:")));
		[Export ("addCardViewController:didCreateToken:completion:")]
		void AddCardViewController (STPAddCardViewController addCardViewController, STPToken token, Action<NSError> completion);

		// @optional -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreateSource:(STPSource * _Nonnull)source completion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((deprecated("Use addCardViewController(_:didCreatePaymentMethod:completion:) instead and migrate your integration to PaymentIntents. See https://stripe.com/docs/payments/payment-intents/migration/charges#read", "addCardViewController:didCreatePaymentMethod:completion:")));
		[Export ("addCardViewController:didCreateSource:completion:")]
		void AddCardViewController (STPAddCardViewController addCardViewController, STPSource source, Action<NSError> completion);
	}

	// @interface Stripe_Swift_500
	interface Stripe_Swift_500
	{
		// -(BOOL)containsRequiredFields:(enum STPBillingAddressFields)requiredFields __attribute__((warn_unused_result("")));
		[Export ("containsRequiredFields:")]
		bool ContainsRequiredFields (STPBillingAddressFields requiredFields);

		// -(BOOL)containsContentForBillingAddressFields:(enum STPBillingAddressFields)desiredFields __attribute__((warn_unused_result("")));
		[Export ("containsContentForBillingAddressFields:")]
		bool ContainsContentForBillingAddressFields (STPBillingAddressFields desiredFields);

		// -(BOOL)containsRequiredShippingAddressFields:(NSSet<STPContactField *> * _Nullable)requiredFields __attribute__((warn_unused_result("")));
		[Export ("containsRequiredShippingAddressFields:")]
		bool ContainsRequiredShippingAddressFields ([NullAllowed] NSSet<STPContactField> requiredFields);

		// -(BOOL)containsContentForShippingAddressFields:(NSSet<STPContactField *> * _Nullable)desiredFields __attribute__((warn_unused_result("")));
		[Export ("containsContentForShippingAddressFields:")]
		bool ContainsContentForShippingAddressFields ([NullAllowed] NSSet<STPContactField> desiredFields);

		// +(NSSet<PKContactField> * _Nonnull)applePayContactFieldsFromBillingAddressFields:(enum STPBillingAddressFields)billingAddressFields __attribute__((warn_unused_result("")));
		[Static]
		[Export ("applePayContactFieldsFromBillingAddressFields:")]
		NSSet<NSString> ApplePayContactFieldsFromBillingAddressFields (STPBillingAddressFields billingAddressFields);

		// +(NSSet<PKContactField> * _Nullable)pkContactFieldsFromStripeContactFields:(NSSet<STPContactField *> * _Nullable)contactFields __attribute__((warn_unused_result("")));
		[Static]
		[Export ("pkContactFieldsFromStripeContactFields:")]
		[return: NullAllowed]
		NSSet<NSString> PkContactFieldsFromStripeContactFields ([NullAllowed] NSSet<STPContactField> contactFields);
	}

	// @protocol STPApplePayContextDelegate
	[Protocol (Name = "_TtP6Stripe26STPApplePayContextDelegate_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe26STPApplePayContextDelegate_")]
	interface STPApplePayContextDelegate
	{
		// @required -(void)applePayContext:(STPApplePayContext * _Nonnull)context didCreatePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod paymentInformation:(PKPayment * _Nonnull)paymentInformation completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export ("applePayContext:didCreatePaymentMethod:paymentInformation:completion:")]
		void DidCreatePaymentMethod (STPApplePayContext context, STPPaymentMethod paymentMethod, PKPayment paymentInformation, Action<NSString, NSError> completion);

		// @required -(void)applePayContext:(STPApplePayContext * _Nonnull)context didCompleteWithStatus:(enum STPPaymentStatus)status error:(NSError * _Nullable)error;
		[Abstract]
		[Export ("applePayContext:didCompleteWithStatus:error:")]
		void DidCompleteWithStatus (STPApplePayContext context, STPPaymentStatus status, [NullAllowed] NSError error);
	}

	// @protocol STPPaymentOption <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/	
	[Protocol (Name = "_TtP6Stripe16STPPaymentOption_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe16STPPaymentOption_")]
	interface STPPaymentOption
	{
		// @required @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
		[Abstract]
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @required @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
		[Abstract]
		[Export ("templateImage", ArgumentSemantic.Strong)]
		UIImage TemplateImage { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull label;
		[Abstract]
		[Export ("label")]
		string Label { get; }

		// @required @property (readonly, nonatomic) BOOL isReusable;
		[Abstract]
		[Export ("isReusable")]
		bool IsReusable { get; }
	}

	// @interface STPApplePayPaymentOption : NSObject <STPPaymentOption>
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe24STPApplePayPaymentOption")]
	interface STPApplePayPaymentOption : ISTPPaymentOption
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
		[Export ("templateImage", ArgumentSemantic.Strong)]
		UIImage TemplateImage { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label { get; }

		// @property (readonly, nonatomic) BOOL isReusable;
		[Export ("isReusable")]
		bool IsReusable { get; }

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);

		// @property (readonly, nonatomic) NSUInteger hash;
		[Export ("hash")]
		nuint Hash { get; }
	}

	// @protocol STPBackendAPIAdapter <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP6Stripe20STPBackendAPIAdapter_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe20STPBackendAPIAdapter_")]
	interface STPBackendAPIAdapter
	{
		// @required -(void)retrieveCustomer:(void (^ _Nullable)(STPCustomer * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export ("retrieveCustomer:")]
		void RetrieveCustomer ([NullAllowed] Action<STPCustomer, NSError> completion);

		// @required -(void)listPaymentMethodsForCustomerWithCompletion:(void (^ _Nullable)(NSArray<STPPaymentMethod *> * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export ("listPaymentMethodsForCustomerWithCompletion:")]
		void ListPaymentMethodsForCustomerWithCompletion ([NullAllowed] Action<NSArray<STPPaymentMethod>, NSError> completion);

		// @required -(void)attachPaymentMethodToCustomer:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Abstract]
		[Export ("attachPaymentMethodToCustomer:completion:")]
		void AttachPaymentMethodToCustomer (STPPaymentMethod paymentMethod, [NullAllowed] Action<NSError> completion);

		// @optional -(void)detachPaymentMethodFromCustomer:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("detachPaymentMethodFromCustomer:completion:")]
		void DetachPaymentMethodFromCustomer (STPPaymentMethod paymentMethod, [NullAllowed] Action<NSError> completion);

		// @optional -(void)updateCustomerWithShippingAddress:(id)shipping completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("updateCustomerWithShippingAddress:completion:")]
		void UpdateCustomerWithShippingAddress (NSObject shipping, [NullAllowed] Action<NSError> completion);
	}

	// @interface STPBankSelectionViewController : STPCoreTableViewController <UITableViewDataSource, UITableViewDelegate>
	[BaseType (typeof(STPCoreTableViewController), Name = "_TtC6Stripe30STPBankSelectionViewController")]
	interface STPBankSelectionViewController : IUITableViewDataSource, IUITableViewDelegate
	{
		// -(instancetype _Nonnull)initWithBankMethod:(enum STPBankSelectionMethod)bankMethod;
		[Export ("initWithBankMethod:")]
		NativeHandle Constructor (STPBankSelectionMethod bankMethod);

		// -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nullable)theme;
		[Export ("initWithTheme:")]
		NativeHandle Constructor ([NullAllowed] STPTheme theme);

		// -(instancetype _Nonnull)initWithBankMethod:(enum STPBankSelectionMethod)bankMethod configuration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme __attribute__((objc_designated_initializer));
		[Export ("initWithBankMethod:configuration:theme:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPBankSelectionMethod bankMethod, STPPaymentConfiguration configuration, STPTheme theme);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		STPBankSelectionViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<STPBankSelectionViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
		[Export ("numberOfSectionsInTableView:")]
		nint NumberOfSections (UITableView tableView);

		// -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:numberOfRowsInSection:")]
		nint RowsInSection(UITableView tableView, nint section);

		// -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
		[Export ("tableView:cellForRowAtIndexPath:")]
		UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath);

		// -(void)tableView:(UITableView * _Nonnull)tableView willDisplayCell:(UITableViewCell * _Nonnull)cell forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("tableView:willDisplayCell:forRowAtIndexPath:")]
		void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath);

		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:heightForFooterInSection:")]
		nfloat GetHeightForFooter (UITableView tableView, nint section);

		// -(BOOL)tableView:(UITableView * _Nonnull)tableView shouldHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
		[Export ("tableView:shouldHighlightRowAtIndexPath:")]
		bool ShouldHighlightRow(UITableView tableView, NSIndexPath indexPath);

		// -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("tableView:didSelectRowAtIndexPath:")]
		void DidSelectRow(UITableView tableView, NSIndexPath indexPath);
	}

	// @protocol STPBankSelectionViewControllerDelegate <NSObject>
	[Protocol (Name = "_TtP6Stripe38STPBankSelectionViewControllerDelegate_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe38STPBankSelectionViewControllerDelegate_")]
	interface STPBankSelectionViewControllerDelegate
	{
		// @required -(void)bankSelectionViewController:(STPBankSelectionViewController * _Nonnull)bankViewController didCreatePaymentMethodParams:(STPPaymentMethodParams * _Nonnull)paymentMethodParams;
		[Abstract]
		[Export ("bankSelectionViewController:didCreatePaymentMethodParams:")]
		void DidCreatePaymentMethodParams (STPBankSelectionViewController bankViewController, STPPaymentMethodParams paymentMethodParams);
	}

	// @interface Stripe_Swift_814
	[Category]
	[BaseType(typeof(STPCard))]
	interface Stripe_Swift_814
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image();

		// @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
		[Export ("templateImage", ArgumentSemantic.Strong)]
		UIImage TemplateImage();

		// @property (readonly, copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label();

		// @property (readonly, nonatomic) BOOL isReusable;
		[Export ("isReusable")]
		bool IsReusable();
	}

	// @interface STPCustomerContext : NSObject <STPBackendAPIAdapter>
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe18STPCustomerContext")]
	[DisableDefaultCtor]
	interface STPCustomerContext : ISTPBackendAPIAdapter
	{
		// -(instancetype _Nonnull)initWithKeyProvider:(id<STPCustomerEphemeralKeyProvider> _Nonnull)keyProvider;
		[Export ("initWithKeyProvider:")]
		NativeHandle Constructor (ISTPCustomerEphemeralKeyProvider keyProvider);

		// -(instancetype _Nonnull)initWithKeyProvider:(id<STPCustomerEphemeralKeyProvider> _Nullable)keyProvider apiClient:(id)apiClient;
		[Export ("initWithKeyProvider:apiClient:")]
		NativeHandle Constructor ([NullAllowed] ISTPCustomerEphemeralKeyProvider keyProvider, STPAPIClient apiClient);

		// -(void)clearCache;
		[Export ("clearCache")]
		void ClearCache ();

		// @property (nonatomic) BOOL includeApplePayPaymentMethods;
		[Export ("includeApplePayPaymentMethods")]
		bool IncludeApplePayPaymentMethods { get; set; }

		// -(void)retrieveCustomer:(void (^ _Nullable)(STPCustomer * _Nullable, NSError * _Nullable))completion;
		[Export ("retrieveCustomer:")]
		void RetrieveCustomer ([NullAllowed] Action<STPCustomer, NSError> completion);

		// -(void)updateCustomerWithShippingAddress:(id)shipping completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("updateCustomerWithShippingAddress:completion:")]
		void UpdateCustomerWithShippingAddress (NSObject shipping, [NullAllowed] Action<NSError> completion);

		// -(void)attachPaymentMethodToCustomerWithPaymentMethodId:(NSString * _Nonnull)paymentMethodId completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("attachPaymentMethodToCustomerWithPaymentMethodId:completion:")]
		void AttachPaymentMethodToCustomerWithPaymentMethodId (string paymentMethodId, [NullAllowed] Action<NSError> completion);

		// -(void)attachPaymentMethodToCustomer:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("attachPaymentMethodToCustomer:completion:")]
		void AttachPaymentMethodToCustomer (STPPaymentMethod paymentMethod, [NullAllowed] Action<NSError> completion);

		// -(void)detachPaymentMethodFromCustomerWithPaymentMethodId:(NSString * _Nonnull)paymentMethodId completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("detachPaymentMethodFromCustomerWithPaymentMethodId:completion:")]
		void DetachPaymentMethodFromCustomerWithPaymentMethodId (string paymentMethodId, [NullAllowed] Action<NSError> completion);

		// -(void)detachPaymentMethodFromCustomer:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nullable)(NSError * _Nullable))completion;
		[Export ("detachPaymentMethodFromCustomer:completion:")]
		void DetachPaymentMethodFromCustomer (STPPaymentMethod paymentMethod, [NullAllowed] Action<NSError> completion);

		// -(void)listPaymentMethodsForCustomerWithCompletion:(void (^ _Nullable)(NSArray<STPPaymentMethod *> * _Nullable, NSError * _Nullable))completion;
		[Export ("listPaymentMethodsForCustomerWithCompletion:")]
		void ListPaymentMethodsForCustomerWithCompletion ([NullAllowed] Action<NSArray<STPPaymentMethod>, NSError> completion);
	}

	// @protocol STPCustomerEphemeralKeyProvider <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP6Stripe31STPCustomerEphemeralKeyProvider_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe31STPCustomerEphemeralKeyProvider_")]
	interface STPCustomerEphemeralKeyProvider
	{
		// @required -(void)createCustomerKeyWithAPIVersion:(NSString * _Nonnull)apiVersion completion:(void (^ _Nonnull)(NSDictionary * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export ("createCustomerKeyWithAPIVersion:completion:")]
		void Completion (string apiVersion, Action<NSDictionary, NSError> completion);
	}

	// @protocol STPEphemeralKeyProvider <STPCustomerEphemeralKeyProvider>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP6Stripe23STPEphemeralKeyProvider_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe23STPEphemeralKeyProvider_")]
	interface STPEphemeralKeyProvider : STPCustomerEphemeralKeyProvider
	{
	}

	// @interface STPFakeAddPaymentPassViewController : UIViewController
	[BaseType (typeof(UIViewController), Name = "_TtC6Stripe35STPFakeAddPaymentPassViewController")]
	interface STPFakeAddPaymentPassViewController
	{
		// +(BOOL)canAddPaymentPass __attribute__((warn_unused_result("")));
		[Static]
		[Export ("canAddPaymentPass")]
		bool CanAddPaymentPass { get; }

		// -(instancetype _Nullable)initWithRequestConfiguration:(PKAddPaymentPassRequestConfiguration * _Nonnull)configuration delegate:(id<PKAddPaymentPassViewControllerDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithRequestConfiguration:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (PKAddPaymentPassRequestConfiguration configuration, [NullAllowed] IPKAddPaymentPassViewControllerDelegate @delegate);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		PKAddPaymentPassViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<PKAddPaymentPassViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil;
		[Export ("initWithNibName:bundle:")]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();
	}

	// @protocol STPIssuingCardEphemeralKeyProvider <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol (Name = "_TtP6Stripe34STPIssuingCardEphemeralKeyProvider_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe34STPIssuingCardEphemeralKeyProvider_")]
	interface STPIssuingCardEphemeralKeyProvider
	{
		// @required -(void)createIssuingCardKeyWithAPIVersion:(NSString * _Nonnull)apiVersion completion:(void (^ _Nonnull)(NSDictionary * _Nullable, NSError * _Nullable))completion;
		[Abstract]
		[Export ("createIssuingCardKeyWithAPIVersion:completion:")]
		void Completion (string apiVersion, Action<NSDictionary, NSError> completion);
	}

	// @interface STPPaymentActivityIndicatorView : UIView
	[BaseType (typeof(UIView), Name = "_TtC6Stripe31STPPaymentActivityIndicatorView")]
	interface STPPaymentActivityIndicatorView
	{
		// -(void)setAnimating:(BOOL)animating animated:(BOOL)animated;
		[Export ("setAnimating:animated:")]
		void SetAnimating (bool animating, bool animated);

		// @property (nonatomic) BOOL animating;
		[Export ("animating")]
		bool Animating { get; set; }

		// @property (nonatomic) BOOL hidesWhenStopped;
		[Export ("hidesWhenStopped")]
		bool HidesWhenStopped { get; set; }

		// @property (nonatomic, strong) UIColor * _Null_unspecified tintColor;
		[Export ("tintColor", ArgumentSemantic.Strong)]
		UIColor TintColor { get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

	// @interface STPPaymentConfiguration : NSObject <NSCopying>
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe23STPPaymentConfiguration")]
	interface STPPaymentConfiguration : INSCopying
	{
		// @property (nonatomic, strong, class) STPPaymentConfiguration * _Nonnull sharedConfiguration;
		[Static]
		[Export ("sharedConfiguration", ArgumentSemantic.Strong)]
		STPPaymentConfiguration SharedConfiguration { get; set; }

		// @property (nonatomic) BOOL applePayEnabled;
		[Export ("applePayEnabled")]
		bool ApplePayEnabled { get; set; }

		// @property (nonatomic) BOOL fpxEnabled;
		[Export ("fpxEnabled")]
		bool FpxEnabled { get; set; }

		// @property (nonatomic) enum STPBillingAddressFields requiredBillingAddressFields;
		[Export ("requiredBillingAddressFields", ArgumentSemantic.Assign)]
		STPBillingAddressFields RequiredBillingAddressFields { get; set; }

		// @property (copy, nonatomic) NSSet<STPContactField *> * _Nullable requiredShippingAddressFields;
		[NullAllowed, Export ("requiredShippingAddressFields", ArgumentSemantic.Copy)]
		NSSet<STPContactField> RequiredShippingAddressFields { get; set; }

		// @property (nonatomic) BOOL verifyPrefilledShippingAddress;
		[Export ("verifyPrefilledShippingAddress")]
		bool VerifyPrefilledShippingAddress { get; set; }

		// @property (nonatomic) enum STPShippingType shippingType;
		[Export ("shippingType", ArgumentSemantic.Assign)]
		STPShippingType ShippingType { get; set; }

		// @property (copy, nonatomic) NSSet<NSString *> * _Nonnull availableCountries;
		[Export ("availableCountries", ArgumentSemantic.Copy)]
		NSSet<NSString> AvailableCountries { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull companyName;
		[Export ("companyName")]
		string CompanyName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable appleMerchantIdentifier;
		[NullAllowed, Export ("appleMerchantIdentifier")]
		string AppleMerchantIdentifier { get; set; }

		// @property (nonatomic) BOOL canDeletePaymentOptions;
		[Export ("canDeletePaymentOptions")]
		bool CanDeletePaymentOptions { get; set; }

		// @property (nonatomic) BOOL cardScanningEnabled;
		[Export ("cardScanningEnabled")]
		bool CardScanningEnabled { get; set; }

		// @property (nonatomic) NSInteger additionalPaymentOptions __attribute__((deprecated("additionalPaymentOptions has been removed. Set applePayEnabled and fpxEnabled on STPPaymentConfiguration instead.")));
		[Export ("additionalPaymentOptions")]
		nint AdditionalPaymentOptions { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("If you used STPPaymentConfiguration.shared.publishableKey, use STPAPIClient.shared.publishableKey instead. If you passed a STPPaymentConfiguration instance to an SDK component, create an STPAPIClient, set publishableKey on it, and set the SDK component's APIClient property.") NSString * publishableKey __attribute__((deprecated("If you used STPPaymentConfiguration.shared.publishableKey, use STPAPIClient.shared.publishableKey instead. If you passed a STPPaymentConfiguration instance to an SDK component, create an STPAPIClient, set publishableKey on it, and set the SDK component's APIClient property.")));
		[Export ("publishableKey")]
		string PublishableKey { get; set; }

		// @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("If you used STPPaymentConfiguration.shared.stripeAccount, use STPAPIClient.shared.stripeAccount instead. If you passed a STPPaymentConfiguration instance to an SDK component, create an STPAPIClient, set stripeAccount on it, and set the SDK component's APIClient property.") NSString * stripeAccount __attribute__((deprecated("If you used STPPaymentConfiguration.shared.stripeAccount, use STPAPIClient.shared.stripeAccount instead. If you passed a STPPaymentConfiguration instance to an SDK component, create an STPAPIClient, set stripeAccount on it, and set the SDK component's APIClient property.")));
		[Export ("stripeAccount")]
		string StripeAccount { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
		[Export ("description")]
		string Description { get; }

		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @protocol STPShippingAddressViewControllerDelegate <NSObject>
	[Protocol (Name = "_TtP6Stripe40STPShippingAddressViewControllerDelegate_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe40STPShippingAddressViewControllerDelegate_")]
	interface STPShippingAddressViewControllerDelegate
	{
		// @required -(void)shippingAddressViewControllerDidCancel:(STPShippingAddressViewController * _Nonnull)addressViewController;
		[Abstract]
		[Export ("shippingAddressViewControllerDidCancel:")]
		void ShippingAddressViewControllerDidCancel (STPShippingAddressViewController addressViewController);

		// @required -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didEnterAddress:(id)address completion:(void (^ _Nonnull)(enum STPShippingStatus, NSError * _Nullable, NSArray<PKShippingMethod *> * _Nullable, PKShippingMethod * _Nullable))completion;
		[Abstract]
		[Export ("shippingAddressViewController:didEnterAddress:completion:")]
		void ShippingAddressViewController (STPShippingAddressViewController addressViewController, NSObject address, Action<STPShippingStatus, NSError, NSArray<PKShippingMethod>, PKShippingMethod> completion);

		// @required -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didFinishWithAddress:(id)address shippingMethod:(PKShippingMethod * _Nullable)method;
		[Abstract]
		[Export ("shippingAddressViewController:didFinishWithAddress:shippingMethod:")]
		void ShippingAddressViewController (STPShippingAddressViewController addressViewController, NSObject address, [NullAllowed] PKShippingMethod method);
	}

	// @protocol STPPaymentOptionsViewControllerDelegate <NSObject>
	[Protocol (Name = "_TtP6Stripe39STPPaymentOptionsViewControllerDelegate_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe39STPPaymentOptionsViewControllerDelegate_")]
	interface STPPaymentOptionsViewControllerDelegate
	{
		// @required -(void)paymentOptionsViewController:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController didFailToLoadWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("paymentOptionsViewController:didFailToLoadWithError:")]
		void PaymentOptionsViewController (STPPaymentOptionsViewController paymentOptionsViewController, NSError error);

		// @required -(void)paymentOptionsViewControllerDidFinish:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController;
		[Abstract]
		[Export ("paymentOptionsViewControllerDidFinish:")]
		void PaymentOptionsViewControllerDidFinish (STPPaymentOptionsViewController paymentOptionsViewController);

		// @required -(void)paymentOptionsViewControllerDidCancel:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController;
		[Abstract]
		[Export ("paymentOptionsViewControllerDidCancel:")]
		void PaymentOptionsViewControllerDidCancel (STPPaymentOptionsViewController paymentOptionsViewController);

		// @optional -(void)paymentOptionsViewController:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController didSelectPaymentOption:(id<STPPaymentOption> _Nonnull)paymentOption;
		[Export ("paymentOptionsViewController:didSelectPaymentOption:")]
		void PaymentOptionsViewController (STPPaymentOptionsViewController paymentOptionsViewController, ISTPPaymentOption paymentOption);
	}

	// @interface STPPaymentContext : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STPPaymentContext
	{
		// -(instancetype _Nonnull)initWithCustomerContext:(STPCustomerContext * _Nonnull)customerContext;
		[Export ("initWithCustomerContext:")]
		NativeHandle Constructor (STPCustomerContext customerContext);

		// -(instancetype _Nonnull)initWithCustomerContext:(STPCustomerContext * _Nonnull)customerContext configuration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme;
		[Export ("initWithCustomerContext:configuration:theme:")]
		NativeHandle Constructor (STPCustomerContext customerContext, STPPaymentConfiguration configuration, STPTheme theme);

		// -(instancetype _Nonnull)initWithApiAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter;
		[Export ("initWithApiAdapter:")]
		NativeHandle Constructor (ISTPBackendAPIAdapter apiAdapter);

		// -(instancetype _Nonnull)initWithApiAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter configuration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme __attribute__((objc_designated_initializer));
		[Export ("initWithApiAdapter:configuration:theme:")]
		[DesignatedInitializer]
		NativeHandle Constructor (ISTPBackendAPIAdapter apiAdapter, STPPaymentConfiguration configuration, STPTheme theme);

		// @property (readonly, nonatomic, strong) id<STPBackendAPIAdapter> _Nonnull apiAdapter;
		[Export ("apiAdapter", ArgumentSemantic.Strong)]
		ISTPBackendAPIAdapter ApiAdapter { get; }

		// @property (readonly, nonatomic, strong) STPPaymentConfiguration * _Nonnull configuration;
		[Export ("configuration", ArgumentSemantic.Strong)]
		STPPaymentConfiguration Configuration { get; }

		// @property (readonly, nonatomic, strong) STPTheme * _Nonnull theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		STPTheme Theme { get; }

		// @property (nonatomic, strong) STPUserInformation * _Nullable prefilledInformation;
		[NullAllowed, Export ("prefilledInformation", ArgumentSemantic.Strong)]
		STPUserInformation PrefilledInformation { get; set; }

		// @property (nonatomic, weak) UIViewController * _Nullable hostViewController;
		[NullAllowed, Export ("hostViewController", ArgumentSemantic.Weak)]
		UIViewController HostViewController { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		STPPaymentContextDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<STPPaymentContextDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) BOOL loading;
		[Export ("loading")]
		bool Loading { get; }

		// @property (copy, nonatomic) NSString * _Nullable defaultPaymentMethod;
		[NullAllowed, Export ("defaultPaymentMethod")]
		string DefaultPaymentMethod { get; set; }

		// @property (readonly, nonatomic, strong) id<STPPaymentOption> _Nullable selectedPaymentOption;
		[NullAllowed, Export ("selectedPaymentOption", ArgumentSemantic.Strong)]
		ISTPPaymentOption SelectedPaymentOption { get; }

		// @property (readonly, copy, nonatomic) NSArray<id<STPPaymentOption>> * _Nullable paymentOptions;
		[NullAllowed, Export ("paymentOptions", ArgumentSemantic.Copy)]
		ISTPPaymentOption[] PaymentOptions { get; }

		// @property (readonly, nonatomic, strong) PKShippingMethod * _Nullable selectedShippingMethod;
		[NullAllowed, Export ("selectedShippingMethod", ArgumentSemantic.Strong)]
		PKShippingMethod SelectedShippingMethod { get; }

		// @property (readonly, copy, nonatomic) NSArray<PKShippingMethod *> * _Nullable shippingMethods;
		[NullAllowed, Export ("shippingMethods", ArgumentSemantic.Copy)]
		PKShippingMethod[] ShippingMethods { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		unsafe STPAddress ShippingAddress { get; }

		// @property (nonatomic) NSInteger paymentAmount;
		[Export ("paymentAmount")]
		nint PaymentAmount { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull paymentCurrency;
		[Export ("paymentCurrency")]
		string PaymentCurrency { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull paymentCountry;
		[Export ("paymentCountry")]
		string PaymentCountry { get; set; }

		// @property (copy, nonatomic) NSArray<PKPaymentSummaryItem *> * _Nonnull paymentSummaryItems;
		[Export ("paymentSummaryItems", ArgumentSemantic.Copy)]
		PKPaymentSummaryItem[] PaymentSummaryItems { get; set; }

		// @property (nonatomic) PKApplePayLaterAvailability applePayLaterAvailability __attribute__((availability(ios, introduced=17.0))) __attribute__((availability(macos, introduced=14.0)));
		[Export ("applePayLaterAvailability", ArgumentSemantic.Assign)]
		PKApplePayLaterAvailability ApplePayLaterAvailability { get; set; }

		// @property (nonatomic) UIModalPresentationStyle modalPresentationStyle;
		[Export ("modalPresentationStyle", ArgumentSemantic.Assign)]
		UIModalPresentationStyle ModalPresentationStyle { get; set; }

		// @property (nonatomic) UINavigationItemLargeTitleDisplayMode largeTitleDisplayMode;
		[Export ("largeTitleDisplayMode", ArgumentSemantic.Assign)]
		UINavigationItemLargeTitleDisplayMode LargeTitleDisplayMode { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable paymentOptionsViewControllerFooterView;
		[NullAllowed, Export ("paymentOptionsViewControllerFooterView", ArgumentSemantic.Strong)]
		UIView PaymentOptionsViewControllerFooterView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable addCardViewControllerFooterView;
		[NullAllowed, Export ("addCardViewControllerFooterView", ArgumentSemantic.Strong)]
		UIView AddCardViewControllerFooterView { get; set; }

		// -(void)retryLoading;
		[Export ("retryLoading")]
		void RetryLoading ();

		// -(void)presentPaymentOptionsViewController;
		[Export ("presentPaymentOptionsViewController")]
		void PresentPaymentOptionsViewController ();

		// -(void)pushPaymentOptionsViewController;
		[Export ("pushPaymentOptionsViewController")]
		void PushPaymentOptionsViewController ();

		// -(void)presentShippingViewController;
		[Export ("presentShippingViewController")]
		void PresentShippingViewController ();

		// -(void)pushShippingViewController;
		[Export ("pushShippingViewController")]
		void PushShippingViewController ();

		// -(void)requestPayment;
		[Export ("requestPayment")]
		void RequestPayment ();

		// -(void)paymentOptionsViewController:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController didSelectPaymentOption:(id<STPPaymentOption> _Nonnull)paymentOption;
		[Export ("paymentOptionsViewController:didSelectPaymentOption:")]
		void PaymentOptionsViewController (STPPaymentOptionsViewController paymentOptionsViewController, ISTPPaymentOption paymentOption);

		// -(void)paymentOptionsViewControllerDidFinish:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController;
		[Export ("paymentOptionsViewControllerDidFinish:")]
		void PaymentOptionsViewControllerDidFinish (STPPaymentOptionsViewController paymentOptionsViewController);

		// -(void)paymentOptionsViewControllerDidCancel:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController;
		[Export ("paymentOptionsViewControllerDidCancel:")]
		void PaymentOptionsViewControllerDidCancel (STPPaymentOptionsViewController paymentOptionsViewController);

		// -(void)paymentOptionsViewController:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController didFailToLoadWithError:(NSError * _Nonnull)error;
		[Export ("paymentOptionsViewController:didFailToLoadWithError:")]
		void PaymentOptionsViewController (STPPaymentOptionsViewController paymentOptionsViewController, NSError error);

		// -(void)shippingAddressViewControllerDidCancel:(STPShippingAddressViewController * _Nonnull)addressViewController;
		[Export ("shippingAddressViewControllerDidCancel:")]
		void ShippingAddressViewControllerDidCancel (STPShippingAddressViewController addressViewController);

		// -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didEnterAddress:(id)address completion:(void (^ _Nonnull)(enum STPShippingStatus, NSError * _Nullable, NSArray<PKShippingMethod *> * _Nullable, PKShippingMethod * _Nullable))completion;
		[Export ("shippingAddressViewController:didEnterAddress:completion:")]
		void ShippingAddressViewController (STPShippingAddressViewController addressViewController, NSObject address, Action<STPShippingStatus, NSError, NSArray<PKShippingMethod>, PKShippingMethod> completion);

		// -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didFinishWithAddress:(id)address shippingMethod:(PKShippingMethod * _Nullable)method;
		[Export ("shippingAddressViewController:didFinishWithAddress:shippingMethod:")]
		void ShippingAddressViewController (STPShippingAddressViewController addressViewController, NSObject address, [NullAllowed] PKShippingMethod method);

		// -(UIViewController * _Nonnull)authenticationPresentingViewController __attribute__((warn_unused_result("")));
		[Export ("authenticationPresentingViewController")]
		UIViewController AuthenticationPresentingViewController { get; }

		// -(void)prepareAuthenticationContextForPresentation:(void (^ _Nonnull)(void))completion;
		[Export ("prepareAuthenticationContextForPresentation:")]
		void PrepareAuthenticationContextForPresentation (Action completion);
	}

	// @protocol STPPaymentContextDelegate <NSObject>
	[Protocol (Name = "_TtP6Stripe25STPPaymentContextDelegate_"), Model]
	[BaseType (typeof(NSObject), Name = "_TtP6Stripe25STPPaymentContextDelegate_")]
	interface STPPaymentContextDelegate
	{
		// @required -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didFailToLoadWithError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("paymentContext:didFailToLoadWithError:")]
		void PaymentContext (STPPaymentContext paymentContext, NSError error);

		// @required -(void)paymentContextDidChange:(STPPaymentContext * _Nonnull)paymentContext;
		[Abstract]
		[Export ("paymentContextDidChange:")]
		void PaymentContextDidChange (STPPaymentContext paymentContext);

		// @required -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didCreatePaymentResult:(STPPaymentResult * _Nonnull)paymentResult completion:(void (^ _Nonnull)(enum STPPaymentStatus, NSError * _Nullable))completion;
		[Abstract]
		[Export ("paymentContext:didCreatePaymentResult:completion:")]
		void PaymentContext (STPPaymentContext paymentContext, STPPaymentResult paymentResult, Action<STPPaymentStatus, NSError> completion);

		// @required -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didFinishWith:(enum STPPaymentStatus)status error:(NSError * _Nullable)error;
		[Abstract]
		[Export ("paymentContext:didFinishWith:error:")]
		void PaymentContext (STPPaymentContext paymentContext, STPPaymentStatus status, [NullAllowed] NSError error);

		// @optional -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didUpdateShippingAddress:(id)address completion:(void (^ _Nonnull)(enum STPShippingStatus, NSError * _Nullable, NSArray<PKShippingMethod *> * _Nullable, PKShippingMethod * _Nullable))completion;
		[Export ("paymentContext:didUpdateShippingAddress:completion:")]
		void PaymentContext (STPPaymentContext paymentContext, NSObject address, Action<STPShippingStatus, NSError, NSArray<PKShippingMethod>, PKShippingMethod> completion);
	}

	// @interface Stripe_Swift_1461
	interface Stripe_Swift_1461
	{
		// -(void)configureWith:(STPPaymentResult * _Nonnull)paymentResult;
		[Export ("configureWith:")]
		void ConfigureWith (STPPaymentResult paymentResult);
	}

	// @interface Stripe_Swift_1468 (STPPaymentMethod)
	[Category]
	[BaseType (typeof(STPPaymentMethod))]
	interface STPPaymentMethod_Stripe_Swift_1468
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image();

		// @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
		[Export ("templateImage", ArgumentSemantic.Strong)]
		UIImage TemplateImage();

		// @property (readonly, copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label();

		// @property (readonly, nonatomic) BOOL isReusable;
		[Export ("isReusable")]
		bool IsReusable();
	}

	// @interface Stripe_Swift_1476 (STPPaymentMethodParams)
	[Category]
	[BaseType (typeof(STPPaymentMethodParams))]
	interface STPPaymentMethodParams_Stripe_Swift_1476
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image();

		// @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
		[Export ("templateImage", ArgumentSemantic.Strong)]
		UIImage TemplateImage();

		// @property (readonly, nonatomic) BOOL isReusable;
		[Export ("isReusable")]
		bool IsReusable();
	}

	// @interface STPPaymentOptionsViewController : STPCoreViewController <STPAddCardViewControllerDelegate>
	[BaseType (typeof(STPCoreViewController), Name = "_TtC6Stripe31STPPaymentOptionsViewController")]
	interface STPPaymentOptionsViewController : STPAddCardViewControllerDelegate
	{
		// -(instancetype _Nonnull)initWithPaymentContext:(STPPaymentContext * _Nonnull)paymentContext;
		[Export ("initWithPaymentContext:")]
		NativeHandle Constructor (STPPaymentContext paymentContext);

		// -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme customerContext:(STPCustomerContext * _Nonnull)customerContext delegate:(id<STPPaymentOptionsViewControllerDelegate> _Nonnull)delegate;
		[Export ("initWithConfiguration:theme:customerContext:delegate:")]
		NativeHandle Constructor (STPPaymentConfiguration configuration, STPTheme theme, STPCustomerContext customerContext, ISTPPaymentOptionsViewControllerDelegate @delegate);

		// -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme apiAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter delegate:(id<STPPaymentOptionsViewControllerDelegate> _Nonnull)delegate __attribute__((objc_designated_initializer));
		[Export ("initWithConfiguration:theme:apiAdapter:delegate:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPPaymentConfiguration configuration, STPTheme theme, ISTPBackendAPIAdapter apiAdapter, ISTPPaymentOptionsViewControllerDelegate @delegate);

		// @property (nonatomic, strong) STPUserInformation * _Nullable prefilledInformation;
		[NullAllowed, Export ("prefilledInformation", ArgumentSemantic.Strong)]
		STPUserInformation PrefilledInformation { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable defaultPaymentMethod;
		[NullAllowed, Export ("defaultPaymentMethod")]
		string DefaultPaymentMethod { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable paymentOptionsViewControllerFooterView;
		[NullAllowed, Export ("paymentOptionsViewControllerFooterView", ArgumentSemantic.Strong)]
		UIView PaymentOptionsViewControllerFooterView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable addCardViewControllerFooterView;
		[NullAllowed, Export ("addCardViewControllerFooterView", ArgumentSemantic.Strong)]
		UIView AddCardViewControllerFooterView { get; set; }

		// -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
		[Export ("dismissWithCompletion:")]
		void DismissWithCompletion ([NullAllowed] Action completion);

		// -(void)viewDidLayoutSubviews;
		[Export ("viewDidLayoutSubviews")]
		void ViewDidLayoutSubviews ();

		// -(void)viewDidAppear:(BOOL)animated;
		[Export ("viewDidAppear:")]
		void ViewDidAppear (bool animated);

		// -(void)addCardViewControllerDidCancel:(STPAddCardViewController * _Nonnull)addCardViewController;
		[Export ("addCardViewControllerDidCancel:")]
		void AddCardViewControllerDidCancel (STPAddCardViewController addCardViewController);

		// -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreatePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nonnull)(NSError * _Nullable))completion;
		[Export ("addCardViewController:didCreatePaymentMethod:completion:")]
		void AddCardViewController (STPAddCardViewController addCardViewController, STPPaymentMethod paymentMethod, Action<NSError> completion);
	}

	// @interface STPPaymentResult : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe16STPPaymentResult")]
	[DisableDefaultCtor]
	interface STPPaymentResult
	{
		// @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
		[NullAllowed, Export ("paymentMethod", ArgumentSemantic.Strong)]
		STPPaymentMethod PaymentMethod { get; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodParams * _Nullable paymentMethodParams;
		[NullAllowed, Export ("paymentMethodParams", ArgumentSemantic.Strong)]
		STPPaymentMethodParams PaymentMethodParams { get; }

		// @property (readonly, nonatomic, weak) id<STPPaymentOption> _Nullable paymentOption;
		[NullAllowed, Export ("paymentOption", ArgumentSemantic.Weak)]
		ISTPPaymentOption PaymentOption { get; }

		// -(instancetype _Nonnull)initWithPaymentOption:(id<STPPaymentOption> _Nullable)paymentOption __attribute__((objc_designated_initializer));
		[Export ("initWithPaymentOption:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] ISTPPaymentOption paymentOption);
	}

	// @interface STPPinManagementService : NSObject
	[Deprecated (PlatformName.iOS, 100000, 0, message: "Please use Issuing Elements instead: https://stripe.com/docs/issuing/elements")]
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe23STPPinManagementService")]
	[DisableDefaultCtor]
	interface STPPinManagementService
	{
		// -(instancetype _Nonnull)initWithKeyProvider:(id<STPIssuingCardEphemeralKeyProvider> _Nonnull)keyProvider __attribute__((objc_designated_initializer));
		[Export ("initWithKeyProvider:")]
		[DesignatedInitializer]
		NativeHandle Constructor (ISTPIssuingCardEphemeralKeyProvider keyProvider);

		// -(void)retrievePin:(NSString * _Nonnull)cardId verificationId:(NSString * _Nonnull)verificationId oneTimeCode:(NSString * _Nonnull)oneTimeCode completion:(void (^ _Nonnull)(STPIssuingCardPin * _Nullable, enum STPPinStatus, NSError * _Nullable))completion;
		[Export ("retrievePin:verificationId:oneTimeCode:completion:")]
		void RetrievePin (string cardId, string verificationId, string oneTimeCode, Action<STPIssuingCardPin, STPPinStatus, NSError> completion);

		// -(void)updatePin:(NSString * _Nonnull)cardId newPin:(NSString * _Nonnull)newPin verificationId:(NSString * _Nonnull)verificationId oneTimeCode:(NSString * _Nonnull)oneTimeCode completion:(void (^ _Nonnull)(STPIssuingCardPin * _Nullable, enum STPPinStatus, NSError * _Nullable))completion;
		[Export ("updatePin:newPin:verificationId:oneTimeCode:completion:")]
		void UpdatePin (string cardId, string newPin, string verificationId, string oneTimeCode, Action<STPIssuingCardPin, STPPinStatus, NSError> completion);
	}

	// @interface STPPushProvisioningContext : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe26STPPushProvisioningContext")]
	[DisableDefaultCtor]
	interface STPPushProvisioningContext
	{
		// +(PKAddPaymentPassRequestConfiguration * _Nonnull)requestConfigurationWithName:(NSString * _Nonnull)name description:(NSString * _Nullable)description last4:(NSString * _Nullable)last4 brand:(enum STPCardBrand)brand __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `requestConfiguration(withName:description:last4:brand:primaryAccountIdentifier:)` instead.", "requestConfigurationWithName:description:last4:brand:primaryAccountIdentifier:")));
		[Static]
		[Export ("requestConfigurationWithName:description:last4:brand:")]
		PKAddPaymentPassRequestConfiguration RequestConfigurationWithName (string name, [NullAllowed] string description, [NullAllowed] string last4, STPCardBrand brand);

		// +(PKAddPaymentPassRequestConfiguration * _Nonnull)requestConfigurationWithName:(NSString * _Nonnull)name description:(NSString * _Nullable)description last4:(NSString * _Nullable)last4 brand:(enum STPCardBrand)brand primaryAccountIdentifier:(NSString * _Nullable)primaryAccountIdentifier __attribute__((warn_unused_result("")));
		[Static]
		[Export ("requestConfigurationWithName:description:last4:brand:primaryAccountIdentifier:")]
		PKAddPaymentPassRequestConfiguration RequestConfigurationWithName (string name, [NullAllowed] string description, [NullAllowed] string last4, STPCardBrand brand, [NullAllowed] string primaryAccountIdentifier);

		// -(instancetype _Nonnull)initWithKeyProvider:(id<STPIssuingCardEphemeralKeyProvider> _Nonnull)keyProvider __attribute__((objc_designated_initializer));
		[Export ("initWithKeyProvider:")]
		[DesignatedInitializer]
		NativeHandle Constructor (ISTPIssuingCardEphemeralKeyProvider keyProvider);

		// -(void)addPaymentPassViewController:(PKAddPaymentPassViewController * _Nonnull)controller generateRequestWithCertificateChain:(NSArray<NSData *> * _Nonnull)certificates nonce:(NSData * _Nonnull)nonce nonceSignature:(NSData * _Nonnull)nonceSignature completionHandler:(void (^ _Nonnull)(PKAddPaymentPassRequest * _Nonnull))handler;
		[Export ("addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:")]
		void AddPaymentPassViewController (PKAddPaymentPassViewController controller, NSData[] certificates, NSData nonce, NSData nonceSignature, Action<PKAddPaymentPassRequest> handler);
	}

	// @interface STPPushProvisioningDetailsParams : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe32STPPushProvisioningDetailsParams")]
	[DisableDefaultCtor]
	interface STPPushProvisioningDetailsParams
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull cardId;
		[Export ("cardId")]
		string CardId { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSData *> * _Nonnull certificates;
		[Export ("certificates", ArgumentSemantic.Copy)]
		NSData[] Certificates { get; }

		// @property (readonly, copy, nonatomic) NSData * _Nonnull nonce;
		[Export ("nonce", ArgumentSemantic.Copy)]
		NSData Nonce { get; }

		// @property (readonly, copy, nonatomic) NSData * _Nonnull nonceSignature;
		[Export ("nonceSignature", ArgumentSemantic.Copy)]
		NSData NonceSignature { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull certificatesBase64;
		[Export ("certificatesBase64", ArgumentSemantic.Copy)]
		string[] CertificatesBase64 { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull nonceHex;
		[Export ("nonceHex")]
		string NonceHex { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull nonceSignatureHex;
		[Export ("nonceSignatureHex")]
		string NonceSignatureHex { get; }

		// -(instancetype _Nonnull)initWithCardId:(NSString * _Nonnull)cardId certificates:(NSArray<NSData *> * _Nonnull)certificates nonce:(NSData * _Nonnull)nonce nonceSignature:(NSData * _Nonnull)nonceSignature __attribute__((objc_designated_initializer));
		[Export ("initWithCardId:certificates:nonce:nonceSignature:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string cardId, NSData[] certificates, NSData nonce, NSData nonceSignature);
	}

	// @interface STPShippingAddressViewController : STPCoreTableViewController
	[BaseType (typeof(STPCoreTableViewController), Name = "_TtC6Stripe32STPShippingAddressViewController")]
	partial interface STPShippingAddressViewController
	{
		// -(instancetype _Nonnull)initWithPaymentContext:(STPPaymentContext * _Nonnull)paymentContext;
		[Export ("initWithPaymentContext:")]
		NativeHandle Constructor (STPPaymentContext paymentContext);

		// -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme currency:(NSString * _Nullable)currency shippingAddress:(id)shippingAddress selectedShippingMethod:(PKShippingMethod * _Nullable)selectedShippingMethod prefilledInformation:(STPUserInformation * _Nullable)prefilledInformation __attribute__((objc_designated_initializer));
		[Export ("initWithConfiguration:theme:currency:shippingAddress:selectedShippingMethod:prefilledInformation:")]
		[DesignatedInitializer]
		NativeHandle Constructor (STPPaymentConfiguration configuration, STPTheme theme, [NullAllowed] string currency, NSObject shippingAddress, [NullAllowed] PKShippingMethod selectedShippingMethod, [NullAllowed] STPUserInformation prefilledInformation);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		STPShippingAddressViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<STPShippingAddressViewControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
		[Export ("dismissWithCompletion:")]
		void DismissWithCompletion ([NullAllowed] Action completion);

		// -(void)viewDidAppear:(BOOL)animated;
		[Export ("viewDidAppear:")]
		void ViewDidAppear (bool animated);

		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:heightForHeaderInSection:")]
		nfloat GetHeightForHeader(UITableView tableView, nint section);
	}

	// @interface Stripe_Swift_1730 (STPShippingAddressViewController) <UITableViewDataSource, UITableViewDelegate>
	partial interface STPShippingAddressViewController : IUITableViewDataSource, IUITableViewDelegate
	{
		// -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
		[Export ("numberOfSectionsInTableView:")]
		nint NumberOfSections (UITableView tableView);

		// -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:numberOfRowsInSection:")]
		nint RowsInSection(UITableView tableView, nint section);

		// -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
		[Export ("tableView:cellForRowAtIndexPath:")]
		UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath);

		// -(void)tableView:(UITableView * _Nonnull)tableView willDisplayCell:(UITableViewCell * _Nonnull)cell forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
		[Export ("tableView:willDisplayCell:forRowAtIndexPath:")]
		void WillDisplay(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath);

		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:heightForFooterInSection:")]
		nfloat GetHeightForFooter(UITableView tableView, nint section);

		// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:viewForFooterInSection:")]
		[return: NullAllowed]
		UIView GetViewForFooter(UITableView tableView, nint section);

		// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
		[Export ("tableView:viewForHeaderInSection:")]
		[return: NullAllowed]
		UIView GetViewForHeader(UITableView tableView, nint section);
	}

	// @interface Stripe_Swift_1766 (STPSource)
	[Category]
	[BaseType (typeof(STPSource))]
	interface STPSource_Stripe_Swift_1766
	{
		// @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image();

		// @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
		[Export ("templateImage", ArgumentSemantic.Strong)]
		UIImage TemplateImage();

		// @property (readonly, copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label();

		// @property (readonly, nonatomic) BOOL isReusable;
		[Export ("isReusable")]
		bool IsReusable();
	}

	// @interface STPTheme : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe8STPTheme")]
	partial interface STPTheme
	{
		// @property (readonly, nonatomic, strong, class) STPTheme * _Nonnull defaultTheme;
		[Static]
		[Export ("defaultTheme", ArgumentSemantic.Strong)]
		STPTheme DefaultTheme { get; }

		// @property (nonatomic, strong) UIColor * _Nonnull primaryBackgroundColor;
		[Export ("primaryBackgroundColor", ArgumentSemantic.Strong)]
		UIColor PrimaryBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull secondaryBackgroundColor;
		[Export ("secondaryBackgroundColor", ArgumentSemantic.Strong)]
		UIColor SecondaryBackgroundColor { get; set; }

		// @property (readonly, nonatomic, strong) UIColor * _Nonnull tertiaryBackgroundColor;
		[Export ("tertiaryBackgroundColor", ArgumentSemantic.Strong)]
		UIColor TertiaryBackgroundColor { get; }

		// @property (readonly, nonatomic, strong) UIColor * _Nonnull quaternaryBackgroundColor;
		[Export ("quaternaryBackgroundColor", ArgumentSemantic.Strong)]
		UIColor QuaternaryBackgroundColor { get; }

		// @property (nonatomic, strong) UIColor * _Nonnull primaryForegroundColor;
		[Export ("primaryForegroundColor", ArgumentSemantic.Strong)]
		UIColor PrimaryForegroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull secondaryForegroundColor;
		[Export ("secondaryForegroundColor", ArgumentSemantic.Strong)]
		UIColor SecondaryForegroundColor { get; set; }

		// @property (readonly, nonatomic, strong) UIColor * _Nonnull tertiaryForegroundColor;
		[Export ("tertiaryForegroundColor", ArgumentSemantic.Strong)]
		UIColor TertiaryForegroundColor { get; }

		// @property (nonatomic, strong) UIColor * _Nonnull accentColor;
		[Export ("accentColor", ArgumentSemantic.Strong)]
		UIColor AccentColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull errorColor;
		[Export ("errorColor", ArgumentSemantic.Strong)]
		UIColor ErrorColor { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull font;
		[Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull emphasisFont;
		[Export ("emphasisFont", ArgumentSemantic.Strong)]
		UIFont EmphasisFont { get; set; }

		// @property (nonatomic) UIBarStyle barStyle;
		[Export ("barStyle", ArgumentSemantic.Assign)]
		UIBarStyle BarStyle { get; set; }

		// @property (nonatomic) BOOL translucentNavigationBar;
		[Export ("translucentNavigationBar")]
		bool TranslucentNavigationBar { get; set; }

		// @property (readonly, nonatomic, strong) UIFont * _Nonnull smallFont;
		[Export ("smallFont", ArgumentSemantic.Strong)]
		UIFont SmallFont { get; }

		// @property (readonly, nonatomic, strong) UIFont * _Nonnull largeFont;
		[Export ("largeFont", ArgumentSemantic.Strong)]
		UIFont LargeFont { get; }
	}

	// @interface Stripe_Swift_1818 (STPTheme) <NSCopying>
	partial interface STPTheme : INSCopying
	{
		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface STPUserInformation : NSObject <NSCopying>
	[BaseType (typeof(NSObject), Name = "_TtC6Stripe18STPUserInformation")]
	interface STPUserInformation : INSCopying
	{
		// @property (nonatomic, strong) int * _Nullable billingAddress;
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Strong)]
		unsafe STPAddress BillingAddress { get; set; }

		// @property (nonatomic, strong) int * _Nullable shippingAddress;
		[NullAllowed, Export ("shippingAddress", ArgumentSemantic.Strong)]
		unsafe STPAddress ShippingAddress { get; set; }

		// -(void)setBillingAddressWithBillingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails;
		[Export ("setBillingAddressWithBillingDetails:")]
		void SetBillingAddressWithBillingDetails (STPPaymentMethodBillingDetails billingDetails);

		// -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
		[Export ("copyWithZone:")]
		unsafe NSObject CopyWithZone ([NullAllowed] NSZone zone);
	}

	// @interface Stripe_Swift_1854 (UINavigationBar)
	[Category]
	[BaseType (typeof(UINavigationBar))]
	interface UINavigationBar_Stripe_Swift_1854
	{
		// -(void)stp_setTheme:(STPTheme * _Nonnull)theme __attribute__((deprecated("Use the `stp_theme` property instead")));
		[Export ("stp_setTheme:")]
		void Stp_setTheme (STPTheme theme);

		// @property (nonatomic, strong) STPTheme * _Nullable stp_theme;
		[NullAllowed, Export("stp_theme", ArgumentSemantic.Strong)]
		STPTheme Stp_theme();
        [NullAllowed, Export("stp_theme: ", ArgumentSemantic.Strong)]
        void Stp_theme(STPTheme theme);
    }
}
