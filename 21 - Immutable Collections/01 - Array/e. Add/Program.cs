// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableArray<string> arr = ["A", "B", "C"];

arr = arr.Add("D");
arr = arr.Insert(1, "E"); // Inserts "E" at index 1

foreach (string item in arr)
{
  Console.WriteLine(item);
}

// A
// E
// B
// C
// D
