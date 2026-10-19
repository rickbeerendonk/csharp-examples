// Copyright © 2026 Rick Beerendonk

Reading[] readings = [new("Oslo", 18), new("Amsterdam", 20), new("Oslo", 19)];

var byCity = readings.ToLookup(reading => reading.City, reading => reading.Celsius);

Console.WriteLine(string.Join(", ", byCity["Oslo"])); // 18, 19
Console.WriteLine(byCity["Aarhus"].Count());          // 0: a missing key has an empty group.

readonly record struct Reading(string City, int Celsius);
