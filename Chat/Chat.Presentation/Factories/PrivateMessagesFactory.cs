using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.PrivateMessage;
using Chat.Presentation.Actions;

namespace Chat.Presentation.Factories
{
    public class PrivateMessagesFactory
    {
        public static PrivateMessageAction Create()
        {
            var actions = new List<IAction>
        {
            new PrivateMessagesNewAction(),
            new PrivateMessageExistingAction(),
            new ExitMenuAction()
        };

            var menuAction = new PrivateMessageAction(actions);
            return menuAction;
        }
    }
}
