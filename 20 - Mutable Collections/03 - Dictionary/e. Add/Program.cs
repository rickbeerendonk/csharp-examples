// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Dictionary<string, int> dict = new()
{
  ["One"] = 1,
  ["Two"] = 2
};

dict.Add("Three", 3); // Add new key-value pair

foreach (var kvp in dict)
{
  Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// One: 1
// Two: 2
// Three: 3
