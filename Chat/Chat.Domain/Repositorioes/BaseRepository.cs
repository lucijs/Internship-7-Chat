using Chat.Domain.Enums;
using Chat.Data.Entities;
namespace Chat.Domain.Repositorioes
{
    public class BaseRepository
    {
        protected readonly ChatDbContext DbContext;

        protected BaseRepository(ChatDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected ResponseResultType SaveChanges()
        {
            var hasChanges = DbContext.SaveChanges() > 0;
            if (hasChanges)
                return ResponseResultType.Success;

            return ResponseResultType.NoChanges;
        }
    }
}
