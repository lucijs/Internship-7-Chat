using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions;
using Chat.Presentation.Actions.MainMenu.Channel;
using TodoApp.Domain.Factories;

namespace Chat.Presentation.Factories
{
    public class ChannelFactory
    {
        public static ChannelAction Create(User user)
        {
            var actions = new List<IAction>
        {
            new ChannelNewAction(RepositoryFactory.Create<ChannelRepository>(), RepositoryFactory.Create<ChannelUserRepository>(),user),
            new ChannelAddToExistingAction(RepositoryFactory.Create<UserRepository>(), RepositoryFactory.Create<ChannelUserRepository>(), RepositoryFactory.Create<ChannelRepository>(),user),
            new ChannelReadMessagesAction(RepositoryFactory.Create<ChannelUserRepository>(),RepositoryFactory.Create<UserRepository>(),RepositoryFactory.Create<ChannelRepository>(),RepositoryFactory.Create<MessagesInTheChannelRepository>(),user),
            new ExitMenuAction()
        };

            var menuAction = new ChannelAction(actions);
            return menuAction;
        }
    }
}
