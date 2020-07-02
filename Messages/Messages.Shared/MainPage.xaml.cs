using Messages.Shared.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Messages
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

#if __ANDROID__ || __IOS__
            Split.IsPaneOpen = false;
#endif
        }

        public MainViewModel ViewModel { get; } = new MainViewModel();

        private void PaneToggle(object sender, PointerRoutedEventArgs e) => Split.IsPaneOpen = !Split.IsPaneOpen;

        private void ListItemClick(object sender, ItemClickEventArgs e) => Split.IsPaneOpen = !Split.IsPaneOpen;
      
    }
}
