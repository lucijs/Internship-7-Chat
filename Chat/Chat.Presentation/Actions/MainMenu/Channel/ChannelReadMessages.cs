using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelReadMessages : IAction
    {
        public int MenuIndex { get; set; }

        public string Name { get; set; } = "Read messages";

        public void Open()
        {

        }
    }
}
