// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

// Collection expression
ImmutableList<string> lst = ["A", "B", "C"];

Console.WriteLine(lst[1]); // B

foreach (string item in lst)
{
  Console.WriteLine(item);
}

// A
// B
// C