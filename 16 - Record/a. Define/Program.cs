// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// Create
Demo demo1 = new(1, "two");
Demo demo2 = new(1, "two");

// Generated Properties
Console.WriteLine(demo1.One);                // 1
Console.WriteLine(demo1.Two);                // two

// Supported methods (open):
Console.WriteLine(demo1.Equals(demo2));      // True
Console.WriteLine(demo1.GetHashCode());      // 456035898
Console.WriteLine(demo1.ToString());         // Demo { One = 1, Two = two }

// Supported methods (destructuring):
var (one, two) = demo1;
Console.WriteLine(one);       // 1
Console.WriteLine(two);       // two

// Supported with expression (nondestructive mutation):
Console.WriteLine(demo1 with { Two = "new" });  // Demo { One = 1, Two = new }

// Define
public record Demo(int One, string Two);

// Define (full implementation)
/*
public record Demo
{
  public int One { get; init; }
  public string Two { get; init; }

  public Demo(int one, string two)
      => (One, Two) = (one, two);

  public void Deconstruct(out int one, out string two)
      => (one, two) = (One, Two);

  public override bool Equals(object obj)
    => obj is Demo other && One == other.One && Two == other.Two;

  public override int GetHashCode()
    => HashCode.Combine(One, Two);

  public override string ToString()
    => $"Demo {{ one = {One}, two = {Two} }}";
}
*/