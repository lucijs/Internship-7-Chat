using Chat.Data.Entities.Models;
using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementChangeEmailAction : IAction
    {
        public string Name { get; set; } = "Change email";
        public User User { get; set; }
        public UserManagementChangeEmailAction(User user)
        {
            User = user;
        }
        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("primini email");
        }
    }
}
