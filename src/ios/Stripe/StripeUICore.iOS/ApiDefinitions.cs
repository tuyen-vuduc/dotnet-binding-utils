using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace StripeUICore
{
	// @interface STP_Internal_ActivityIndicator : UIView
	[BaseType (typeof(UIView))]
	interface STP_Internal_ActivityIndicator
	{
		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)tintColorDidChange;
		[Export ("tintColorDidChange")]
		void TintColorDidChange ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)willMoveToWindow:(UIWindow * _Nullable)newWindow;
		[Export ("willMoveToWindow:")]
		void WillMoveToWindow ([NullAllowed] UIWindow newWindow);
	}

	// @interface STP_Internal_Button : UIControl
	[BaseType (typeof(UIControl))]
	interface STP_Internal_Button
	{
		// @property (readonly, nonatomic) UIControlState state;
		[Export ("state")]
		UIControlState State { get; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// -(void)tintColorDidChange;
		[Export ("tintColorDidChange")]
		void TintColorDidChange ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("hitTest:withEvent:")]
		[return: NullAllowed]
		UIView HitTest (CGPoint point, [NullAllowed] UIEvent @event);
	}

	// @interface StripeUICore_Swift_344 (STP_Internal_Button)
	[Category]
	[BaseType (typeof(STP_Internal_Button))]
	interface STP_Internal_Button_StripeUICore_Swift_344
	{
		// -(void)updateConstraints __attribute__((objc_requires_super));
		[Export ("updateConstraints")]
		[RequiresSuper]
		void UpdateConstraints ();
	}

	// @interface STP_Internal_CheckboxButton : UIControl
	[BaseType (typeof(UIControl))]
	partial interface STP_Internal_CheckboxButton
	{
		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (getter = isHidden, nonatomic) BOOL hidden;
		[Export ("hidden")]
		bool Hidden { [Bind ("isHidden")] get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

	// @interface StripeUICore_Swift_366 (STP_Internal_CheckboxButton) <UITextViewDelegate>
	partial interface STP_Internal_CheckboxButton : IUITextViewDelegate
	{
		// -(BOOL)textView:(UITextView * _Nonnull)textView shouldInteractWithURL:(NSURL * _Nonnull)url inRange:(NSRange)characterRange __attribute__((warn_unused_result("")));
		[Export ("textView:shouldInteractWithURL:inRange:")]
		bool ShouldInteractWithUrl(UITextView textView, NSUrl url, NSRange characterRange);
	}

	// @interface STP_Internal_DoneButtonToolbar : UIToolbar
	[BaseType (typeof(UIToolbar))]
	interface STP_Internal_DoneButtonToolbar
	{
	}

	// @interface STP_Internal_DropdownFieldElement : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	partial interface STP_Internal_DropdownFieldElement
	{
	}

	// @interface StripeUICore_Swift_392 (STP_Internal_DropdownFieldElement) <UIPickerViewDataSource>
	partial interface STP_Internal_DropdownFieldElement : IUIPickerViewDataSource
	{
		// -(NSInteger)numberOfComponentsInPickerView:(UIPickerView * _Nonnull)pickerView __attribute__((warn_unused_result("")));
		[Export ("numberOfComponentsInPickerView:")]
		nint GetComponentCount(UIPickerView pickerView);

		// -(NSInteger)pickerView:(UIPickerView * _Nonnull)pickerView numberOfRowsInComponent:(NSInteger)component __attribute__((warn_unused_result("")));
		[Export ("pickerView:numberOfRowsInComponent:")]
		nint GetRowsInComponent(UIPickerView pickerView, nint component);
	}

	// @interface StripeUICore_Swift_399 (STP_Internal_DropdownFieldElement) <UIPickerViewDelegate>
	partial interface STP_Internal_DropdownFieldElement : IUIPickerViewDelegate
    {
		// -(NSAttributedString * _Nullable)pickerView:(UIPickerView * _Nonnull)pickerView attributedTitleForRow:(NSInteger)row forComponent:(NSInteger)component __attribute__((warn_unused_result("")));
		[Export ("pickerView:attributedTitleForRow:forComponent:")]
		[return: NullAllowed]
		NSAttributedString GetAttributedTitle (UIPickerView pickerView, nint row, nint component);

		// -(void)pickerView:(UIPickerView * _Nonnull)pickerView didSelectRow:(NSInteger)row inComponent:(NSInteger)component;
		[Export ("pickerView:didSelectRow:inComponent:")]
		void Selected (UIPickerView pickerView, nint row, nint component);
	}

	// @interface STP_Internal_DynamicHeightContainerView : UIView
	[BaseType (typeof(UIView))]
	interface STP_Internal_DynamicHeightContainerView
	{
	}

	// @interface STP_Internal_DynamicImageView : UIImageView
	[BaseType (typeof(UIImageView))]
	interface STP_Internal_DynamicImageView
	{
		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

	// @interface STP_Internal_FormView : UIView
	[BaseType (typeof(UIView))]
	interface STP_Internal_FormView
	{
	}

	// @interface STP_Internal_OneTimeCodeTextField : UIControl
	[BaseType (typeof(UIControl))]
	partial interface STP_Internal_OneTimeCodeTextField
	{
		// @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
		[Export ("canBecomeFirstResponder")]
		bool CanBecomeFirstResponder { get; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (nonatomic) UIKeyboardType keyboardType;
		[Export ("keyboardType", ArgumentSemantic.Assign)]
		UIKeyboardType KeyboardType { get; set; }

		// @property (nonatomic) UITextContentType _Nullable textContentType;
		[NullAllowed, Export ("textContentType")]
		string TextContentType { get; set; }

		// @property (nonatomic, strong) UITextRange * _Nullable selectedTextRange;
		[NullAllowed, Export ("selectedTextRange", ArgumentSemantic.Strong)]
		UITextRange SelectedTextRange { get; set; }

		[Wrap ("WeakInputDelegate")]
		[NullAllowed]
		UITextInputDelegate InputDelegate { get; set; }

		// @property (nonatomic, strong) id<UITextInputDelegate> _Nullable inputDelegate;
		[NullAllowed, Export ("inputDelegate", ArgumentSemantic.Strong)]
		NSObject WeakInputDelegate { get; set; }

		// @property (nonatomic, strong) id<UITextInputTokenizer> _Nonnull tokenizer;
		[Export ("tokenizer", ArgumentSemantic.Strong)]
		UITextInputTokenizer Tokenizer { get; set; }

		// -(BOOL)becomeFirstResponder;
		[Export ("becomeFirstResponder")]
		bool BecomeFirstResponder();

		// -(BOOL)resignFirstResponder;
		[Export ("resignFirstResponder")]
		bool ResignFirstResponder();

		// -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);
	}

	// @interface StripeUICore_Swift_468 (STP_Internal_OneTimeCodeTextField)
	partial interface STP_Internal_OneTimeCodeTextField
	{
		// -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nullable)sender __attribute__((warn_unused_result("")));
		[Export ("canPerformAction:withSender:")]
		bool CanPerformAction (Selector action, [NullAllowed] NSObject sender);

		// -(void)paste:(id _Nullable)sender;
		[Export ("paste:")]
		void Paste ([NullAllowed] NSObject sender);
	}

	// @interface StripeUICore_Swift_475 (STP_Internal_OneTimeCodeTextField) <UIKeyInput>
	partial interface STP_Internal_OneTimeCodeTextField : IUIKeyInput
	{
		// @property (readonly, nonatomic) BOOL hasText;
		[Export ("hasText")]
		bool HasText { get; }

		// -(void)insertText:(NSString * _Nonnull)text;
		[Export ("insertText:")]
		void InsertText (string text);

		// -(void)deleteBackward;
		[Export ("deleteBackward")]
		void DeleteBackward ();
	}

	// @interface StripeUICore_Swift_485 (STP_Internal_OneTimeCodeTextField) <UITextInput>
	partial interface STP_Internal_OneTimeCodeTextField : IUITextInput
	{
		// @property (readonly, nonatomic, strong) UITextRange * _Nullable markedTextRange;
		[NullAllowed, Export ("markedTextRange", ArgumentSemantic.Strong)]
		UITextRange MarkedTextRange { get; }

		// @property (copy, nonatomic) NSDictionary<NSAttributedStringKey,id> * _Nullable markedTextStyle;
		[NullAllowed, Export ("markedTextStyle", ArgumentSemantic.Copy)]
		NSDictionary MarkedTextStyle { get; set; }

		// @property (readonly, nonatomic, strong) UITextPosition * _Nonnull beginningOfDocument;
		[Export ("beginningOfDocument", ArgumentSemantic.Strong)]
		UITextPosition BeginningOfDocument { get; }

		// @property (readonly, nonatomic, strong) UITextPosition * _Nonnull endOfDocument;
		[Export ("endOfDocument", ArgumentSemantic.Strong)]
		UITextPosition EndOfDocument { get; }

		// -(NSString * _Nullable)textInRange:(UITextRange * _Nonnull)range __attribute__((warn_unused_result("")));
		[Export ("textInRange:")]
		[return: NullAllowed]
		string TextInRange (UITextRange range);

		// -(void)replaceRange:(UITextRange * _Nonnull)range withText:(NSString * _Nonnull)text;
		[Export ("replaceRange:withText:")]
		void ReplaceText (UITextRange range, string text);

		// -(void)setMarkedText:(NSString * _Nullable)markedText selectedRange:(NSRange)selectedRange;
		[Export ("setMarkedText:selectedRange:")]
		void SetMarkedText ([NullAllowed] string markedText, NSRange selectedRange);

		// -(void)unmarkText;
		[Export ("unmarkText")]
		void UnmarkText ();

		// -(UITextRange * _Nullable)textRangeFromPosition:(UITextPosition * _Nonnull)fromPosition toPosition:(UITextPosition * _Nonnull)toPosition __attribute__((warn_unused_result("")));
		[Export ("textRangeFromPosition:toPosition:")]
		[return: NullAllowed]
		UITextRange TextRangeFromPosition (UITextPosition fromPosition, UITextPosition toPosition);

		// -(UITextPosition * _Nullable)positionFromPosition:(UITextPosition * _Nonnull)position offset:(NSInteger)offset __attribute__((warn_unused_result("")));
		[Export ("positionFromPosition:offset:")]
		[return: NullAllowed]
		UITextPosition PositionFromPosition (UITextPosition position, nint offset);

		// -(UITextPosition * _Nullable)positionFromPosition:(UITextPosition * _Nonnull)position inDirection:(UITextLayoutDirection)direction offset:(NSInteger)offset __attribute__((warn_unused_result("")));
		[Export ("positionFromPosition:inDirection:offset:")]
		[return: NullAllowed]
		UITextPosition PositionFromPosition (UITextPosition position, UITextLayoutDirection direction, nint offset);

		// -(NSComparisonResult)comparePosition:(UITextPosition * _Nonnull)position toPosition:(UITextPosition * _Nonnull)other __attribute__((warn_unused_result("")));
		[Export ("comparePosition:toPosition:")]
		NSComparisonResult ComparePosition (UITextPosition position, UITextPosition other);

		// -(NSInteger)offsetFromPosition:(UITextPosition * _Nonnull)from toPosition:(UITextPosition * _Nonnull)toPosition __attribute__((warn_unused_result("")));
		[Export ("offsetFromPosition:toPosition:")]
		nint OffsetFromPosition (UITextPosition from, UITextPosition toPosition);

		// -(UITextPosition * _Nullable)positionWithinRange:(UITextRange * _Nonnull)range farthestInDirection:(UITextLayoutDirection)direction __attribute__((warn_unused_result("")));
		[Export ("positionWithinRange:farthestInDirection:")]
		[return: NullAllowed]
		UITextPosition PositionWithinRange (UITextRange range, UITextLayoutDirection direction);

		// -(UITextRange * _Nullable)characterRangeByExtendingPosition:(UITextPosition * _Nonnull)position inDirection:(UITextLayoutDirection)direction __attribute__((warn_unused_result("")));
		[Export ("characterRangeByExtendingPosition:inDirection:")]
		[return: NullAllowed]
		UITextRange GetCharacterRange (UITextPosition position, UITextLayoutDirection direction);

		// -(NSWritingDirection)baseWritingDirectionForPosition:(UITextPosition * _Nonnull)position inDirection:(UITextStorageDirection)direction __attribute__((warn_unused_result("")));
		[Export ("baseWritingDirectionForPosition:inDirection:")]
		NSWritingDirection GetBaseWritingDirection (UITextPosition position, UITextStorageDirection direction);

		// -(void)setBaseWritingDirection:(NSWritingDirection)writingDirection forRange:(UITextRange * _Nonnull)range;
		[Export ("setBaseWritingDirection:forRange:")]
		void SetBaseWritingDirectionforRange (NSWritingDirection writingDirection, UITextRange range);

		// -(CGRect)firstRectForRange:(UITextRange * _Nonnull)range __attribute__((warn_unused_result("")));
		[Export ("firstRectForRange:")]
		CGRect GetFirstRectForRange (UITextRange range);

		// -(CGRect)caretRectForPosition:(UITextPosition * _Nonnull)position __attribute__((warn_unused_result("")));
		[Export ("caretRectForPosition:")]
		CGRect GetCaretRectForPosition (UITextPosition position);

		// -(NSArray<UITextSelectionRect *> * _Nonnull)selectionRectsForRange:(UITextRange * _Nonnull)range __attribute__((warn_unused_result("")));
		[Export ("selectionRectsForRange:")]
		UITextSelectionRect[] SelectionRectsForRange (UITextRange range);

		// -(UITextPosition * _Nullable)closestPositionToPoint:(CGPoint)point __attribute__((warn_unused_result("")));
		[Export ("closestPositionToPoint:")]
		[return: NullAllowed]
		UITextPosition GetClosestPositionToPoint (CGPoint point);

		// -(UITextPosition * _Nullable)closestPositionToPoint:(CGPoint)point withinRange:(UITextRange * _Nonnull)range __attribute__((warn_unused_result("")));
		[Export ("closestPositionToPoint:withinRange:")]
		[return: NullAllowed]
		UITextPosition GetClosestPositionToPoint (CGPoint point, UITextRange range);

		// -(UITextRange * _Nullable)characterRangeAtPoint:(CGPoint)point __attribute__((warn_unused_result("")));
		[Export ("characterRangeAtPoint:")]
		[return: NullAllowed]
		UITextRange GetCharacterRangeAtPoint (CGPoint point);
	}

	// @interface STPEmailAddressValidator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC12StripeUICore24STPEmailAddressValidator")]
	interface STPEmailAddressValidator
	{
	}

	// @interface STPVPANumberValidator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC12StripeUICore21STPVPANumberValidator")]
	interface STPVPANumberValidator
	{
	}

	// @interface STP_Internal_StackViewWithSeparator : UIStackView
	[BaseType (typeof(UIStackView))]
	interface STP_Internal_StackViewWithSeparator
	{
		// @property (nonatomic) CGFloat spacing;
		[Export ("spacing")]
		nfloat Spacing { get; set; }

		// @property (getter = isUserInteractionEnabled, nonatomic) BOOL userInteractionEnabled;
		[Export ("userInteractionEnabled")]
		bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);
	}
}
