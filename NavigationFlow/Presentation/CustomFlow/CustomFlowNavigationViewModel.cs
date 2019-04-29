using FlexiMvvm.ViewModels;

namespace NavigationFlow.Presentation.CustomFlow
{
    public sealed class CustomFlowNavigationViewModel
        : LifecycleViewModel, ILifecycleViewModelWithResult<FlowResult>
    {
        public void SetResult(ResultCode resultCode, FlowResult result)
        {
        }
    }
}