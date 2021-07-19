using System;
using System.Collections.Generic;
using System.Text;

namespace Whatsapp
{
    public interface IMessageReceiver
    {
        void ReceiveMessage(RegularMessage regularMessage);
    }
}
