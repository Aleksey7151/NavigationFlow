using System;
using Android.Content;
using FlexiMvvm.Navigation;
using FlexiMvvm.ViewModels;
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
            var splashScreenActivity = NavigationViewProvider.GetActivity<SplashScreenActivity, EntryViewModel>(fromViewModel);
            var homeIntent = new Intent(splashScreenActivity, typeof(HomeActivity));
            splashScreenActivity.StartActivity(homeIntent);
        }

        public void NavigateToFirst(HomeViewModel fromViewModel)
        {
            var homeActivity = NavigationViewProvider.GetActivity<HomeActivity, HomeViewModel>(fromViewModel);
            var firstIntent = new Intent(homeActivity, typeof(FirstActivity));
            homeActivity.StartActivity(firstIntent);
        }

        public void NavigateToSecond(FirstViewModel fromViewModel)
        {
            var firstActivity = NavigationViewProvider.GetActivity<FirstActivity, FirstViewModel>(fromViewModel);
            var secondIntent = new Intent(firstActivity, typeof(SecondActivity));
            firstActivity.StartActivity(secondIntent);
        }

        public void NavigateToThird(SecondViewModel fromViewModel)
        {
            var secondActivity = NavigationViewProvider.GetActivity<SecondActivity, SecondViewModel>(fromViewModel);
            var thirdIntent = new Intent(secondActivity, typeof(ThirdActivity));
            secondActivity.StartActivity(thirdIntent);
        }

        public void SetCustomFlowResult(ThirdViewModel fromViewModel, ResultCode resultCode, FlowResult flowResult)
        {
            throw new NotImplementedException();
        }
    }
}