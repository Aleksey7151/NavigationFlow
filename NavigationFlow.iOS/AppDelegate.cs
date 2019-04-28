using FlexiMvvm.Bootstrappers;
using FlexiMvvm.Ioc;
using Foundation;
using NavigationFlow.Bootstrapper;
using NavigationFlow.iOS.Navigation;
using NavigationFlow.iOS.Views;
using NavigationFlow.iOS.Views.CustomFlow;
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
            var simpleIoc = new SimpleIoc();
            simpleIoc.Register<INavigationService>(() => new NavigationService());

            simpleIoc.Register(() => new CustomFlowNavigationViewModel());

            var config = new BootstrapperConfig();
            config.SetSimpleIoc(simpleIoc);

            var bootstrapper = new CoreBootstrapper();
            bootstrapper.Execute(config);

            Window = new UIWindow(UIScreen.MainScreen.Bounds)
            {
                RootViewController = new RootNavigationController()
            };

            Window.MakeKeyAndVisible();

            return true;
        }
    }
}
