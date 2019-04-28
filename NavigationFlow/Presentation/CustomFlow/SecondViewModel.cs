using System.Windows.Input;
using FlexiMvvm.ViewModels;

namespace NavigationFlow.Presentation
{
    public sealed class SecondViewModel : LifecycleViewModel
    {
        private readonly INavigationService _navigationService;

        public ICommand GoToNextCommand => CommandProvider.Get(Move);

        public SecondViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private void Move()
        {
            _navigationService.NavigateToThird(this);
        }
    }
}
