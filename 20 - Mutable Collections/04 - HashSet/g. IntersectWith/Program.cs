// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

HashSet<int> set1 = [1, 2, 3, 4];
HashSet<int> set2 = [3, 4, 5, 6];

set1.IntersectWith(set2); // Keeps only common elements

foreach (int item in set1)
{
  Console.WriteLine(item);
}

// 3
// 4
