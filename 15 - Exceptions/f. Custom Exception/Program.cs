// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Custom exception class

try
{
  ValidateEmail("invalid-email");
}
catch (InvalidEmailException ex)
{
  Console.WriteLine($"Custom exception: {ex.Message}");
}

try
{
  ValidateEmail("user@example.com");
  Console.WriteLine("Email is valid");
}
catch (InvalidEmailException ex)
{
  Console.WriteLine($"Custom exception: {ex.Message}");
}

void ValidateEmail(string email)
{
  if (!email.Contains("@"))
  {
    throw new InvalidEmailException($"Invalid email format: {email}");
  }
}

class InvalidEmailException : Exception
{
  public InvalidEmailException() : base() { }

  public InvalidEmailException(string message) : base(message) { }

  public InvalidEmailException(string message, Exception innerException)
    : base(message, innerException) { }
}
