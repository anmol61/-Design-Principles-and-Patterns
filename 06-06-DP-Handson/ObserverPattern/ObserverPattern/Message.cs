using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Message
    {
       private readonly string messageContent;
        public Message(string m)
        {
            this.messageContent = m;
        }
        public string getMessageContent()
        {
            return messageContent;
        }
    }
}
