using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.LogOut 
{
    public class LogOutAction : IAction
    {
        public string Name { get; set; } = "Log out";

        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            Console.WriteLine("logautiramo se");
            Console.ReadKey();
        }
    }
}
