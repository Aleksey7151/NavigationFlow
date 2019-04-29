using System.Windows.Input;
using FlexiMvvm.ViewModels;

namespace NavigationFlow.Presentation
{
    public sealed class HomeViewModel
        : LifecycleViewModel, ILifecycleViewModelWithResultHandler
    {
        private readonly INavigationService _navigationService;
        private string _result;

        public ICommand StartSeparateFlowCommand => CommandProvider.Get(StartFlow);

        public string Result
        {
            get => _result;
            set => SetValue(ref _result, value);
        }

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private void StartFlow()
        {
            _navigationService.NavigateToFirst(this);
        }

        public void HandleResult(ResultCode resultCode, Result result)
        {
            if (resultCode == ResultCode.Canceled)
            {
                Result = "Flow was closed without setting Result";
            }
            else if (result is FlowResult flowResult)
            {
                Result = flowResult.Result;
            }
        }
    }
}
