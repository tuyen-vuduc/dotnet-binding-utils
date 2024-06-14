//
//  SHKSessionAuthenticationProtocol.h
//  Shake
//
//  Created by David Halapir on 18.03.2021..
//  Copyright © 2021 DECODE HQ Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

/**
 Advanced Shake users can implement this protocol, and register the conforming class with Shake to respond
 to authentication challenges.
 The conforming class has a responsibility to call the passed in completion handler with the appropriate value.
 Use the passed challenge protectionSpace property values  to determine the appropriate handling.
 Conforming class is responsible for calling the completion handler with the appriopriate value, failure to
 call the completion handler will result in failed requests.
 */
@protocol SHKSessionAuthenticationProtocol <NSObject>

- (void)didReceiveChallenge:(NSURLAuthenticationChallenge *)challenge completionHandler:(void (^)(NSURLSessionAuthChallengeDisposition, NSURLCredential * _Nullable))completionHandler;

@end

NS_ASSUME_NONNULL_END
