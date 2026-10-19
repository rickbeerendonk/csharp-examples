// Copyright © 2026 Rick Beerendonk

Console.WriteLine(default(int));            // 0
Console.WriteLine(default(bool));           // False
Console.WriteLine(default(string) == null); // True

// A default literal uses the type supplied by its context.
int count = default;
Console.WriteLine(count); // 0
