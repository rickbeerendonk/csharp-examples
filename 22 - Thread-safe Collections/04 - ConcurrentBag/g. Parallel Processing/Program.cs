// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var bag = new ConcurrentBag<int>();

// Parallel.For adds items from multiple threads
Parallel.For(0, 1000, i =>
{
  bag.Add(i);
});

Console.WriteLine($"Total items: {bag.Count}"); // 1000

// Multiple threads processing items
int processed = 0;
var tasks = Enumerable.Range(0, 4).Select(threadId => Task.Run(() =>
{
  int localCount = 0;
  while (bag.TryTake(out int item))
  {
    // Process item
    localCount++;
  }
  Interlocked.Add(ref processed, localCount);
  Console.WriteLine($"Thread {threadId} processed {localCount} items");
})).ToArray();

Task.WaitAll(tasks);

Console.WriteLine($"Total processed: {processed}"); // 1000
Console.WriteLine($"Remaining items: {bag.Count}"); // 0
