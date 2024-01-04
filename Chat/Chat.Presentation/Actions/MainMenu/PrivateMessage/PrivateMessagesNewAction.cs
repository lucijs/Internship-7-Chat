using Chat.Data.Entities.Models;
using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.PrivateMessage
{
    public class PrivateMessagesNewAction : IAction
    {
        public string Name { get; set; } = "New message";
        public User User { get; set; }
        public int MenuIndex { get; set; }
        public PrivateMessagesNewAction(User user)
        {
            User = user;
        }
        public void Open()
        {
            Console.Clear();
            Console.WriteLine("nova poruka");
        }
    }
}
