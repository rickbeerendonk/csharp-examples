// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Type patterns

object obj = "Hello";

string description = obj switch
{
  int => "It's an integer",
  string => "It's a string",
  double => "It's a double",
  bool => "It's a boolean",
  _ => "Unknown type"
};

Console.WriteLine(description);

// Type pattern with variable
if (obj is string s)
{
  Console.WriteLine($"String value: {s}");
}
