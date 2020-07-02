using Messages.Shared.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Messages.Shared.Resources
{
    public class MessageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FromTemplate { get; set; }

        public DataTemplate ToTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) =>
            SelectTemplateCore(item);

        protected override DataTemplate SelectTemplateCore(object item)
        {
            var message = (MessageViewModel)item;
            return message.IsFrom ? FromTemplate : ToTemplate;
        }
    }
}
