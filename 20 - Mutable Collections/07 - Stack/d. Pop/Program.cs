// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Stack<string> stack = new(["A", "B", "C"]);

string top = stack.Pop(); // Removes and returns "C"

Console.WriteLine($"Popped: {top}");
Console.WriteLine($"Count: {stack.Count}"); // 2
