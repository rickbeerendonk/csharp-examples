// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Dictionary<string, int> dict = new()
{
  ["One"] = 1,
  ["Two"] = 2
};

dict["Two"] = 20; // Update existing key

foreach (var kvp in dict)
{
  Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// One: 1
// Two: 20
