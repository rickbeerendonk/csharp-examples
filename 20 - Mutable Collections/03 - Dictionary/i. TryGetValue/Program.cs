// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Dictionary<string, int> dict = new()
{
  ["One"] = 1,
  ["Two"] = 2
};

if (dict.TryGetValue("Two", out int value))
{
  Console.WriteLine($"Found: {value}");
}
else
{
  Console.WriteLine("Not found");
}

if (dict.TryGetValue("Three", out int value2))
{
  Console.WriteLine($"Found: {value2}");
}
else
{
  Console.WriteLine("Not found");
}

// Found: 2
// Not found
