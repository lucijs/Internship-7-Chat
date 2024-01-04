using Chat.Data.Entities.Models;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions;
using Chat.Presentation.Actions.MainMenu.LogOut;
namespace Chat.Presentation.Factories
{
    public class LogOutFactory
    {
        public static LogOutAction Create(User user)
        {
            var actions = new List<IAction>
        {
            new LogOutAction(),
            new ExitMenuAction()
        };

            var menuAction = new LogOutAction();
            return menuAction;
        }
    }
}
