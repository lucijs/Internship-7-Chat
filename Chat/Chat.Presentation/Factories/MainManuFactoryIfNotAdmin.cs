using Chat.Data.Entities.Models;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;

namespace Chat.Presentation.Factories
{
    public class MainMenuFactoryIfNotAdmin
    {
        public static IList<IAction> CreateActions(User user)
        {
            var actions = new List<IAction>
        {
            ChannelFactory.Create(user),
            PrivateMessagesFactory.Create(user),
            SettingsFactory.Create(user),
            LogOutFactory.Create(user)
        };

            actions.SetActionIndexes();

            return actions;
        }
    }
}
