using FlexiMvvm.ViewModels;
using NavigationFlow.Presentation;

namespace NavigationFlow
{
    public interface INavigationService
    {
        void NavigateToHome(EntryViewModel fromViewModel);

        void NavigateToFirst(HomeViewModel fromViewModel);

        void NavigateToSecond(FirstViewModel fromViewModel);

        void NavigateToThird(SecondViewModel fromViewModel);

        void NavigateBack(
            ThirdViewModel fromViewModel,
            ResultCode resultCode,
            FlowResult result);

        void NavigateBack(
            FirstViewModel fromViewModel,
            ResultCode resultCode,
            FlowResult result);

        void NavigateBack<TResult>(
            ILifecycleViewModelWithResult<TResult> fromViewModel,
            ResultCode resultCode,
            TResult result) where TResult : Result;
    }
}
