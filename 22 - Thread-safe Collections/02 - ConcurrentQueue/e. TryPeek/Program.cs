// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var queue = new ConcurrentQueue<string>(["A", "B", "C"]);

if (queue.TryPeek(out string? item))
{
  Console.WriteLine($"Peeked: {item}"); // A
}

Console.WriteLine($"Count: {queue.Count}"); // 3 (not removed)
