//
//  ViewController.m
//  TStripeQs
//
//  Created by Tuyen Vu on 6/23/24.
//

#import "ViewController.h"
@import TVStripePaymentSheet;

@interface ViewController ()

@property UIButton* payButton;
@property NSString* paymentIntentClientSecret;

@end

@implementation ViewController {
    NSString* backendURL;
}

- (void)viewDidLoad {
    [super viewDidLoad];
    
    // Do any additional setup after loading the view.
    backendURL = @"https://5d3c-222-254-47-134.ngrok-free.app"; //@"http://127.0.0.1:4242";
    
    self.view.backgroundColor = UIColor.systemBackgroundColor;
    
    _payButton = [UIButton buttonWithType: UIButtonTypeCustom];
    [_payButton setTitle:@"Pay now" forState:UIControlStateNormal];
    _payButton.backgroundColor = UIColor.systemIndigoColor;
    _payButton.layer.cornerRadius = 5;
    _payButton.contentEdgeInsets = UIEdgeInsetsMake(12, 12, 12, 12);
    [_payButton addTarget:self action:@selector(pay:) forControlEvents:UIControlEventTouchUpInside];
    _payButton.translatesAutoresizingMaskIntoConstraints = false;
    [_payButton setEnabled: false];
    
    [self.view addSubview:self.payButton];
    
    [NSLayoutConstraint activateConstraints:@[
        [self.payButton.leadingAnchor constraintEqualToAnchor:self.view.safeAreaLayoutGuide.leadingAnchor constant:16],
        [self.payButton.trailingAnchor constraintEqualToAnchor:self.view.safeAreaLayoutGuide.trailingAnchor constant:-16],
        [self.payButton.bottomAnchor constraintEqualToAnchor:self.view.safeAreaLayoutGuide.bottomAnchor constant:-16]
    ]];
    
    [self fetchPaymentIntent];
}

- (void) pay: (UIButton*) sender {
    if (!self.paymentIntentClientSecret) return;
    
    TSPSConfiguration* configuration = [TSPSConfiguration new];
    configuration.merchantDisplayName = @"Example, Inc.";
    
    TSPSPaymentSheet* paymentSheet = [[TSPSPaymentSheet alloc] initWithPaymentIntentClientSecret:self.paymentIntentClientSecret configuration:configuration];
    
    [paymentSheet presentFrom:self completion:^(enum TSPSPaymentSheetResult result, NSError * _Nullable error) {
            switch (result) {
                case TSPSPaymentSheetResultCompleted:
                    [self displayAlert:@"Payment completed" message:nil];
                    break;
                case TSPSPaymentSheetResultCanceled:
                    NSLog(@"Payment cancelled");
                    
                default:
                    if (!error) {
                        [self displayAlert:@"Payment ERR" message:error.localizedDescription];
                    }
            }
    }];
}

- (void) fetchPaymentIntent {
    NSString* url = [backendURL stringByAppendingString:@"/create-payment-intent"];
    NSDictionary* shoppingCartIntent = @{
        @"items": @[
            @{
                @"id": @"xl-shirt",
                @"amount": @"100"
            }
        ]
    };
    NSMutableURLRequest* request = [NSMutableURLRequest requestWithURL:[NSURL URLWithString:url]];
    request.HTTPMethod = @"POST";
    [request setValue:@"application/json" forHTTPHeaderField:@"Content-Type"];
    request.HTTPBody = [NSJSONSerialization dataWithJSONObject:shoppingCartIntent
                                                       options:NSJSONWritingPrettyPrinted
                                                         error:nil];
    
    NSString* xjson = [[NSString alloc] initWithData:request.HTTPBody encoding:NSUTF8StringEncoding];
    
    __weak ViewController* weakSelf = self;
    NSURLSessionDataTask* task = [NSURLSession.sharedSession dataTaskWithRequest:request
                                                               completionHandler:^(NSData * _Nullable data, NSURLResponse * _Nullable response, NSError * _Nullable error) {
        if (!weakSelf || !data) {
            [weakSelf showAPIError];
            return;
        }
        
        NSHTTPURLResponse* httpResponse = (NSHTTPURLResponse*)response;
        
        if (!httpResponse) {
            [weakSelf showAPIError];
            return;
        }
        
        if (httpResponse.statusCode != 200) {
            [weakSelf showAPIError];
            return;
        }
        
        NSDictionary<NSString*, NSObject*>* json = [NSJSONSerialization JSONObjectWithData:data options:NSJSONReadingJSON5Allowed error:nil];
        NSString* clientSecret = (NSString*)[json objectForKey:@"clientSecret"];
        
        if (!clientSecret) {
            [weakSelf showAPIError];
            return;
        }
        
        weakSelf.paymentIntentClientSecret = clientSecret;
        NSLog(@"Created PaymentIntent");
        
        dispatch_async(dispatch_get_main_queue(), ^{
            [self.payButton setEnabled:true];
        });
    }];
    
    [task resume];
}

- (void) showAPIError {
    [self displayAlert:@"Error calling API" message:@"Failed to decode response from server."];
}

- (void) displayAlert: (NSString*) title message: (nullable NSString*) message {
    dispatch_async(dispatch_get_main_queue(), ^{
        UIAlertController* alert = [UIAlertController alertControllerWithTitle:title
                                                                      message:message
                                                               preferredStyle:UIAlertControllerStyleAlert];
        UIAlertAction* okAction = [UIAlertAction actionWithTitle:@"OK" style:UIAlertActionStyleDefault handler:nil];
        [alert addAction:okAction];
        
        [self presentViewController:alert animated:true completion:nil];
    });
}

@end
