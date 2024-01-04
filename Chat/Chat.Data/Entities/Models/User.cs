namespace Chat.Data.Entities.Models
{
    public class User
    {
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public User(string email, string password, bool isAdmin)
        {
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool IsAdmin { get; set; } = false;

        public ICollection<MessagesInTheChannel> MessagesInTheChannel { get; } = new List<MessagesInTheChannel>();
        public ICollection<ChannelUser> UserChannels { get; } = new List<ChannelUser>();

        public ICollection<PrivateMessage> MessagesSent { get; } = new List<PrivateMessage>();

        public ICollection<PrivateMessage> MessagesReceived { get; } = new List<PrivateMessage>();
    }
}
