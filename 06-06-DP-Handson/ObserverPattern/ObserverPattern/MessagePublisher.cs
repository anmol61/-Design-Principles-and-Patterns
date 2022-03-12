using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class MessagePublisher : Subject
    {
        private List<Observer> observers = new List<Observer>();

        

        public void attach(Observer o)
        {
            observers.Add(o);
            changeState(o);
        }

        public void changeState( object state)
        {
            notifyUpdate(new Message("State is changed"));
        }

        public void detach(Observer o)
        {
            observers.Remove(o);
            changeState(0);
        }

        public void notifyUpdate(Message m)
        {
            foreach(var o in observers)
            {
                o.Update(m);
            }
        }
    }
}
