using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.Homepage.Login
{
    public class LoginAction : IAction
    {
        private readonly UserRepository _userRepository;
        public string Name { get; set; } = "Log in";
        public User User { get; set; }
        public int MenuIndex { get; set; }

        public LoginAction(UserRepository userRepository)
        { 
            _userRepository = userRepository;
        }
        public void Open()
        {
            User? user = FindUser();
            while (user == null) 
            {
                Thread.Sleep(30000);
                bool cont = Reader.DoYouWantToContinue();
                if (cont)
                    user = FindUser();
                else
                    ActionExtensions.PrintActions();
            }
            if (user.IsAdmin)
            { 
                ActionExtensions.PrintActions(user, true);
                return;
            }
            ActionExtensions.PrintActions(user);

        }

        public User? FindUser()
        {
            Console.Clear();
            Reader.TryReadLine("Enter your email", out string email);
            Reader.TryReadLine("Enter your password", out string password);

            User? user = _userRepository.GetByEmailAndPassword(email, password);
            return user;
        }
    }
}
