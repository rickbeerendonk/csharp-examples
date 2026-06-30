// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Methods are functions defined in a class

Calculator calc = new(2);

int sum = calc.Add(3);
Console.WriteLine($"2 + 3 = {sum}");

int product = calc.Multiply(3);
Console.WriteLine($"2 * 3 = {product}");

calc.PrintMessage("Hello from method!");

class Calculator(int a)
{
  public int Add(int b) => a + b;

  public int Multiply(int b) => a * b;

  public void PrintMessage(string message)
  {
    Console.WriteLine($"{message} | a={a}");
  }
}
