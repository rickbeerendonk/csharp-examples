// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var dict = new ConcurrentDictionary<int, int>();

// Multiple threads incrementing counters safely
var tasks = new Task[10];
for (int i = 0; i < 10; i++)
{
  int threadId = i;
  tasks[i] = Task.Run(() =>
  {
    for (int j = 0; j < 1000; j++)
    {
      dict.AddOrUpdate(threadId, 1, (key, oldValue) => oldValue + 1);
    }
  });
}

Task.WaitAll(tasks);

Console.WriteLine($"Total keys: {dict.Count}"); // 10
Console.WriteLine($"Each key value: {dict[0]}"); // 1000

// All operations completed safely without locks
