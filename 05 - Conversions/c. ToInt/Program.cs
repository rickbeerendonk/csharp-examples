// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Convert.ToInt32 - Boolean
Console.WriteLine(Convert.ToInt32(true));   // 1
Console.WriteLine(Convert.ToInt32(false));  // 0

// Convert.ToInt32 - Integers
Console.WriteLine(Convert.ToInt32(0));      // 0
Console.WriteLine(Convert.ToInt32(1));      // 1
Console.WriteLine(Convert.ToInt32(-1));     // -1

// Convert.ToInt32 - Double
Console.WriteLine(Convert.ToInt32(0.0));    // 0
Console.WriteLine(Convert.ToInt32(0.9));    // 1 (rounds)
Console.WriteLine(Convert.ToInt32(-1.1));   // -1 (rounds)

// Convert.ToInt32 - Decimal
Console.WriteLine(Convert.ToInt32(0.0m));   // 0
Console.WriteLine(Convert.ToInt32(0.9m));   // 1 (rounds)
Console.WriteLine(Convert.ToInt32(-1.1m));  // -1 (rounds)

// Convert.ToInt32 - String
Console.WriteLine(Convert.ToInt32("0"));    // 0
Console.WriteLine(Convert.ToInt32("1"));    // 1
Console.WriteLine(Convert.ToInt32("-1"));   // -1

Console.WriteLine(Convert.ToInt32(null));   // 0

try
{
    Console.WriteLine(Convert.ToInt32("0.9"));
}
catch (FormatException e)
{
    Console.WriteLine(e.Message); // Input string was not in a correct format.
}
