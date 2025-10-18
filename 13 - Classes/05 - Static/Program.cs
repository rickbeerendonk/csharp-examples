// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Static members belong to the class, not instances

// Access static members without creating an instance
Console.WriteLine($"PI = {MathHelper.PI}");
Console.WriteLine($"Square of 5 = {MathHelper.Square(5)}");

// Instance counter
Counter c1 = new();
Counter c2 = new();
Counter c3 = new();

Console.WriteLine($"Total instances created: {Counter.Count}");

class MathHelper
{
  public static double PI = 3.14159;

  public static int Square(int x)
  {
    return x * x;
  }
}

class Counter
{
  public static int Count = 0;

  public Counter()
  {
    Count++;
  }
}
