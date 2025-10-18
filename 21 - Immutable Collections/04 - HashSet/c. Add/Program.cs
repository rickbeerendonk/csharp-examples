// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableHashSet<string> set = ["A", "B", "C"].ToImmutableHashSet();

set = set.Add("D");
set = set.Add("A"); // Does nothing, "A" already exists

foreach (string item in set)
{
  Console.WriteLine(item);
}

// A
// B
// C
// D
