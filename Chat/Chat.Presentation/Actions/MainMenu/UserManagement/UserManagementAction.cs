using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementAction : BaseMenuAction
    {
        public UserManagementAction(IList<IAction> actions) : base(actions)
        {
            Name = "User management";
        }

        public override void Open()
        {
            Console.WriteLine("user management");
            base.Open();
        }
    }
}
