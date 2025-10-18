// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

// SAFE: ConcurrentBag works correctly with multiple threads
var safeBag = new ConcurrentBag<int>();

Console.WriteLine("Running safe ConcurrentBag with multiple threads...");
Console.WriteLine();

var tasks = new Task[10];
for (int i = 0; i < 10; i++)
{
  int threadId = i;
  tasks[i] = Task.Run(() =>
  {
    for (int j = 0; j < 1000; j++)
    {
      safeBag.Add(threadId * 1000 + j);
    }
  });
}

Task.WaitAll(tasks);

Console.WriteLine($"Expected count: 10000");
Console.WriteLine($"Actual count: {safeBag.Count}");
Console.WriteLine("✅ All items added successfully - no race conditions!");
