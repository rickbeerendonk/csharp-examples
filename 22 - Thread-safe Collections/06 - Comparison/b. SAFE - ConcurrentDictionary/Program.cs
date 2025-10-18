// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

// SAFE: ConcurrentDictionary is thread-safe
var safeDict = new ConcurrentDictionary<int, int>();

// This will complete successfully
var tasks = new Task[10];
for (int i = 0; i < 10; i++)
{
  int threadId = i;
  tasks[i] = Task.Run(() =>
  {
    for (int j = 0; j < 100; j++)
    {
      // Thread-safe atomic operation
      safeDict.AddOrUpdate(threadId, 1, (key, oldValue) => oldValue + 1);
    }
  });
}

Task.WaitAll(tasks);

Console.WriteLine($"Total keys: {safeDict.Count}"); // 10
Console.WriteLine($"Each key value: {safeDict[0]}"); // 100
Console.WriteLine("Completed successfully - no race conditions!");

// Benefits:
// - No exceptions from concurrent access
// - Correct results guaranteed
// - No need for manual locking
// - Better performance than lock-based approaches
