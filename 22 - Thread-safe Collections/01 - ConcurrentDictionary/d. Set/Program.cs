// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.Collections.Concurrent;

var dict = new ConcurrentDictionary<string, int>();
dict["A"] = 1;
dict["B"] = 2;

Console.WriteLine(dict["B"]); // 2

dict["B"] = 20; // Updates existing value

Console.WriteLine(dict["B"]); // 20
