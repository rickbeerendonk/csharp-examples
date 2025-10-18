// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableArray<string> arr = ["A", "B", "C", "D", "E"];

arr = arr.RemoveAt(1); // Removes the second item
arr = arr.Remove("D"); // Removes "D"

foreach (string item in arr)
{
  Console.WriteLine(item);
}

// A
// C
// E
