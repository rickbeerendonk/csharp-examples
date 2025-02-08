// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// Integers

Console.WriteLine(Convert.ToBoolean(0));  // False
Console.WriteLine(Convert.ToBoolean(1));  // True

// Double

Console.WriteLine(Convert.ToBoolean(0.0));  // False
Console.WriteLine(Convert.ToBoolean(0.1));  // True

// Decimal

Console.WriteLine(Convert.ToBoolean(0.0D));  // False
Console.WriteLine(Convert.ToBoolean(0.1D));  // True

// String

Console.WriteLine(Convert.ToBoolean(null));     // False
Console.WriteLine(Convert.ToBoolean("False"));  // False
Console.WriteLine(Convert.ToBoolean("false"));  // False
Console.WriteLine(Convert.ToBoolean("True"));   // True
Console.WriteLine(Convert.ToBoolean("true"));   // True

try
{
  Console.WriteLine(Convert.ToBoolean("other"));
}
catch (FormatException e)
{
  Console.WriteLine(e.Message);  // String 'other' was not recognized as a valid Boolean.
}

