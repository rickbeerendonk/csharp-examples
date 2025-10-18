// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var collection = new BlockingCollection<string>();

collection.Add("A");
collection.Add("B");
collection.Add("C");

// Signal that no more items will be added
collection.CompleteAdding();

Console.WriteLine($"IsAddingCompleted: {collection.IsAddingCompleted}"); // True
Console.WriteLine($"IsCompleted: {collection.IsCompleted}"); // False (items still in collection)

// Can still take items
while (!collection.IsCompleted)
{
  if (collection.TryTake(out string? item))
  {
    Console.WriteLine($"Took: {item}");
  }
}

Console.WriteLine($"IsCompleted: {collection.IsCompleted}"); // True
