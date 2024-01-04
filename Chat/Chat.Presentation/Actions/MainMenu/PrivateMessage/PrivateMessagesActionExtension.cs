using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Helpers;


namespace Chat.Presentation.Actions.MainMenu.PrivateMessage
{
    public static class PrivateMessagesActionExtension
    {
        public static bool IsCorrectUser(User user)
        {
            if (user == null)
            {
                Console.WriteLine($"There is no user with this email.");
                Console.ReadLine();
                return false;
            }
            return true;
        }
        public static string GetEmail(ICollection<User> users)
        {
            Writer.Write(users);
            Console.ReadKey();
            Reader.TryReadLine("Write the email of a user you want to send direct message to.", out string email);
            return email;
        }
        public static void WriteNewMessages(User User, User user, ICollection<Chat.Data.Entities.Models.PrivateMessage> messages)
        {            
            foreach (var m in messages)
            {
                if (m.UserSentId == User.Id)
                    Writer.Write(m, User.Email);
                else
                    Writer.Write(m, user.Email);
            }
            Console.ReadKey();
            return;
        }
    }
}
