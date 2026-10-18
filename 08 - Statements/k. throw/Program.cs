// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

try
{
  int age = -5;

  if (age < 0) {
    // Throw an exception if the age is negative
    throw new ArgumentException("Age cannot be negative", nameof(age));
  }

  Console.WriteLine($"Age: {age}");
}
catch (ArgumentException ex)
{
  Console.WriteLine($"Error: {ex.Message}");
}

// Rethrow the same exception with its original stack trace.
try
{
  try
  {
    throw new InvalidOperationException("Something went wrong");
  }
  catch (InvalidOperationException)
  {
    Console.WriteLine("Rethrowing...");

    // Rethrow the exception to preserve the original stack trace
    throw;
  }
}
catch (InvalidOperationException ex)
{
  Console.WriteLine($"Caught again: {ex.Message}");
}

// Error: Age cannot be negative (Parameter 'age')
// Caught and re-throwing...
// Caught again: Something went wrong
