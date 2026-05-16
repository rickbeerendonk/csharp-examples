// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// IComparer - custom sorting logic

List<Person> people =
[
  new Person("Charlie", 25),
  new Person("Alice", 30),
  new Person("Bob", 20)
];

// Sort by name
people.Sort(new PersonNameComparer());

Console.WriteLine("Sorted by name:");
foreach (var person in people)
{
  Console.WriteLine($"{person.Name} - {person.Age}");
}

Console.WriteLine();

// Sort by age descending
people.Sort(new PersonAgeDescendingComparer());

Console.WriteLine("Sorted by age (descending):");
foreach (var person in people)
{
  Console.WriteLine($"{person.Name} - {person.Age}");
}

// Sorted by name:
// Alice - 30
// Bob - 20
// Charlie - 25
//
// Sorted by age (descending):
// Alice - 30
// Charlie - 25
// Bob - 20

record Person(string Name, int Age);

class PersonNameComparer : IComparer<Person>
{
  public int Compare(Person? x, Person? y)
  {
    if (x == null && y == null) return 0;
    if (x == null) return -1;
    if (y == null) return 1;
    return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
  }
}

class PersonAgeDescendingComparer : IComparer<Person>
{
  public int Compare(Person? x, Person? y)
  {
    if (x == null && y == null) return 0;
    if (x == null) return -1;
    if (y == null) return 1;
    return y.Age.CompareTo(x.Age); // Reversed for descending
  }
}
