namespace Chat.Data.Entities.Models
{
    public class Channel
    {
        public Channel(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ChannelUser> ChannelUsers { get; } = new List<ChannelUser>();
        public ICollection<MessagesInTheChannel> MessagesInTheChannel { get; } = new List<MessagesInTheChannel>();
    }
}
