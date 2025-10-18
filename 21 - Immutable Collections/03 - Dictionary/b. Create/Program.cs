// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Immutable;

ImmutableDictionary<string, int> dic = new Dictionary<string, int>
{
  ["A"] = 1,
  ["B"] = 2,
  ["C"] = 3
}.ToImmutableDictionary();

Console.WriteLine(dic.Count); // 3
