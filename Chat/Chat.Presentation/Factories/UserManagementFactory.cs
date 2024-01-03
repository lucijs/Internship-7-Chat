using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.UserManagement;
using Chat.Presentation.Actions;

namespace Chat.Presentation.Factories
{
    public class UserManagementFactory
    {
        public static UserManagementAction Create()
        {
            var actions = new List<IAction>
        {
            new UserManagementDeleteAction(),
            new UserManagementChangeEmailAction(),
            new UserManagementAddAdminAction(),
            new ExitMenuAction()
        };

            var menuAction = new UserManagementAction(actions);
            return menuAction;
        }
    }
}
