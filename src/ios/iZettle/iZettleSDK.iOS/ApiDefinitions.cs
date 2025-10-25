using Foundation;
using UIKit;
using ObjCRuntime;
using System;

namespace iZettleSDK
{
    //// @interface IZAuthorizationProviderBridge : NSObject
    //[BaseType(typeof(NSObject))]
    //interface IZAuthorizationProviderBridge
    //{
    //    /// Just syntax sugar to bridge between public and private Authorization providers.
    //    /// Required scopes are necesary for future operations that might require additional scopes
    //    /// which a token might not have even though the token is valid.
    //    /// A check will be performed to validate scopes and user asked to authorize again
    //    /// if the token is missing required scopes. Public provider is required to return a token
    //    /// with necessary scopes to perform any operation when asked to authorize.
    //    /// \param publicProvider Object conforming to <code>iZettleSDKAuthorizationProvider</code> protocol
    //    ///
    //    /// \param requiredScopes Scopes that are required by the operation that wants to authorize.
    //    ///
    //    //+ (IZAuthorizationProvider* _Nonnull) bridgePublicProvider:(id<iZettleSDKAuthorizationProvider> _Nonnull) publicProvider requiredScopes:(NSArray<IZOAuthTokenScope*>* _Nonnull) requiredScopes SWIFT_WARN_UNUSED_RESULT;
    //    [Static, Export("bridgePublicProvider:requiredScopes:")]
    //    IZAuthorizationProvider BridgePublicProvider(IiZettleSDKAuthorizationProvider publicProvider, IZOAuthTokenScope[] requiredScopes);


    //    //- (nonnull instancetype) init OBJC_DESIGNATED_INITIALIZER;
    //    [Export("init"), DesignatedInitializer]
    //    IntPtr Constructor();

    //    //@end
    //}

    partial interface IiZettleSDKAuthorizationProvider { }

    //@protocol iZettleSDKAuthorizationProvider
    [BaseType(typeof(NSObject), Name = "_TtP10iZettleSDK31iZettleSDKAuthorizationProvider_")]
    [Protocol, Model]
    interface iZettleSDKAuthorizationProvider
    {
        ///// Called to request a token.
        ///// This method will only be called once when a valid token is requested, the token will be stored internally for subsequent requests.
        ///// \param completion Complete with token or error.
        /////
        //- (void) authorizeAccountWithCompletion:(void (^ _Nonnull)(iZettleSDKOAuthToken* _Nullable, NSError* _Nullable))completion;
        [Export("authorizeAccountWithCompletion:")]
        void AuthorizeAccountWithCompletion(Action<iZettleSDKOAuthToken, NSError> completion);

        ///// Called to request an elevated token.
        ///// Elevated tokens are stored internally but are not refreshed by the SDK.
        ///// \param uuid The uuid of the account performing the operation which requires elevated token.
        ///// Use this uuid in the verification step.
        /////
        ///// \param completion Complete with elevated token or error.
        /////
        //- (void) verifyAccountWithUuid:(NSUUID* _Nonnull) uuid completion:(void (^ _Nonnull)(iZettleSDKOAuthToken* _Nullable, NSError* _Nullable))completion;
        [Export("verifyAccountWithUuid:completion:")]
        void VerifyAccountWithUuid(NSUuid uuid, Action<iZettleSDKOAuthToken, NSError> completion);
        //@end
    }

    //@interface iZettleSDKAuthorization : NSObject <iZettleSDKAuthorizationProvider>
    [BaseType(typeof(NSObject), Name = "_TtC10iZettleSDK23iZettleSDKAuthorization"), DisableDefaultCtor]
    interface iZettleSDKAuthorization : iZettleSDKAuthorizationProvider
    {
        ///// Required information to perform authorization.
        ///// \param clientID Client identifier.
        /////
        ///// \param callbackURL [App URL scheme] + login.callback, example: com.myapp.scheme://login.callback
        /////
        ///// \param enforcedUserAccount Is an autoclosure for the email of the account that must be used to login, use <code>nil</code> to allow any account to login.
        ///// Because it is an autoclosure the property will be read whenever an operation requiering autorization is performed,
        ///// therefore it can be changed in between operations to switch between accounts.
        /////
        /////
        ///// throws:
        ///// If clientID or callbackURL validation fails.
        //- (nullable instancetype)initWithClientID:(NSString * _Nonnull)clientID callbackURL:(NSURL * _Nonnull)callbackURL error:(NSError * _Nullable * _Nullable)error enforcedUserAccount:(NSString * _Nullable (^ _Nonnull)(void))enforcedUserAccount OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithClientID:callbackURL:error:enforcedUserAccount:"), DesignatedInitializer]
        IntPtr Constructor(string clientID, NSUrl callbackUrl, [NullAllowed] NSError error, [NullAllowed] Func<string> enforcedUserAccount);

