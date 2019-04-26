using Android.App;
using Android.OS;
using Android.Support.V7.App;
using FlexiMvvm.Views;
using NavigationFlow.Presentation;

namespace NavigationFlow.Droid.Views
{
    [Activity(
        Label = "@string/app_name",
        Theme = "@style/AppTheme",
        MainLauncher = true)]
    internal sealed class HomeActivity : AppCompatActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}