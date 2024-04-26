using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using StripePaymentsUI;
using UIKit;

namespace StripePaymentsUI
{
	// @interface STP_Internal_CardBrandView : UIView
	[BaseType (typeof(UIView))]
	interface STP_Internal_CardBrandView
	{
		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

	// @interface STP_Internal_PaymentMethodMessagingView : UIView
	[BaseType (typeof(UIView))]
	interface STP_Internal_PaymentMethodMessagingView
	{
		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

	// @protocol STPFormTextFieldContainer <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol (Name = "_TtP16StripePaymentsUI25STPFormTextFieldContainer_")]
	[BaseType (typeof(NSObject), Name = "_TtP16StripePaymentsUI25STPFormTextFieldContainer_")]
	interface STPFormTextFieldContainer
	{
		// @required @property (nonatomic, strong) UIFont * _Nonnull formFont;
		[Abstract]
		[Export ("formFont", ArgumentSemantic.Strong)]
		UIFont FormFont { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nonnull formTextColor;
		[Abstract]
		[Export ("formTextColor", ArgumentSemantic.Strong)]
		UIColor FormTextColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nonnull formTextErrorColor;
		[Abstract]
		[Export ("formTextErrorColor", ArgumentSemantic.Strong)]
		UIColor FormTextErrorColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nonnull formPlaceholderColor;
		[Abstract]
		[Export ("formPlaceholderColor", ArgumentSemantic.Strong)]
		UIColor FormPlaceholderColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nonnull formCursorColor;
		[Abstract]
		[Export ("formCursorColor", ArgumentSemantic.Strong)]
		UIColor FormCursorColor { get; set; }

		// @required @property (nonatomic) UIKeyboardAppearance formKeyboardAppearance;
		[Abstract]
		[Export ("formKeyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance FormKeyboardAppearance { get; set; }
	}

	// @interface STPMultiFormTextField : UIView <STPFormTextFieldContainer, UITextFieldDelegate>
	[BaseType (typeof(UIView), Name = "_TtC16StripePaymentsUI21STPMultiFormTextField")]
	interface STPMultiFormTextField : ISTPFormTextFieldContainer, IUITextFieldDelegate
	{
		// -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		bool TextField (UITextField textField, NSRange range, string @string);

		// -(void)focusNextForm;
		[Export ("focusNextForm")]
		void FocusNextForm ();

		// @property (readonly, nonatomic) BOOL canResignFirstResponder;
		[Export ("canResignFirstResponder")]
		bool CanResignFirstResponder { get; }

		// -(BOOL)resignFirstResponder __attribute__((warn_unused_result("")));
		[Export ("resignFirstResponder")]
		[Verify (MethodToProperty)]
		bool ResignFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL isFirstResponder;
		[Export ("isFirstResponder")]
		bool IsFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
		[Export ("canBecomeFirstResponder")]
		bool CanBecomeFirstResponder { get; }

		// -(BOOL)becomeFirstResponder __attribute__((warn_unused_result("")));
		[Export ("becomeFirstResponder")]
		[Verify (MethodToProperty)]
		bool BecomeFirstResponder { get; }

		// -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
		[Export ("textFieldDidEndEditing:")]
		void TextFieldDidEndEditing (UITextField textField);

		// -(void)textFieldDidBeginEditing:(UITextField * _Nonnull)textField;
		[Export ("textFieldDidBeginEditing:")]
		void TextFieldDidBeginEditing (UITextField textField);

		// -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
		[Export ("textFieldShouldReturn:")]
		bool TextFieldShouldReturn (UITextField textField);

		// @property (nonatomic, strong) UIFont * _Nonnull formFont;
		[Export ("formFont", ArgumentSemantic.Strong)]
		UIFont FormFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull formTextColor;
		[Export ("formTextColor", ArgumentSemantic.Strong)]
		UIColor FormTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull formTextErrorColor;
		[Export ("formTextErrorColor", ArgumentSemantic.Strong)]
		UIColor FormTextErrorColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull formPlaceholderColor;
		[Export ("formPlaceholderColor", ArgumentSemantic.Strong)]
		UIColor FormPlaceholderColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull formCursorColor;
		[Export ("formCursorColor", ArgumentSemantic.Strong)]
		UIColor FormCursorColor { get; set; }

		// @property (nonatomic) UIKeyboardAppearance formKeyboardAppearance;
		[Export ("formKeyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance FormKeyboardAppearance { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCoder coder);
	}

	// @interface STPAUBECSDebitFormView : STPMultiFormTextField <UITextViewDelegate>
	[BaseType (typeof(STPMultiFormTextField), Name = "_TtC16StripePaymentsUI22STPAUBECSDebitFormView")]
	interface STPAUBECSDebitFormView : IUITextViewDelegate
	{
		// -(instancetype _Nonnull)initWithCompanyName:(NSString * _Nonnull)companyName __attribute__((objc_designated_initializer));
		[Export ("initWithCompanyName:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string companyName);

		// @property (nonatomic, strong) UIColor * _Nonnull formBackgroundColor;
		[Export ("formBackgroundColor", ArgumentSemantic.Strong)]
		UIColor FormBackgroundColor { get; set; }

		[Wrap ("WeakBecsDebitFormDelegate")]
		[NullAllowed]
		STPAUBECSDebitFormViewDelegate BecsDebitFormDelegate { get; set; }

		// @property (nonatomic, weak) id<STPAUBECSDebitFormViewDelegate> _Nullable becsDebitFormDelegate;
		[NullAllowed, Export ("becsDebitFormDelegate", ArgumentSemantic.Weak)]
		NSObject WeakBecsDebitFormDelegate { get; set; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodParams * _Nullable paymentMethodParams;
		[NullAllowed, Export ("paymentMethodParams", ArgumentSemantic.Strong)]
		STPPaymentMethodParams PaymentMethodParams { get; }

		// -(CGSize)systemLayoutSizeFittingSize:(CGSize)targetSize withHorizontalFittingPriority:(UILayoutPriority)horizontalFittingPriority verticalFittingPriority:(UILayoutPriority)verticalFittingPriority __attribute__((warn_unused_result("")));
		[Export ("systemLayoutSizeFittingSize:withHorizontalFittingPriority:verticalFittingPriority:")]
		CGSize SystemLayoutSizeFittingSize (CGSize targetSize, float horizontalFittingPriority, float verticalFittingPriority);

		// -(BOOL)textView:(UITextView * _Nonnull)textView shouldInteractWithURL:(NSURL * _Nonnull)URL inRange:(NSRange)characterRange interaction:(UITextItemInteraction)interaction __attribute__((warn_unused_result("")));
		[Export ("textView:shouldInteractWithURL:inRange:interaction:")]
		bool TextView (UITextView textView, NSUrl URL, NSRange characterRange, UITextItemInteraction interaction);

		// @property (nonatomic, strong) UIFont * _Nonnull formFont;
		[Export ("formFont", ArgumentSemantic.Strong)]
		UIFont FormFont { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull formTextColor;
		[Export ("formTextColor", ArgumentSemantic.Strong)]
		UIColor FormTextColor { get; set; }
	}

	// @protocol STPAUBECSDebitFormViewDelegate <NSObject>
	[Protocol (Name = "_TtP16StripePaymentsUI30STPAUBECSDebitFormViewDelegate_"), Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject), Name = "_TtP16StripePaymentsUI30STPAUBECSDebitFormViewDelegate_")]
	interface STPAUBECSDebitFormViewDelegate
	{
		// @required -(void)auBECSDebitForm:(STPAUBECSDebitFormView * _Nonnull)form didChangeToStateComplete:(BOOL)complete;
		[Abstract]
		[Export ("auBECSDebitForm:didChangeToStateComplete:")]
		void DidChangeToStateComplete (STPAUBECSDebitFormView form, bool complete);
	}

	// @interface STPFloatingPlaceholderTextField : UITextField
	[BaseType (typeof(UITextField), Name = "_TtC16StripePaymentsUI31STPFloatingPlaceholderTextField")]
	interface STPFloatingPlaceholderTextField
	{
	}

	// @interface STPInputTextField : STPFloatingPlaceholderTextField
	[BaseType (typeof(STPFloatingPlaceholderTextField), Name = "_TtC16StripePaymentsUI17STPInputTextField")]
	interface STPInputTextField
	{
		// @property (copy, nonatomic) NSString * _Nullable text;
		[NullAllowed, Export ("text")]
		string Text { get; set; }

		// -(BOOL)becomeFirstResponder __attribute__((warn_unused_result("")));
		[Export ("becomeFirstResponder")]
		[Verify (MethodToProperty)]
		bool BecomeFirstResponder { get; }

		// -(BOOL)resignFirstResponder __attribute__((warn_unused_result("")));
		[Export ("resignFirstResponder")]
		[Verify (MethodToProperty)]
		bool ResignFirstResponder { get; }

		// @property (getter = isUserInteractionEnabled, nonatomic) BOOL userInteractionEnabled;
		[Export ("userInteractionEnabled")]
		bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable accessibilityAttributedValue;
		[NullAllowed, Export ("accessibilityAttributedValue", ArgumentSemantic.Strong)]
		NSAttributedString AccessibilityAttributedValue { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable accessibilityAttributedLabel;
		[NullAllowed, Export ("accessibilityAttributedLabel", ArgumentSemantic.Strong)]
		NSAttributedString AccessibilityAttributedLabel { get; set; }

		// -(void)deleteBackward;
		[Export ("deleteBackward")]
		void DeleteBackward ();

		// @property (readonly, copy, nonatomic) NSArray<UIKeyCommand *> * _Nullable keyCommands;
		[NullAllowed, Export ("keyCommands", ArgumentSemantic.Copy)]
		UIKeyCommand[] KeyCommands { get; }
	}

	// @interface STPCardCVCInputTextField : STPInputTextField
	[BaseType (typeof(STPInputTextField), Name = "_TtC16StripePaymentsUI24STPCardCVCInputTextField")]
	interface STPCardCVCInputTextField
	{
	}

	// @interface STPFormView : UIView
	[BaseType (typeof(UIView), Name = "_TtC16StripePaymentsUI11STPFormView")]
	interface STPFormView
	{
		// @property (readonly, nonatomic) BOOL canResignFirstResponder;
		[Export ("canResignFirstResponder")]
		bool CanResignFirstResponder { get; }

		// -(BOOL)resignFirstResponder __attribute__((warn_unused_result("")));
		[Export ("resignFirstResponder")]
		[Verify (MethodToProperty)]
		bool ResignFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL isFirstResponder;
		[Export ("isFirstResponder")]
		bool IsFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
		[Export ("canBecomeFirstResponder")]
		bool CanBecomeFirstResponder { get; }

		// -(BOOL)becomeFirstResponder __attribute__((warn_unused_result("")));
		[Export ("becomeFirstResponder")]
		[Verify (MethodToProperty)]
		bool BecomeFirstResponder { get; }

		// @property (getter = isUserInteractionEnabled, nonatomic) BOOL userInteractionEnabled;
		[Export ("userInteractionEnabled")]
		bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }
	}

	// @interface STPCardFormView : STPFormView
	[BaseType (typeof(STPFormView), Name = "_TtC16StripePaymentsUI15STPCardFormView")]
	interface STPCardFormView
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		STPCardFormViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<STPCardFormViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable disabledBackgroundColor;
		[NullAllowed, Export ("disabledBackgroundColor", ArgumentSemantic.Strong)]
		UIColor DisabledBackgroundColor { get; set; }

		// @property (readonly, nonatomic, strong) STPPaymentMethodParams * _Nullable cardParams;
		[NullAllowed, Export ("cardParams", ArgumentSemantic.Strong)]
		STPPaymentMethodParams CardParams { get; }

		// @property (getter = isUserInteractionEnabled, nonatomic) BOOL userInteractionEnabled;
		[Export ("userInteractionEnabled")]
		bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }

		// -(instancetype _Nonnull)initWithStyle:(enum STPCardFormViewStyle)style;
		[Export ("initWithStyle:")]
		NativeHandle Constructor (STPCardFormViewStyle style);

		// -(NSArray<NSNumber *> * _Nullable)preferredNetworks __attribute__((warn_unused_result("")));
		// -(void)setPreferredNetworks:(NSArray<NSNumber *> * _Nullable)preferredNetworks;
		[NullAllowed, Export ("preferredNetworks")]
		[Verify (MethodToProperty)]
		NSNumber[] PreferredNetworks { get; set; }
	}

	// @interface StripePaymentsUI_Swift_556 (STPCardFormView)
	[Category]
	[BaseType (typeof(STPCardFormView))]
	interface STPCardFormView_StripePaymentsUI_Swift_556
	{
	}

	// @protocol STPCardFormViewDelegate <NSObject>
	[Protocol (Name = "_TtP16StripePaymentsUI23STPCardFormViewDelegate_"), Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject), Name = "_TtP16StripePaymentsUI23STPCardFormViewDelegate_")]
	interface STPCardFormViewDelegate
	{
		// @required -(void)cardFormView:(STPCardFormView * _Nonnull)form didChangeToStateComplete:(BOOL)complete;
		[Abstract]
		[Export ("cardFormView:didChangeToStateComplete:")]
		void DidChangeToStateComplete (STPCardFormView form, bool complete);
	}

	// @interface STPCardNumberInputTextField : STPInputTextField
	[BaseType (typeof(STPInputTextField), Name = "_TtC16StripePaymentsUI27STPCardNumberInputTextField")]
	interface STPCardNumberInputTextField
	{
		// -(CGPoint)menuAttachmentPointForConfiguration:(UIContextMenuConfiguration * _Nonnull)configuration __attribute__((warn_unused_result("")));
		[Export ("menuAttachmentPointForConfiguration:")]
		CGPoint MenuAttachmentPointForConfiguration (UIContextMenuConfiguration configuration);

		// -(UIContextMenuConfiguration * _Nullable)contextMenuInteraction:(UIContextMenuInteraction * _Nonnull)interaction configurationForMenuAtLocation:(CGPoint)location __attribute__((warn_unused_result("")));
		[Export ("contextMenuInteraction:configurationForMenuAtLocation:")]
		[return: NullAllowed]
		UIContextMenuConfiguration ContextMenuInteraction (UIContextMenuInteraction interaction, CGPoint location);
	}

	// @interface STPGenericInputPickerField : STPInputTextField
	[BaseType (typeof(STPInputTextField), Name = "_TtC16StripePaymentsUI26STPGenericInputPickerField")]
	interface STPGenericInputPickerField
	{
		// @property (nonatomic, strong) NSAttributedString * _Nullable accessibilityAttributedValue;
		[NullAllowed, Export ("accessibilityAttributedValue", ArgumentSemantic.Strong)]
		NSAttributedString AccessibilityAttributedValue { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable accessibilityAttributedLabel;
		[NullAllowed, Export ("accessibilityAttributedLabel", ArgumentSemantic.Strong)]
		NSAttributedString AccessibilityAttributedLabel { get; set; }

		// -(BOOL)resignFirstResponder __attribute__((warn_unused_result("")));
		[Export ("resignFirstResponder")]
		[Verify (MethodToProperty)]
		bool ResignFirstResponder { get; }

		// -(CGRect)caretRectForPosition:(UITextPosition * _Nonnull)position __attribute__((warn_unused_result("")));
		[Export ("caretRectForPosition:")]
		CGRect CaretRectForPosition (UITextPosition position);
	}

	// @interface STPCountryPickerInputField : STPGenericInputPickerField
	[BaseType (typeof(STPGenericInputPickerField), Name = "_TtC16StripePaymentsUI26STPCountryPickerInputField")]
	interface STPCountryPickerInputField
	{
	}

	// @interface StripePaymentsUI_Swift_606 (STPCountryPickerInputField)
	[Category]
	[BaseType (typeof(STPCountryPickerInputField))]
	interface STPCountryPickerInputField_StripePaymentsUI_Swift_606
	{
	}

	// @interface StripePaymentsUI_Swift_611 (STPFloatingPlaceholderTextField)
	[Category]
	[BaseType (typeof(STPFloatingPlaceholderTextField))]
	interface STPFloatingPlaceholderTextField_StripePaymentsUI_Swift_611
	{
		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export ("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable attributedPlaceholder;
		[NullAllowed, Export ("attributedPlaceholder", ArgumentSemantic.Strong)]
		NSAttributedString AttributedPlaceholder { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable font;
		[NullAllowed, Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic) NSTextAlignment textAlignment;
		[Export ("textAlignment", ArgumentSemantic.Assign)]
		NSTextAlignment TextAlignment { get; set; }

		// @property (nonatomic) UITextFieldViewMode leftViewMode;
		[Export ("leftViewMode", ArgumentSemantic.Assign)]
		UITextFieldViewMode LeftViewMode { get; set; }

		// @property (nonatomic) UITextFieldViewMode rightViewMode;
		[Export ("rightViewMode", ArgumentSemantic.Assign)]
		UITextFieldViewMode RightViewMode { get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(BOOL)becomeFirstResponder __attribute__((warn_unused_result("")));
		[Export ("becomeFirstResponder")]
		[Verify (MethodToProperty)]
		bool BecomeFirstResponder { get; }

		// -(BOOL)resignFirstResponder __attribute__((warn_unused_result("")));
		[Export ("resignFirstResponder")]
		[Verify (MethodToProperty)]
		bool ResignFirstResponder { get; }

		// -(CGRect)textRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
		[Export ("textRectForBounds:")]
		CGRect TextRectForBounds (CGRect bounds);

		// -(CGRect)placeholderRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
		[Export ("placeholderRectForBounds:")]
		CGRect PlaceholderRectForBounds (CGRect bounds);

		// -(CGRect)editingRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
		[Export ("editingRectForBounds:")]
		CGRect EditingRectForBounds (CGRect bounds);

		// -(CGRect)leftViewRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
		[Export ("leftViewRectForBounds:")]
		CGRect LeftViewRectForBounds (CGRect bounds);

		// -(CGRect)rightViewRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
		[Export ("rightViewRectForBounds:")]
		CGRect RightViewRectForBounds (CGRect bounds);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(CGSize)systemLayoutSizeFittingSize:(CGSize)targetSize withHorizontalFittingPriority:(UILayoutPriority)horizontalFittingPriority verticalFittingPriority:(UILayoutPriority)verticalFittingPriority __attribute__((warn_unused_result("")));
		[Export ("systemLayoutSizeFittingSize:withHorizontalFittingPriority:verticalFittingPriority:")]
		CGSize SystemLayoutSizeFittingSize (CGSize targetSize, float horizontalFittingPriority, float verticalFittingPriority);
	}

	// @interface STPValidatedTextField : UITextField
	[BaseType (typeof(UITextField), Name = "_TtC16StripePaymentsUI21STPValidatedTextField")]
	interface STPValidatedTextField
	{
		// @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
		[NullAllowed, Export ("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (nonatomic) BOOL validText;
		[Export ("validText")]
		bool ValidText { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholder;
		[NullAllowed, Export ("placeholder")]
		string Placeholder { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCoder coder);
	}

	// @interface STPFormTextField : STPValidatedTextField
	[BaseType (typeof(STPValidatedTextField), Name = "_TtC16StripePaymentsUI16STPFormTextField")]
	interface STPFormTextField
	{
		// -(void)insertText:(NSString * _Nonnull)text;
		[Export ("insertText:")]
		void InsertText (string text);

		// -(void)deleteBackward;
		[Export ("deleteBackward")]
		void DeleteBackward ();

		// @property (copy, nonatomic) NSString * _Nullable text;
		[NullAllowed, Export ("text")]
		string Text { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable attributedText;
		[NullAllowed, Export ("attributedText", ArgumentSemantic.Strong)]
		NSAttributedString AttributedText { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable accessibilityAttributedValue;
		[NullAllowed, Export ("accessibilityAttributedValue", ArgumentSemantic.Strong)]
		NSAttributedString AccessibilityAttributedValue { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable accessibilityAttributedLabel;
		[NullAllowed, Export ("accessibilityAttributedLabel", ArgumentSemantic.Strong)]
		NSAttributedString AccessibilityAttributedLabel { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable attributedPlaceholder;
		[NullAllowed, Export ("attributedPlaceholder", ArgumentSemantic.Strong)]
		NSAttributedString AttributedPlaceholder { get; set; }

		// @property (readonly, copy, nonatomic) NSArray<UIKeyCommand *> * _Nullable keyCommands;
		[NullAllowed, Export ("keyCommands", ArgumentSemantic.Copy)]
		UIKeyCommand[] KeyCommands { get; }

		// -(UITextPosition * _Nullable)closestPositionToPoint:(CGPoint)point __attribute__((warn_unused_result("")));
		[Export ("closestPositionToPoint:")]
		[return: NullAllowed]
		UITextPosition ClosestPositionToPoint (CGPoint point);

		// -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nullable)sender __attribute__((warn_unused_result("")));
		[Export ("canPerformAction:withSender:")]
		bool CanPerformAction (Selector action, [NullAllowed] NSObject sender);

		// -(void)paste:(id _Nullable)sender;
		[Export ("paste:")]
		void Paste ([NullAllowed] NSObject sender);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		UITextFieldDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UITextFieldDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCoder coder);
	}

	// @interface StripePaymentsUI_Swift_701 (STPGenericInputPickerField) <UIPickerViewDelegate>
	[Category]
	[BaseType (typeof(STPGenericInputPickerField))]
	interface STPGenericInputPickerField_StripePaymentsUI_Swift_701 : IUIPickerViewDelegate
	{
		// -(NSAttributedString * _Nullable)pickerView:(UIPickerView * _Nonnull)pickerView attributedTitleForRow:(NSInteger)row forComponent:(NSInteger)component __attribute__((warn_unused_result("")));
		[Export ("pickerView:attributedTitleForRow:forComponent:")]
		[return: NullAllowed]
		NSAttributedString PickerView (UIPickerView pickerView, nint row, nint component);
	}

	// @interface STPImageLibrary : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC16StripePaymentsUI15STPImageLibrary")]
	interface STPImageLibrary
	{
		// +(UIImage * _Nonnull)applePayCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("applePayCardImage")]
		[Verify (MethodToProperty)]
		UIImage ApplePayCardImage { get; }

		// +(UIImage * _Nonnull)amexCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("amexCardImage")]
		[Verify (MethodToProperty)]
		UIImage AmexCardImage { get; }

		// +(UIImage * _Nonnull)dinersClubCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("dinersClubCardImage")]
		[Verify (MethodToProperty)]
		UIImage DinersClubCardImage { get; }

		// +(UIImage * _Nonnull)discoverCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("discoverCardImage")]
		[Verify (MethodToProperty)]
		UIImage DiscoverCardImage { get; }

		// +(UIImage * _Nonnull)jcbCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("jcbCardImage")]
		[Verify (MethodToProperty)]
		UIImage JcbCardImage { get; }

		// +(UIImage * _Nonnull)mastercardCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("mastercardCardImage")]
		[Verify (MethodToProperty)]
		UIImage MastercardCardImage { get; }

		// +(UIImage * _Nonnull)unionPayCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("unionPayCardImage")]
		[Verify (MethodToProperty)]
		UIImage UnionPayCardImage { get; }

		// +(UIImage * _Nonnull)visaCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("visaCardImage")]
		[Verify (MethodToProperty)]
		UIImage VisaCardImage { get; }

		// +(UIImage * _Nonnull)unknownCardCardImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("unknownCardCardImage")]
		[Verify (MethodToProperty)]
		UIImage UnknownCardCardImage { get; }

		// +(UIImage * _Nonnull)brandImageForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("brandImageForCardBrand:")]
		UIImage BrandImageForCardBrand (STPCardBrand brand);

		// +(UIImage * _Nonnull)cardBrandChoiceImage __attribute__((warn_unused_result("")));
		[Static]
		[Export ("cardBrandChoiceImage")]
		[Verify (MethodToProperty)]
		UIImage CardBrandChoiceImage { get; }

		// +(UIImage * _Nonnull)templatedBrandImageForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("templatedBrandImageForCardBrand:")]
		UIImage TemplatedBrandImageForCardBrand (STPCardBrand brand);

		// +(UIImage * _Nonnull)cvcImageForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("cvcImageForCardBrand:")]
		UIImage CvcImageForCardBrand (STPCardBrand brand);

		// +(UIImage * _Nonnull)errorImageForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("errorImageForCardBrand:")]
		UIImage ErrorImageForCardBrand (STPCardBrand brand);
	}

	// @interface STPPaymentCardTextField : UIControl <UIKeyInput>
	[BaseType (typeof(UIControl))]
	interface STPPaymentCardTextField : IUIKeyInput
	{
		// -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
		bool TextField (UITextField textField, NSRange range, string @string);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		STPPaymentCardTextFieldDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<STPPaymentCardTextFieldDelegate> _Nullable delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) UIFont * _Nonnull font;
		[Export ("font", ArgumentSemantic.Strong)]
		UIFont Font { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull textErrorColor;
		[Export ("textErrorColor", ArgumentSemantic.Strong)]
		UIColor TextErrorColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
		[Export ("placeholderColor", ArgumentSemantic.Strong)]
		UIColor PlaceholderColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable numberPlaceholder;
		[NullAllowed, Export ("numberPlaceholder")]
		string NumberPlaceholder { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable expirationPlaceholder;
		[NullAllowed, Export ("expirationPlaceholder")]
		string ExpirationPlaceholder { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable cvcPlaceholder;
		[NullAllowed, Export ("cvcPlaceholder")]
		string CvcPlaceholder { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable postalCodePlaceholder;
		[NullAllowed, Export ("postalCodePlaceholder")]
		string PostalCodePlaceholder { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull cursorColor;
		[Export ("cursorColor", ArgumentSemantic.Strong)]
		UIColor CursorColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable borderColor;
		[NullAllowed, Export ("borderColor", ArgumentSemantic.Strong)]
		UIColor BorderColor { get; set; }

		// @property (nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; set; }

		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic) UIKeyboardAppearance keyboardAppearance;
		[Export ("keyboardAppearance", ArgumentSemantic.Assign)]
		UIKeyboardAppearance KeyboardAppearance { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable inputView;
		[NullAllowed, Export ("inputView", ArgumentSemantic.Strong)]
		UIView InputView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable inputAccessoryView;
		[NullAllowed, Export ("inputAccessoryView", ArgumentSemantic.Strong)]
		UIView InputAccessoryView { get; set; }

		// @property (readonly, nonatomic, strong) UIImage * _Nullable brandImage;
		[NullAllowed, Export ("brandImage", ArgumentSemantic.Strong)]
		UIImage BrandImage { get; }

		// @property (readonly, nonatomic) BOOL isValid;
		[Export ("isValid")]
		bool IsValid { get; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable cardNumber;
		[NullAllowed, Export ("cardNumber")]
		string CardNumber { get; }

		// @property (readonly, nonatomic) NSInteger expirationMonth;
		[Export ("expirationMonth")]
		nint ExpirationMonth { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable formattedExpirationMonth;
		[NullAllowed, Export ("formattedExpirationMonth")]
		string FormattedExpirationMonth { get; }

		// @property (readonly, nonatomic) NSInteger expirationYear;
		[Export ("expirationYear")]
		nint ExpirationYear { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable formattedExpirationYear;
		[NullAllowed, Export ("formattedExpirationYear")]
		string FormattedExpirationYear { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable cvc;
		[NullAllowed, Export ("cvc")]
		string Cvc { get; }

		// @property (copy, nonatomic) NSString * _Nullable postalCode;
		[NullAllowed, Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (nonatomic) BOOL postalCodeEntryEnabled;
		[Export ("postalCodeEntryEnabled")]
		bool PostalCodeEntryEnabled { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryCode;
		[NullAllowed, Export ("countryCode")]
		string CountryCode { get; set; }

		// @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("Use .paymentMethodParams instead. If you must access the STPPaymentMethodCardParams, use .paymentMethodParams.card.") STPPaymentMethodCardParams * cardParams __attribute__((deprecated("Use .paymentMethodParams instead. If you must access the STPPaymentMethodCardParams, use .paymentMethodParams.card.")));
		[Export ("cardParams", ArgumentSemantic.Strong)]
		STPPaymentMethodCardParams CardParams { get; set; }

		// @property (nonatomic, strong) STPPaymentMethodParams * _Nonnull paymentMethodParams;
		[Export ("paymentMethodParams", ArgumentSemantic.Strong)]
		STPPaymentMethodParams PaymentMethodParams { get; set; }

		// -(BOOL)becomeFirstResponder;
		[Export ("becomeFirstResponder")]
		[Verify (MethodToProperty)]
		bool BecomeFirstResponder { get; }

		// -(BOOL)resignFirstResponder;
		[Export ("resignFirstResponder")]
		[Verify (MethodToProperty)]
		bool ResignFirstResponder { get; }

		// -(void)clear;
		[Export ("clear")]
		void Clear ();

		// +(UIImage * _Nullable)cvcImageForCardBrand:(enum STPCardBrand)cardBrand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("cvcImageForCardBrand:")]
		[return: NullAllowed]
		UIImage CvcImageForCardBrand (STPCardBrand cardBrand);

		// +(UIImage * _Nullable)cardBrandChoiceImage __attribute__((warn_unused_result("")));
		[Static]
		[NullAllowed, Export ("cardBrandChoiceImage")]
		[Verify (MethodToProperty)]
		UIImage CardBrandChoiceImage { get; }

		// +(UIImage * _Nullable)brandImageForCardBrand:(enum STPCardBrand)cardBrand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("brandImageForCardBrand:")]
		[return: NullAllowed]
		UIImage BrandImageForCardBrand (STPCardBrand cardBrand);

		// +(UIImage * _Nullable)errorImageForCardBrand:(enum STPCardBrand)cardBrand __attribute__((warn_unused_result("")));
		[Static]
		[Export ("errorImageForCardBrand:")]
		[return: NullAllowed]
		UIImage ErrorImageForCardBrand (STPCardBrand cardBrand);

		// -(CGRect)brandImageRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
		[Export ("brandImageRectForBounds:")]
		CGRect BrandImageRectForBounds (CGRect bounds);

		// -(CGRect)fieldsRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
		[Export ("fieldsRectForBounds:")]
		CGRect FieldsRectForBounds (CGRect bounds);

		// @property (copy, nonatomic) NSArray<STPFormTextField *> * _Nonnull allFields;
		[Export ("allFields", ArgumentSemantic.Copy)]
		STPFormTextField[] AllFields { get; set; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCoder aDecoder);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(CGPoint)menuAttachmentPointForConfiguration:(UIContextMenuConfiguration * _Nonnull)configuration __attribute__((warn_unused_result("")));
		[Export ("menuAttachmentPointForConfiguration:")]
		CGPoint MenuAttachmentPointForConfiguration (UIContextMenuConfiguration configuration);

		// -(UIContextMenuConfiguration * _Nullable)contextMenuInteraction:(UIContextMenuInteraction * _Nonnull)interaction configurationForMenuAtLocation:(CGPoint)location __attribute__((warn_unused_result("")));
		[Export ("contextMenuInteraction:configurationForMenuAtLocation:")]
		[return: NullAllowed]
		UIContextMenuConfiguration ContextMenuInteraction (UIContextMenuInteraction interaction, CGPoint location);

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic) UIControlContentVerticalAlignment contentVerticalAlignment;
		[Export ("contentVerticalAlignment", ArgumentSemantic.Assign)]
		UIControlContentVerticalAlignment ContentVerticalAlignment { get; set; }

		// @property (readonly, nonatomic) BOOL isFirstResponder;
		[Export ("isFirstResponder")]
		bool IsFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
		[Export ("canBecomeFirstResponder")]
		bool CanBecomeFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL canResignFirstResponder;
		[Export ("canResignFirstResponder")]
		bool CanResignFirstResponder { get; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(BOOL)textFieldShouldBeginEditing:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
		[Export ("textFieldShouldBeginEditing:")]
		bool TextFieldShouldBeginEditing (UITextField textField);

		// -(void)textFieldDidBeginEditing:(UITextField * _Nonnull)textField;
		[Export ("textFieldDidBeginEditing:")]
		void TextFieldDidBeginEditing (UITextField textField);

		// -(BOOL)textFieldShouldEndEditing:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
		[Export ("textFieldShouldEndEditing:")]
		bool TextFieldShouldEndEditing (UITextField textField);

		// -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
		[Export ("textFieldDidEndEditing:")]
		void TextFieldDidEndEditing (UITextField textField);

		// -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
		[Export ("textFieldShouldReturn:")]
		bool TextFieldShouldReturn (UITextField textField);

		// @property (readonly, nonatomic) BOOL hasText;
		[Export ("hasText")]
		bool HasText { get; }

		// -(void)insertText:(NSString * _Nonnull)text;
		[Export ("insertText:")]
		void InsertText (string text);

		// -(void)deleteBackward;
		[Export ("deleteBackward")]
		void DeleteBackward ();

		// +(NSSet<NSString *> * _Nonnull)keyPathsForValuesAffectingIsValid __attribute__((warn_unused_result("")));
		[Static]
		[Export ("keyPathsForValuesAffectingIsValid")]
		[Verify (MethodToProperty)]
		NSSet<NSString> KeyPathsForValuesAffectingIsValid { get; }

		// -(NSArray<NSNumber *> * _Nullable)preferredNetworks __attribute__((warn_unused_result("")));
		// -(void)setPreferredNetworks:(NSArray<NSNumber *> * _Nullable)preferredNetworks;
		[NullAllowed, Export ("preferredNetworks")]
		[Verify (MethodToProperty)]
		NSNumber[] PreferredNetworks { get; set; }
	}

	// @protocol STPPaymentCardTextFieldDelegate <NSObject>
	[Protocol (Name = "_TtP16StripePaymentsUI31STPPaymentCardTextFieldDelegate_"), Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject), Name = "_TtP16StripePaymentsUI31STPPaymentCardTextFieldDelegate_")]
	interface STPPaymentCardTextFieldDelegate
	{
		// @optional -(void)paymentCardTextFieldDidChange:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidChange:")]
		void PaymentCardTextFieldDidChange (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidBeginEditing:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidBeginEditing:")]
		void PaymentCardTextFieldDidBeginEditing (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldWillEndEditingForReturn:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldWillEndEditingForReturn:")]
		void PaymentCardTextFieldWillEndEditingForReturn (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidEndEditing:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidEndEditing:")]
		void PaymentCardTextFieldDidEndEditing (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidBeginEditingNumber:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidBeginEditingNumber:")]
		void PaymentCardTextFieldDidBeginEditingNumber (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidEndEditingNumber:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidEndEditingNumber:")]
		void PaymentCardTextFieldDidEndEditingNumber (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidBeginEditingCVC:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidBeginEditingCVC:")]
		void PaymentCardTextFieldDidBeginEditingCVC (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidEndEditingCVC:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidEndEditingCVC:")]
		void PaymentCardTextFieldDidEndEditingCVC (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidBeginEditingExpiration:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidBeginEditingExpiration:")]
		void PaymentCardTextFieldDidBeginEditingExpiration (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidEndEditingExpiration:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidEndEditingExpiration:")]
		void PaymentCardTextFieldDidEndEditingExpiration (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidBeginEditingPostalCode:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidBeginEditingPostalCode:")]
		void PaymentCardTextFieldDidBeginEditingPostalCode (STPPaymentCardTextField textField);

		// @optional -(void)paymentCardTextFieldDidEndEditingPostalCode:(STPPaymentCardTextField * _Nonnull)textField;
		[Export ("paymentCardTextFieldDidEndEditingPostalCode:")]
		void PaymentCardTextFieldDidEndEditingPostalCode (STPPaymentCardTextField textField);
	}

	// @interface STPPhoneNumberValidator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC16StripePaymentsUI23STPPhoneNumberValidator")]
	interface STPPhoneNumberValidator
	{
	}

	// @interface STPPostalCodeInputTextField : STPInputTextField
	[BaseType (typeof(STPInputTextField), Name = "_TtC16StripePaymentsUI27STPPostalCodeInputTextField")]
	interface STPPostalCodeInputTextField
	{
	}

	// @interface STPPostalCodeValidator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC16StripePaymentsUI22STPPostalCodeValidator")]
	interface STPPostalCodeValidator
	{
	}

	// @interface STPStringUtils : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC16StripePaymentsUI14STPStringUtils")]
	interface STPStringUtils
	{
		// +(NSString * _Nullable)expirationDateStringFromString:(NSString * _Nullable)string __attribute__((warn_unused_result("")));
		[Static]
		[Export ("expirationDateStringFromString:")]
		[return: NullAllowed]
		string ExpirationDateStringFromString ([NullAllowed] string @string);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double StripePaymentsUIVersionNumber;
		[Field ("StripePaymentsUIVersionNumber", "__Internal")]
		double StripePaymentsUIVersionNumber { get; }

		// extern const unsigned char[] StripePaymentsUIVersionString;
		[Field ("StripePaymentsUIVersionString", "__Internal")]
		byte[] StripePaymentsUIVersionString { get; }
	}
}
