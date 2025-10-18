// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var stack = new ConcurrentStack<string>();

// Multiple threads pushing and popping safely
var pushTask1 = Task.Run(() =>
{
  for (int i = 0; i < 50; i++)
  {
    stack.Push($"Thread1-{i}");
  }
});

var pushTask2 = Task.Run(() =>
{
  for (int i = 0; i < 50; i++)
  {
    stack.Push($"Thread2-{i}");
  }
});

Task.WaitAll(pushTask1, pushTask2);

Console.WriteLine($"Total items pushed: {stack.Count}"); // 100

// Multiple threads popping
var popTask1 = Task.Run(() =>
{
  for (int i = 0; i < 50; i++)
  {
    if (stack.TryPop(out string? item))
    {
      Console.WriteLine($"Pop1: {item}");
    }
  }
});

var popTask2 = Task.Run(() =>
{
  for (int i = 0; i < 50; i++)
  {
    if (stack.TryPop(out string? item))
    {
      Console.WriteLine($"Pop2: {item}");
    }
  }
});

Task.WaitAll(popTask1, popTask2);

Console.WriteLine($"Remaining items: {stack.Count}"); // 0
