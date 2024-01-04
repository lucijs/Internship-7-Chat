using Chat.Data.Entities.Models;
using Chat.Data.Entities;
using Chat.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Chat.Domain.Repositorioes
{
    public class PrivateMessageRepository : BaseRepository
    {
        public PrivateMessageRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int userSentId, int userReceivedId, string content)
        {
            var message = new PrivateMessage
            {
                UserReceivedId= userReceivedId,
                UserSentId=userSentId,
                Content=content,
                TimeSent=DateTime.UtcNow
            };
            DbContext.PrivateMessages.Add(message);
 //           var usersChanged = DbContext.Users.Where(u => u.Id == userReceivedId || u.Id == userSentId).ToList();
 //           foreach (var user in usersChanged)
 //           { 
 //               user.DirectMessages.Add(message);
 //               foreach(var u in user.DirectMessages)
 //                   Console.WriteLine(u.Content);
 //
 //               Console.ReadKey();
 //               //var reposnseResult = DbContext.Users.Update(user);
 //           }
            
            return SaveChanges();
        }

        public ICollection<PrivateMessage> GetAll() => DbContext.PrivateMessages.OrderByDescending(pm=>pm.TimeSent).ToList();

        public ICollection<PrivateMessage> GetByIds(int logedInUserId, int choosenUserId)
        {
            var messages = DbContext.PrivateMessages.OrderBy(pm=>pm.TimeSent).Where(pm => (pm.UserSentId == logedInUserId && pm.UserReceivedId == choosenUserId) || (pm.UserSentId == choosenUserId && pm.UserReceivedId == logedInUserId)).ToList();
            return messages;
        }
    }
}
