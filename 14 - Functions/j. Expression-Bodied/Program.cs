// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Expression-bodied members provide concise syntax

Calculator calc = new();

Console.WriteLine($"5 + 3 = {calc.Add(5, 3)}");
Console.WriteLine($"10 - 4 = {calc.Subtract(10, 4)}");
Console.WriteLine($"Area of circle (r=5): {calc.CircleArea(5):F2}");

class Calculator
{
  // Expression-bodied method
  public int Add(int a, int b) => a + b;

  // Expression-bodied method
  public int Subtract(int a, int b) => a - b;

  // Expression-bodied property
  public double Pi => 3.14159;

  // Expression-bodied method using property
  public double CircleArea(double radius) => Pi * radius * radius;
}
