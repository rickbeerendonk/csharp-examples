// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(decimal.MinValue); // -79228162514264337593543950335
Console.WriteLine(decimal.MaxValue); // 79228162514264337593543950335

// Explicit vs Implicit
decimal explicitValue = 1.23M; // M suffix required
var implicitValue1 = 1.23;
var implicitValue2 = 1.23M;    // M suffix

Console.WriteLine(explicitValue.GetType().FullName);  // System.Decimal
Console.WriteLine(implicitValue1.GetType().FullName); // System.Double
Console.WriteLine(implicitValue2.GetType().FullName); // System.Decimal

// Size
Console.WriteLine(sizeof(decimal)); // 16