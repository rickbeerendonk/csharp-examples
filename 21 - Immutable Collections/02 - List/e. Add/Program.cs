// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableList<string> lst = ["A", "B", "C"];

lst = lst.Add("D");
lst = lst.Insert(1, "E"); // Inserts "E" at index 1

foreach (string item in lst)
{
  Console.WriteLine(item);
}

// A
// E
// B
// C
// D