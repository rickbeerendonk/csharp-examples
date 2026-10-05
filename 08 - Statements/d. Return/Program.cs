// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Return statement exits a method and optionally returns a value

int result = Add(5, 3);
Console.WriteLine($"5 + 3 = {result}");

string greeting = GetGreeting("Rick");
Console.WriteLine(greeting);

PrintMessage("Hello");

int Add(int a, int b)
{
  return a + b; // Returns an integer value
}

string GetGreeting(string name)
{
  return $"Hello, {name}!"; // Returns a string value
}

void PrintMessage(string message)
{
  Console.WriteLine(message);
  return; // Optional return in void method (does not return a value)
}
