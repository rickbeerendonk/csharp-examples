// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

HashSet<string> set = ["A", "B", "C"];

bool hasB = set.Contains("B");
bool hasD = set.Contains("D");

Console.WriteLine($"Contains 'B': {hasB}"); // True
Console.WriteLine($"Contains 'D': {hasD}"); // False
