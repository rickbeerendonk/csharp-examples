// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Auto-implemented properties

Person person = new();
person.Name = "Rick";
person.Age = 30;

Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Age: {person.Age}");

// Read-only auto property
Console.WriteLine($"ID: {person.Id}");

class Person
{
  // Auto-implemented properties
  public string Name { get; set; } = "";
  public int Age { get; set; }

  // Read-only auto property (can only be set in constructor or initializer)
  public string Id { get; } = Guid.NewGuid().ToString();
}
