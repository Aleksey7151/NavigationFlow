using Android.Content;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
using FlexiMvvm.Views;
using NavigationFlow.Droid.Views;
using NavigationFlow.Droid.Views.CustomFlow.First;
using NavigationFlow.Droid.Views.CustomFlow.Second;
using NavigationFlow.Droid.Views.CustomFlow.Third;
using NavigationFlow.Presentation;

namespace NavigationFlow.Droid.Navigation
{
    internal sealed class NavigationService
        : FlexiMvvm.Navigation.NavigationService, INavigationService
    {
        public void NavigateToHome(EntryViewModel fromViewModel)
        {
            var splashScreenActivity =
                NavigationViewProvider.GetActivity<SplashScreenActivity, EntryViewModel>(fromViewModel);
            var homeIntent = new Intent(splashScreenActivity, typeof(HomeActivity));
            splashScreenActivity.StartActivity(homeIntent);
        }

        public void NavigateToFirst(HomeViewModel fromViewModel)
        {
            var homeActivity = NavigationViewProvider.GetActivity<HomeActivity, HomeViewModel>(fromViewModel);
            var firstIntent = new Intent(homeActivity, typeof(FirstActivity));
            var requestCode = homeActivity.RequestCode.GetFor<DefaultResultMapper<FlowResult>>();

            homeActivity.StartActivityForResult(firstIntent, requestCode);
        }

        public void NavigateToSecond(FirstViewModel fromViewModel)
        {
            var firstActivity = NavigationViewProvider.GetActivity<FirstActivity, FirstViewModel>(fromViewModel);
            var secondIntent = new Intent(firstActivity, typeof(SecondActivity));
            var requestCode = firstActivity.RequestCode.GetFor<DefaultResultMapper<FlowResult>>();

            firstActivity.StartActivityForResult(secondIntent, requestCode);
        }

        public void NavigateToThird(SecondViewModel fromViewModel)
        {
            var secondActivity = NavigationViewProvider.GetActivity<SecondActivity, SecondViewModel>(fromViewModel);
            var thirdIntent = new Intent(secondActivity, typeof(ThirdActivity));
            var requestCode = secondActivity.RequestCode.GetFor<DefaultResultMapper<FlowResult>>();

            secondActivity.StartActivityForResult(thirdIntent, requestCode);
        }

        public void NavigateBack<TResult>(ILifecycleViewModelWithResult<TResult> fromViewModel, ResultCode resultCode,
            TResult result)
            where TResult : Result
        {
            var fromView = NavigationViewProvider.Get(fromViewModel);

            NavigateBack(fromView, resultCode, result);
        }

        public void NavigateBack(ThirdViewModel fromViewModel, ResultCode resultCode, FlowResult result)
        {
            NavigateBack<FlowResult>(fromViewModel, resultCode, result);
        }

        public void NavigateBack(FirstViewModel fromViewModel, ResultCode resultCode, FlowResult result)
        {
            NavigateBack<FlowResult>(fromViewModel, resultCode, result);
        }
    }
}