// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Reflecting on methods

using System.Reflection;

Calculator calc = new();
Type type = typeof(Calculator);

MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
Console.WriteLine($"Methods of {type.Name}:");

foreach (var method in methods)
{
  Console.WriteLine($"  {method.Name}");
  foreach (var param in method.GetParameters())
  {
    Console.WriteLine($"    Parameter: {param.Name} ({param.ParameterType.Name})");
  }
}

// Methods of Calculator:
//   Add
//     Parameter: a (Int32)
//     Parameter: b (Int32)
//   Divide
//     Parameter: a (Int32)
//     Parameter: b (Double)

class Calculator
{
  public int Add(int a, int b) => a + b;
  public double Divide(int a, double b) => a / b;
}
