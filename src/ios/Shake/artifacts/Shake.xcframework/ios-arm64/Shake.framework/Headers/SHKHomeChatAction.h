//
//  SHKHomeChatAction.h
//  Shake
//
//  Created by David Halapir on 20.04.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "SHKHomeActionProtocol.h"

NS_ASSUME_NONNULL_BEGIN

@interface SHKHomeChatAction : NSObject <SHKHomeActionProtocol>

- (instancetype)initWithTitle:(nullable NSString *)title subtitle:(nullable NSString *)subtitle icon:(nullable UIImage *)icon;

- (instancetype)init;

@end

NS_ASSUME_NONNULL_END
