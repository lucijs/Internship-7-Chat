using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelAction : BaseMenuAction
    {
        public ChannelAction(IList<IAction> actions) : base(actions)
        {
            Name = "Group channels";
        }

        public override void Open()
        {
            Console.WriteLine("Group channel options");
            base.Open();
        }
    }
}
