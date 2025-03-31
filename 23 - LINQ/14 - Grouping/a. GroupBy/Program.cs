// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

IEnumerable<Person> persons = [
    new Person("Alexandra", 34),
    new Person("Bob", 22),
    new Person("Charlie", 51),
    new Person("David", 22),
    new Person("Eva", 34)
    ];

var personGroups = persons.GroupBy(p => p.Age);

foreach (var group in personGroups)
{
    Console.WriteLine($"Age: {group.Key}");

    foreach (var person in group)
    {
        Console.WriteLine($"- {person}");
    }
}

record Person(string Name, int Age);

// Age: 34
// - Person { Name = Alexandra, Age = 34 }
// - Person { Name = Eva, Age = 34 }
// Age: 22
// - Person { Name = Bob, Age = 22 }
// - Person { Name = David, Age = 22 }
// Age: 51
// - Person { Name = Charlie, Age = 51 }
