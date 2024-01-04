﻿using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;

namespace Chat.Presentation.Actions.MainMenu.UserManagement
{
    public class UserManagementAddAdminAction : IAction
    {
        public string Name { get; set; } = "Add new admin";
        public User User { get; set; }
        private readonly UserRepository _userRepository;

        public UserManagementAddAdminAction(User user, UserRepository userRepository)
        {
            User = user;
            _userRepository = userRepository;
        }
        public int MenuIndex { get; set; }

        public void Open()
        {
            Console.Clear();

            Console.WriteLine("novi admin");
        }
    }
}