        //- (nonnull instancetype)init SWIFT_UNAVAILABLE;
        //+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
        //@end
    }

    ////@interface iZettleSDKAuthorization(SWIFT_EXTENSION(iZettleSDK))
    //[BaseType(typeof(NSObject))]
    //interface iZettleSDK_iZettleSDKAuthorization
    //{
    //    //- (void) authorizeAccountWithCompletion:(void (^ _Nonnull)(iZettleSDKOAuthToken* _Nullable, NSError* _Nullable))completion;
    //    //- (void) verifyAccountWithUuid:(NSUUID* _Nonnull) uuid completion:(void (^ _Nonnull)(iZettleSDKOAuthToken* _Nullable, NSError* _Nullable))completion;
    //    //@end
    //}

    //@interface iZettleSDKOAuthToken : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10iZettleSDK20iZettleSDKOAuthToken"), DisableDefaultCtor]
    interface iZettleSDKOAuthToken
    {
        ///// Initialize with raw token data.
        ///// \param data Raw token data as received from the API
        /////
        /////
        ///// throws:
        ///// If token is invalid.
        //- (nullable instancetype)initWithData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
        [Export("initWithData:error:")]
        IntPtr Constructor(NSData clientID, [NullAllowed] NSError error);

        ///// Initialize with token components
        ///// \param accessToken JWT access token
        /////
        ///// \param expiresIn Seconds until token expires
        /////
        ///// \param refreshToken Used to refresh access token
        /////
        /////
        ///// throws:
        ///// If any of the parameters are invalid.
        //- (nullable instancetype)initWithAccessToken:(NSString * _Nonnull)accessToken expiresIn:(NSInteger)expiresIn refreshToken:(NSString * _Nullable)refreshToken error:(NSError * _Nullable * _Nullable)error OBJC_DESIGNATED_INITIALIZER;
        [Export("initWithAccessToken:expiresIn:refreshToken:error:"), DesignatedInitializer]
        IntPtr Constructor(string accessToken, nint expiresIn, string refreshToken, [NullAllowed] NSError error);

        //- (nonnull instancetype)init SWIFT_UNAVAILABLE;
        //+ (nonnull instancetype)new SWIFT_UNAVAILABLE_MSG("-init is unavailable");
        //@end
    }

    // typedef void (^iZettleSDKOperationCompletion)(iZettleSDKPaymentInfo * _Nullable, NSError * _Nullable);
    delegate void iZettleSDKOperationCompletion([NullAllowed] iZettleSDKPaymentInfo arg0, [NullAllowed] NSError arg1);

    // typedef void(^IZSDKPayPalQRCCompletion)(IZSDKPayPalQRCPaymentInfo * _Nullable paymentInfo, NSError * _Nullable error);
    delegate void IZSDKPayPalQRCCompletion([NullAllowed] IZSDKPayPalQRCPaymentInfo arg0, [NullAllowed] NSError arg1);

    // @interface iZettleSDK : NSObject
    [BaseType(typeof(NSObject)), DisableDefaultCtor]
    interface iZettleSDK
    {
        // @property (readonly, nonatomic) NSString * _Nonnull version;
        [Export("version")]
        string Version { get; }

        // +(iZettleSDK * _Nonnull)shared;
        [Static]
        [Export("shared")]
        iZettleSDK Shared { get; }

        // @property (copy, nonatomic) NSString * _Nullable enforcedUserAccount;
        [NullAllowed, Export("enforcedUserAccount")]
        string EnforcedUserAccount { get; set; }

