// Copyright © 2026 Rick Beerendonk

int offset = 1;
Func<int, int> adjust = reading => reading + offset;

Console.WriteLine(adjust(18)); // 19

offset = 2; // Captures the variable, not a snapshot of its original value.
Console.WriteLine(adjust(18)); // 20
