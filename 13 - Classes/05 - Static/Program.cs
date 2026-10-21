// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Static members belong to the class, not its instances.
Console.WriteLine($"PI = {MathHelper.PI}");
Console.WriteLine($"Square of 5 = {MathHelper.Square(5)}");

// Static state shared by all instances.
new Counter();
new Counter();
new Counter();
Console.WriteLine($"Total instances created: {Counter.Count}");

static class MathHelper
{
  public static double PI = 3.14159;

  public static int Square(int x) => x * x;
}

class Counter
{
  public static int Count = 0;

  public Counter() => Count++;
}
