// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// Int

Console.WriteLine(Convert.ToChar(48));  // 0
Console.WriteLine(Convert.ToChar(49));  // 1
Console.WriteLine(Convert.ToChar(65));  // A
Console.WriteLine(Convert.ToChar(66));  // B
Console.WriteLine(Convert.ToChar(67));  // C

// String

Console.WriteLine(Convert.ToChar("a"));  // a

try
{
  Console.WriteLine(Convert.ToChar("ab"));
}
catch (FormatException e)
{
  Console.WriteLine(e.Message);  // String must be exactly one character long.
}