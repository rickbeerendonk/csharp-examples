// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableSortedSet<int> set = [3, 1, 2].ToImmutableSortedSet();

foreach (int item in set)
{
  Console.WriteLine(item);
}

// 1
// 2
// 3
