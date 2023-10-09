// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(short.MinValue); // -32768
Console.WriteLine(short.MaxValue); // 32767

// Explicit vs Implicit
short explicitValue = 32767;
var implicitValue1 = 32767; // int
var implicitValue2 = (short)32767;

Console.WriteLine(explicitValue.GetType().FullName);  // System.Int16
Console.WriteLine(implicitValue1.GetType().FullName); // System.Int32
Console.WriteLine(implicitValue2.GetType().FullName); // System.Int16
