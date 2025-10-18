// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Pattern matching with property patterns

Person person = new("Rick", 30);

string description = person switch
{
  { Age: < 18 } => "Minor",
  { Age: >= 18 and < 65 } => "Adult",
  { Age: >= 65 } => "Senior",
  _ => "Unknown"
};

Console.WriteLine($"{person.Name} is a {description}");

// More complex property pattern
person = new("Alice", 25);
description = person switch
{
  { Name: "Rick", Age: > 20 } => "Rick, over 20",
  { Name: "Alice" } => "It's Alice!",
  { Age: < 18 } => "Minor",
  _ => "Someone else"
};

Console.WriteLine(description);

record Person(string Name, int Age);
