using FlexiMvvm.ViewModels;

namespace NavigationFlow.Presentation
{
    public sealed class EntryViewModel : LifecycleViewModel
    {
        private readonly INavigationService _navigationService;

        public EntryViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Initialize(bool recreated)
        {
            base.Initialize(recreated);

            _navigationService.NavigateToHome(this);
        }
    }
}
