using System.Windows.Input;
using FlexiMvvm.ViewModels;

namespace NavigationFlow.Presentation
{
    public sealed class FirstViewModel
        : LifecycleViewModel, ILifecycleViewModelWithResult<FlowResult>, ILifecycleViewModelWithResultHandler
    {
        private readonly INavigationService _navigationService;

        public ICommand CloseFlowCommand => CommandProvider.Get(CloseFlow);

        public ICommand GoToNextCommand => CommandProvider.Get(Move);

        public FirstViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void SetResult(ResultCode resultCode, FlowResult result)
        {
            HandleResult(resultCode, result);
        }

        public void HandleResult(ResultCode resultCode, Result result)
        {
            _navigationService.NavigateBack(this, resultCode, (FlowResult)result);
        }

        private void Move()
        {
            _navigationService.NavigateToSecond(this);
        }

        private void CloseFlow()
        {
            _navigationService.NavigateBack(this, ResultCode.Canceled, new FlowResult(string.Empty));
        }
    }
}
