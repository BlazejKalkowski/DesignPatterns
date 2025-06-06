using System.Collections.Generic;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        // A property whose change will trigger notification.
        // Using a backing field to demonstrate logic on set.
        private int _state;
        public int State
        {
            get { return _state; }
            set
            {
                _state = value;
                Notify(); // Notify observers when the state changes
            }
        }

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                Console.WriteLine("Subject: Attached an observer.");
            }
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Remove(observer))
            {
                Console.WriteLine("Subject: Detached an observer.");
            }
        }

        public void Notify()
        {
            Console.WriteLine($"Subject: Notifying observers about state change to: {State}");
            // It's important to iterate over a copy of the list if observers
            // might detach themselves during the Update call, to avoid modification
            // of the collection during iteration.
            foreach (var observer in new List<IObserver>(_observers))
            {
                observer.Update(this);
            }
        }

        // Example method that might cause state change
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new System.Random().Next(0, 10); // Simulate state change

            Console.WriteLine($"Subject: My state has just changed to: {this.State}");
        }
    }
}
