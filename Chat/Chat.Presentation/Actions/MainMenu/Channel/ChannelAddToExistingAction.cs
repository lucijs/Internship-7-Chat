using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelAddToExistingAction : IAction
    {
        public int MenuIndex { get; set; }

        public string Name { get; set; } = "Enter existing channel";

        public void Open()
        { 
            
        }
    }
}
