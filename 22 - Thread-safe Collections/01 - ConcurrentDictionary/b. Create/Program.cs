// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var dict = new ConcurrentDictionary<string, int>();

dict["A"] = 1;
dict["B"] = 2;
dict["C"] = 3;

foreach (var kvp in dict)
{
  Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// A: 1
// B: 2
// C: 3
