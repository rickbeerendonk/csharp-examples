// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// String indexer - multiple parameters

PhoneBook book = new();
book["Alice", "Mobile"] = "06-12345678";
book["Alice", "Home"] = "010-7654321";
book["Bob", "Mobile"] = "06-55551234";

Console.WriteLine($"Alice Mobile: {book["Alice", "Mobile"]}");
Console.WriteLine($"Alice Home: {book["Alice", "Home"]}");
Console.WriteLine($"Bob Mobile: {book["Bob", "Mobile"]}");

class PhoneBook
{
  private readonly Dictionary<string, string> _numbers = [];

  // Multi-parameter indexer
  public string this[string name, string type]
  {
    get => _numbers[$"{name}:{type}"];
    set => _numbers[$"{name}:{type}"] = value;
  }
}

// Alice Mobile: 06-12345678
// Alice Home: 010-7654321
// Bob Mobile: 06-55551234
