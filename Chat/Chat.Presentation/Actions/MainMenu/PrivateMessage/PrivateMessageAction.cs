using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.PrivateMessage
{
    public class PrivateMessageAction: BaseMenuAction
    {
        public PrivateMessageAction(IList<IAction> actions) : base(actions)
        {
            Name = "Direct messages";
        }

        public override void Open()
        {
            Console.WriteLine("Direct messages");
            base.Open();
        }
    }
}
