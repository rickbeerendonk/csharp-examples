// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// IComparable - sorting items in a collection

List<Person> people =
[
  new Person("Charlie", 25),
  new Person("Alice", 30),
  new Person("Bob", 20)
];

people.Sort();

Console.WriteLine("Sorted by age:");
foreach (var person in people)
{
  Console.WriteLine($"{person.Name} - {person.Age}");
}

// Sorted by age:
// Bob - 20
// Charlie - 25
// Alice - 30

class Person : IComparable<Person>
{
  public string Name { get; }
  public int Age { get; }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }

  // Compare by age
  public int CompareTo(Person? other)
  {
    if (other == null) return 1;
    return Age.CompareTo(other.Age);
  }
}
