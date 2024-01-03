using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;


namespace Chat.Presentation.Actions.Homepage.SingIn
{
    public class SingInAction : IAction
    {
        public string Name { get; set; } = "Sing in";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.WriteLine("Sing in");

            ActionExtensions.PrintActions();

        }

       
    }
}
