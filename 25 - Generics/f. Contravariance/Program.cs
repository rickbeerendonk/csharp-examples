// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Contravariance (in) - allows less derived types to be accepted

IConsumer<object> objectConsumer = new ObjectConsumer();
IConsumer<string> stringConsumer = objectConsumer; // Contravariant conversion
stringConsumer.Consume("Hello");

// Contravariance with Action
Action<object> objectAction = obj => Console.WriteLine($"Object: {obj}");
Action<string> stringAction = objectAction; // Contravariant
stringAction("World");

interface IConsumer<in T> // in = contravariant
{
  void Consume(T item);
}

class ObjectConsumer : IConsumer<object>
{
  public void Consume(object item)
  {
    Console.WriteLine($"Consuming: {item}");
  }
}
