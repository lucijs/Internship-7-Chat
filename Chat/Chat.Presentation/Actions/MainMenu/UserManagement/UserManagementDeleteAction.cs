using Chat.Data.Entities.Models;
using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementDeleteAction : IAction
    {
        public string Name { get; set; } = "Delete account";
        public User User { get; set; }
        public UserManagementDeleteAction(User user)
        {
            User = user;
        }
        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("izbrisi account");
        }
    }
}
