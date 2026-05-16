// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Custom collection with collection initializer support

// Collection initializer syntax
MyCollection<string> names = ["Alice", "Bob", "Charlie"];

foreach (var name in names)
{
  Console.WriteLine(name);
}

// Alice
// Bob
// Charlie

// To support collection initializers, a class must:
// 1. Implement IEnumerable<T>
// 2. Have an Add method
class MyCollection<T> : IEnumerable<T>
{
  private readonly List<T> _items = [];

  // Required for collection initializer
  public void Add(T item)
  {
    _items.Add(item);
  }

  // Required for IEnumerable<T>
  public IEnumerator<T> GetEnumerator()
  {
    return _items.GetEnumerator();
  }

  // Required for IEnumerable
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }
}
