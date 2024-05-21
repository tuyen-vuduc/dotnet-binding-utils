//
//  SHKTheme.h
//  Shake
//
//  Created by David Halapir on 20.03.2023..
//  Copyright © 2023 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "SHKShadowInfo.h"

NS_ASSUME_NONNULL_BEGIN

@interface SHKTheme : NSObject

@property (nonatomic, readwrite, nonnull) NSString *fontFamilyMedium;
@property (nonatomic, readwrite, nonnull) NSString *fontFamilyBold;

@property (nonatomic, readwrite, nonnull) UIColor *background;
@property (nonatomic, readwrite, nonnull) UIColor *secondaryBackground;

@property (nonatomic, readwrite, nonnull) UIColor *textColor;
@property (nonatomic, readwrite, nonnull) UIColor *secondaryTextColor;

@property (nonatomic, readwrite, nonnull) UIColor *brandAccentColor;
@property (nonatomic, readwrite, nonnull) UIColor *brandTextColor;

@property (nonatomic, readwrite, nonnull) UIColor *outlineColor;

@property (nonatomic, readwrite) CGFloat borderRadius;

@property (nonatomic, readwrite, nonnull) SHKShadowInfo *shadowInfo;

- (instancetype)initWithFontFamilyMedium:(NSString * _Nullable)fontFamilyMedium
                          fontFamilyBold:(NSString * _Nullable)fontFamilyBold
                              background:(UIColor * _Nullable)background
                     secondaryBackground:(UIColor * _Nullable)secondaryBackground
                               textColor:(UIColor * _Nullable)textColor
                      secondaryTextColor:(UIColor * _Nullable)secondaryTextColor
                        brandAccentColor:(UIColor * _Nullable)brandAccentColor
                    brandTextColor:(UIColor * _Nullable)brandTextColor
                            borderRadius:(CGFloat)borderRadius
                            outlineColor:(UIColor * _Nullable)outlineColor
                              shadowInfo:(SHKShadowInfo * _Nullable)shadowInfo;

- (instancetype)init
__attribute__((unavailable("Use provided initializer")));

+ (SHKTheme *)defaultTheme;

@end

NS_ASSUME_NONNULL_END
