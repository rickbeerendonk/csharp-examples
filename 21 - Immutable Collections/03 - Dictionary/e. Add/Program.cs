// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableDictionary<string, int> dic = new Dictionary<string, int>
{
  ["A"] = 1,
  ["B"] = 2
}.ToImmutableDictionary();

dic = dic.Add("C", 3);
dic = dic.SetItem("D", 4); // Also works for adding new keys

foreach (var kvp in dic)
{
  Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// A: 1
// B: 2
// C: 3
// D: 4
