// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Lists:
// Collection initializer syntax with new and {}
List<string> cities = new() { "Amsterdam", "Oslo", "Copenhagen" };
Console.WriteLine(string.Join(", ", cities)); // Amsterdam, Oslo, Copenhagen

// Dictionaries:
// The same `new() {}` syntax with key-value pairs.
Dictionary<string, int> postalCodes = new()
{
  ["Utrecht"] = 3511,
  ["Bergen"] = 5003
};
Console.WriteLine(postalCodes["Bergen"]); // 5003