        //- (void) authorizeAccountWithCompletion:(void (^ _Nonnull)(iZettleSDKOAuthToken* _Nullable, NSError* _Nullable))completion;
        [Export("authorizeAccountWithCompletion:")]
        void AuthorizeAccountWithCompletion(Action<iZettleSDKOAuthToken, NSError> completion);

        // - (void)setEnabledAlternativePaymentMethods:(NSArray<NSNumber *> *)enabledAPMs;
        [Export("setEnabledAlternativePaymentMethods:")]
        void SetEnabledAlternativePaymentMethods(NSArray enabledAPMs);

        //- (void) verifyAccountWithUuid:(NSUUID* _Nonnull) uuid completion:(void (^ _Nonnull)(iZettleSDKOAuthToken* _Nullable, NSError* _Nullable))completion;
        [Export("verifyAccountWithUuid:completion:")]
        void VerifyAccountWithUuid(NSUuid uuid, Action<iZettleSDKOAuthToken, NSError> completion);

        //- (void) startWithAuthorizationProvider:(id<iZettleSDKAuthorizationProvider>) provider;
        [Export("startWithAuthorizationProvider:")]
        void StartWithAuthorizationProvider(IiZettleSDKAuthorizationProvider provider);

        // - (void)startWithAuthorizationProvider:(id<iZettleSDKAuthorizationProvider>)provider
        //            enableDeveloperMode:(BOOL)enableDeveloperMode;
        [Export("startWithAuthorizationProvider:enableDeveloperMode:")]
        void StartWithAuthorizationProvider(IiZettleSDKAuthorizationProvider provider, bool enableDeveloperMode);

        //- (BOOL) applicationDidOpenWithURL:(NSURL*) url NS_DEPRECATED_IOS(9_0, 11_0, "Not needed on newer iOS versions.")
        [Export("applicationDidOpenWithURL:")]
        // [Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.All, "Not needed on newer iOS versions.")]
        void ApplicationDidOpenWithURL(NSUrl url);
        
        //- (void) logout;
        [Export("logout")]
        void Logout();

        // -(void)chargeAmount:(NSDecimalNumber * _Nonnull)amount enableTipping:(BOOL)enableTipping reference:(NSString * _Nullable)reference presentFromViewController:(UIViewController * _Nonnull)viewController completion:(iZettleSDKOperationCompletion _Nonnull)completion;
        [Export("chargeAmount:enableTipping:reference:presentFromViewController:completion:")]
        void ChargeAmount(NSDecimalNumber amount, bool enableTipping, [NullAllowed] string reference, UIViewController viewController, iZettleSDKOperationCompletion completion);

        // - (void)chargeAmount:(NSDecimalNumber *)amount
        //         tippingStyle:(IZSDKTippingStyle)tippingStyle
        //            reference:(nullable NSString *)reference
        // presentFromViewController:(UIViewController *)viewController
        //           completion:(iZettleSDKOperationCompletion)completion
        // NS_SWIFT_NAME(charge(amount:tippingStyle:reference:presentFrom:completion:));
        [Export("chargeAmount:tippingStyle:reference:presentFromViewController:completion:")]
        void ChargeAmount(NSDecimalNumber amount, IZSDKTippingStyle tippingStyle, [NullAllowed] string reference, UIViewController viewController, iZettleSDKOperationCompletion completion);

        // -(void)refundAmount:(NSDecimalNumber * _Nullable)amount ofPaymentWithReference:(NSString * _Nonnull)reference refundReference:(NSString * _Nullable)refundReference presentFromViewController:(UIViewController * _Nonnull)viewController completion:(iZettleSDKOperationCompletion _Nonnull)completion;
        [Export("refundAmount:ofPaymentWithReference:refundReference:presentFromViewController:completion:")]
        void RefundAmount([NullAllowed] NSDecimalNumber amount, string reference, [NullAllowed] string refundReference, UIViewController viewController, iZettleSDKOperationCompletion completion);

        // -(void)retrievePaymentInfoForReference:(NSString * _Nonnull)reference presentFromViewController:(UIViewController * _Nonnull)viewController completion:(iZettleSDKOperationCompletion _Nonnull)completion;
        [Export("retrievePaymentInfoForReference:presentFromViewController:completion:")]
        void RetrievePaymentInfoForReference(string reference, UIViewController viewController, iZettleSDKOperationCompletion completion);

