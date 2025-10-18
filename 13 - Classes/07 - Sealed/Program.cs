// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Sealed classes cannot be inherited

SealedClass obj = new();
obj.PrintMessage();

// This would cause a compile error:
// class DerivedClass : SealedClass { }

sealed class SealedClass
{
  public void PrintMessage()
  {
    Console.WriteLine("This is a sealed class - cannot be inherited");
  }
}
