// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableList<string> lst = ["A", "B", "C", "D", "E"];

lst = lst.RemoveAt(1); // Removes the second item
lst = lst.Remove("D"); // Removes "D"

foreach (string item in lst)
{
  Console.WriteLine(item);
}

// A
// C
// E