﻿using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using NavigationFlow.Presentation;

namespace NavigationFlow.iOS.Views.CustomFlow.First
{
    internal sealed class FirstViewController
        : BindableViewController<FirstViewModel>
    {
        public new FirstView View
        {
            get => (FirstView)base.View;
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new FirstView();
        }

        public override void Bind(BindingSet<FirstViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            bindingSet.Bind(View.NextButton)
                .For(v => v.TouchUpInsideBinding())
                .To(vm => vm.GoToNextCommand);
        }
    }
}