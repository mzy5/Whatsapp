using System;

namespace Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();
            channel.Name = "CApRE";

            Person person1 = new Person();
            person1.Name = "Cineva";

            Person person2 = new Person();
            person2.Name = "Altcineva";

            Person person3 = new Person();
            person3.Name = "Jane Doe";


            person1.AddFriend(person2);
            person1.SendMessageToFriend("mama are mere", "Altcineva");

            person1.RegisterChannel(channel);
            person2.RegisterChannel(channel);
            person3.RegisterChannel(channel);

            person1.SendMessageToChannel("Tata are pere", "CApRE");
            person1.SendMessageToFriend("Bunica are Alzheimer", "Altcineva");


            
        }
    }
}
