// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Invoking methods via reflection

using System.Reflection;

Calculator calc = new();
Type type = typeof(Calculator);

MethodInfo? addMethod = type.GetMethod("Add");
if (addMethod != null)
{
  object? result = addMethod.Invoke(calc, [5, 3]);
  Console.WriteLine($"5 + 3 = {result}");
}

// 5 + 3 = 8

class Calculator
{
  public int Add(int a, int b) => a + b;
}
