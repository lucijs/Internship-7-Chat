using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.UserManagement;
using Chat.Presentation.Actions;
using Chat.Data.Entities.Models;
using TodoApp.Domain.Factories;
using Chat.Domain.Repositorioes;

namespace Chat.Presentation.Factories
{
    public class UserManagementOptionsFactory
    {
        public static UserManagementAction Create(User user)
        {
            var actions = new List<IAction>
        {
            new UserManagementDeleteAction(user),
            new UserManagementChangeEmailAction(user),
            new UserManagementAddAdminAction(user, RepositoryFactory.Create<UserRepository>()),
            new ExitMenuAction()
        };

            var menuAction = new UserManagementAction(actions);
            return menuAction;
        }
    }
}
