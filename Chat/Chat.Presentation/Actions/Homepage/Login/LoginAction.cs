using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;

namespace Chat.Presentation.Actions.Homepage.Login
{
    public class LoginAction : IAction
    {
        public string Name { get; set; } = "Log in";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("Email");

            ActionExtensions.PrintActions();

        }
    }
}
