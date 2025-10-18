// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Exception filters with when clause

try
{
  throw new ArgumentException("Test error", "testParam");
}
catch (ArgumentException ex) when (ex.ParamName == "testParam")
{
  Console.WriteLine($"Caught exception for testParam: {ex.Message}");
}

try
{
  throw new ArgumentException("Another error", "otherParam");
}
catch (ArgumentException ex) when (ex.ParamName == "testParam")
{
  Console.WriteLine("This won't be executed");
}
catch (ArgumentException ex)
{
  Console.WriteLine($"Caught different parameter: {ex.Message}");
}
