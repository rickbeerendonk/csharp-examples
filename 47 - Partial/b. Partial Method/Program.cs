// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Partial method - declaration and implementation

Calculator calc = new();
calc.Calculate(10, 20);

partial class Calculator
{
  // Partial method declaration
  partial void OnCalculating(int a, int b);
  partial void OnCalculated(int result);

  public void Calculate(int a, int b)
  {
    OnCalculating(a, b);
    int result = a + b;
    Console.WriteLine($"Result: {result}");
    OnCalculated(result);
  }
}

// Partial method implementation
partial class Calculator
{
  partial void OnCalculating(int a, int b)
  {
    Console.WriteLine($"Calculating: {a} + {b}");
  }

  partial void OnCalculated(int result)
  {
    Console.WriteLine($"Calculation completed: {result}");
  }
}

// Calculating: 10 + 20
// Result: 30
// Calculation completed: 30
