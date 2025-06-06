using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Pattern Example");
            Console.WriteLine("------------------------\n");

            // Create subject
            var subject = new Subject();

            // Create observers
            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();

            // Attach observers to the subject
            Console.WriteLine("\n--- Attaching Observers ---");
            subject.Attach(observerA);
            subject.Attach(observerB);

            // Simulate business logic that changes subject's state
            Console.WriteLine("\n--- Simulating State Changes ---");
            subject.SomeBusinessLogic(); // State changes, observers are notified
            subject.SomeBusinessLogic(); // State changes again

            // Detach an observer
            Console.WriteLine("\n--- Detaching Observer A ---");
            subject.Detach(observerA);

            // Simulate another state change
            Console.WriteLine("\n--- Simulating State Change After Detach ---");
            subject.SomeBusinessLogic(); // Only Observer B should be notified

            Console.WriteLine("\n------------------------");
            Console.WriteLine("Observer Pattern Example Finished.");
        }
    }
}
