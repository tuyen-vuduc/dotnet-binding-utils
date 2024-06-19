//
//  Copyright © 2020 Shake Technologies, Inc. All rights reserved.
//  https://www.shakebugs.com
//

#import <Foundation/Foundation.h>
#import "SHKShakeFile.h"
#import "SHKShakeConfiguration.h"
#import "SHKShakeReportConfiguration.h"
#import "SHKNetworkRequestEditor.h"
#import "SHKNotificationEventEditor.h"
#import "SHKNetworkRequestEditor.h"
#import "SHKSessionAuthenticationProtocol.h"
#import "SHKConstants.h"
#import <UserNotifications/UserNotifications.h>

//! Project version number for Shake.
FOUNDATION_EXPORT double ShakeVersionNumber;

//! Project version string for Shake.
FOUNDATION_EXPORT const unsigned char ShakeVersionString[];

NS_SWIFT_NAME(Shake)
@interface SHKShake : NSObject

typedef NS_ENUM(NSUInteger, LogLevel) {
    LogLevelVerbose,
    LogLevelDebug,
    LogLevelInfo,
    LogLevelWarn,
    LogLevelError
};

///Shake bundle
@property (nonnull, class, readonly) NSBundle *bundle;

///Use this property to check if Shake has been started
@property (class, readonly) BOOL isStarted;

// MARK: - Configuration

/**
 Shake configuration object.
 */
@property (nonnull, class, readonly) SHKShakeConfiguration* configuration;

/**
 Starts the Shake with the provided api key. Also start the tracking and Shake features specified in the "configuration" object.
 */
+ (void)startWithApiKey:(nonnull NSString *)apiKey
NS_SWIFT_NAME(start(apiKey:));


/**
 Assign a callback function to this property to lazily attach additional files to each Shake report. This enables you to construct various
 files at the time of the report, keeping the data most relevant.
 */
@property (nullable, class, nonatomic) NSArray<SHKShakeFile *> *_Nonnull (^onPrepareReportData)(void);

// MARK: - Manual invocation

typedef NS_ENUM(NSUInteger, SHKShowOption) {
    SHKShowOptionHome = 1,
    SHKShowOptionNew,
    SHKShowOptionNewChat
};

/**
 Triggers the display of Shake UI.
 */
+ (void)show;

/**
 Triggers the display of Shake UI with the provided option.
 Default option is SHKShowOptionNew.
 */
+ (void)show:(SHKShowOption)option;

// MARK: Silent Report

/**
 Constructs a silent report  and sends it silently without presenting any kind of UI to the user of your app.
 */
+ (void)silentReportWithDescription:(nullable NSString *)description fileAttachBlock:(NSArray<SHKShakeFile *> *_Nonnull (^ __nonnull)(void))fileAttachBlock reportConfiguration:(nonnull SHKShakeReportConfiguration *)reportConfiguration
NS_SWIFT_NAME(silentReport(description:fileAttachBlock:reportConfiguration:));


// MARK: Notification intercepting

/**
 Assign a filter function to this property and Shake will call the function prior to inserting the notification record in database. This gives you a chance to remove or edit some specific
 notifications.
 */
@property (nullable, class) SHKNotificationEventEditor * _Nullable (^notificationEventsFilter)(SHKNotificationEventEditor * _Nonnull);

/**
 Manually register the received notification with Shake.
 */
+ (void)handleNotificationWithNotificationTitle:(NSString* __nonnull)notificationTitle notificationDescription:(NSString * __nonnull)notificationDescription;

// MARK: Unread messages

/**
 Unread messages listener. When set, it reports current number of unread messages, and will call the completion again when
 the number of unread messages changes.
 */
@property (nullable, class) void (^unreadMessagesListener)(NSUInteger);

// MARK: Logging

/**
 Adds a custom log entry to Activity History
 */
+ (void)logWithLevel:(LogLevel)level message:(NSString * __nonnull)message
NS_SWIFT_NAME(log(_:_:));

/** Adds a custom log entry to Activity History with debug level
 */
+ (void)logWithMessage:(NSString * __nonnull)message
NS_SWIFT_NAME(log(_:));

// MARK: Privacy

/// Adds private UIView/UIViewController  entry to Activity History
+ (void)addPrivateView:(nullable id)view;
+ (void)removePrivateView:(nullable id)view;

+ (void)addPrivateViewController:(nullable id)viewController;
+ (void)removePrivateViewController:(nullable id)viewController;

