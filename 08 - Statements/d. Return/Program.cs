// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Return statement exits a method and optionally returns a value

int result = Add(5, 3);
Console.WriteLine($"5 + 3 = {result}");

string greeting = GetGreeting("Rick");
Console.WriteLine(greeting);

PrintMessage("Hello");

int Add(int a, int b)
{
  return a + b; // Returns a value
}

string GetGreeting(string name)
{
  return $"Hello, {name}!"; // Returns a string
}

void PrintMessage(string message)
{
  Console.WriteLine(message);
  return; // Optional return in void method
}
