using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Subscriber2 : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("Message at subscriber2 :" + m.getMessageContent());
        }
    }
}
