//
//  SHKShadowInfo.h
//  Shake
//
//  Created by David Halapir on 21.03.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

NS_ASSUME_NONNULL_BEGIN

@interface SHKShadowInfo : NSObject

@property (readonly) CGSize offset;
@property (readonly) UIColor *color;
@property (readonly) CGFloat opacity;
@property (readonly) CGFloat radius;

- (instancetype)initWithOffset:(CGSize)offset opacity:(CGFloat)opacity radius:(CGFloat)radius color:(UIColor * _Nullable)color;

- (instancetype)init
__attribute__((unavailable("Use provided initializer")));

@end

NS_ASSUME_NONNULL_END
