using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.Settings
{
    public class SettingsChangeEmailAction : IAction
    {
        public string Name { get; set; } = "Change email";
        public User User { get; set; } 
        private readonly UserRepository _userRepository;

        public SettingsChangeEmailAction(User user, UserRepository userRepository)
        {
            User = user;
            _userRepository = userRepository;

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
            var updatedUser = new User(newEmail, User.Password);
            var responseReturn = _userRepository.Update(updatedUser, User.Id);
            if (responseReturn is Domain.Enums.ResponseResultType.Success)
            {
                Writer.Write(User);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Failed to update user, no changes saved!");
            Console.ReadLine();
        }
    }
}
