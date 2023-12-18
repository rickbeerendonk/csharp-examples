// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

int[] values = [1, 2, 3, 4, 5, 6, 7];

Console.WriteLine(string.Join(", ", values[..]));     // 1, 2, 3, 4, 5, 6, 7
Console.WriteLine(string.Join(", ", values[2..]));    //       3, 4, 5, 6, 7
Console.WriteLine(string.Join(", ", values[..2]));    // 1, 2
Console.WriteLine(string.Join(", ", values[..^2]));   // 1, 2, 3, 4, 5
Console.WriteLine(string.Join(", ", values[^2..]));   //             6, 7
Console.WriteLine(string.Join(", ", values[2..^2]));  //       3, 4, 5
Console.WriteLine(string.Join(", ", values[^5..5]));  //       3, 4, 5
