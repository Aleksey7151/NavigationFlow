using Android.App;
using FlexiMvvm.Views;
using NavigationFlow.Presentation;

namespace NavigationFlow.Droid.Views
{
    [Activity(
        Label = "SplashScreenActivity",
        NoHistory = true,
        MainLauncher = true)]
    internal sealed class SplashScreenActivity
        : AppCompatActivity<EntryViewModel>
    {
    }
}