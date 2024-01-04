using Chat.Data.Entities;
using Chat.Data.Entities.Models;
using Chat.Domain.Enums;
using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;

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

        public ICollection<ChannelMessages> GetMessagesByChannelName(string channelName)
        {
            var messagesInTheChannel = DbContext.Channels
                .Include(c => c.MessagesInTheChannel)
                .Select(c => new ChannelMessages
                {
                    Id = c.Id,
                    Name = channelName,
                    Messages = c.MessagesInTheChannel.ToList(),
                })
                .Where(c => c.Name == channelName)
                .ToList();

            return messagesInTheChannel;
        }
    }
}
