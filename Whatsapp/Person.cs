using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Whatsapp
{
    public class Person : IMessageReceiver
    {
        public string Name { get; set; }

        private List<Channel> _myChannels;
        private List<Person> _myFriends;

        public Person()
        {
            _myChannels = new List<Channel>();
            _myFriends = new List<Person>();
        }

        public void RegisterChannel(Channel channel)
        {
            _myChannels.Add(channel);
            channel.Register(this);
        }

        public void AddFriend(Person person)
        {
            _myFriends.Add(person);
        }

        public void ReceiveMessage(RegularMessage regularMessage)
        {
            Console.WriteLine($"{regularMessage.Sender}: {regularMessage.Body}");
        }

        public void SendMessageToFriend(string message, string friendName)
        {
            bool foundBulb = false;

            foreach (var friend in _myFriends)
            {
               if(friend.Name == friendName)
                {
                    foundBulb = true;
                    RegularMessage regularMessage = new RegularMessage(message, Name);
                    friend.ReceiveMessage(regularMessage);
                }
            }

            if(!foundBulb)
            {
                Console.WriteLine($"Cannot send message! The person {friendName} is not a friend.");
            }
        }

        public void ReceiveChannelMessage(ChannelMessage channelMessage)
        {
            Console.WriteLine($"The message received from {channelMessage.Sender} through the channel {channelMessage.Channel} is: {channelMessage.Body}");
        }

        public void SendMessageToChannel(string message, string channelName)
        {
            var channel = _myChannels.Where(ch => ch.Name == channelName).FirstOrDefault();
            if (channel != null)
            {
                RegularMessage regularMessage = new RegularMessage(message, Name);
                channel.ReceiveMessage(regularMessage);
            }
            else
            {
                Console.WriteLine($"Cannot send message! You are not registered to the channel {channel}.");
            }
        }
    }
}
