// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableSortedSet<int> set1 = [1, 2, 3, 4].ToImmutableSortedSet();
ImmutableSortedSet<int> set2 = [3, 4, 5, 6].ToImmutableSortedSet();

ImmutableSortedSet<int> union = set1.Union(set2);

foreach (int item in union)
{
  Console.WriteLine(item);
}

// 1
// 2
// 3
// 4
// 5
// 6
