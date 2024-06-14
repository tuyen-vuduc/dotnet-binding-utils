//
//  SHKPicker.h
//  Shake
//
//  Created by David Halapir on 01.03.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "SHKPickerItem.h"
#import "SHKFormItemProtocol.h"

NS_ASSUME_NONNULL_BEGIN

@interface SHKPicker : NSObject<SHKFormItemProtocol>

@property (readonly, strong) NSString *label;
@property (readonly, strong) NSString *key;
@property (readonly, strong) NSArray<SHKPickerItem *> * items;

- (instancetype)initWithKey:(NSString *)key label:(NSString *)label items:(NSArray<SHKPickerItem *> *)items;

- (instancetype)init NS_UNAVAILABLE;

@end

NS_ASSUME_NONNULL_END
