// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

Console.WriteLine(double.MinValue); // -1.7976931348623157E+308
Console.WriteLine(double.MaxValue); // 1.7976931348623157E+308

// Explicit vs Implicit
double explicitValue = 1.23; // F suffix required
var implicitValue = 1.23;

Console.WriteLine(explicitValue.GetType().FullName);  // System.Double
Console.WriteLine(implicitValue.GetType().FullName); // System.Double
