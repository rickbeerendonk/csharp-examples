// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Collection expression
List<string> lst = ["A", "C", "B", "C", "D"];

lst.RemoveAll(item => item == "C"); // Removes all "C"

foreach (string item in lst)
{
  Console.WriteLine(item);
}

// A
// B
// D
