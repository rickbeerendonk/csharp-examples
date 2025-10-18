// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

object obj = "Hello";

// as operator attempts to cast, returns null if unsuccessful
string? str = obj as string;
if (str != null)
{
  Console.WriteLine($"Successfully cast to string: {str}"); // Successfully cast to string: Hello
}

int? num = obj as int?;
if (num == null)
{
  Console.WriteLine("Cannot cast to int, result is null"); // Cannot cast to int, result is null
}
