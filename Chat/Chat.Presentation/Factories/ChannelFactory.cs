using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions;
using Chat.Presentation.Actions.MainMenu.Channel;

namespace Chat.Presentation.Factories
{
    public class ChannelFactory
    {
        public static ChannelAction Create()
        {
            var actions = new List<IAction>
        {
            new ChannelNewAction(),
            new ChannelAddToExistingAction(),
            new ChannelReadMessages(),
            new ExitMenuAction()
        };

            var menuAction = new ChannelAction(actions);
            return menuAction;
        }
    }
}
