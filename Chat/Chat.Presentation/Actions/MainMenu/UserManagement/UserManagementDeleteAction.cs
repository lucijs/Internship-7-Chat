using Chat.Data.Entities.Models;
using Chat.Domain.Enums;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementDeleteAction : IAction
    {
        public string Name { get; set; } = "Delete account";
        public User User { get; set; }
        public User ChoosenUser { get; set; }
        private readonly UserRepository _userRepository;


        public UserManagementDeleteAction(User user, User choosenUser, UserRepository userRepository)
        {
            User = user;
            _userRepository = userRepository;
            ChoosenUser = choosenUser;
        }
        public int MenuIndex { get; set; }

        public void Open()
        {
            var responseResult = _userRepository.Delete(ChoosenUser.Id);

            switch (responseResult)
            {
                case ResponseResultType.Success:
                    Console.WriteLine("Customer deleted successfully!");
                    break;
                case ResponseResultType.NotFound:
                    Console.WriteLine("Customer with inputted id does not exist.");
                    break;
                case ResponseResultType.NoChanges:
                    Console.WriteLine("No changes applied");
                    break;
                default:
                    Console.WriteLine("Error occurred while updating customer");
                    break;
            }

            Console.ReadLine();
            Console.Clear();


        }
    }
}
