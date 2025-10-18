// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var bag = new ConcurrentBag<string>(["A", "B"]);

bag.Add("C"); // Adds to the bag
bag.Add("D"); // Adds to the bag
bag.Add("A"); // Can add duplicates

foreach (string item in bag)
{
  Console.WriteLine(item);
}

// Output order is not guaranteed (unordered collection)
