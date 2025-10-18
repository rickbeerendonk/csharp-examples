// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Indexers allow instances to be indexed like arrays

Collection collection = new();
collection[0] = "First";
collection[1] = "Second";
collection[2] = "Third";

Console.WriteLine($"collection[0] = {collection[0]}");
Console.WriteLine($"collection[1] = {collection[1]}");
Console.WriteLine($"collection[2] = {collection[2]}");

class Collection
{
  private string[] _items = new string[10];

  // Indexer
  public string this[int index]
  {
    get => _items[index];
    set => _items[index] = value;
  }
}
