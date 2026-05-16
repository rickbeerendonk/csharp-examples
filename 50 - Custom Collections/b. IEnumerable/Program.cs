// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Custom collection implementing IEnumerable<T>

NumberCollection numbers = [];
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

Console.WriteLine($"Count: {numbers.Count}");

foreach (var number in numbers)
{
  Console.WriteLine(number);
}

// Count: 3
// 10
// 20
// 30

class NumberCollection : IEnumerable<int>
{
  private readonly List<int> _items = [];

  public int Count => _items.Count;

  public void Add(int item)
  {
    _items.Add(item);
  }

  public IEnumerator<int> GetEnumerator()
  {
    return _items.GetEnumerator();
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }
}
