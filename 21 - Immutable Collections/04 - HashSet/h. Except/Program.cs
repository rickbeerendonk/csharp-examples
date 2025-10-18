// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableHashSet<int> set1 = [1, 2, 3, 4].ToImmutableHashSet();
ImmutableHashSet<int> set2 = [3, 4, 5, 6].ToImmutableHashSet();

ImmutableHashSet<int> except = set1.Except(set2);

foreach (int item in except)
{
  Console.WriteLine(item);
}

// 1
// 2
