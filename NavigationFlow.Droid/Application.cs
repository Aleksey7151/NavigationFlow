using System;
using Android.App;
using Android.Runtime;
using FlexiMvvm.Bootstrappers;
using FlexiMvvm.Ioc;
using NavigationFlow.Bootstrapper;
using NavigationFlow.Droid.Navigation;

namespace NavigationFlow.Droid
{
    [Application]
    public sealed class Application : Android.App.Application
    {
        /// <inheritdoc />
        protected Application(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            var simpleIoc = new SimpleIoc();
            simpleIoc.Register<INavigationService>(() => new NavigationService());

            var config = new BootstrapperConfig();
            config.SetSimpleIoc(simpleIoc);

            var bootstrapper = new CoreBootstrapper();
            bootstrapper.Execute(config);
        }
    }
}