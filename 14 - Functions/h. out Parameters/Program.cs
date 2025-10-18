// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// out parameters must be assigned before returning

int result;
bool success = TryParse("123", out result);

Console.WriteLine($"Success: {success}");
Console.WriteLine($"Result: {result}");

// out variable declaration
success = TryParse("456", out int value);
Console.WriteLine($"Success: {success}");
Console.WriteLine($"Value: {value}");

// Failed parse
success = TryParse("abc", out int invalid);
Console.WriteLine($"Success: {success}");
Console.WriteLine($"Invalid: {invalid}");

bool TryParse(string input, out int output)
{
  try
  {
    output = int.Parse(input);
    return true;
  }
  catch
  {
    output = 0;
    return false;
  }
}
