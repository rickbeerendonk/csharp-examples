// European Union Public License version 1.2
// Copyright © 2023-2024 Rick Beerendonk

int[] values = [1, 2, 3, 4, 5, 6, 7];

// 1 value
Console.WriteLine(string.Join(", ", values[0]));       // 1
Console.WriteLine(string.Join(", ", values[1]));       // 2
Console.WriteLine(string.Join(", ", values[2]));       // 3
//Console.WriteLine(string.Join(", ", values[^0]));      // System.IndexOutOfRangeException: Index was outside the bounds of the array.
Console.WriteLine(string.Join(", ", values[^1]));      // 7
Console.WriteLine(string.Join(", ", values[^2]));      // 6

// Multiple values
Console.WriteLine(string.Join(", ", values[..]));     // 1, 2, 3, 4, 5, 6, 7
Console.WriteLine(string.Join(", ", values[2..]));    //       3, 4, 5, 6, 7
Console.WriteLine(string.Join(", ", values[..2]));    // 1, 2
Console.WriteLine(string.Join(", ", values[..^2]));   // 1, 2, 3, 4, 5
Console.WriteLine(string.Join(", ", values[^2..]));   //             6, 7
Console.WriteLine(string.Join(", ", values[2..^2]));  //       3, 4, 5
Console.WriteLine(string.Join(", ", values[^5..5]));  //       3, 4, 5
