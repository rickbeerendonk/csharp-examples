// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

// Collection expression
ImmutableList<string> lst = ["A", "B", "C"];

Console.WriteLine(lst[1]); // B

 // ImmutableList does not allow direct modification: lst[1] = "D";
lst = lst.SetItem(1, "D");

foreach (string item in lst)
{
  Console.WriteLine(item);
}

// A
// B
// C