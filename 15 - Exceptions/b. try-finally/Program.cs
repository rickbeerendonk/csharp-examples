// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// try-finally ensures cleanup code runs

try
{
  Console.WriteLine("Trying something...");
  throw new Exception("Something went wrong");
}
finally
{
  Console.WriteLine("Finally block always executes");
}
