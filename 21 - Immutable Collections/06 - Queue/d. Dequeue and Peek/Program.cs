// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableQueue<string> queue = ImmutableQueue.CreateRange(["A", "B", "C"]);

string first = queue.Peek(); // Returns "A" without removing
queue = queue.Dequeue(); // Removes "A"

Console.WriteLine($"Peeked: {first}");
Console.WriteLine($"First after dequeue: {queue.Peek()}"); // B
