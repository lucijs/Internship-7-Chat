using Chat.Domain.Enums;
using Chat.Data.Entities.Models;
using Chat.Data.Entities;
using Chat.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Chat.Domain.Repositorioes
{
    public class ChannelRepository : BaseRepository
    {
        public ChannelRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Channel channel)
        {
            DbContext.Channels.Add(channel);
            return SaveChanges();
        }

        public Channel? GetByName(string name) => DbContext.Channels.FirstOrDefault(c => c.Name == name);

        public int NumberOfMembers(Channel channel)
        {
            var number = DbContext.ChannelUsers
                .Where(cu => cu.ChannelId == channel.Id)
                .Count();
            return number;

        }
    }
}
