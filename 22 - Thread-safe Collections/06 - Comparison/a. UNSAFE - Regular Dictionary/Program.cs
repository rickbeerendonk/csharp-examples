// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// UNSAFE: Regular Dictionary is NOT thread-safe
var unsafeDict = new Dictionary<int, int>();

// This will likely cause exceptions or data corruption
try
{
  var tasks = new Task[10];
  for (int i = 0; i < 10; i++)
  {
    int threadId = i;
    tasks[i] = Task.Run(() =>
    {
      for (int j = 0; j < 100; j++)
      {
        // Race condition: multiple threads accessing the same dictionary
        if (unsafeDict.ContainsKey(threadId))
        {
          unsafeDict[threadId]++;
        }
        else
        {
          unsafeDict[threadId] = 1;
        }
      }
    });
  }

  Task.WaitAll(tasks);
  Console.WriteLine("Completed without exception (rare)");
}
catch (Exception ex)
{
  Console.WriteLine($"Exception occurred: {ex.GetType().Name}");
  Console.WriteLine("This demonstrates why thread-safe collections are needed!");
}

// Common exceptions:
// - ArgumentException: "An item with the same key has already been added"
// - InvalidOperationException: "Collection was modified"
// - NullReferenceException: Due to race conditions
