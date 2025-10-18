// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var queue = new ConcurrentQueue<string>(["A", "B"]);

queue.Enqueue("C"); // Adds to the end
queue.Enqueue("D"); // Adds to the end

foreach (string item in queue)
{
  Console.WriteLine(item);
}

// A
// B
// C
// D
