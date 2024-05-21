//
//  SHKPickerItem.h
//  Shake
//
//  Created by David Halapir on 01.03.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

NS_ASSUME_NONNULL_BEGIN

@interface SHKPickerItem : NSObject

@property (readonly, strong) NSString *key;
@property (readonly, strong) NSString *text;

@property (readonly, strong) UIImage *icon;

@property (readonly, strong, nullable) NSString *tag;

- (instancetype)initWithKey:(NSString *)key text:(NSString *)text icon:(nullable UIImage *)icon tag:(nullable NSString *)tag;

- (instancetype)init NS_UNAVAILABLE;

@end

NS_ASSUME_NONNULL_END
