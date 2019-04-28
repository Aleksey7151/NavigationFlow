using System;
using FlexiMvvm;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
using FlexiMvvm.Views;
using NavigationFlow.iOS.Views;
using NavigationFlow.iOS.Views.CustomFlow;
using NavigationFlow.iOS.Views.CustomFlow.First;
using NavigationFlow.iOS.Views.CustomFlow.Second;
using NavigationFlow.iOS.Views.CustomFlow.Third;
using NavigationFlow.iOS.Views.Home;
using NavigationFlow.Presentation;
using UIKit;

namespace NavigationFlow.iOS.Navigation
{
    internal sealed class NavigationService
        : FlexiMvvm.Navigation.NavigationService, INavigationService
    {
        public void NavigateToHome(EntryViewModel fromViewModel)
        {
            var rootNavigationController = NavigationViewProvider.GetViewController<RootNavigationController, EntryViewModel>(fromViewModel);
            var homeViewController = new HomeViewController();

            rootNavigationController.SetViewControllers(new UIViewController[] { homeViewController }, true);
        }

        public void NavigateToFirst(HomeViewModel fromViewModel)
        {
            var homeViewController = NavigationViewProvider.GetViewController<HomeViewController, HomeViewModel>(fromViewModel);

            var customFlowNavigationController = new CustomFlowNavigationController();
            customFlowNavigationController.ResultSetWeakSubscribe(homeViewController.HandleResult);
            customFlowNavigationController.SetViewControllers(new UIViewController[] { new FirstViewController() }, false);

            homeViewController.NavigationController.PresentViewController(customFlowNavigationController, true, null);
        }

        public void NavigateToSecond(FirstViewModel fromViewModel)
        {
            var firstViewController = NavigationViewProvider.GetViewController<FirstViewController, FirstViewModel>(fromViewModel);

            firstViewController.NavigationController.PushViewController(new SecondViewController(), true);
        }

        public void NavigateToThird(SecondViewModel fromViewModel)
        {
            var secondViewController = NavigationViewProvider.GetViewController<SecondViewController, SecondViewModel>(fromViewModel);

            var customFlowNavigationController = (CustomFlowNavigationController)secondViewController.NavigationController;

            var thirdViewController = new ThirdViewController();
            thirdViewController.ResultSetWeakSubscribe(customFlowNavigationController.HandleResult);

            customFlowNavigationController.PushViewController(thirdViewController, true);
        }

        public void SetCustomFlowResult(ThirdViewModel fromViewModel, ResultCode resultCode, FlowResult flowResult)
        {
            var thirdViewController = NavigationViewProvider.GetViewController<ThirdViewController, ThirdViewModel>(fromViewModel);

            thirdViewController.SetResult(resultCode, flowResult);

            thirdViewController.NavigationController.DismissViewController(true, null);
        }
    }
}