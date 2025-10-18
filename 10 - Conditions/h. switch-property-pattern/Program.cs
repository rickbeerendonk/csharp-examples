// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Pattern matching with property patterns

Person person = new("Alexandra", 34);

string description = person switch
{
  { Age: < 18 } => "Minor",
  { Age: >= 18 and < 65 } => "Adult",
  { Age: >= 65 } => "Senior",
  _ => "Unknown"
};

Console.WriteLine($"{person.Name} is a {description}"); // Alexandra is a Adult

// More complex property pattern
person = new("Alexandra", 24);
description = person switch
{
  { Name: "Bob", Age: > 20 } => "Bob, over 20",
  { Name: "Alexandra" } => "It's Alexandra!",
  { Age: < 18 } => "Minor",
  _ => "Someone else"
};

Console.WriteLine(description); // It's Alexandra!

record Person(string Name, int Age);
