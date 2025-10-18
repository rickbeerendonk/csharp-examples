// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableQueue<string> queue = ImmutableQueue.CreateRange(["A", "B"]);

queue = queue.Enqueue("C"); // Adds to the end
queue = queue.Enqueue("D"); // Adds to the end

foreach (string item in queue)
{
  Console.WriteLine(item);
}

// A
// B
// C
// D
