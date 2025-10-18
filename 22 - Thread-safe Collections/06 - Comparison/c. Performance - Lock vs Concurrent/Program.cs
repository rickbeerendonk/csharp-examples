// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;
using System.Diagnostics;

Console.WriteLine("Performance Comparison: Lock vs ConcurrentDictionary");
Console.WriteLine("====================================================");

// Test 1: Dictionary with lock
var dictWithLock = new Dictionary<int, int>();
var lockObj = new object();

var sw1 = Stopwatch.StartNew();
var tasks1 = new Task[10];
for (int i = 0; i < 10; i++)
{
  int threadId = i;
  tasks1[i] = Task.Run(() =>
  {
    for (int j = 0; j < 10000; j++)
    {
      lock (lockObj)
      {
        if (dictWithLock.ContainsKey(threadId))
        {
          dictWithLock[threadId]++;
        }
        else
        {
          dictWithLock[threadId] = 1;
        }
      }
    }
  });
}
Task.WaitAll(tasks1);
sw1.Stop();

Console.WriteLine($"Dictionary with lock: {sw1.ElapsedMilliseconds}ms");

// Test 2: ConcurrentDictionary (lock-free)
var concurrentDict = new ConcurrentDictionary<int, int>();

var sw2 = Stopwatch.StartNew();
var tasks2 = new Task[10];
for (int i = 0; i < 10; i++)
{
  int threadId = i;
  tasks2[i] = Task.Run(() =>
  {
    for (int j = 0; j < 10000; j++)
    {
      concurrentDict.AddOrUpdate(threadId, 1, (key, oldValue) => oldValue + 1);
    }
  });
}
Task.WaitAll(tasks2);
sw2.Stop();

Console.WriteLine($"ConcurrentDictionary:  {sw2.ElapsedMilliseconds}ms");
Console.WriteLine();
Console.WriteLine($"Speedup: {sw1.ElapsedMilliseconds / (double)sw2.ElapsedMilliseconds:F2}x faster");
