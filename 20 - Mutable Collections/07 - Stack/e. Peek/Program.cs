// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Stack<string> stack = new(["A", "B", "C"]);

string top = stack.Peek(); // Returns "C" without removing

Console.WriteLine($"Peeked: {top}");
Console.WriteLine($"Count: {stack.Count}"); // 3
