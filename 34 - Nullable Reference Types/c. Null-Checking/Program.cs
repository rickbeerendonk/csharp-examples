// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Null checking

string? name = GetName();

// Check before using
if (name != null)
{
  Console.WriteLine($"Name length: {name.Length}");
}

// Null-conditional operator
Console.WriteLine($"Name length: {name?.Length ?? 0}");

// Pattern matching
if (name is not null)
{
  Console.WriteLine($"Name: {name}");
}

string? GetName()
{
  return Random.Shared.Next(2) == 0 ? "Rick" : null;
}
