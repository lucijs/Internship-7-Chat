using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.Settings;
using Chat.Presentation.Actions;
using Chat.Data.Entities.Models;
using TodoApp.Domain.Factories;
using Chat.Domain.Repositorioes;

namespace Chat.Presentation.Factories
{
    public class SettingsFactory
    {
        public static SettingsAction Create(User user)
        {
            var actions = new List<IAction>
        {
            new SettingsChangeEmailAction(user, RepositoryFactory.Create<UserRepository>()),
            new SettingsChangePasswordAction(user, RepositoryFactory.Create<UserRepository>()),
            new ExitMenuAction()
        };

            var menuAction = new SettingsAction(actions);
            return menuAction;
        }
    }
}
