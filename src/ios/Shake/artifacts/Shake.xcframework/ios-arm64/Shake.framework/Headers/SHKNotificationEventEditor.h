//
//  SHKNotificationEventEditor.h
//  Shake
//
//  Created by Vedran Ozir on 03/11/2020.
//  Copyright © 2020 Shake Technologies, Inc. All rights reserved. 
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

NS_SWIFT_NAME(NotificationEventEditor)
@interface SHKNotificationEventEditor : NSObject

@property (nonnull) NSString *title;
@property (nonnull) NSString *description;
@property (nonnull) NSString *identifier;
@property (nonnull) NSString *timestamp;

-(instancetype)initWithTitle:(nonnull NSString *)title description:(nonnull NSString *)description identifier:(NSString *)identifier timestamp:(NSString *)timestamp;

@end

NS_ASSUME_NONNULL_END
