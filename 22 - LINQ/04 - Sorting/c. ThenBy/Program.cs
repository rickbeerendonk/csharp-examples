// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

IEnumerable<Person> persons = [
    new Person("Eva", 34),
    new Person("David", 22),
    new Person("Charlie", 51),
    new Person("Bob", 22),
    new Person("Alexandra", 34)
    ];


Console.WriteLine("--- OrderBy ---");

var sortedPersons = persons.OrderBy(p => p.Age);

foreach (var person in sortedPersons)
{
    Console.WriteLine(person);
}

Console.WriteLine("--- ThenBy ---");

var sortedPersons2 = persons.OrderBy(p => p.Age).ThenBy(p => p.Name);

foreach (var person in sortedPersons2)
{
    Console.WriteLine(person);
}


record Person(string Name, int Age);

// --- OrderBy ---
// Person { Name = David, Age = 22 }
// Person { Name = Bob, Age = 22 }
// Person { Name = Eva, Age = 34 }
// Person { Name = Alexandra, Age = 34 }
// Person { Name = Charlie, Age = 51 }
// --- ThenBy ---
// Person { Name = Bob, Age = 22 }
// Person { Name = David, Age = 22 }
// Person { Name = Alexandra, Age = 34 }
// Person { Name = Eva, Age = 34 }
// Person { Name = Charlie, Age = 51 }
