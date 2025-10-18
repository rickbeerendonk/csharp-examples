// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableHashSet<int> set1 = [1, 2, 3, 4].ToImmutableHashSet();
ImmutableHashSet<int> set2 = [3, 4, 5, 6].ToImmutableHashSet();

ImmutableHashSet<int> intersection = set1.Intersect(set2);

foreach (int item in intersection)
{
  Console.WriteLine(item);
}

// 3
// 4
