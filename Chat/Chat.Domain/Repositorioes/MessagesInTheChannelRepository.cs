using Chat.Data.Entities;
using Chat.Data.Entities.Models;
using Chat.Domain.Enums;

namespace Chat.Domain.Repositorioes
{
    public class MessagesInTheChannelRepository : BaseRepository
    {
        public MessagesInTheChannelRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(MessagesInTheChannel newMessage)
        {             
            DbContext.MessagesInTheChannel.Add(newMessage);
            return SaveChanges();
        }
        public ICollection<MessagesInTheChannel> GetAll() => DbContext.MessagesInTheChannel.OrderBy(m => m.TimeSent).ToList();

    }
}
