// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Custom collection implementing IList<T>

NameList names = ["Alice", "Bob"];
names.Insert(1, "Charlie");
names[0] = "Alicia";

Console.WriteLine($"Count: {names.Count}");
Console.WriteLine($"Index of 'Bob': {names.IndexOf("Bob")}");

foreach (var name in names)
{
  Console.WriteLine(name);
}

// Count: 3
// Index of 'Bob': 2
// Alicia
// Charlie
// Bob

class NameList : IList<string>
{
  private readonly List<string> _items = [];

  public int Count => _items.Count;
  public bool IsReadOnly => false;

  public string this[int index]
  {
    get => _items[index];
    set => _items[index] = value;
  }

  public void Add(string item) => _items.Add(item);
  public void Clear() => _items.Clear();
  public bool Contains(string item) => _items.Contains(item);
  public void CopyTo(string[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
  public int IndexOf(string item) => _items.IndexOf(item);
  public void Insert(int index, string item) => _items.Insert(index, item);
  public bool Remove(string item) => _items.Remove(item);
  public void RemoveAt(int index) => _items.RemoveAt(index);

  public IEnumerator<string> GetEnumerator() => _items.GetEnumerator();
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}
