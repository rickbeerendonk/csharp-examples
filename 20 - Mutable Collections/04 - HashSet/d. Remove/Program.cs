// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

HashSet<string> set = ["A", "B", "C", "D"];

set.Remove("B"); // Removes "B"

foreach (string item in set)
{
  Console.WriteLine(item);
}

// A
// C
// D
