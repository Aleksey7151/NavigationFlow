using NavigationFlow.Presentation;

namespace NavigationFlow
{
    public interface INavigationService
    {
        void NavigateToHome(EntryViewModel fromViewModel);

        void NavigateToFirst(HomeViewModel fromViewModel);

        void NavigateToSecond(FirstViewModel fromViewModel);

        void NavigateToThird(SecondViewModel fromViewModel);
    }
}
