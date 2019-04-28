using FlexiMvvm.ViewModels;
using NavigationFlow.Presentation;

namespace NavigationFlow.iOS.Views.CustomFlow
{
    internal sealed class CustomFlowNavigationViewModel
        : LifecycleViewModel, ILifecycleViewModelWithResult<FlowResult>, ILifecycleViewModelWithResultHandler
    {
        public void SetResult(ResultCode resultCode, FlowResult result)
        {

        }

        public void HandleResult(ResultCode resultCode, Result result)
        {
            SetResult(resultCode, (FlowResult)result);
        }
    }
}