// Copyright © 2026 Rick Beerendonk

Index index = ^1;

Console.WriteLine(index);                          // ^1
Console.WriteLine(index.IsFromEnd);                // True
Console.WriteLine(index.Value);                    // 1

// Usage examples:

char[] values = ['A', 'B', 'C', 'D', 'E'];

Console.WriteLine(index.GetOffset(values.Length)); // 4
Console.WriteLine(values[index]);                  // E
