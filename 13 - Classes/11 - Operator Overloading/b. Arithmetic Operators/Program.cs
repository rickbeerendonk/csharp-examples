// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

using System.Globalization;

// Arithmetic operator overloading: vector arithmetic

Vector first = new(3, 4);
Vector second = new(1, 2);

Vector sum = first + second;
Console.WriteLine($"{first} + {second} = {sum}");

Vector difference = first - second;
Console.WriteLine($"{first} - {second} = {difference}");

Vector scaled = first * 2;
Console.WriteLine($"{first} * 2 = {scaled}");

Vector divided = first / 2;
Console.WriteLine($"{first} / 2 = {divided}");

// (3, 4) + (1, 2) = (4, 6)
// (3, 4) - (1, 2) = (2, 2)
// (3, 4) * 2 = (6, 8)
// (3, 4) / 2 = (1.5, 2)

class Vector(decimal x, decimal y)
{
  public decimal X { get; } = x;
  public decimal Y { get; } = y;

  public static Vector operator +(Vector a, Vector b)
  {
    return new Vector(a.X + b.X, a.Y + b.Y);
  }

  public static Vector operator -(Vector a, Vector b)
  {
    return new Vector(a.X - b.X, a.Y - b.Y);
  }

  public static Vector operator *(Vector vector, decimal factor)
  {
    return new Vector(vector.X * factor, vector.Y * factor);
  }

  public static Vector operator /(Vector vector, decimal divisor)
  {
    return new Vector(vector.X / divisor, vector.Y / divisor);
  }

  public override string ToString() =>
    $"({X.ToString()}, {Y.ToString()})";
}
