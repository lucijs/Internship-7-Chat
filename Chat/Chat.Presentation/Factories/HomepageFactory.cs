using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.Homepage.Login;
using Chat.Presentation.Actions.Homepage.SingIn;
using Chat.Presentation.Actions;
using Chat.Presentation.Extensions;
using TodoApp.Domain.Factories;
using Chat.Domain.Repositorioes;

namespace Chat.Presentation.Factories
{
    public class HomepageFactory
    {
        public static IList<IAction> CreateActions()
        {
            var actions = new List<IAction>
        {
            new LoginAction(RepositoryFactory.Create<UserRepository>()),
            new SingInAction(RepositoryFactory.Create<UserRepository>()),
            new ExitMenuAction(),
        };

            actions.SetActionIndexes();

            return actions;
        }
    }
}
