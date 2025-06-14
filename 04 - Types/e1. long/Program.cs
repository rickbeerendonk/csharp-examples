// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(long.MinValue); // -9223372036854775808
Console.WriteLine(long.MaxValue); // 9223372036854775807

// Explicit vs Implicit
long explicitValue = 9_223_372_036_854_775_807; // _ for readability
var implicitValue = 9_223_372_036_854_775_807; // _ for readability

Console.WriteLine(explicitValue.GetType().FullName); // System.Int64
Console.WriteLine(implicitValue.GetType().FullName); // System.Int64

// Size
Console.WriteLine(sizeof(long)); // 8