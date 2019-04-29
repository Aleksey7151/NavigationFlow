using FlexiMvvm.Bootstrappers;
using FlexiMvvm.ViewModels;
using NavigationFlow.Presentation;
using NavigationFlow.Presentation.CustomFlow;

namespace NavigationFlow.Bootstrapper
{
    public sealed class CoreBootstrapper : IBootstrapper
    {
        public void Execute(BootstrapperConfig config)
        {
            var simpleIoc = config.GetSimpleIoc();

            simpleIoc.Register(() => new EntryViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new HomeViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new FirstViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new SecondViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new ThirdViewModel(simpleIoc.Get<INavigationService>()));
            simpleIoc.Register(() => new CustomFlowNavigationViewModel());

            LifecycleViewModelProvider.SetFactory(new DefaultLifecycleViewModelFactory(simpleIoc));
        }
    }
}
