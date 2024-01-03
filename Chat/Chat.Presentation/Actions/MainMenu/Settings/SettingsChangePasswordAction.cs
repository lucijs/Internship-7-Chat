using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.Settings
{
    public class SettingsChangePasswordAction : IAction
    {
        public string Name { get; set; } = "New password";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("nova lozinka");
        }
    }
}
