using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.Settings;
using Chat.Presentation.Actions;

namespace Chat.Presentation.Factories
{
    public class SettingsFactory
    {
        public static SettingsAction Create()
        {
            var actions = new List<IAction>
        {
            new SettingsChangeEmailAction(),
            new SettingsChangePasswordAction(),
            new ExitMenuAction()
        };

            var menuAction = new SettingsAction(actions);
            return menuAction;
        }
    }
}
