//
//  SHKEmail.h
//  Shake
//
//  Created by David Halapir on 01.03.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "SHKFormItemProtocol.h"

NS_ASSUME_NONNULL_BEGIN

@interface SHKEmail : NSObject<SHKFormItemProtocol>

@property (readonly, strong) NSString * label;
@property (readonly, strong) NSString * key;

@property (readonly, strong, nullable) NSString * initialValue;

@property (readonly) BOOL required;

- (instancetype)initWithKey:(NSString *)key label:(NSString *)label required:(BOOL)required initialValue:(nullable NSString *)initialValue;

- (instancetype)init NS_UNAVAILABLE;

@end

NS_ASSUME_NONNULL_END
