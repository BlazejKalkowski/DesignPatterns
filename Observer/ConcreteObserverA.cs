using System;

namespace ObserverPattern
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Subject s)
            {
                Console.WriteLine($"ConcreteObserverA: Reacted to the event. New state is: {s.State}");
            }
        }
    }
}
