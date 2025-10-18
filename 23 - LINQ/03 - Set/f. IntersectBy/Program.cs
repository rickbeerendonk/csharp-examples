// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

IEnumerable<Person> first = [
    new Person("Alexandra", 34),
    new Person("Bob", 22),
    new Person("Charlie", 51)
    ];

IEnumerable<Person> second = [
    new Person("Alice", 22),
    new Person("Bart", 34),
    new Person("Chris", 25)
    ];

var result = first.IntersectBy(second.Select(p => p.Age), p => p.Age);

foreach (var person in result)
{
    Console.WriteLine(person);
}

record Person(string Name, int Age);

// Person { Name = Alexandra, Age = 34 }
// Person { Name = Bob, Age = 22 }
