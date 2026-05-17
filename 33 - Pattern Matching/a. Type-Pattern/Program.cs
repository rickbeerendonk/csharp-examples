// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Type patterns

object obj = "Hello";
//object obj = 123;
//object obj = 3.14;
//object obj = true;
//object obj = new object();

// Type pattern without variable

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

if (obj is int i)
{
  Console.WriteLine($"Integer value: {i}");
}

if (obj is double d)
{
  Console.WriteLine($"Double value: {d}");
}

if (obj is bool b)
{
  Console.WriteLine($"Boolean value: {b}");
}


