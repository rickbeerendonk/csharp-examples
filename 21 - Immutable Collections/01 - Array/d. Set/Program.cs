// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableArray<string> arr = ["A", "B", "C"];

Console.WriteLine(arr[1]); // B

// ImmutableArray does not allow direct modification: arr[1] = "D";
arr = arr.SetItem(1, "D");

foreach (string item in arr)
{
  Console.WriteLine(item);
}

// A
// D
// C
