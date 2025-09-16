// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Collection expression
List<string> lst = ["A", "B", "C", "D"];

lst.RemoveAt(1); // Removes the second item

foreach (string item in lst)
{
  Console.WriteLine(item);
}

// A
// C
// D