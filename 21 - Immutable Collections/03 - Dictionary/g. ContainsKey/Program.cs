// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableDictionary<string, int> dic = new Dictionary<string, int>
{
  ["A"] = 1,
  ["B"] = 2
}.ToImmutableDictionary();

bool hasB = dic.ContainsKey("B");
bool hasC = dic.ContainsKey("C");

Console.WriteLine($"Contains 'B': {hasB}"); // True
Console.WriteLine($"Contains 'C': {hasC}"); // False
