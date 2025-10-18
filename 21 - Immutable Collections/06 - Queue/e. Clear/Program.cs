// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableQueue<int> queue = ImmutableQueue.CreateRange([1, 2, 3]);

queue = queue.Clear(); // Removes all elements

Console.WriteLine($"IsEmpty: {queue.IsEmpty}"); // True
