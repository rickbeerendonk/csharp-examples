// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableArray<string> arr = ["A", "B", "C"];

Console.WriteLine(arr[1]); // B

foreach (string item in arr)
{
  Console.WriteLine(item);
}

// A
// B
// C
