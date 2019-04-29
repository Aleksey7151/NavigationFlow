﻿using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using NavigationFlow.iOS.Bindings;
using NavigationFlow.Presentation;

namespace NavigationFlow.iOS.Views.CustomFlow.Third
{
    internal sealed class ThirdViewController
        : BindableViewController<ThirdViewModel>
    {
        public new ThirdView View
        {
            get => (ThirdView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new ThirdView();
        }

        public override void Bind(BindingSet<ThirdViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            bindingSet.Bind(View.ResultTextField)
                .For(v => v.TextChangedBinding())
                .To(vm => vm.Result);

            bindingSet.Bind(View.AcceptButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.AcceptCommand);

            bindingSet.Bind(View.DeclineButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.DeclineCommand);
        }
    }
}