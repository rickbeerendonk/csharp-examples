// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Required properties (C# 11+)

// Must set required properties during initialization
Person person = new()
{
  // Comment out the following lines to see the compiler error for missing required properties
  Name = "Rick",
  Email = "rick@example.com"
};

Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Email: {person.Email}");
Console.WriteLine($"Age: {person.Age}");

class Person
{
  // Required properties must be initialized
  public required string Name { get; set; }
  public required string Email { get; set; }

  // Optional property
  public int Age { get; set; }
}
