﻿using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelAddToExistingAction : IAction
    {
        private readonly UserRepository _userRepository;
        private readonly ChannelUserRepository _channeluserRepository;
        private readonly ChannelRepository _channelRepository;
        public User User { get; set; }

        public ChannelAddToExistingAction(UserRepository userRepository, ChannelUserRepository channeluserRepository, ChannelRepository channelRepository,User user)
        {
            _userRepository = userRepository;
            _channeluserRepository = channeluserRepository;
            _channelRepository = channelRepository;
            User = user;

        }
        public int MenuIndex { get; set; }

        public string Name { get; set; } = "Enter existing channel";

        public void Open()
        {
            var channelsUserCanBeAddedTo = _userRepository.UserNotInChannels(User.Id);
            Writer.Write(channelsUserCanBeAddedTo);
            Reader.TryReadLine("\n\nChoose the channel you want to enter", out var name);
            var channel = _channelRepository.GetByName(name);
            if (channel is null)
            {
                Console.WriteLine("Channel with inputted name does not exist.");
                Console.ReadLine();
                return;
            }
            var responseResult = _channeluserRepository.Add(channel, User.Id);
            Console.ReadKey();
        }
    }
}
