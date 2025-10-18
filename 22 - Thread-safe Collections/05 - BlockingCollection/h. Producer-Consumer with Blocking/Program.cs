// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var collection = new BlockingCollection<int>(boundedCapacity: 10);

// Producer thread
var producer = Task.Run(() =>
{
  for (int i = 0; i < 50; i++)
  {
    collection.Add(i); // Blocks when capacity is reached
    Console.WriteLine($"Produced: {i}");
    Thread.Sleep(50);
  }
  collection.CompleteAdding();
  Console.WriteLine("Producer completed");
});

// Consumer thread
var consumer = Task.Run(() =>
{
  while (!collection.IsCompleted)
  {
    try
    {
      int item = collection.Take(); // Blocks when empty
      Console.WriteLine($"  Consumed: {item}");
      Thread.Sleep(100); // Slower consumer
    }
    catch (InvalidOperationException)
    {
      // Collection was marked complete and is empty
      break;
    }
  }
  Console.WriteLine("Consumer completed");
});

Task.WaitAll(producer, consumer);

Console.WriteLine("All items processed");
