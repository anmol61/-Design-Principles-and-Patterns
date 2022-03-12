using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer o1 = new Subscriber1();
            Observer o2 = new Subscriber2();
            Observer o3 = new Subscriber3();

            MessagePublisher p = new MessagePublisher();

            p.attach(o1);
            p.attach(o2);

            p.notifyUpdate(new Message("Message one"));

            p.detach(o1);
            p.attach(o3);

            p.notifyUpdate(new Message("Message two"));

            Console.ReadLine();

        }
    }
}
