using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    public class Person : IMessageReceiver
    {
        public string Name { get; set; }

        private List<Channel> _myChannel = new List<Channel>();
        private List<Person> _myFriends = new List<Person>();

        public Person()
        {
            //???
        }

        public void RegisterChannel(Channel channel)
        {
            _myChannel.Add(channel);
            //Besides this, the method should also call the Register method of the channel passing the current person as an argument to it: channel.Register(this);
        }

        public void AddFriend(Person person)
        {
            _myFriends.Add(person);
        }

        public void ReceiveMessage(RegularMessage regularMessage)
        {
            if (regularMessage != null)
            {
                Console.WriteLine("The message sent by???is???");
            }
        }

        public void SendMessageToFriend(string message, string friendName)
        {
            foreach (var item in _myFriends)
            {
                //if(item???
            }
        }

        public void SendMessageToChannel(string message, string channelName)
        {
            foreach (var item in _myChannel)
            {

            }
        }
    }
}
