// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Queue<string> queue = new(["A", "B", "C"]);

string first = queue.Peek(); // Returns "A" without removing

Console.WriteLine($"Peeked: {first}");
Console.WriteLine($"Count: {queue.Count}"); // 3
