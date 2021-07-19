using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    public class Channel : IMessageReceiver
    {
        public string Name { get; set; }
        public List<Person> Members = new List<Person>();
        public List<RegularMessage> Messages = new List<RegularMessage>();

        public Channel()
        {
            //initialize lists
        }

        public void Register(Person person)
        {
            Members.Add(person);
        }

        public void ReceiveMessage(RegularMessage regularMessage)
        {
            Messages.Add(regularMessage);
            void NotifyMembers()
            {
                foreach (var item in Members)
                {
                    if ()
                    {

                    }
                }
            }
        }
    }
}
