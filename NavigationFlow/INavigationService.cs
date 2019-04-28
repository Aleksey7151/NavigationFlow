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

        void SetCustomFlowResult(ThirdViewModel fromViewModel, ResultCode resultCode, FlowResult flowResult);
    }
}
