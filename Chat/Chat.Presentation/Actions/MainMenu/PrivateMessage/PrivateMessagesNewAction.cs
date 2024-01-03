using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.PrivateMessage
{
    public class PrivateMessagesNewAction : IAction
    {
        public string Name { get; set; } = "New message";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("nova poruka");
        }
    }
}
