// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(sbyte.MinValue); // -128
Console.WriteLine(sbyte.MaxValue); // 127

// Explicit vs Implicit
sbyte explicitValue = 127;
var implicitValue = 127; // int

Console.WriteLine(explicitValue.GetType().FullName); // System.SByte
Console.WriteLine(implicitValue.GetType().FullName); // System.Int32
