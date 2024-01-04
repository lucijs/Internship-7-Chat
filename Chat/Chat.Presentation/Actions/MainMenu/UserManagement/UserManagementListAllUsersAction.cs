using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementListAllUsersAction : IAction
    {
        public string Name { get; set; } = "List all users";
        public User User { get; set; }
        private readonly UserRepository _userRepository;

        public UserManagementListAllUsersAction(User user, UserRepository userRepository)
        {
            User = user;
            _userRepository = userRepository;
        }
        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();
            var users = _userRepository.GetAll();
            Writer.Write(users);

            Reader.TryReadNumber("Enter the id number of user you want to change", out int id);

            var choosenUser = _userRepository.GetById(id);
            if (choosenUser != null)
            {
                Console.Clear();
                Writer.Write(choosenUser);
                ActionExtensions.PrintActions(User,choosenUser);
            }

            Console.ReadKey ();
        }
    }
}
