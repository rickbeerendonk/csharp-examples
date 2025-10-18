// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableSortedSet<int> set = [1, 2, 3, 4, 5].ToImmutableSortedSet();

set = set.Remove(3); // Removes 3

foreach (int item in set)
{
  Console.WriteLine(item);
}

// 1
// 2
// 4
// 5
