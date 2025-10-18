// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var dict = new ConcurrentDictionary<string, int>();
dict["A"] = 1;
dict["B"] = 2;

if (dict.TryGetValue("B", out int value))
{
  Console.WriteLine($"Value: {value}"); // 2
}

if (!dict.TryGetValue("C", out int value2))
{
  Console.WriteLine("Key 'C' not found");
}
