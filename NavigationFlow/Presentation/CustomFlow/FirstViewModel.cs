using System.Windows.Input;
using FlexiMvvm.ViewModels;

namespace NavigationFlow.Presentation
{
    public sealed class FirstViewModel : LifecycleViewModel
    {
        private readonly INavigationService _navigationService;

        public ICommand GoToNextCommand => CommandProvider.Get(Move);

        public FirstViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private void Move()
        {
            _navigationService.NavigateToSecond(this);
        }
    }
}
