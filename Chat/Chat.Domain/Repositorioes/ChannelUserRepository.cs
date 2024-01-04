using Chat.Data.Entities.Models;
using Chat.Data.Entities;
using Chat.Domain.Enums;
using System.ComponentModel;

namespace Chat.Domain.Repositorioes
{
    public class ChannelUserRepository : BaseRepository
    {
        public ChannelUserRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int channelId, int userId)
        {
            var channelUser = new ChannelUser
            {
                UserId = userId,
                ChannelId = channelId,
                MessagesInTheChannel = new List<MessagesInTheChannel>(),

            };

            DbContext.ChannelUsers.Add(channelUser);

            return SaveChanges();
        }
        public ChannelUser? GetByChannelIdAndUserId(int userId, int channelId)
        {
            var channelUser = DbContext.ChannelUsers.FirstOrDefault(u => u.UserId==userId && u.ChannelId==channelId);
            return channelUser;
        }
        public ChannelUser? GetById(int id)
        { 
            var channelUser = DbContext.ChannelUsers.FirstOrDefault(u => u.Id == id);
            return channelUser;
        }
    }
}
