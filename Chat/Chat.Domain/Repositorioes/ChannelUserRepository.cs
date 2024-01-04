using Chat.Data.Entities.Models;
using Chat.Data.Entities;
using Chat.Domain.Enums;

namespace Chat.Domain.Repositorioes
{
    public class ChannelUserRepository : BaseRepository
    {
        public ChannelUserRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Channel channel, int userId)
        {
            var channelUser = new ChannelUser
            {
                Channel = channel,
                UserId = userId,
                ChannelId = channel.Id,
                Id = FirstNextIndex()
            };

            DbContext.ChannelUsers.Add(channelUser);

            return SaveChanges();
        }

        public int FirstNextIndex()
        {
            var id = 0;
            foreach(var channelUser in DbContext.ChannelUsers)
                if(channelUser.Id>id)
                    id = channelUser.Id;
            return id+1;
        }
    }
}
