using Chat.Domain.Enums;
using Chat.Data.Entities.Models;
using Chat.Data.Entities;

namespace Chat.Domain.Repositorioes
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(ChatDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(User user)
        {
            DbContext.Users.Add(user);

            return SaveChanges();
        }

        public ResponseResultType Delete(int id)
        {
            var customerToDelete = GetById(id);
            if (customerToDelete is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Users.Remove(customerToDelete);

            return SaveChanges();
        }

        public ResponseResultType Update(User user, int id)
        {
            var userToUpdate = GetById(id);
            if (userToUpdate is null)
            {
                return ResponseResultType.NotFound;
            }

            userToUpdate.Email = user.Email;
            userToUpdate.Password = user.Password;

            return SaveChanges();
        }
        public User? GetByEmailAndPassword(string email, string password) => DbContext.Users.FirstOrDefault(u => u.Password == password && u.Email == email);
        public User? GetById(int id) => DbContext.Users.FirstOrDefault(u => u.Id == id);
        public User? GetByEmail(string email) => DbContext.Users.FirstOrDefault(u => u.Email == email);
        public ICollection<User> GetAll() => DbContext.Users.ToList();

        public ICollection<Channel> UserInChannels(int userId)
        {
            var channels = DbContext.Channels
                .Where(c => c.ChannelUsers.Any(cu => cu.UserId == userId))
                .ToList();

            return channels;
        }
        public ICollection<Channel> UserNotInChannels(int userId)
        {
            var channels = DbContext.Channels
                .Where(c => !UserInChannels(userId).Contains(c))
                .ToList();

            return channels;
        }
    }
}
