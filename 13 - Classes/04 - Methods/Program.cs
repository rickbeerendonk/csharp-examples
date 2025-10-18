// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Methods are functions defined in a class

Calculator calc = new();

int sum = calc.Add(5, 3);
Console.WriteLine($"5 + 3 = {sum}");

int product = calc.Multiply(4, 7);
Console.WriteLine($"4 * 7 = {product}");

calc.PrintMessage("Hello from method!");

class Calculator
{
  public int Add(int a, int b)
  {
    return a + b;
  }

  public int Multiply(int a, int b)
  {
    return a * b;
  }

  public void PrintMessage(string message)
  {
    Console.WriteLine(message);
  }
}
