//
// Created by Manuel Vrhovac on 23/05/2020.
// Copyright © 2020 Shake Technologies, Inc. All rights reserved.
//

#import "SHKForm.h"
#import "SHKTheme.h"

#import "SHKHomeActions.h"

typedef NS_ENUM(NSUInteger, SHKShowOption);

/// Used to enable or disable specific features or invocation methods
NS_SWIFT_NAME(ShakeConfiguration)
@interface SHKShakeConfiguration : NSObject

/// Automatic network request redaction based on keywords (regular expressions)
@property (nonatomic, assign) BOOL isSensitiveDataRedactionEnabled;

/// Creates and displays a UI button that invokes Shake on tap. Button floats above all elements.
@property (nonatomic) BOOL isFloatingReportButtonShown;

/// Shake will be automatically invoked when user shakes their device
@property (nonatomic) BOOL isInvokedByShakeDeviceEvent;

/// You can set how sensitive device should be to the shaking
@property (nonatomic, assign) float shakingThreshold;

/// Shake will be automatically invoked when user takes a screenshot
@property (nonatomic) BOOL isInvokedByScreenshot;

/// Shake will be automatically invoked when user swipes in from the right edge of the screen
@property (nonatomic) BOOL isInvokedByRightEdgePan;

/// Shake will record certain events on device like CPU, RAM, Orientation to help you easily spot correlations
@property (nonatomic) BOOL isBlackBoxEnabled;

/// Shake will record certain events on device like User tap events, network events, view controllers and app state changes.
@property (nonatomic) BOOL isActivityHistoryEnabled;

///If enabled, a one-off intro message will be shown to a user as soon as they open up your app for the first time.
@property (nonatomic) BOOL setShowIntroMessage;

/// to capture console log or not
@property (nonatomic, assign) BOOL isConsoleLogsEnabled;

// Can Shake capture apps screen and audio and record into movie file
@property (nonatomic, assign) BOOL isAutoVideoRecordingEnabled;

/// Shake will track crash events
@property (nonatomic) BOOL isCrashReportingEnabled;

/// It will gives a chance to user to describe the crash
@property (nonatomic, assign) BOOL isAskForCrashDescriptionEnabled;

/**
 Setting this flag to "false" disables automatic screenshot when invoking Shake.
 Default value is "true".
 */
@property (nonatomic, assign) BOOL isScreenshotIncluded;

/// Pick the default Shake show option (new or home) upon invocation
@property (nonatomic, assign) enum SHKShowOption defaultShowOption;

/**
If disabled, your app users won't be able to invoke Shake and generate reports.
 Default is true.
 */
@property (nonatomic, assign) BOOL isUserFeedbackEnabled;

/**
Use this property to customize your form items.
 */
@property (nonatomic, strong) SHKForm* form;

/**
Use this property to customize the look of the Shake user interface and match it with your product.
 */
@property (nonatomic, strong) SHKTheme* theme;

/**
Change the subtitle text displayed on the home screen.
 */
@property (nonatomic, strong, nullable) NSString* homeSubtitle;

/**
Use this property to customize action items on the Shake home screen.
 */
@property (nonatomic, strong) NSArray<id<SHKHomeActionProtocol>> *homeActions;

/**
 Shake open listener. When set, it reports an event when Shake screen is opened.
 */
@property (nonatomic, strong, nullable) void (^shakeOpenListener)(void);

/**
 Shake dismiss listener. When set, it reports an event when Shake screen is dismissed.
 */
@property (nonatomic, strong, nullable) void (^shakeDismissListener)(void);

/**
 Shake submit listener. When set, it reports an event when Submit button is pressed on Shake new ticket screen..
 */
@property (nonatomic, strong, nullable) void (^shakeSubmitListener)(NSString*_Nonnull, NSDictionary*_Nonnull);

/**
Use this property to set custom tags to the tickets.
 */
@property (nonatomic, strong, nullable) NSArray* tags;

- (instancetype)init
__attribute__((unavailable("Access 'Shake.configuration' directly instead.")));

@end
