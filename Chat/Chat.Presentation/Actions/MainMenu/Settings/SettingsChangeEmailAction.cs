using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.Settings
{
    public class SettingsChangeEmailAction : IAction
    {
        public string Name { get; set; } = "Change email";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("nova email");
        }
    }
}
