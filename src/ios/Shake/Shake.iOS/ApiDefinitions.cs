using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Shake;
using UIKit;
using UserNotifications;

namespace Shake
{
	// @protocol SHKFormItemProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/ 
	partial interface ISHKFormItemProtocol {}

	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SHKFormItemProtocol
	{
	}

	// @interface SHKAttachments : NSObject <SHKFormItemProtocol>
	[BaseType (typeof(NSObject))]
	interface SHKAttachments : SHKFormItemProtocol
	{
	}

	// @interface SHKConstants : NSObject
	[BaseType (typeof(NSObject))]
	interface SHKConstants
	{
	}

	// @interface SHKEmail : NSObject <SHKFormItemProtocol>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKEmail : SHKFormItemProtocol
	{
		// @property (readonly, strong) NSString * _Nonnull label;
		[Export ("label", ArgumentSemantic.Strong)]
		string Label { get; }

		// @property (readonly, strong) NSString * _Nonnull key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }

		// @property (readonly, strong) NSString * _Nullable initialValue;
		[NullAllowed, Export ("initialValue", ArgumentSemantic.Strong)]
		string InitialValue { get; }

		// @property (readonly) BOOL required;
		[Export ("required")]
		bool Required { get; }

		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)key label:(NSString * _Nonnull)label required:(BOOL)required initialValue:(NSString * _Nullable)initialValue;
		[Export ("initWithKey:label:required:initialValue:")]
		NativeHandle Constructor (string key, string label, bool required, [NullAllowed] string initialValue);
	}

	// @interface SHKPickerItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKPickerItem
	{
		// @property (readonly, strong) NSString * _Nonnull key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }

		// @property (readonly, strong) NSString * _Nonnull text;
		[Export ("text", ArgumentSemantic.Strong)]
		string Text { get; }

		// @property (readonly, strong) UIImage * _Nonnull icon;
		[Export ("icon", ArgumentSemantic.Strong)]
		UIImage Icon { get; }

		// @property (readonly, strong) NSString * _Nullable tag;
		[NullAllowed, Export ("tag", ArgumentSemantic.Strong)]
		string Tag { get; }

		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)key text:(NSString * _Nonnull)text icon:(UIImage * _Nullable)icon tag:(NSString * _Nullable)tag;
		[Export ("initWithKey:text:icon:tag:")]
		NativeHandle Constructor (string key, string text, [NullAllowed] UIImage icon, [NullAllowed] string tag);
	}

	// @interface SHKPicker : NSObject <SHKFormItemProtocol>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKPicker : SHKFormItemProtocol
	{
		// @property (readonly, strong) NSString * _Nonnull label;
		[Export ("label", ArgumentSemantic.Strong)]
		string Label { get; }

		// @property (readonly, strong) NSString * _Nonnull key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }

		// @property (readonly, strong) NSArray<SHKPickerItem *> * _Nonnull items;
		[Export ("items", ArgumentSemantic.Strong)]
		SHKPickerItem[] Items { get; }

		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)key label:(NSString * _Nonnull)label items:(NSArray<SHKPickerItem *> * _Nonnull)items;
		[Export ("initWithKey:label:items:")]
		NativeHandle Constructor (string key, string label, SHKPickerItem[] items);
	}

	// @interface SHKTitle : NSObject <SHKFormItemProtocol>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKTitle : SHKFormItemProtocol
	{
		// @property (readonly, strong) NSString * _Nonnull label;
		[Export ("label", ArgumentSemantic.Strong)]
		string Label { get; }

		// @property (readonly, strong) NSString * _Nonnull key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }

		// @property (readonly, strong) NSString * _Nullable initialValue;
		[NullAllowed, Export ("initialValue", ArgumentSemantic.Strong)]
		string InitialValue { get; }

		// @property (readonly) BOOL required;
		[Export ("required")]
		bool Required { get; }

		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)key label:(NSString * _Nonnull)label required:(BOOL)required initialValue:(NSString * _Nullable)initialValue;
		[Export ("initWithKey:label:required:initialValue:")]
		NativeHandle Constructor (string key, string label, bool required, [NullAllowed] string initialValue);
	}

	// @interface SHKInspectButton : NSObject <SHKFormItemProtocol>
	[BaseType (typeof(NSObject))]
	interface SHKInspectButton : SHKFormItemProtocol
	{
	}

	// @interface SHKTextInput : NSObject <SHKFormItemProtocol>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKTextInput : SHKFormItemProtocol
	{
		// @property (readonly, strong) NSString * _Nonnull label;
		[Export ("label", ArgumentSemantic.Strong)]
		string Label { get; }

		// @property (readonly, strong) NSString * _Nonnull key;
		[Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }

		// @property (readonly, strong) NSString * _Nullable initialValue;
		[NullAllowed, Export ("initialValue", ArgumentSemantic.Strong)]
		string InitialValue { get; }

		// @property (readonly) BOOL required;
		[Export ("required")]
		bool Required { get; }

		// -(instancetype _Nonnull)initWithKey:(NSString * _Nonnull)key label:(NSString * _Nonnull)label required:(BOOL)required initialValue:(NSString * _Nullable)initialValue;
		[Export ("initWithKey:label:required:initialValue:")]
		NativeHandle Constructor (string key, string label, bool required, [NullAllowed] string initialValue);
	}

	// @interface SHKForm : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKForm
	{
		// @property (readonly) NSArray<id<SHKFormItemProtocol>> * _Nonnull items;
		[Export ("items")]
		ISHKFormItemProtocol[] Items { get; }

		// -(instancetype _Nonnull)initWithItems:(NSArray<id<SHKFormItemProtocol>> * _Nonnull)items;
		[Export ("initWithItems:")]
		IntPtr Constructor (ISHKFormItemProtocol[] items);

		// +(SHKForm * _Nonnull)defaultForm;
		[Static]
		[Export ("defaultForm")]
		SHKForm DefaultForm ();
	}

	// @protocol SHKHomeActionProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ISHKHomeActionProtocol {}

	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SHKHomeActionProtocol
	{
		// @required @property (nonatomic, strong) UIImage * _Nonnull icon;
		[Abstract]
		[Export ("icon", ArgumentSemantic.Strong)]
		UIImage Icon { get; set; }

		// @required @property (nonatomic, strong) NSString * _Nonnull title;
		[Abstract]
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @required @property (nonatomic, strong) NSString * _Nullable subtitle;
		[Abstract]
		[NullAllowed, Export ("subtitle", ArgumentSemantic.Strong)]
		string Subtitle { get; set; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(void) handler;
		[Abstract]
		[NullAllowed, Export ("handler", ArgumentSemantic.Copy)]
		Action Handler { get; set; }
	}

	// @interface SHKHomeAction : NSObject <SHKHomeActionProtocol>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKHomeAction : SHKHomeActionProtocol
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle icon:(UIImage * _Nullable)icon handler:(void (^ _Nullable)(void))handler;
		[Export ("initWithTitle:subtitle:icon:handler:")]
		NativeHandle Constructor (string title, [NullAllowed] string subtitle, [NullAllowed] UIImage icon, [NullAllowed] Action handler);

		// +(NSArray<id<SHKHomeActionProtocol>> * _Nonnull)defaultHomeActions;
		[Static]
		[Export ("defaultHomeActions")]
		ISHKHomeActionProtocol[] DefaultHomeActions();
	}

	// @interface SHKHomeSubmitAction : NSObject <SHKHomeActionProtocol>
	[BaseType (typeof(NSObject))]
	interface SHKHomeSubmitAction : SHKHomeActionProtocol
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title subtitle:(NSString * _Nullable)subtitle icon:(UIImage * _Nullable)icon;
		[Export ("initWithTitle:subtitle:icon:")]
		NativeHandle Constructor ([NullAllowed] string title, [NullAllowed] string subtitle, [NullAllowed] UIImage icon);
	}

	// @interface SHKHomeChatAction : NSObject <SHKHomeActionProtocol>
	[BaseType (typeof(NSObject))]
	interface SHKHomeChatAction : SHKHomeActionProtocol
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title subtitle:(NSString * _Nullable)subtitle icon:(UIImage * _Nullable)icon;
		[Export ("initWithTitle:subtitle:icon:")]
		NativeHandle Constructor ([NullAllowed] string title, [NullAllowed] string subtitle, [NullAllowed] UIImage icon);
	}

	// @interface SHKNetworkRequestEditor : NSObject
	[BaseType (typeof(NSObject))]
	interface SHKNetworkRequestEditor
	{
		// -(instancetype _Nonnull)initWith:(NSUrlRequest * _Nonnull)request response:(NSUrlResponse * _Nullable)response responseData:(NSData * _Nullable)data error:(NSError * _Nullable)error timestamp:(NSDate * _Nonnull)timestamp duration:(NSTimeInterval)duration;
		[Export ("initWith:response:responseData:error:timestamp:duration:")]
		NativeHandle Constructor (NSUrlRequest request, [NullAllowed] NSUrlResponse response, [NullAllowed] NSData data, [NullAllowed] NSError error, NSDate timestamp, double duration);

		// @property (readonly, nonatomic, strong) NSString * _Nullable method;
		[NullAllowed, Export ("method", ArgumentSemantic.Strong)]
		string Method { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable statusCode;
		[NullAllowed, Export ("statusCode", ArgumentSemantic.Strong)]
		string StatusCode { get; }

		// @property (nonatomic, strong) NSUrl * _Nonnull url;
		[Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; set; }

		// @property (nonatomic, strong) NSData * _Nullable requestBody;
		[NullAllowed, Export ("requestBody", ArgumentSemantic.Strong)]
		NSData RequestBody { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary<NSString *,NSString *> * _Nonnull requestHeaders;
		[Export ("requestHeaders", ArgumentSemantic.Strong)]
		NSMutableDictionary<NSString, NSString> RequestHeaders { get; set; }

		// @property (nonatomic, strong) NSData * _Nullable responseBody;
		[NullAllowed, Export ("responseBody", ArgumentSemantic.Strong)]
		NSData ResponseBody { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary<NSString *,NSString *> * _Nullable responseHeaders;
		[NullAllowed, Export ("responseHeaders", ArgumentSemantic.Strong)]
		NSMutableDictionary<NSString, NSString> ResponseHeaders { get; set; }

		// @property (readonly, nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull timestamp;
		[Export ("timestamp", ArgumentSemantic.Strong)]
		string Timestamp { get; }

		// @property (readonly, nonatomic, strong) NSError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Strong)]
		NSError Error { get; }
	}

	// @interface SHKNotificationEventEditor : NSObject
	[BaseType (typeof(NSObject))]
	interface SHKNotificationEventEditor
	{
		// @property NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property NSString * _Nonnull description;
		[Export ("description")]
		string DDescription { get; set; }

		// @property NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; set; }

		// @property NSString * _Nonnull timestamp;
		[Export ("timestamp")]
		string Timestamp { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title description:(NSString * _Nonnull)description identifier:(NSString * _Nonnull)identifier timestamp:(NSString * _Nonnull)timestamp;
		[Export ("initWithTitle:description:identifier:timestamp:")]
		NativeHandle Constructor (string title, string description, string identifier, string timestamp);
	}

	// @protocol SHKSessionAuthenticationProtocol <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface ISHKSessionAuthenticationProtocol {}

	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SHKSessionAuthenticationProtocol
	{
		// @required -(void)didReceiveChallenge:(NSUrlAuthenticationChallenge * _Nonnull)challenge completionHandler:(void (^ _Nonnull)(NSUrlSessionAuthChallengeDisposition, NSUrlCredential * _Nullable))completionHandler;
		[Abstract]
		[Export ("didReceiveChallenge:completionHandler:")]
		void CompletionHandler (NSUrlAuthenticationChallenge challenge, Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler);
	}

	// @interface SHKShadowInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKShadowInfo
	{
		// @property (readonly) CGSize offset;
		[Export ("offset")]
		CGSize Offset { get; }

		// @property (readonly) UIColor * _Nonnull color;
		[Export ("color")]
		UIColor Color { get; }

		// @property (readonly) CGFloat opacity;
		[Export ("opacity")]
		nfloat Opacity { get; }

		// @property (readonly) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; }

		// -(instancetype _Nonnull)initWithOffset:(CGSize)offset opacity:(CGFloat)opacity radius:(CGFloat)radius color:(UIColor * _Nullable)color;
		[Export ("initWithOffset:opacity:radius:color:")]
		NativeHandle Constructor (CGSize offset, nfloat opacity, nfloat radius, [NullAllowed] UIColor color);
	}

	// @interface SHKTheme : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKTheme
	{
		// @property (readwrite, nonatomic) NSString * _Nonnull fontFamilyMedium;
		[Export ("fontFamilyMedium")]
		string FontFamilyMedium { get; set; }

		// @property (readwrite, nonatomic) NSString * _Nonnull fontFamilyBold;
		[Export ("fontFamilyBold")]
		string FontFamilyBold { get; set; }

		// @property (readwrite, nonatomic) UIColor * _Nonnull background;
		[Export ("background", ArgumentSemantic.Assign)]
		UIColor Background { get; set; }

		// @property (readwrite, nonatomic) UIColor * _Nonnull secondaryBackground;
		[Export ("secondaryBackground", ArgumentSemantic.Assign)]
		UIColor SecondaryBackground { get; set; }

		// @property (readwrite, nonatomic) UIColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Assign)]
		UIColor TextColor { get; set; }

		// @property (readwrite, nonatomic) UIColor * _Nonnull secondaryTextColor;
		[Export ("secondaryTextColor", ArgumentSemantic.Assign)]
		UIColor SecondaryTextColor { get; set; }

		// @property (readwrite, nonatomic) UIColor * _Nonnull brandAccentColor;
		[Export ("brandAccentColor", ArgumentSemantic.Assign)]
		UIColor BrandAccentColor { get; set; }

		// @property (readwrite, nonatomic) UIColor * _Nonnull brandTextColor;
		[Export ("brandTextColor", ArgumentSemantic.Assign)]
		UIColor BrandTextColor { get; set; }

		// @property (readwrite, nonatomic) UIColor * _Nonnull outlineColor;
		[Export ("outlineColor", ArgumentSemantic.Assign)]
		UIColor OutlineColor { get; set; }

		// @property (readwrite, nonatomic) CGFloat borderRadius;
		[Export ("borderRadius")]
		nfloat BorderRadius { get; set; }

		// @property (readwrite, nonatomic) SHKShadowInfo * _Nonnull shadowInfo;
		[Export ("shadowInfo", ArgumentSemantic.Assign)]
		SHKShadowInfo ShadowInfo { get; set; }

		// -(instancetype _Nonnull)initWithFontFamilyMedium:(NSString * _Nullable)fontFamilyMedium fontFamilyBold:(NSString * _Nullable)fontFamilyBold background:(UIColor * _Nullable)background secondaryBackground:(UIColor * _Nullable)secondaryBackground textColor:(UIColor * _Nullable)textColor secondaryTextColor:(UIColor * _Nullable)secondaryTextColor brandAccentColor:(UIColor * _Nullable)brandAccentColor brandTextColor:(UIColor * _Nullable)brandTextColor borderRadius:(CGFloat)borderRadius outlineColor:(UIColor * _Nullable)outlineColor shadowInfo:(SHKShadowInfo * _Nullable)shadowInfo;
		[Export ("initWithFontFamilyMedium:fontFamilyBold:background:secondaryBackground:textColor:secondaryTextColor:brandAccentColor:brandTextColor:borderRadius:outlineColor:shadowInfo:")]
		NativeHandle Constructor ([NullAllowed] string fontFamilyMedium, [NullAllowed] string fontFamilyBold, [NullAllowed] UIColor background, [NullAllowed] UIColor secondaryBackground, [NullAllowed] UIColor textColor, [NullAllowed] UIColor secondaryTextColor, [NullAllowed] UIColor brandAccentColor, [NullAllowed] UIColor brandTextColor, nfloat borderRadius, [NullAllowed] UIColor outlineColor, [NullAllowed] SHKShadowInfo shadowInfo);

		// +(SHKTheme * _Nonnull)defaultTheme;
		[Static]
		[Export ("defaultTheme")]
		SHKTheme DefaultTheme ();
	}

	// @interface SHKShakeConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SHKShakeConfiguration
	{
		// @property (assign, nonatomic) BOOL isSensitiveDataRedactionEnabled;
		[Export ("isSensitiveDataRedactionEnabled")]
		bool IsSensitiveDataRedactionEnabled { get; set; }

		// @property (nonatomic) BOOL isFloatingReportButtonShown;
		[Export ("isFloatingReportButtonShown")]
		bool IsFloatingReportButtonShown { get; set; }

		// @property (nonatomic) BOOL isInvokedByShakeDeviceEvent;
		[Export ("isInvokedByShakeDeviceEvent")]
		bool IsInvokedByShakeDeviceEvent { get; set; }

		// @property (assign, nonatomic) float shakingThreshold;
		[Export ("shakingThreshold")]
		float ShakingThreshold { get; set; }

		// @property (nonatomic) BOOL isInvokedByScreenshot;
		[Export ("isInvokedByScreenshot")]
		bool IsInvokedByScreenshot { get; set; }

		// @property (nonatomic) BOOL isInvokedByRightEdgePan;
		[Export ("isInvokedByRightEdgePan")]
		bool IsInvokedByRightEdgePan { get; set; }

		// @property (nonatomic) BOOL isBlackBoxEnabled;
		[Export ("isBlackBoxEnabled")]
		bool IsBlackBoxEnabled { get; set; }

		// @property (nonatomic) BOOL isActivityHistoryEnabled;
		[Export ("isActivityHistoryEnabled")]
		bool IsActivityHistoryEnabled { get; set; }

		// @property (nonatomic) BOOL setShowIntroMessage;
		[Export ("setShowIntroMessage")]
		bool SetShowIntroMessage { get; set; }

		// @property (assign, nonatomic) BOOL isConsoleLogsEnabled;
		[Export ("isConsoleLogsEnabled")]
		bool IsConsoleLogsEnabled { get; set; }

		// @property (assign, nonatomic) BOOL isAutoVideoRecordingEnabled;
		[Export ("isAutoVideoRecordingEnabled")]
		bool IsAutoVideoRecordingEnabled { get; set; }

		// @property (nonatomic) BOOL isCrashReportingEnabled;
		[Export ("isCrashReportingEnabled")]
		bool IsCrashReportingEnabled { get; set; }

		// @property (assign, nonatomic) BOOL isAskForCrashDescriptionEnabled;
		[Export ("isAskForCrashDescriptionEnabled")]
		bool IsAskForCrashDescriptionEnabled { get; set; }

		// @property (assign, nonatomic) BOOL isScreenshotIncluded;
		[Export ("isScreenshotIncluded")]
		bool IsScreenshotIncluded { get; set; }

		// @property (assign, nonatomic) enum SHKShowOption defaultShowOption;
		[Export ("defaultShowOption", ArgumentSemantic.Assign)]
		SHKShowOption DefaultShowOption { get; set; }

		// @property (assign, nonatomic) BOOL isUserFeedbackEnabled;
		[Export ("isUserFeedbackEnabled")]
		bool IsUserFeedbackEnabled { get; set; }

		// @property (nonatomic, strong) SHKForm * form;
		[Export ("form", ArgumentSemantic.Strong)]
		SHKForm Form { get; set; }

		// @property (nonatomic, strong) SHKTheme * theme;
		[Export ("theme", ArgumentSemantic.Strong)]
		SHKTheme Theme { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable homeSubtitle;
		[NullAllowed, Export ("homeSubtitle", ArgumentSemantic.Strong)]
		string HomeSubtitle { get; set; }

		// @property (nonatomic, strong) NSArray<id<SHKHomeActionProtocol>> * homeActions;
		[Export ("homeActions", ArgumentSemantic.Strong)]
		ISHKHomeActionProtocol[] HomeActions { get; set; }

		// @property (nonatomic, strong) void (^ _Nullable)(void) shakeOpenListener;
		[NullAllowed, Export ("shakeOpenListener", ArgumentSemantic.Strong)]
		Action ShakeOpenListener { get; set; }

		// @property (nonatomic, strong) void (^ _Nullable)(void) shakeDismissListener;
		[NullAllowed, Export ("shakeDismissListener", ArgumentSemantic.Strong)]
		Action ShakeDismissListener { get; set; }

		// @property (nonatomic, strong) void (^ _Nullable)(NSString * _Nonnull, NSDictionary * _Nonnull) shakeSubmitListener;
		[NullAllowed, Export ("shakeSubmitListener", ArgumentSemantic.Strong)]
		Action<NSString, NSDictionary> ShakeSubmitListener { get; set; }

		// @property (nonatomic, strong) NSArray * _Nullable tags;
		[NullAllowed, Export ("tags", ArgumentSemantic.Strong)]
		NSObject[] Tags { get; set; }
	}

	// @interface SHKShakeFile : NSObject <NSCoding, NSSecureCoding>
	[BaseType (typeof(NSObject))]
	interface SHKShakeFile : INSCoding, INSSecureCoding
	{
		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSData * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		NSData Data { get; set; }

		// @property (nonatomic, strong) NSUrl * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; set; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name andData:(NSData * _Nonnull)data __attribute__((swift_name("init(name:data:)")));
		[Export ("initWithName:andData:")]
		NativeHandle Constructor (string name, NSData data);

		// -(instancetype _Nullable)initWithName:(NSString * _Nonnull)name andFileURL:(NSUrl * _Nonnull)url __attribute__((swift_name("init(name:fileUrl:)")));
		[Export ("initWithName:andFileURL:")]
		NativeHandle Constructor (string name, NSUrl url);

		// -(instancetype _Nullable)initWithFileURL:(NSUrl * _Nonnull)url __attribute__((swift_name("init(fileUrl:)")));
		[Export ("initWithFileURL:")]
		NativeHandle Constructor (NSUrl url);
	}

	// @interface Equatable (SHKShakeFile)
	[Category]
	[BaseType (typeof(SHKShakeFile))]
	interface SHKShakeFile_Equatable
	{
		// -(BOOL)fileIsEqual:(SHKShakeFile * _Nonnull)file;
		[Export ("fileIsEqual:")]
		bool FileIsEqual (SHKShakeFile file);
	}

	// @interface SHKShakeReportConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	interface SHKShakeReportConfiguration
	{
		// @property (assign, nonatomic) BOOL includesBlackBoxData;
		[Export ("includesBlackBoxData")]
		bool IncludesBlackBoxData { get; set; }

		// @property (assign, nonatomic) BOOL includesActivityHistoryData;
		[Export ("includesActivityHistoryData")]
		bool IncludesActivityHistoryData { get; set; }

		// @property (assign, nonatomic) BOOL includesScreenshotImage;
		[Export ("includesScreenshotImage")]
		bool IncludesScreenshotImage { get; set; }

		// @property (assign, nonatomic) BOOL includesVideo;
		[Export ("includesVideo")]
		bool IncludesVideo { get; set; }

		// @property (assign, nonatomic) BOOL showsToastMessageOnSend;
		[Export ("showsToastMessageOnSend")]
		bool ShowsToastMessageOnSend { get; set; }
	}

	// @interface SHKSocketService : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC5Shake16SHKSocketService")]
	[DisableDefaultCtor]
	interface SHKSocketService
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		NSObject Delegate { get; set; }

		// @property (nonatomic, strong) id _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithEndpointURL:(NSUrl * _Nonnull)endpointURL __attribute__((objc_designated_initializer));
		[Export ("initWithEndpointURL:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSUrl endpointURL);

		// -(void)userDidRegisterWithIdentifierWithIdentifier:(NSString * _Nonnull)identifier token:(NSString * _Nonnull)token;
		[Export ("userDidRegisterWithIdentifierWithIdentifier:token:")]
		void UserDidRegisterWithIdentifierWithIdentifier (string identifier, string token);

		// -(void)userDidUnregister;
		[Export ("userDidUnregister")]
		void UserDidUnregister ();
	}

	// [Static]
	// [Verify (ConstantsInterfaceAssociation)]
	// partial interface Constants
	// {
	// 	// extern double ShakeVersionNumber;
	// 	[Field ("ShakeVersionNumber", "__Internal")]
	// 	double ShakeVersionNumber { get; }

	// 	// extern const unsigned char[] ShakeVersionString;
	// 	[Field ("ShakeVersionString", "__Internal")]
	// 	byte[] ShakeVersionString { get; }
	// }

	// @interface SHKShake : NSObject
	[BaseType (typeof(NSObject))]
	interface SHKShake
	{
		// @property (readonly, class) NSBundle * _Nonnull bundle;
		[Static]
		[Export ("bundle")]
		NSBundle Bundle { get; }

		// @property (readonly, class) BOOL isStarted;
		[Static]
		[Export ("isStarted")]
		bool IsStarted { get; }

		// @property (readonly, class) SHKShakeConfiguration * _Nonnull configuration;
		[Static]
		[Export ("configuration")]
		SHKShakeConfiguration Configuration { get; }

		// +(void)startWithClientId:(NSString * _Nonnull)clientId clientSecret:(NSString * _Nonnull)clientSecret __attribute__((swift_name("start(clientId:clientSecret:)")));
		[Static]
		[Export ("startWithClientId:clientSecret:")]
		void StartWithClientId (string clientId, string clientSecret);

		// @property (nonatomic, class) NSArray<SHKShakeFile *> * _Nonnull (^ _Nullable)(void) onPrepareReportData;
		[Static]
		[NullAllowed, Export ("onPrepareReportData", ArgumentSemantic.Assign)]
		Func<NSArray<SHKShakeFile>> OnPrepareReportData { get; set; }

		// +(void)show;
		[Static]
		[Export ("show")]
		void Show ();

		// +(void)show:(SHKShowOption)option;
		[Static]
		[Export ("show:")]
		void Show (SHKShowOption option);

		// +(void)silentReportWithDescription:(NSString * _Nullable)description fileAttachBlock:(NSArray<SHKShakeFile *> * _Nonnull (^ _Nonnull)(void))fileAttachBlock reportConfiguration:(SHKShakeReportConfiguration * _Nonnull)reportConfiguration __attribute__((swift_name("silentReport(description:fileAttachBlock:reportConfiguration:)")));
		[Static]
		[Export ("silentReportWithDescription:fileAttachBlock:reportConfiguration:")]
		void SilentReportWithDescription ([NullAllowed] string description, Func<NSArray<SHKShakeFile>> fileAttachBlock, SHKShakeReportConfiguration reportConfiguration);

		// @property (class) SHKNotificationEventEditor * _Nullable (^ _Nullable)(SHKNotificationEventEditor * _Nonnull) notificationEventsFilter;
		[Static]
		[NullAllowed, Export ("notificationEventsFilter", ArgumentSemantic.Assign)]
		Func<SHKNotificationEventEditor, SHKNotificationEventEditor> NotificationEventsFilter { get; set; }

		// +(void)handleNotificationWithNotificationTitle:(NSString * _Nonnull)notificationTitle notificationDescription:(NSString * _Nonnull)notificationDescription;
		[Static]
		[Export ("handleNotificationWithNotificationTitle:notificationDescription:")]
		void HandleNotificationWithNotificationTitle (string notificationTitle, string notificationDescription);

		// @property (class) void (^ _Nullable)(NSUInteger) unreadMessagesListener;
		[Static]
		[NullAllowed, Export ("unreadMessagesListener", ArgumentSemantic.Assign)]
		Action<nuint> UnreadMessagesListener { get; set; }

		// +(void)logWithLevel:(LogLevel)level message:(NSString * _Nonnull)message __attribute__((swift_name("log(_:_:)")));
		[Static]
		[Export ("logWithLevel:message:")]
		void LogWithLevel (LogLevel level, string message);

		// +(void)logWithMessage:(NSString * _Nonnull)message __attribute__((swift_name("log(_:)")));
		[Static]
		[Export ("logWithMessage:")]
		void LogWithMessage (string message);

		// +(void)addPrivateView:(id _Nullable)view;
		[Static]
		[Export ("addPrivateView:")]
		void AddPrivateView ([NullAllowed] NSObject view);

		// +(void)removePrivateView:(id _Nullable)view;
		[Static]
		[Export ("removePrivateView:")]
		void RemovePrivateView ([NullAllowed] NSObject view);

		// +(void)addPrivateViewController:(id _Nullable)viewController;
		[Static]
		[Export ("addPrivateViewController:")]
		void AddPrivateViewController ([NullAllowed] NSObject viewController);

		// +(void)removePrivateViewController:(id _Nullable)viewController;
		[Static]
		[Export ("removePrivateViewController:")]
		void RemovePrivateViewController ([NullAllowed] NSObject viewController);

		// +(void)clearPrivateViews;
		[Static]
		[Export ("clearPrivateViews")]
		void ClearPrivateViews ();

		// +(void)registerUserWithUserId:(NSString * _Nonnull)userId __attribute__((swift_name("registerUser(userId:)")));
		[Static]
		[Export ("registerUserWithUserId:")]
		void RegisterUserWithUserId (string userId);

		// +(void)updateUserMetadata:(NSDictionary<NSString *,id> * _Nonnull)metadata __attribute__((swift_name("updateUserMetadata(_:)")));
		[Static]
		[Export ("updateUserMetadata:")]
		void UpdateUserMetadata (NSDictionary<NSString, NSObject> metadata);

		// +(void)updateUserId:(NSString * _Nonnull)userId __attribute__((swift_name("updateUserId(_:)")));
		[Static]
		[Export ("updateUserId:")]
		void UpdateUserId (string userId);

		// +(void)unregisterUser;
		[Static]
		[Export ("unregisterUser")]
		void UnregisterUser ();

		// +(void)registerSessionConfiguration:(NSUrlSessionConfiguration * _Nonnull)configuration __attribute__((swift_name("registerSessionConfiguration(_:)")));
		[Static]
		[Export ("registerSessionConfiguration:")]
		void RegisterSessionConfiguration (NSUrlSessionConfiguration configuration);

		// +(void)registerAuthDelegate:(id<SHKSessionAuthenticationProtocol> _Nonnull)authDelegate __attribute__((swift_name("registerAuthDelegate(_:)")));
		[Static]
		[Export ("registerAuthDelegate:")]
		void RegisterAuthDelegate (ISHKSessionAuthenticationProtocol authDelegate);

		// @property (class) SHKNetworkRequestEditor * _Nullable (^ _Nullable)(SHKNetworkRequestEditor * _Nonnull) networkRequestsFilter;
		[Static]
		[NullAllowed, Export ("networkRequestsFilter", ArgumentSemantic.Assign)]
		Func<SHKNetworkRequestEditor, SHKNetworkRequestEditor> NetworkRequestsFilter { get; set; }

		// +(void)insertNetworkRequest:(SHKNetworkRequestEditor * _Nonnull)networkRequest __attribute__((swift_name("insertNetworkRequest(_:)")));
		[Static]
		[Export ("insertNetworkRequest:")]
		void InsertNetworkRequest (SHKNetworkRequestEditor networkRequest);

		// +(void)setMetadataWithKey:(NSString * _Nonnull)key value:(NSString * _Nullable)value __attribute__((swift_name("setMetadata(key:value:)")));
		[Static]
		[Export ("setMetadataWithKey:value:")]
		void SetMetadataWithKey (string key, [NullAllowed] string value);

		// +(void)clearMetadata;
		[Static]
		[Export ("clearMetadata")]
		void ClearMetadata ();

		// +(void)handleError:(NSError * _Nonnull)error clusterID:(NSString * _Nonnull)clusterID;
		[Static]
		[Export ("handleError:clusterID:")]
		void HandleError (NSError error, string clusterID);

		// +(void)reportNotificationCenter:(UNUserNotificationCenter * _Nonnull)center willPresentNotification:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler;
		[Static]
		[Export ("reportNotificationCenter:willPresentNotification:withCompletionHandler:")]
		void ReportNotificationCenter (UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

		// +(void)reportNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler;
		[Static]
		[Export ("reportNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
		void ReportNotificationCenter (UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);

		// +(BOOL)isShakeNotification:(UNNotification * _Nonnull)notification;
		[Static]
		[Export ("isShakeNotification:")]
		bool IsShakeNotification (UNNotification notification);

		// +(void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData * _Nonnull)deviceToken;
		[Static]
		[Export ("didRegisterForRemoteNotificationsWithDeviceToken:")]
		void DidRegisterForRemoteNotificationsWithDeviceToken (NSData deviceToken);
	}
}
