using Foundation;
using NavigationFlow.iOS.Views;
using UIKit;

namespace NavigationFlow.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(
            UIApplication application,
            NSDictionary launchOptions)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds)
            {
                RootViewController = new RootNavigationController()
            };

            Window.MakeKeyAndVisible();

            return true;
        }
    }
}
