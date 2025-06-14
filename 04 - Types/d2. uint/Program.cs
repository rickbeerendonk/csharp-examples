// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(uint.MinValue); // 0
Console.WriteLine(uint.MaxValue); // 4294967295

// Explicit vs Implicit
uint explicitValue = 4294967295;
var implicitValue = 4294967295;  // uint

Console.WriteLine(explicitValue.GetType().FullName); // System.UInt32
Console.WriteLine(implicitValue.GetType().FullName); // System.UInt32

// Size
Console.WriteLine(sizeof(uint)); // 4