using Foundation;
using iZettle;
using UIKit;

namespace iZettleQs
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        const string clientId = @"73xxxxeea-xxx-425d-xxx-236exxxx85b8";
        const string callbackURL = @"xzettleqs://login.callback";

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method
            NSError error = null;
            var authorizationProvider = new iZettleSDKAuthorization(
                clientId,
                NSUrl.FromString(callbackURL),
                error,
                () => AccountManager.Shared.EnforcedUserAccount);

            iZettleSDK.Shared.StartWithAuthorizationProvider(authorizationProvider, true);

            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }

        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options)
        {
            iZettleSDK.Shared.ApplicationDidOpenWithURL(url);

            return true;
        }
    }

    public class AccountManager
    {
        public string EnforcedUserAccount { get; set; }

        private static AccountManager accountManager;
        public static AccountManager Shared
        {
            get
            {
                if (accountManager == null)
                {
                    accountManager = new AccountManager();
                }

                return accountManager;
            }
        }
    }
}

