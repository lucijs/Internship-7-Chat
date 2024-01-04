using Chat.Data.Entities.Models;
using Chat.Presentation.Abstractions;
namespace Chat.Presentation.Actions
{
    public class ExitMenuAction : IAction
    {
        public User User { get; set; }
        public int MenuIndex { get; set; }
        public string Name { get; set; } = "Exit";

        public ExitMenuAction()
        {
        }

        public void Open()
        {
        }
    }
}
