// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// Integers

Console.WriteLine(Convert.ToBoolean(0));  // False
Console.WriteLine(Convert.ToBoolean(1));  // True

// Floating point

Console.WriteLine(Convert.ToBoolean(0.0));  // False
Console.WriteLine(Convert.ToBoolean(0.1));  // True

// String

Console.WriteLine(Convert.ToBoolean(null));     // False
Console.WriteLine(Convert.ToBoolean("False"));  // False
Console.WriteLine(Convert.ToBoolean("false"));  // False
Console.WriteLine(Convert.ToBoolean("True"));   // True
Console.WriteLine(Convert.ToBoolean("true"));   // True

Console.WriteLine(Convert.ToBoolean("other"));  // System.FormatException: String 'other' was not recognized as a valid Boolean.