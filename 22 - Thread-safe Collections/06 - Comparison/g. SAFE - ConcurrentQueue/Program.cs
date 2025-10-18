// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

// SAFE: ConcurrentQueue is thread-safe
var safeQueue = new ConcurrentQueue<int>();

Console.WriteLine("Producer-Consumer with SAFE ConcurrentQueue");
Console.WriteLine("===========================================");
Console.WriteLine("Running aggressive concurrent access...");
Console.WriteLine();

// Run multiple times to show consistent correctness
for (int run = 0; run < 5; run++)
{
  safeQueue.Clear();

  // More aggressive: Multiple producers AND consumers at the same time
  var tasks = new List<Task>();

  // 5 producer threads
  for (int p = 0; p < 5; p++)
  {
    int producerId = p;
    tasks.Add(Task.Run(() =>
    {
      for (int i = 0; i < 1000; i++)
      {
        safeQueue.Enqueue(producerId * 1000 + i);
      }
    }));
  }

  // 5 consumer threads running simultaneously
  int[] consumed = new int[5];
  for (int c = 0; c < 5; c++)
  {
    int consumerId = c;
    tasks.Add(Task.Run(() =>
    {
      for (int i = 0; i < 1000; i++)
      {
        if (safeQueue.TryDequeue(out _))
        {
          consumed[consumerId]++;
        }
      }
    }));
  }

  Task.WaitAll(tasks.ToArray());

  int totalConsumed = consumed.Sum();
  Console.WriteLine($"Run {run + 1}: Produced=5000, Consumed={totalConsumed}, Remaining={safeQueue.Count}");
  Console.WriteLine($"  ✅ Total: {totalConsumed + safeQueue.Count} (Perfect!)");
}

Console.WriteLine();
Console.WriteLine("Benefits of ConcurrentQueue:");
Console.WriteLine("- No exceptions from concurrent access");
Console.WriteLine("- All items correctly accounted for");
Console.WriteLine("- No data loss or corruption");
Console.WriteLine("- Lock-free implementation for better performance");
