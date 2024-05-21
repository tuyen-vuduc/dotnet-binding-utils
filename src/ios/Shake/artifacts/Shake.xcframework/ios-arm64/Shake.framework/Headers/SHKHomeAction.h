//
//  SHKHomeAction.h
//  Shake
//
//  Created by David Halapir on 20.04.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "SHKHomeActionProtocol.h"

NS_ASSUME_NONNULL_BEGIN

@interface SHKHomeAction : NSObject <SHKHomeActionProtocol>

- (instancetype)initWithTitle:(NSString *)title subtitle:(nullable NSString *)subtitle icon:(nullable UIImage *)icon handler:(void (^_Nullable)(void))handler;

- (instancetype)init NS_UNAVAILABLE;

+ (NSArray<id<SHKHomeActionProtocol>> *)defaultHomeActions;

@end

NS_ASSUME_NONNULL_END
