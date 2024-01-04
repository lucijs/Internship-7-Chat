using Chat.Domain.Enums;
using Chat.Data.Entities.Models;
using Chat.Data.Entities;

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

        public Channel? GetByName(string name) => DbContext.Channels.FirstOrDefault(g => g.Name == name);

        public ICollection<Channel> GetAll() => DbContext.Channels.ToList();

    }
}
