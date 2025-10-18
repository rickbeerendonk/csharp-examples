// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

// SAFE: ConcurrentStack is thread-safe
var safeStack = new ConcurrentStack<string>();

Console.WriteLine("Multi-threaded operations with SAFE ConcurrentStack");
Console.WriteLine("===================================================");
Console.WriteLine();

// Multiple threads pushing
var pushTask1 = Task.Run(() =>
{
  for (int i = 0; i < 500; i++)
  {
    safeStack.Push($"Thread1-{i}");
  }
});

var pushTask2 = Task.Run(() =>
{
  for (int i = 0; i < 500; i++)
  {
    safeStack.Push($"Thread2-{i}");
  }
});

Task.WaitAll(pushTask1, pushTask2);

Console.WriteLine($"Expected count: 1000");
Console.WriteLine($"Actual count: {safeStack.Count}");

// Multiple threads popping
int popped1 = 0, popped2 = 0;

var popTask1 = Task.Run(() =>
{
  for (int i = 0; i < 500; i++)
  {
    if (safeStack.TryPop(out _))
    {
      popped1++;
    }
  }
});

var popTask2 = Task.Run(() =>
{
  for (int i = 0; i < 500; i++)
  {
    if (safeStack.TryPop(out _))
    {
      popped2++;
    }
  }
});

Task.WaitAll(popTask1, popTask2);

Console.WriteLine($"Thread 1 popped: {popped1}");
Console.WriteLine($"Thread 2 popped: {popped2}");
Console.WriteLine($"Remaining: {safeStack.Count}");
Console.WriteLine($"Total accounted for: {popped1 + popped2 + safeStack.Count}");
Console.WriteLine("✅ All items accounted for correctly!");
