using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    public class RegularMessage
    {
        private readonly string _sender;
        public RegularMessage(string body, string sender)
        {
            _sender = sender;
            Body = body;
        }
        
        public string Body { get; private set; }
        public string Sender
        {
            get { return _sender; }
        }
    }
}
