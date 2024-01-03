using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementChangeEmailAction : IAction
    {
        public string Name { get; set; } = "Change email";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("primini email");
        }
    }
}
