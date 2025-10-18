// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

object obj = "Hello";

// is operator checks if an instance is of a specific type
if (obj is string)
{
  Console.WriteLine("obj is a string");
}

if (obj is int)
{
  Console.WriteLine("obj is an int");
}
else
{
  Console.WriteLine("obj is not an int");
}

// is with pattern matching
if (obj is string s)
{
  Console.WriteLine($"String value: {s}");
}
