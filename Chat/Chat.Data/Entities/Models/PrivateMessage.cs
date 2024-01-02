namespace Chat.Data.Entities.Models
{
    public class PrivateMessage
    {
        public int Id { get; set; }

        public string? Content { get; set; } 

        public int UserSentId { get; set; }
        public User? UserSent { get; set; }

        public int UserRecievedId { get; set; }
        public User? UserReceived { get; set; }

        public DateTime TimeSent { get; set; }
    }
}
