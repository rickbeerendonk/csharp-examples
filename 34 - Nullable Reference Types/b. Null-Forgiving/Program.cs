// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Null-forgiving operator (!)

string? nullableText = GetText();

// Without null-forgiving operator - warning
// int length = nullableText.Length;

// With null-forgiving operator - suppresses warning
int length = nullableText!.Length;
Console.WriteLine($"Length: {length}");

string? GetText()
{
  // This method might return null, but we know it won't in this case
  return "Hello";
}
