using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.Settings
{
    public class SettingsAction : BaseMenuAction
    {
        public SettingsAction(IList<IAction> actions) : base(actions)
        {
            Name = "Settings";
        }

        public override void Open()
        {
            Console.WriteLine("Settings");
            base.Open();
        }
    }
}
