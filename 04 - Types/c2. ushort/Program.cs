// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(ushort.MinValue); // 0
Console.WriteLine(ushort.MaxValue); // 65535

// Explicit vs Implicit
ushort explicitValue = 65535;
var implicitValue1 = 65535; // int
var implicitValue2 = (ushort)65535;

Console.WriteLine(explicitValue.GetType().FullName);  // System.UInt16
Console.WriteLine(implicitValue1.GetType().FullName); // System.Int32
Console.WriteLine(implicitValue2.GetType().FullName); // System.UInt32

// Size
Console.WriteLine(sizeof(ushort)); // 2
