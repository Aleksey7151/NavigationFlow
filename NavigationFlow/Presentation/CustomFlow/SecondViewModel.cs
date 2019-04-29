using System.Windows.Input;
using FlexiMvvm.ViewModels;

namespace NavigationFlow.Presentation
{
    public sealed class SecondViewModel
        : LifecycleViewModel, ILifecycleViewModelWithResult<FlowResult>, ILifecycleViewModelWithResultHandler
    {
        private readonly INavigationService _navigationService;

        public ICommand GoToNextCommand => CommandProvider.Get(Move);

        public SecondViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void SetResult(ResultCode resultCode, FlowResult result)
        {
            _navigationService.NavigateBack(this, resultCode, result);
        }

        public void HandleResult(ResultCode resultCode, Result result)
        {
            SetResult(resultCode, (FlowResult)result);
        }

        private void Move()
        {
            _navigationService.NavigateToThird(this);
        }
    }
}
