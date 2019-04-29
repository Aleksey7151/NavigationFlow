using FlexiMvvm.Bindings;
using FlexiMvvm.Bindings.Custom;
using UIKit;

namespace NavigationFlow.iOS.Bindings
{
    internal static class BindingExtensions
    {
        public static TargetItemBinding<UITextField, string> TextChangedBinding(
            this IItemReference<UITextField> viewReference)
        {
            return new TargetItemOneWayToSourceCustomBinding<UITextField,string>(
                viewReference,
                (textField, eventHandler) =>
                {
                    textField.EditingChanged -= eventHandler;
                    textField.EditingChanged += eventHandler;
                },
                (textField, eventHandler) => { },
                (textField, canExecuteCommand) => { },
                textField => textField.Text,
                () => "TextChangedBinding");
        }
    }
}