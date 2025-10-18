// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

SortedSet<int> set = [1, 3, 5];

set.Add(4); // Adds 4
set.Add(2); // Adds 2
set.Add(1); // Does nothing, 1 already exists

foreach (int item in set)
{
  Console.WriteLine(item);
}

// 1
// 2
// 3
// 4
// 5
