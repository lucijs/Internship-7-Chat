using Chat.Data.Entities.Models;

namespace Chat.Presentation.Abstractions
{
    public interface IAction
    {
        string Name { get; set; }

        int MenuIndex { get; set; }

        User User { get; set; }

        void Open();
    }
}
