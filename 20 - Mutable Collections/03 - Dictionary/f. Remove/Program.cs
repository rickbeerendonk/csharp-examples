// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Dictionary<string, int> dict = new()
{
  ["One"] = 1,
  ["Two"] = 2,
  ["Three"] = 3
};

dict.Remove("Two"); // Remove by key

foreach (var kvp in dict)
{
  Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// One: 1
// Three: 3
