// Copyright © 2026 Rick Beerendonk

string? city = null;

Console.WriteLine(city?.ToUpperInvariant() ?? "(missing)"); // (missing)
Console.WriteLine(city?[0] ?? '-');                         // -

city = "Amsterdam";

Console.WriteLine(city?.ToUpperInvariant() ?? "(missing)"); // AMSTERDAM
Console.WriteLine(city?[0] ?? '-');                         // A
