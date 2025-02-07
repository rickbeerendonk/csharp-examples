// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

IEnumerable<Person> persons = [
    new Person("Alexandra", 34),
    new Person("Bob", 22),
    new Person("Charlie", 51),
    new Person("David", 22),
    new Person("Eva", 34)
    ];

var distinctPersons = persons.DistinctBy(p => p.Age);

foreach (var person in distinctPersons)
{
    Console.WriteLine(person);
}

record Person(string Name, int Age);

// Person { Name = Alexandra, Age = 34 }
// Person { Name = Bob, Age = 22 }
// Person { Name = Charlie, Age = 51 }
