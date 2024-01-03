using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.PrivateMessage
{
    public class PrivateMessageExistingAction : IAction
    {
        public string Name { get; set; } = "Existing direct messages";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("stare poruke");
        }
    }
}
