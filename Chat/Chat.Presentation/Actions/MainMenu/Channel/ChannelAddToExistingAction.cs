using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelAddToExistingAction : IAction
    {
        private readonly UserRepository _userRepository;
        private readonly ChannelUserRepository _channelUserRepository;
        private readonly ChannelRepository _channelRepository;
        public User User { get; set; }

        public ChannelAddToExistingAction(UserRepository userRepository, ChannelUserRepository channelUserRepository, ChannelRepository channelRepository,User user)
        {
            _userRepository = userRepository;
            _channelUserRepository = channelUserRepository;
            _channelRepository = channelRepository;
            User = user;

        }
        public int MenuIndex { get; set; }

        public string Name { get; set; } = "Enter existing channel";

        public void Open()
        {
            var channelsUserCanBeAddedTo = _userRepository.UserNotInChannels(User.Id);
            foreach (var c in channelsUserCanBeAddedTo)
            {
                Writer.Write(c, _channelRepository.NumberOfMembers(c));
            }
            Reader.TryReadLine("\n\nChoose the channel you want to enter", out var name);
            var channel = _channelRepository.GetByName(name);
            if (channel == null)
            {
                Console.WriteLine("Channel with inputted name does not exist.");
                Console.ReadLine();
                return;
            }
            Console.ReadKey();
            var responseResult = _channelUserRepository.Add(channel.Id, User.Id);
            if (responseResult is Domain.Enums.ResponseResultType.Success)
            {
                Writer.Write(User);
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Couldn't add the user to that channel.");
            Console.ReadLine();
            return;
        }
    }
}