        //- (void) retrievePaymentInfoForReference:(NSString*) reference
        //                              completion:(iZettleSDKOperationCompletion) completion
        [Export("retrievePaymentInfoForReference:completion:")]
        void RetrievePaymentInfoForReference(string reference, iZettleSDKOperationCompletion completion);

        // - (void)chargePayPalQRCWithAmount:(NSDecimalNumber *)amount
        //                         reference:(NSString *)reference
        //       presentedFromViewController:(UIViewController *)viewController
        //                        completion:(IZSDKPayPalQRCCompletion)completion
        // NS_SWIFT_NAME(chargePayPalQRC(amount:reference:presentFrom:completion:))
        // API_AVAILABLE(ios(13));
        [Export("chargePayPalQRCWithAmount:reference:presentedFromViewController:completion:")]
        void ChargePayPalQRCWithAmount(NSDecimalNumber amount, string reference, UIViewController presentedFromViewController, IZSDKPayPalQRCCompletion completion);

        //         - (void)chargePayPalQRCWithAmount:(NSDecimalNumber *)amount
        //                         reference:(NSString *)reference
        //                        appearance:(IZSDKPayPalQRCAppearance)appearance
        //         presentFromViewController:(UIViewController *)viewController
        //                        completion:(IZSDKPayPalQRCCompletion)completion
        // NS_SWIFT_NAME(chargePayPalQRC(amount:reference:appearance:presentFrom:completion:))
        // API_AVAILABLE(ios(13));
        [Export("chargePayPalQRCWithAmount:reference:appearance:presentFromViewController:completion:")]
        void ChargePayPalQRCWithAmount(NSDecimalNumber amount, string reference, IZSDKPayPalQRCAppearance appearance, UIViewController presentedFromViewController, IZSDKPayPalQRCCompletion completion);

        // - (void)retrievePayPalQRCPaymentInfoForReference:(NSString *)reference
        //                        presentFromViewController:(UIViewController *)viewController
        //                                       completion:(IZSDKPayPalQRCCompletion)completion
        // NS_SWIFT_NAME(retrievePayPalQRCPaymentInfo(for:presentFrom:completion:))
        // API_AVAILABLE(ios(13));
        [Export("retrievePayPalQRCPaymentInfoForReference:presentFromViewController:completion:")]
        void RetrievePayPalQRCPaymentInfoForReference(string reference, UIViewController viewController, IZSDKPayPalQRCCompletion completion);

        // - (void)retrievePayPalQRCPaymentInfoForReference:(NSString *)reference
        //                                       completion:(IZSDKPayPalQRCCompletion)completion
        // NS_SWIFT_NAME(retrievePayPalQRCPaymentInfo(for:completion:))
        // API_AVAILABLE(ios(13));
        [Export("retrievePayPalQRCPaymentInfoForReference:completion:")]
        void RetrievePayPalQRCPaymentInfoForReference(string reference, IZSDKPayPalQRCCompletion completion);

        // - (void)refundPayPalQRCAmount:(nullable NSDecimalNumber *)amount
        //        ofPaymentWithReference:(NSString *)paymentReference
        //               refundReference:(NSString *)refundReference
        //     presentFromViewController:(UIViewController *)viewController
        //                    completion:(IZSDKPayPalQRCCompletion)completion
        // NS_SWIFT_NAME(refundPayPalQRC(amount:ofPayment:withRefundReference:presentFrom:completion:))
        // API_AVAILABLE(ios(13));
        [Export("refundPayPalQRCAmount:ofPaymentWithReference:refundReference:presentFromViewController:completion:")]
        void RefundPayPalQRCAmount([NullAllowed] NSDecimalNumber amount, string reference, [NullAllowed] string refundReference, UIViewController viewController, IZSDKPayPalQRCCompletion completion);

        // -(void)presentSettingsFromViewController:(UIViewController * _Nonnull)viewController;
        [Export("presentSettingsFromViewController:")]
        void PresentSettingsFromViewController(UIViewController viewController);

