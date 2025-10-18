// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

HashSet<string> set = ["A", "B", "C"];

set.Add("D"); // Adds "D"
set.Add("A"); // Does nothing, "A" already exists

foreach (string item in set)
{
  Console.WriteLine(item);
}

// A
// B
// C
// D
