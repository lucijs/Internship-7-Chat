using Chat.Presentation.Actions;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Factories;
using Chat.Data.Entities.Models;
using Chat.Presentation.Helpers;
using Chat.Domain.Repositorioes;

namespace Chat.Presentation.Extensions
{
    public static class ActionExtensions
    {
        public static void PrintActionsAndOpen(this IList<IAction> actions)
        {
            const string INVALID_INPUT_MSG = "Please type in number!";
            const string INVALID_ACTION_MSG = "Please select valid action!";

            var isExitSelected = false;
            do
            {
                PrintActions(actions);

                var isValidInput = int.TryParse(Console.ReadLine(), out var actionIndex);
                if (!isValidInput)
                {
                    PrintErrorMessage(INVALID_INPUT_MSG);
                    continue;
                }

                var action = actions.FirstOrDefault(a => a.MenuIndex == actionIndex);
                if (action is null)
                {
                    PrintErrorMessage(INVALID_ACTION_MSG);
                    continue;
                }

                action.Open();

                isExitSelected = action is ExitMenuAction;
            } while (!isExitSelected);
        }

        public static void SetActionIndexes(this IList<IAction> actions)
        {
            var index = 0;
            foreach (var action in actions)
            {
                action.MenuIndex = ++index;
            }
        }
        public static void PrintActions(User user, bool value)
        {
            var mainMenuActions = MainMenuFactoryIfAdmin.CreateActions(user);
            mainMenuActions.PrintActionsAndOpen();
        }
        public static void PrintActions(User user)
        {
            var mainMenuActions = MainMenuFactoryIfNotAdmin.CreateActions(user);
            mainMenuActions.PrintActionsAndOpen();
        }

        public static void PrintActions(User user, User choosenUser)
        {
            var mainMenuActions = UserManagementOptionsFactory.CreateActions(user, choosenUser);
            mainMenuActions.PrintActionsAndOpen();
        }
        public static void PrintActions()
        {
            var homepageActions = HomepageFactory.CreateActions();
            homepageActions.PrintActionsAndOpen();
        }
        private static void PrintActions(IList<IAction> actions)
        {
            Console.Clear();

            foreach (var action in actions)
            {
                Console.WriteLine($"{action.MenuIndex}. {action.Name}");
            }
        }

        private static void PrintErrorMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static string? EmailChoice()
        {
            Console.Clear();
            string? email = Reader.ReadInput();
            return email;
        }
        public static string? IsCorrectPassword()
        {
            Reader.TryReadLine("Enter your choosen password", out string password);
            Reader.TryReadLine("Enter your choosen password again", out string secondTryPassword);
            if (password == secondTryPassword)
                return password;
            return null;
        }
        public static string CorrectPasswordChoice()
        {
            string? password = IsCorrectPassword();
            while (password == null)
            {
                bool cont = Reader.DoYouWantToContinue();
                if (cont)
                    password = IsCorrectPassword();
                else
                    PrintActions();
            }
            return password;
        }
        public static string CorrectEmailChoice()
        {
            string? email = Reader.ReadInput();
            while (email == null)
            {
                bool cont = Reader.DoYouWantToContinue();
                if (cont)
                    email = EmailChoice();
                else
                    PrintActions();
            }
            return email;
        }
    }
}
