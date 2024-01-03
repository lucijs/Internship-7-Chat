using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.Homepage.Login;
using Chat.Presentation.Actions.Homepage.SingIn;
using Chat.Presentation.Actions;
using Chat.Presentation.Extensions;

namespace Chat.Presentation.Factories
{
    public class HomepageFactory
    {
        public static IList<IAction> CreateActions()
        {
            var actions = new List<IAction>
        {
            new LoginAction(),
            new SingInAction(),
            new ExitMenuAction(),
        };

            actions.SetActionIndexes();

            return actions;
        }
    }
}
