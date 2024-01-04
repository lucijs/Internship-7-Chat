using Chat.Data.Entities.Models;
using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.PrivateMessage
{
    public class PrivateMessageExistingAction : IAction
    {
        public string Name { get; set; } = "Existing direct messages";
        public User User { get; set; }
        public int MenuIndex { get; set; }
        public PrivateMessageExistingAction(User user)
        {
            User = user;
        }
        public void Open()
        {
            Console.Clear();
            Console.WriteLine("stare poruke");
        }
    }
}
