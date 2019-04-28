using FlexiMvvm.ViewModels;

namespace NavigationFlow.Presentation
{
    public sealed class FlowResult : Result
    {
        public string Result
        {
            get => Bundle.GetString();
            private set => Bundle.SetString(value);
        }

        public FlowResult(string result)
        {
            Result = result;
        }
    }
}
