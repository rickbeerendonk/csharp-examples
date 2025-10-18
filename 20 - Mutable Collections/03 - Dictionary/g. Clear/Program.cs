// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Dictionary<string, int> dict = new()
{
  ["One"] = 1,
  ["Two"] = 2,
  ["Three"] = 3
};

dict.Clear(); // Remove all key-value pairs

Console.WriteLine($"Count: {dict.Count}"); // 0
