using Chat.Data.Entities.Models;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;

namespace Chat.Presentation.Actions.MainMenu.LogOut 
{
    public class LogOutAction : IAction
    {
        public string Name { get; set; } = "Log out";
        public User User { get; set; }
        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            ActionExtensions.PrintActions();
        }
    }
}
