// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

SortedSet<int> set1 = [1, 2, 3, 4];
SortedSet<int> set2 = [3, 4, 5, 6];

set1.UnionWith(set2); // Adds elements from set2

foreach (int item in set1)
{
  Console.WriteLine(item);
}

// 1
// 2
// 3
// 4
// 5
// 6
