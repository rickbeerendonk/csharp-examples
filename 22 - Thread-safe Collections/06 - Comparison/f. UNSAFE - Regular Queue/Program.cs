// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// UNSAFE: Regular Queue is NOT thread-safe
var unsafeQueue = new Queue<int>();

Console.WriteLine("Producer-Consumer with UNSAFE Queue");
Console.WriteLine("====================================");
Console.WriteLine("Running aggressive concurrent access...");
Console.WriteLine();

int exceptionCount = 0;
int successfulRuns = 0;

// Run multiple times to increase chance of seeing the race condition
for (int run = 0; run < 5; run++)
{
  unsafeQueue.Clear();
  bool failed = false;

  try
  {
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
          unsafeQueue.Enqueue(producerId * 1000 + i); // Race condition
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
          try
          {
            if (unsafeQueue.Count > 0)
            {
              // Check-then-act race condition
              unsafeQueue.Dequeue();
              consumed[consumerId]++;
            }
          }
          catch
          {
            // Ignore individual exceptions to see overall behavior
          }
        }
      }));
    }

    Task.WaitAll(tasks.ToArray());

    int totalConsumed = consumed.Sum();
    Console.WriteLine($"Run {run + 1}: Produced=5000, Consumed={totalConsumed}, Remaining={unsafeQueue.Count}");
    
    if (totalConsumed + unsafeQueue.Count != 5000)
    {
      Console.WriteLine($"  ❌ Data corruption! Expected 5000, got {totalConsumed + unsafeQueue.Count}");
      failed = true;
    }

    if (!failed)
    {
      successfulRuns++;
    }
  }
  catch (Exception ex)
  {
    Console.WriteLine($"  ❌ Exception in run {run + 1}: {ex.GetType().Name}");
    exceptionCount++;
    failed = true;
  }
}

Console.WriteLine();
Console.WriteLine($"Results: {exceptionCount} runs with exceptions, {successfulRuns} successful runs");
Console.WriteLine();
Console.WriteLine("Common issues with regular Queue:");
Console.WriteLine("- InvalidOperationException: Queue empty (race condition between Count check and Dequeue)");
Console.WriteLine("- Data loss: Items lost due to concurrent modifications");
Console.WriteLine("- Incorrect counts: Count doesn't reflect actual state");
Console.WriteLine("- Silent corruption: Internal data structure becomes inconsistent");
