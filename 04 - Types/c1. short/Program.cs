// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(short.MinValue); // -32768
Console.WriteLine(short.MaxValue); // 32767

// Explicit vs Implicit
short explicitValue = 32767;
var implicitValue = 32767; // int

Console.WriteLine(explicitValue.GetType().FullName); // System.Int16
Console.WriteLine(implicitValue.GetType().FullName); // System.Int32