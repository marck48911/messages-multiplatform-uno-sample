using System.Collections.ObjectModel;

namespace Messages.Shared.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public ObservableCollection<ConversationViewModel> Conversations { get; } =
            new ObservableCollection<ConversationViewModel>(SampleData.CreateSampleConversations());

        public ConversationViewModel SelectedConversation { get; set; }
    }
}
