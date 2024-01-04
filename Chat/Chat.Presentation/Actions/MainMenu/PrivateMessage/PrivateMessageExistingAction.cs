using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.PrivateMessage
{
    public class PrivateMessageExistingAction : IAction
    {
        public string Name { get; set; } = "Existing direct messages";
        public User User { get; set; }
        private readonly UserRepository _userRepository;
        private readonly PrivateMessageRepository _privateMessageRepository;

        public int MenuIndex { get; set; }
        public PrivateMessageExistingAction(User user, UserRepository userRepository, PrivateMessageRepository privateMessageRepository)
        {
            User = user;
            _userRepository = userRepository;
            _privateMessageRepository = privateMessageRepository;
        }
        public void Open()
        {
            Console.Clear();
            var users = _userRepository.GetAllUserTexted(User.Id);
            if (users.Count < 0)
                return;
            var email = PrivateMessagesActionExtension.GetEmail(users);

            var user = _userRepository.GetByEmail(email);
                 
            if (!PrivateMessagesActionExtension.IsCorrectUser(user))
                return;
            var messages = _privateMessageRepository.GetByIds(User.Id, user.Id);
            PrivateMessagesActionExtension.WriteNewMessages(User, user, messages);

            var correctInput = Reader.NewMessage(out string message);
            if (!correctInput)
            {
                Writer.Error("Incorrect message input");
                return;
            }
            var resume = Reader.DoYouWantToContinue(message);
            if (!resume)
                return;
            var responseReturn = _privateMessageRepository.Add(User.Id, user.Id, message);
            if (responseReturn is Domain.Enums.ResponseResultType.Success)
            {
                Console.Clear();
                var updatedMessages = _privateMessageRepository.GetByIds(User.Id, user.Id);
                PrivateMessagesActionExtension.WriteNewMessages(User, user, updatedMessages);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Failed to update user, no changes saved!");
            Console.ReadLine();
        }
    }
}
