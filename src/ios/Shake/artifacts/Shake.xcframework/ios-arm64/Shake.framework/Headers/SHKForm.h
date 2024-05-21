//
//  SHKForm.h
//  Shake
//
//  Created by David Halapir on 01.03.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "SHKPicker.h"
#import "SHKPickerItem.h"
#import "SHKTitle.h"
#import "SHKAttachments.h"
#import "SHKInspectButton.h"
#import "SHKEmail.h"
#import "SHKFormItemProtocol.h"
#import "SHKTextInput.h"

NS_ASSUME_NONNULL_BEGIN

@interface SHKForm : NSObject

@property (readonly, nonnull) NSArray<id<SHKFormItemProtocol>> *items;

- (instancetype)initWithItems:(NSArray<id<SHKFormItemProtocol>> *)items;

- (instancetype)init NS_UNAVAILABLE;

+ (SHKForm *)defaultForm;

@end

NS_ASSUME_NONNULL_END
