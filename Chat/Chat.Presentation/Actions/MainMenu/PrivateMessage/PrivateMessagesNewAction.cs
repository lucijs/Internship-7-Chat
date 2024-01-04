using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.PrivateMessage
{
    public class PrivateMessagesNewAction : IAction
    {
        public string Name { get; set; } = "New message";
        public User User { get; set; }
        private readonly PrivateMessageRepository _privateMessageRepository;
        private readonly UserRepository _userRepository;

        public PrivateMessagesNewAction(User user, UserRepository userRepository, PrivateMessageRepository privateMessageRepository)
        {
            User = user;
            _userRepository = userRepository;
            _privateMessageRepository = privateMessageRepository;
        }
        public int MenuIndex { get; set; }
        public void Open()
        {
            Console.Clear();
            var users = _userRepository.GetAllBesideOne(User.Id);
            var email = PrivateMessagesActionExtension.GetEmail(users);
            var userOther = _userRepository.GetByEmail(email);
            if (!PrivateMessagesActionExtension.IsCorrectUser(userOther))
                return;
            var messages = _privateMessageRepository.GetByIds(User.Id, userOther.Id);
            PrivateMessagesActionExtension.WriteNewMessages(User, userOther, messages);

            var correctInput= Reader.NewMessage(out string message);
            if (!correctInput)
            {
                Writer.Error("Incorrect message input");
                return;
            }
            var resume = Reader.DoYouWantToContinue(message);
            if (!resume)
                return;
            var responseReturn = _privateMessageRepository.Add(User.Id,userOther.Id,message);
            if (responseReturn is Domain.Enums.ResponseResultType.Success)
            {
                Console.Clear();
                var updatedMessages = _privateMessageRepository.GetByIds(User.Id, userOther.Id);
                PrivateMessagesActionExtension.WriteNewMessages(User, userOther, updatedMessages);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Failed to update user, no changes saved!");
            Console.ReadLine();
        }
    }
}
