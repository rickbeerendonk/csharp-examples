// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(float.MinValue); // -3.4028235E+38
Console.WriteLine(float.MaxValue); // 3.4028235E+38

// Explicit vs Implicit
float explicitValue = 1.23F; // F suffix required
var implicitValue1 = 1.23;
var implicitValue2 = 1.23F;  // F suffix

Console.WriteLine(explicitValue.GetType().FullName);  // System.Single
Console.WriteLine(implicitValue1.GetType().FullName); // System.Double
Console.WriteLine(implicitValue2.GetType().FullName); // System.Single
