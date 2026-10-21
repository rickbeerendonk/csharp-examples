// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// The type comes from the declaration, so it is not repeated.
List<string> cities = new();
cities.Add("Utrecht");

Dictionary<string, int> populations = new() { ["Bergen"] = 291_000 };

DateOnly holiday = new(2026, 4, 27);

Console.WriteLine(cities[0]);              // Utrecht
Console.WriteLine(populations["Bergen"]);  // 291000
Console.WriteLine(holiday.ToString("yyyy-MM-dd")); // 2026-04-27
