using Chat.Data.Entities.Models;
using Chat.Domain.Enums;
using Chat.Domain.Repositorioes;
using Chat.Presentation.Abstractions;
using Chat.Presentation.Helpers;

namespace Chat.Presentation.Actions.MainMenu.Channel
{
    public class ChannelNewAction: IAction
    {
        private readonly ChannelRepository _channelRepository;
        private readonly ChannelUserRepository _channelUserRepository;
        public User User { get; set; }
        public int MenuIndex { get; set; }

        public string Name { get; set; } = "Create new channel";

        public ChannelNewAction(ChannelRepository channelRepository, ChannelUserRepository channelUserRepository, User user)
        { 
            _channelRepository = channelRepository;
            User = user;
            _channelUserRepository = channelUserRepository;
        }

        public void Open()
        {
            Reader.ReadInput("Name", out var name);
            var channel = new Data.Entities.Models.Channel(name);

            var channelUser = new ChannelUser
            {
                ChannelId = channel.Id,
                Channel = channel,
                UserId = User.Id,
                User = User
            };

            var responseResult = _channelRepository.Add(channel);
            var anotherResponseResult = _channelUserRepository.Add(channel.Id, User.Id);
                       
            if (responseResult is ResponseResultType.Success && anotherResponseResult is ResponseResultType.Success)
            {
                Writer.Write(channel);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Failed to add group, no changes saved!");
            Console.ReadLine();
        }
    }
}
