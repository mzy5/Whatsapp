using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    public class ChannelMessage : RegularMessage
    {
        public ChannelMessage(string body, string sender, string channel) : base(body, sender)
        {
            ChannelPropr = sender;
        }

        public string ChannelPropr
        {
            get;
            private set;
        }
    }
}
