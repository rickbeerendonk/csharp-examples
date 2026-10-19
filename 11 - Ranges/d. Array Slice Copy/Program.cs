// Copyright © 2026 Rick Beerendonk

char[] values = ['A', 'B', 'C', 'D', 'E'];
char[] middle = values[1..^1];

middle[0] = 'Z'; // Array slicing copies elements into a new array.

Console.WriteLine(string.Join(", ", values));  // A, B, C, D, E
Console.WriteLine(string.Join(", ", middle));  // Z, C, D
