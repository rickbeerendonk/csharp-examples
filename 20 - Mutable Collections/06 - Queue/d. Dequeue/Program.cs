// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Queue<string> queue = new(["A", "B", "C"]);

string first = queue.Dequeue(); // Removes and returns "A"

Console.WriteLine($"Dequeued: {first}");
Console.WriteLine($"Count: {queue.Count}"); // 2
