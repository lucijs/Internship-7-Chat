using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Extensions;
using Chat.Presentation.Helpers;


namespace Chat.Presentation.Actions.Homepage.SingIn
{
    public class SingInAction : IAction
    {
        public string Name { get; set; } = "Sign in";
        private readonly UserRepository _userRepository;
        public User User { get; set; }
        public int MenuIndex { get; set; }
        public SingInAction(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Open()
        {
            var email = ActionExtensions.CorrectEmailChoice();
            User? user = _userRepository.GetByEmail(email);
            if (user != null)
            {
                Writer.Error("There is already a user with that username.");
                ActionExtensions.PrintActions();
            }
            var password = ActionExtensions.CorrectPasswordChoice();
            if (!Writer.GenerateRandomString())
                ActionExtensions.PrintActions();
            var newUser = new User(email, password);
            var responseResult = _userRepository.Add(newUser);
            if(responseResult is Domain.Enums.ResponseResultType.Success)
            {
                Writer.Write(newUser);
                Console.ReadKey();
                if (newUser.IsAdmin)
            { 
                ActionExtensions.PrintActions(newUser, true);
                return;
            }
            ActionExtensions.PrintActions(newUser);
            }

            Console.WriteLine("Failed to add user, no changes saved!");
            Console.ReadLine();

        }
    }
}
