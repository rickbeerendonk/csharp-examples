// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Custom collection implementing ICollection<T>

PersonCollection people = [];
people.Add(new Person("Alice", 30));
people.Add(new Person("Bob", 25));

Console.WriteLine($"Count: {people.Count}");

foreach (var person in people)
{
  Console.WriteLine($"{person.Name} - {person.Age}");
}

people.Remove(new Person("Alice", 30));
Console.WriteLine($"\nAfter remove: {people.Count}");

// Count: 2
// Alice - 30
// Bob - 25
//
// After remove: 1

record Person(string Name, int Age);

class PersonCollection : ICollection<Person>
{
  private readonly List<Person> _items = [];

  public int Count => _items.Count;
  public bool IsReadOnly => false;

  public void Add(Person item) => _items.Add(item);
  public void Clear() => _items.Clear();
  public bool Contains(Person item) => _items.Contains(item);
  public void CopyTo(Person[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
  public bool Remove(Person item) => _items.Remove(item);

  public IEnumerator<Person> GetEnumerator() => _items.GetEnumerator();
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}
