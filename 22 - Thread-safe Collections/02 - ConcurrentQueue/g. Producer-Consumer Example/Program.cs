// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var queue = new ConcurrentQueue<int>();

// Producer-Consumer pattern with multiple threads
var producer = Task.Run(() =>
{
  for (int i = 0; i < 100; i++)
  {
    queue.Enqueue(i);
    Thread.Sleep(10); // Simulate work
  }
});

var consumer1 = Task.Run(() =>
{
  int count = 0;
  while (count < 50)
  {
    if (queue.TryDequeue(out int item))
    {
      Console.WriteLine($"Consumer 1 got: {item}");
      count++;
    }
    Thread.Sleep(15);
  }
});

var consumer2 = Task.Run(() =>
{
  int count = 0;
  while (count < 50)
  {
    if (queue.TryDequeue(out int item))
    {
      Console.WriteLine($"Consumer 2 got: {item}");
      count++;
    }
    Thread.Sleep(15);
  }
});

Task.WaitAll(producer, consumer1, consumer2);

Console.WriteLine($"Remaining items: {queue.Count}");
