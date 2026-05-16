// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Indexers - custom array-like access

NameCollection names = new();
names[0] = "Alice";
names[1] = "Bob";
names[2] = "Charlie";

Console.WriteLine($"First name: {names[0]}");
Console.WriteLine($"Second name: {names[1]}");
Console.WriteLine($"Third name: {names[2]}");

class NameCollection
{
  private readonly string?[] _names = new string?[10];

  // Indexer
  public string? this[int index]
  {
    get => _names[index];
    set => _names[index] = value;
  }
}

// First name: Alice
// Second name: Bob
// Third name: Charlie
