using Chat.Data.Entities.Models;

namespace Chat.Domain.Models
{
    public class ChannelMessages
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public ICollection<MessagesInTheChannel> Messages { get; set; } = null!;
    }
}
