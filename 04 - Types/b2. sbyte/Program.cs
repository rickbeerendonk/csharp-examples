// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(sbyte.MinValue); // -128
Console.WriteLine(sbyte.MaxValue); // 127

// Explicit vs Implicit
sbyte explicitValue = 127;
var implicitValue1 = 127; // int
var implicitValue2 = (sbyte)127;

Console.WriteLine(explicitValue.GetType().FullName);  // System.SByte
Console.WriteLine(implicitValue1.GetType().FullName); // System.Int32
Console.WriteLine(implicitValue2.GetType().FullName); // System.SByte

// Size
Console.WriteLine(sizeof(sbyte)); // 1