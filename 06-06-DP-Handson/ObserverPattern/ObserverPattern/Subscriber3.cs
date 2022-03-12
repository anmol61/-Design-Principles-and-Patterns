using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Subscriber3 : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("Message at subscriber3 :" + m.getMessageContent());
        }
    }
}
