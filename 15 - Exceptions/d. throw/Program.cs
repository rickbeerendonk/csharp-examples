// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// throw statement raises an exception

try
{
  ValidateAge(15);
}
catch (ArgumentException ex)
{
  Console.WriteLine($"Validation error: {ex.Message}");
}

try
{
  ValidateAge(25);
  Console.WriteLine("Age is valid");
}
catch (ArgumentException ex)
{
  Console.WriteLine($"Validation error: {ex.Message}");
}

void ValidateAge(int age)
{
  if (age < 18)
  {
    throw new ArgumentException("Age must be at least 18");
  }
}
