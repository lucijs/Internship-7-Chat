using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.UserManagement;
using Chat.Presentation.Actions;
using TodoApp.Domain.Factories;

namespace Chat.Presentation.Factories
{
    public class UserManagementAllUsersFactory
    {
        public static UserManagementAction Create(User user)
        {
            var actions = new List<IAction>
        {
            new UserManagementListAllUsersAction(user, RepositoryFactory.Create<UserRepository>()),
            new ExitMenuAction()
        };

            var menuAction = new UserManagementAction(actions);
            return menuAction;
        }
    }
}
