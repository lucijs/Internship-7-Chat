using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;

namespace Chat.Presentation.Factories
{
    public class MainMenuFactory
    {
        public static IList<IAction> CreateActions()
        {
            var actions = new List<IAction>
        {
            ChannelFactory.Create(),
            PrivateMessagesFactory.Create(),
            UserManagementFactory.Create(),
            SettingsFactory.Create(),
            LogOutFactory.Create()
        };

            actions.SetActionIndexes();

            return actions;
        }
    }
}
