using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.UserManagement;
using Chat.Presentation.Actions;
using Chat.Data.Entities.Models;
using TodoApp.Domain.Factories;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Extensions;

namespace Chat.Presentation.Factories
{
    public class UserManagementOptionsFactory
    {
        public static IList<IAction> CreateActions(User user, User choosenUser)
        {
            var actions = new List<IAction>
        {
            new UserManagementDeleteAction(user,choosenUser ,RepositoryFactory.Create<UserRepository>()),
            new UserManagementChangeEmailAction(user,choosenUser, RepositoryFactory.Create<UserRepository>()),
            new UserManagementAddAdminAction(user,choosenUser, RepositoryFactory.Create<UserRepository>()),
            new ExitMenuAction()
        };

            actions.SetActionIndexes();
            return actions;
        }
    }
}
