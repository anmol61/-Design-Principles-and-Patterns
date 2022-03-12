using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Subscriber1 :Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("Message at subscriber1 :" + m.getMessageContent());
        }
    }
}
