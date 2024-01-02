namespace Chat.Data.Entities.Models
{
    public class MessagesInTheChannel
    {
        public int Id { get; set; }
        public string? Content { get; set; } 

        public int ChannelUserId { get; set; }
        
        public ChannelUser? ChannelUser { get; set; }

        public DateTime TimeSent { get; set; }
    }
}