using Android.App;
using Android.OS;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using NavigationFlow.Presentation;

namespace NavigationFlow.Droid.Views.CustomFlow.Second
{
    [Activity(Label = "SecondActivity")]
    internal sealed class SecondActivity
        : BindableAppCompatActivity<SecondViewModel>
    {
        private SecondActivityViewHolder ViewHolder { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_second);

            ViewHolder = new SecondActivityViewHolder(this);
        }

        public override void Bind(BindingSet<SecondViewModel> bindingSet)
        {
            bindingSet.Bind(ViewHolder.NextButton)
                .For(v => v.ClickBinding())
                .To(vm => vm.GoToNextCommand);
        }
    }
}