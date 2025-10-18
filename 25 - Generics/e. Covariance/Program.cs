// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Covariance (out) - allows more derived types to be returned

IProducer<string> stringProducer = new StringProducer();
IProducer<object> objectProducer = stringProducer; // Covariant conversion
Console.WriteLine(objectProducer.Produce());

// Covariance with IEnumerable
IEnumerable<string> strings = new List<string> { "Hello", "World" };
IEnumerable<object> objects = strings; // Covariant
foreach (var obj in objects)
{
  Console.WriteLine(obj);
}

interface IProducer<out T> // out = covariant
{
  T Produce();
}

class StringProducer : IProducer<string>
{
  public string Produce()
  {
    return "Produced string";
  }
}
