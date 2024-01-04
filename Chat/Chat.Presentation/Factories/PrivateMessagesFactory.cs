using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.PrivateMessage;
using Chat.Presentation.Actions;
using Chat.Data.Entities.Models;

namespace Chat.Presentation.Factories
{
    public class PrivateMessagesFactory
    {
        public static PrivateMessageAction Create(User user)
        {
            var actions = new List<IAction>
        {
            new PrivateMessagesNewAction(user),
            new PrivateMessageExistingAction(user),
            new ExitMenuAction()
        };

            var menuAction = new PrivateMessageAction(actions);
            return menuAction;
        }
    }
}