+ (void)clearPrivateViews;

// MARK: - User

/**
 Registers the user of your application with Shake.
 Ideally, passed in userId should uniquely identify the user of your application in your database or system.
 */
+ (void)registerUserWithUserId:(nonnull NSString *)userId NS_SWIFT_NAME(registerUser(userId:));

/**
 Update the metadata of previously registered user. Metadata updates are merged (updated key values will overwrite the existing ones) so this method can safely
 be called with new key value pairs in separate contexts of your application.
 This method does nothing if there is no registered user.
 */
+ (void)updateUserMetadata:(nonnull NSDictionary<NSString *, id> *)metadata NS_SWIFT_NAME(updateUserMetadata(_:));

/**
 This method updates the previously registered user with the new userId. In most cases, this is never used but can be usefull if for example your
 internal user identifiers are user emails, which can be changed from the settings screen of your application.
 */
+ (void)updateUserId:(nonnull NSString *)userId NS_SWIFT_NAME(updateUserId(_:));

/**
 Unregisters the previously registered user from this device.
 */
+ (void)unregisterUser;


//MARK: - Network Request Reporting

/**
 Pass your NSURLSessionConfiguration to this method before  initializing your NSURLSession with the configuration.
 Later, use the same configuration to initialize the NSURLSession.
 */
+ (void)registerSessionConfiguration:(nonnull NSURLSessionConfiguration *)configuration
NS_SWIFT_NAME(registerSessionConfiguration(_:));

/**
 Shake assumes your  NSURLSession is already initialized with the configuration returned by calling registerSessionConfiguration method.
 Use this method if your app using any kind of authentication challenges with the server.
 Shake will pass down authentication challenges to this delegate.
 Auth delegate is not retained.
 */
+ (void)registerAuthDelegate:(nonnull id<SHKSessionAuthenticationProtocol>)authDelegate
NS_SWIFT_NAME(registerAuthDelegate(_:));

/**
 A network request filter that is called prior to registering request with Shake. Use this this to target and  remove/edit specific requests.
 */
@property (nullable, class) SHKNetworkRequestEditor * _Nullable (^networkRequestsFilter)(SHKNetworkRequestEditor * _Nonnull);

/**
 Manually register the network request with Shake. Use this when the standard setup is not suitable, or when using the
 custom NSURLProtocol in you application.
 */
+ (void)insertNetworkRequest:(nonnull SHKNetworkRequestEditor *)networkRequest
NS_SWIFT_NAME(insertNetworkRequest(_:));

// MARK: - Metadata

+ (void)setMetadataWithKey:(nonnull NSString *)key value:(nullable NSString *)value
NS_SWIFT_NAME(setMetadata(key:value:));

/**
 Clears all previously set global metadata.
 */
+ (void)clearMetadata;

// MARK: - Caught Errors

/**
 Silently reports a non fatal error. Cluster ID affects dashboard grouping.
 */
+ (void)handleError:(nonnull NSError *)error clusterID:(nonnull NSString *)clusterID;


// MARK: User notifications

NS_ASSUME_NONNULL_BEGIN

/**
 Call this method from the native delegate method when you want Shake SDK to handle the notification presentation.
 Shake will process only notifications that were scheduled by Shake, and will call completion with default options  if you accidentally
 call this method with your own notification.
 */
+ (void)reportNotificationCenter:(UNUserNotificationCenter *)center willPresentNotification:(UNNotification *)notification withCompletionHandler:(void (^)(UNNotificationPresentationOptions options))completionHandler;

/**
 Call this method from the native delegate method when you want Shake SDK to handle the notification tap or action.
 If you call this method with non-Shake notification, this methods returns immediately and calls completion handler.
 */
+ (void)reportNotificationCenter:(UNUserNotificationCenter *)center didReceiveNotificationResponse:(UNNotificationResponse *)response withCompletionHandler:(void(^)(void))completionHandler;

/**
 Returns true if the passed in notification originated from Shake SDK or server.
 */
+ (BOOL)isShakeNotification:(UNNotification *)notification;

/**
 Report the device APNS token to Shake. This enables Shake originated push notifications.
 Although tokens rarely change, its recommended to call `registerForRemoteNotifications` method
 even if already registered to ensure that up to date token is always forwarded to Shake.
 */
+ (void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)deviceToken;

NS_ASSUME_NONNULL_END

@end
