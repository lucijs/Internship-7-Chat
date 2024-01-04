using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.Settings
{
    public class SettingsChangePasswordAction : IAction
    {
        public string Name { get; set; } = "New password";
        public User User { get; set; }
        private readonly UserRepository _userRepository;

        public SettingsChangePasswordAction(User user, UserRepository userRepository)
        {
            User = user;
            _userRepository = userRepository;

        }
        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            var newPassword = ActionExtensions.CorrectPasswordChoice();
            var updatedUser = new User(User.Email,newPassword );
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
