using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using NavigationFlow.Presentation;

namespace NavigationFlow.iOS.Views.CustomFlow.Second
{
    internal sealed class SecondViewController
        : BindableViewController<SecondViewModel>
    {
        public new SecondView View
        {
            get => (SecondView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new SecondView();
        }

        public override void Bind(BindingSet<SecondViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            bindingSet.Bind(View.NextButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.GoToNextCommand);
        }
    }
}