// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Local functions are functions defined within another function

int result = CalculateSum(5, 10);
Console.WriteLine($"Sum: {result}");

int product = CalculateProduct(4, 7);
Console.WriteLine($"Product: {product}");

int CalculateSum(int a, int b)
{
  // Local function
  int Add(int x, int y)
  {
    return x + y;
  }

  return Add(a, b);
}

int CalculateProduct(int a, int b)
{
  // Local function with access to outer variables
  int Multiply()
  {
    return a * b;
  }

  return Multiply();
}
