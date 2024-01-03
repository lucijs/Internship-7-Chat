using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelNewAction: IAction
    {
        public int MenuIndex { get; set; }

        public string Name { get; set; } = "Create new channel";

        public void Open()
        {

        }
    }
}
