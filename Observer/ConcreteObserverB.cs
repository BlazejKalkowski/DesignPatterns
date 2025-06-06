using System;

namespace ObserverPattern
{
    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is Subject s)
            {
                // Example: Observer B might only care about states above a certain threshold
                if (s.State >= 5)
                {
                    Console.WriteLine($"ConcreteObserverB: Reacted to the event. New state ({s.State}) is >= 5.");
                }
                else
                {
                    Console.WriteLine($"ConcreteObserverB: Reacted to the event. New state ({s.State}) is < 5, taking no specific action.");
                }
            }
        }
    }
}
