// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Error: reject use of the obsolete method at compile time.
// true = compile-time error
[Obsolete("Use NewMethod instead", true)]
void VeryOldMethod()
{
  Console.WriteLine("Very old method");
}

// Warning: provide a replacement for callers.
[Obsolete("Use NewMethod instead")]
void OldMethod()
{
  Console.WriteLine("Old method");
}

void NewMethod()
{
  Console.WriteLine("New method");
}

// VeryOldMethod(); // Compile-time error
OldMethod(); // Compile-time warning
NewMethod();