        // -(void)abortOperation;
        [Export("abortOperation")]
        void AbortOperation();
    }

    // @interface iZettleSDKPaymentInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface iZettleSDKPaymentInfo
    {
        // @property (readonly, nonatomic) NSDictionary<NSString *,id> * _Nonnull dictionary;
        [Export("dictionary")]
        NSDictionary<NSString, NSObject> Dictionary { get; }

        // @property (readonly, nonatomic) NSDecimalNumber * _Nonnull amount;
        [Export("amount")]
        NSDecimalNumber Amount { get; }

        // @property (nonatomic, readonly) NSString *transactionId;
        [Export("transactionId")]
        string TransactionId { get; }

        // @property (readonly, nonatomic) NSDecimalNumber * _Nullable gratuityAmount;
        [NullAllowed, Export("gratuityAmount")]
        NSDecimalNumber GratuityAmount { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull referenceNumber;
        [Export("referenceNumber")]
        string ReferenceNumber { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull entryMode;
        [Export("entryMode")]
        string EntryMode { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull authorizationCode;
        [Export("authorizationCode")]
        string AuthorizationCode { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull obfuscatedPan;
        [Export("obfuscatedPan")]
        string ObfuscatedPan { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull panHash;
        [Export("panHash")]
        string PanHash { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull cardBrand;
        [Export("cardBrand")]
        string CardBrand { get; }

        // @property (readonly, nonatomic) NSString * _Nullable AID;
        [NullAllowed, Export("AID")]
        string AID { get; }

        // @property (readonly, nonatomic) NSString * _Nullable TSI;
        [NullAllowed, Export("TSI")]
        string TSI { get; }

        // @property (readonly, nonatomic) NSString * _Nullable TVR;
        [NullAllowed, Export("TVR")]
        string TVR { get; }

        // @property (readonly, nonatomic) NSString * _Nullable applicationName;
        [NullAllowed, Export("applicationName")]
        string ApplicationName { get; }

        // @property (readonly, nonatomic) NSNumber * _Nullable numberOfInstallments;
        [NullAllowed, Export("numberOfInstallments")]
        NSNumber NumberOfInstallments { get; }

        // @property (readonly, nonatomic) NSDecimalNumber * _Nullable installmentAmount;
        [NullAllowed, Export("installmentAmount")]
        NSDecimalNumber InstallmentAmount { get; }


        // Only used for Mexico
        //@property(nonatomic, readonly, nullable) NSString* mxFIID;
        [NullAllowed, Export("mxFIID")]
        string MexcioFIID { get; }

        //@property(nonatomic, readonly, nullable) NSString* mxCardType;
        [NullAllowed, Export("mxCardType")]
        string MexicoCardType { get; }
    }

    // extern NSErrorDomain const IZSDKErrorDomain;
    // extern NSErrorDomain const IZSDKPayPalQRCErrorDomain;

    // @interface IZSDKPayPalQRCPaymentInfo: NSObject
    [BaseType(typeof(NSObject))]
    interface IZSDKPayPalQRCPaymentInfo
    {
        // /// Total transaction amount.
        // @property (nonatomic, readonly) NSDecimalNumber *amount;
        [Export("amount")]
        NSDecimalNumber Amount { get; }

        // /// Zettle's reference to the payment that should be displayed on receipts (not to be confused with the reference provided by you during a charge or refund operation).
        // @property (nonatomic, readonly) NSString *referenceNumber;
        [Export("referenceNumber")]
        string ReferenceNumber { get; }

        // /// Transaction Identifier that should be displayed on receipts and comes from the PayPal service.
        // @property (nonatomic, readonly) NSString *paypalTransactionId;
        [Export("paypalTransactionId")]
        string PaypalTransactionId { get; }

        // /// Which QRC type was used to perform the payment PayPal or Venmo (USA Only).
        // @property (nonatomic, readonly) IZSDKPayPalQRCType type;
        [Export("type")]
        IZSDKPayPalQRCType Type { get; }

        // /// The Zettle transaction identifier for the transaction itself.
        // @property (nonatomic, readonly) NSString *transactionId;
        [Export("transactionId")]
        string TransactionId { get; }

        // @end
    }
}
