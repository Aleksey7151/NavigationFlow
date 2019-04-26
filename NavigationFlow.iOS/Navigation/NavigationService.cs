using System;
using FlexiMvvm;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
using FlexiMvvm.Views;
using NavigationFlow.iOS.Views;
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

            rootNavigationController.NavigationController.NotNull().SetViewControllers(new UIViewController[] { homeViewController }, true);
        }

        public void NavigateToFirst(HomeViewModel fromViewModel)
        {
            var homeViewController = NavigationViewProvider.GetViewController<HomeViewController, HomeViewModel>(fromViewModel);
            var firstViewController = new HomeViewController();
        }

        public void NavigateToSecond(FirstViewModel fromViewModel)
        {
            throw new NotImplementedException();
        }

        public void NavigateToThird(SecondViewModel fromViewModel)
        {
            throw new NotImplementedException();
        }
    }
}