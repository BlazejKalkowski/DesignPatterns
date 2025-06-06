# Observer Pattern Example (C#)

This project demonstrates the Observer design pattern in C#.

## What is the Observer Pattern?

The Observer pattern is a behavioral design pattern that defines a one-to-many dependency between objects. When one object (the "subject" or "observable") changes its state, all its dependents ("observers") are notified and updated automatically.

Key components:
*   **Subject (`ISubject`):** An interface defining methods for attaching, detaching, and notifying observers.
*   **ConcreteSubject (`Subject`):** Implements `ISubject`. It maintains a list of observers and sends notifications when its state changes.
*   **Observer (`IObserver`):** An interface defining the `Update` method, which is called when the subject's state changes.
*   **ConcreteObserver (`ConcreteObserverA`, `ConcreteObserverB`):** Implement `IObserver`. Each observer registers with a concrete subject to receive updates.

## Project Structure

*   `Observer.csproj`: The C# project file.
*   `Program.cs`: Contains the `Main` method that demonstrates the Observer pattern in action. It creates a subject, attaches observers, simulates state changes, and shows observers being notified.
*   `IObserver.cs`: Defines the `IObserver` interface.
*   `ISubject.cs`: Defines the `ISubject` interface.
*   `Subject.cs`: The concrete implementation of `ISubject`.
*   `ConcreteObserverA.cs`: A concrete observer implementation.
*   `ConcreteObserverB.cs`: Another concrete observer implementation, demonstrating different reactions to updates.

## How to Run

1.  Ensure you have the .NET SDK installed.
2.  Navigate to the `Observer` directory in your terminal.
3.  Run the command: `dotnet run`

This will execute the `Program.cs` file, and you will see console output demonstrating the interactions between the subject and observers.

## Design Principles Applied

*   **SOLID:**
    *   **Single Responsibility Principle:** `Subject` handles state and notifications. Observers handle their specific reactions.
    *   **Interface Segregation Principle:** `IObserver` and `ISubject` provide focused interfaces.
*   **KISS (Keep It Simple, Stupid):** The example is straightforward and focuses on the core pattern.
*   **DRY (Don't Repeat Yourself):** The notification logic is centralized in the `Subject`.
```
