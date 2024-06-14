//
// Created by Manuel Vrhovac on 25/05/2020.
// Copyright © 2020 Shake Technologies, Inc. All rights reserved.
//

/**
 Used to configure an individual report before submitting it, ex. leave out some data or display a toast on success
 */
NS_SWIFT_NAME(ShakeReportConfiguration)
@interface SHKShakeReportConfiguration : NSObject

/**
 Determines if the black box data is included in the report.
 If the feature is enabled, the default value is true.
 */
@property (nonatomic, assign) BOOL includesBlackBoxData;
/**
 Determines if the activity history is included in the report.
 If the feature is enabled, the default value is true.
 */
@property (nonatomic, assign) BOOL includesActivityHistoryData;
/**
Determines if the activity history is included in the report.
Default value is true.
 */
@property (nonatomic, assign) BOOL includesScreenshotImage;
/**
Determines if the automatic video recording is attached to the report.
Default value is true.
 */
@property (nonatomic, assign) BOOL includesVideo;
@property (nonatomic, assign) BOOL showsToastMessageOnSend;

@end
