// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Collection expression
List<string> lst = ["A", "B", "C"];

Console.WriteLine(lst[1]); // B

lst[1] = "D"; // Change item at index 1

foreach (string item in lst)
{
  Console.WriteLine(item);
}

// A
// D
// C