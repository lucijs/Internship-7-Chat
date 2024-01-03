using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementDeleteAction : IAction
    {
        public string Name { get; set; } = "Delete account";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("izbrisi account");
        }
    }
}
