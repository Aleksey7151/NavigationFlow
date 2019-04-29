using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
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
            customFlowNavigationController.PushViewController(new FirstViewController(), false);

            NavigateForResult<CustomFlowNavigationController, FlowResult>(
                homeViewController,
                customFlowNavigationController,
                true,
                NavigationStrategy.Forward.PresentViewController());
        }

        public void NavigateToSecond(FirstViewModel fromViewModel)
        {
            var firstViewController = NavigationViewProvider.GetViewController<FirstViewController, FirstViewModel>(fromViewModel);

            firstViewController.NavigationController.PushViewController(new SecondViewController(), true);
        }

        public void NavigateToThird(SecondViewModel fromViewModel)
        {
            var secondViewController = NavigationViewProvider.GetViewController<SecondViewController, SecondViewModel>(fromViewModel);

            secondViewController.NavigationController.PushViewController(new ThirdViewController(), true);
        }

        public void NavigateBack<TResult>(ILifecycleViewModelWithResult<TResult> fromViewModel, ResultCode resultCode, TResult result)
            where TResult : Result
        {
            var fromView = NavigationViewProvider.Get(fromViewModel);

            NavigateBack(fromView, resultCode, result, true);
        }

        public void NavigateBack(ThirdViewModel fromViewModel, ResultCode resultCode, FlowResult result)
        {
            var thirdViewController = NavigationViewProvider.GetViewController<ThirdViewController, ThirdViewModel>(fromViewModel);
            var customFlowNavigationController = (CustomFlowNavigationController)thirdViewController.NavigationController;

            NavigateBack(customFlowNavigationController, resultCode, result, true);
        }

        public void NavigateBack(FirstViewModel fromViewModel, ResultCode resultCode, FlowResult result)
        {
            var firstViewController = NavigationViewProvider.GetViewController<FirstViewController, FirstViewModel>(fromViewModel);
            var customFlowNavigationController = (CustomFlowNavigationController)firstViewController.NavigationController;

            NavigateBack(customFlowNavigationController, resultCode, result, true);
        }
    }
}