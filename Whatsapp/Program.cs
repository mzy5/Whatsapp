﻿using System;

namespace Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();
            channel.Name = "CApRE";

            Person person1 = new Person();
            Person person2 = new Person();

            person1.Name = "Cineva";
            person2.Name = "Altcineva";

            person1.RegisterChannel(channel);
            person2.RegisterChannel(channel);

            person1.SendMessageToChannel("Tata are pere", "CApRE");
            person1.SendMessageToFriend("Bunica are Alzheimer", "Altcineva");

            
        }
    }
}
