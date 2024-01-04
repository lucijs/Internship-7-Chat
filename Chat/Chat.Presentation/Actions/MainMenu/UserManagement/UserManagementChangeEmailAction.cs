using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementChangeEmailAction : IAction
    {
        public string Name { get; set; } = "Change email";
        public User User { get; set; }
        private readonly UserRepository _userRepository;

        public User ChoosenUser { get; set; }

        public UserManagementChangeEmailAction(User user, User choosenUser, UserRepository userRepository)
        {
            User = user;
            _userRepository = userRepository;
            ChoosenUser = choosenUser;
        }
        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            var newEmail = ActionExtensions.CorrectEmailChoice();
            User? user = _userRepository.GetByEmail(newEmail);
            if (user != null)
            {
                Writer.Error("There is already a user with that username.");
                return;
            }
            var updatedUser = new User(newEmail, ChoosenUser.Password);
            var responseReturn = _userRepository.Update(updatedUser, ChoosenUser.Id);
            if (responseReturn is Domain.Enums.ResponseResultType.Success)
            {
                var choosenUser = _userRepository.GetById(ChoosenUser.Id);
                Writer.Write(choosenUser);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Failed to update user, no changes saved!");
            Console.ReadLine();
        }
    }
}
