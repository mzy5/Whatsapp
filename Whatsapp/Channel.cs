using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    public class Channel : IMessageReceiver
    {
        public string Name { get; set; }
        public List<Person> Members;
        public List<RegularMessage> Messages;

        public Channel()
        {
            Members = new List<Person>();
            Messages = new List<RegularMessage>();
        }

        public void Register(Person person)
        {
            Members.Add(person);
        }

        public void ReceiveMessage(RegularMessage regularMessage)
        {
            Messages.Add(regularMessage);
            NotifyMembers(regularMessage);
        }

        private void NotifyMembers(RegularMessage messagePostedByAMember)
        {
            foreach (var person in Members)
            {
                ChannelMessage channelMessage = new ChannelMessage(messagePostedByAMember.Body, messagePostedByAMember.Sender, Name);

                if (person.Name != messagePostedByAMember.Sender)
                {
                    person.ReceiveChannelMessage(channelMessage);
                }
            }
        }
    }
}
