// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Predefined attributes

[Obsolete("Use NewMethod instead")]
void OldMethod()
{
  Console.WriteLine("Old method");
}

void NewMethod()
{
  Console.WriteLine("New method");
}

// Using obsolete method (will show warning)
OldMethod();
NewMethod();

[Obsolete("This is really old", true)] // true = error instead of warning
void VeryOldMethod()
{
  Console.WriteLine("Very old method");
}

// VeryOldMethod(); // Uncomment to see error
