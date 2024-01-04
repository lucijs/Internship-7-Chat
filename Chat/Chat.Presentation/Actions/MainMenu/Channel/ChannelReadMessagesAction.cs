using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelReadMessagesAction : IAction
    {
        public int MenuIndex { get; set; }
        private readonly UserRepository _userRepository;
        private readonly ChannelRepository _channelRepository;
        private readonly MessagesInTheChannelRepository _messageRepository;

        public User User { get; set; }
        public string Name { get; set; } = "Read messages";
        public ChannelReadMessagesAction(UserRepository userRepository, ChannelRepository channelRepository,MessagesInTheChannelRepository messagesInTheChannelRepository, User user)
        {
            _userRepository = userRepository;
            _channelRepository = channelRepository;
            _messageRepository = messagesInTheChannelRepository;
            User = user;
        }
        public void Open()
        {
            var channelsUserIsIn = _userRepository.UserInChannels(User.Id);
            Writer.Write(channelsUserIsIn);
            Reader.TryReadLine("\n\nChoose the channel you want to read", out var name);
            var channel = _channelRepository.GetByName(name);
            if (channel is null)
            {
                Console.WriteLine("Channel with inputted name does not exist.");
                Console.ReadLine();
                return;
            }

            Console.ReadKey();
        }
    }
}
