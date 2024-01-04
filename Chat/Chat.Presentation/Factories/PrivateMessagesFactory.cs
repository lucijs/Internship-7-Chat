using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.PrivateMessage;
using Chat.Presentation.Actions;
using Chat.Data.Entities.Models;
using TodoApp.Domain.Factories;
using Chat.Domain.Repositorioes;

namespace Chat.Presentation.Factories
{
    public class PrivateMessagesFactory
    {
        public static PrivateMessageAction Create(User user)
        {
            var actions = new List<IAction>
        {
            new PrivateMessagesNewAction(user, RepositoryFactory.Create<UserRepository>(),RepositoryFactory.Create<PrivateMessageRepository>()),
            new PrivateMessageExistingAction(user, RepositoryFactory.Create<UserRepository>(), RepositoryFactory.Create<PrivateMessageRepository>()),
            new ExitMenuAction()
        };

            var menuAction = new PrivateMessageAction(actions);
            return menuAction;
        }
    }
}
