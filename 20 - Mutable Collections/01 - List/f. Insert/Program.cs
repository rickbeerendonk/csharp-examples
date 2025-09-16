// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Collection expression
List<string> lst = ["A", "B", "C"];

lst.Insert(1, "D"); // Inserts "D" at index 1

foreach (string item in lst)
{
  Console.WriteLine(item);
}

// A
// D
// B
// C