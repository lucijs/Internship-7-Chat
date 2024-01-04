using Chat.Data.Entities.Models;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Actions.MainMenu.PrivateMessage;
using Chat.Presentation.Helpers;
using System.Threading.Channels;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelReadMessagesAction : IAction
    {
        public int MenuIndex { get; set; }
        private readonly UserRepository _userRepository;
        private readonly ChannelRepository _channelRepository;
        private readonly MessagesInTheChannelRepository _messageRepository;
        private readonly ChannelUserRepository _channelUserRepository;

        public User User { get; set; }
        public string Name { get; set; } = "Read messages";
        public ChannelReadMessagesAction(ChannelUserRepository channelUserRepository,UserRepository userRepository, ChannelRepository channelRepository,MessagesInTheChannelRepository messagesInTheChannelRepository, User user)
        {
            _userRepository = userRepository;
            _channelRepository = channelRepository;
            _messageRepository = messagesInTheChannelRepository;
            _channelUserRepository = channelUserRepository;
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
            var messages = _messageRepository.GetAll();
            WriteMessagesInTheChat(messages, channel);
            Console.ReadKey();
            var correctInput = Reader.NewMessage(out string message);
            if (!correctInput)
            {
                Writer.Error("Incorrect message input");
                return;
            }
            var resume = Reader.DoYouWantToContinue(message);
            if (!resume)
                return;
            var ourChannelUser = _channelUserRepository.GetByChannelIdAndUserId(User.Id, channel.Id);
            if (ourChannelUser == null)
                return;
            var newMessageInTheChannel = new MessagesInTheChannel
            {
                ChannelUserId = ourChannelUser.Id,
                Content = message,
                TimeSent = DateTime.UtcNow,
            };
            var responseReturn = _messageRepository.Add(newMessageInTheChannel);
            if (responseReturn is Domain.Enums.ResponseResultType.Success)
            {
                Console.Clear();
                var updatedMessages = _messageRepository.GetAll();
                WriteMessagesInTheChat(updatedMessages, channel);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Failed to update user, no changes saved!");
            Console.ReadLine();
        }

        public void WriteMessagesInTheChat(ICollection<MessagesInTheChannel> messages, Chat.Data.Entities.Models.Channel channel)
        {
            foreach (var m in messages)
            {
                var channelUser = _channelUserRepository.GetById(m.ChannelUserId);
                if (channelUser == null)
                    return;
                var user = _userRepository.GetByChannelUserIdAndChannelUser(channelUser, channel.Id);
                if (user != null)
                {
                    Writer.Write(m, user.Email);
                }
            }
            Console.ReadKey();
        }

    }
}
