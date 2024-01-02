namespace Chat.Data.Entities.Models
{
    public class ChannelUser
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public Channel Channel { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<MessagesInTheChannel> MessagesInTheChannel { get; set; } = new List<MessagesInTheChannel>();
    }
}
