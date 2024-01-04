using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementAddAdminAction : IAction
    {
        public string Name { get; set; } = "Add new admin";
        public User User { get; set; }
        public User ChoosenUser {  get; set; }
        private readonly UserRepository _userRepository;

        public UserManagementAddAdminAction(User user, User choosenUser, UserRepository userRepository)
        {
            User = user;
            _userRepository = userRepository;
            ChoosenUser = choosenUser;

        }
        public int MenuIndex { get; set; }

        public void Open()
        {
            var responseReturn = _userRepository.Update(ChoosenUser, ChoosenUser.Id, true);
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
