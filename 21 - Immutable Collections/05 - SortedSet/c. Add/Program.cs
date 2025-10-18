// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableSortedSet<int> set = [1, 3, 5].ToImmutableSortedSet();

set = set.Add(4);
set = set.Add(2);
set = set.Add(1); // Does nothing, 1 already exists

foreach (int item in set)
{
  Console.WriteLine(item);
}

// 1
// 2
// 3
// 4
// 5
