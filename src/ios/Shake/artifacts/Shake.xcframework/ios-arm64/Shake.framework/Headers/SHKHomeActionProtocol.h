//
//  SHKHomeActionProtocol.h
//  Shake
//
//  Created by David Halapir on 20.04.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@protocol SHKHomeActionProtocol <NSObject>

@property(nonatomic, strong, nonnull) UIImage *icon;

@property(nonatomic, strong, nonnull) NSString *title;

@property(nonatomic, strong, nullable) NSString *subtitle;

@property (nonatomic, copy, nullable) void (^handler)(void);

@end

NS_ASSUME_NONNULL_END
