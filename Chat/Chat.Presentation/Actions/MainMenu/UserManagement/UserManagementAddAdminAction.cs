using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementAddAdminAction : IAction
    {
        public string Name { get; set; } = "Add new admin";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("novi admin");
        }
    }
}
