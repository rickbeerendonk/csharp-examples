// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Operator overloading allows custom behavior for operators

Vector v1 = new(3, 4);
Vector v2 = new(1, 2);

Vector sum = v1 + v2;
Console.WriteLine($"({v1.X}, {v1.Y}) + ({v2.X}, {v2.Y}) = ({sum.X}, {sum.Y})");

Vector difference = v1 - v2;
Console.WriteLine($"({v1.X}, {v1.Y}) - ({v2.X}, {v2.Y}) = ({difference.X}, {difference.Y})");

bool areEqual = v1 == v2;
Console.WriteLine($"v1 == v2: {areEqual}");

class Vector
{
  public double X { get; set; }
  public double Y { get; set; }

  public Vector(double x, double y)
  {
    X = x;
    Y = y;
  }

  // Overload + operator
  public static Vector operator +(Vector a, Vector b)
  {
    return new Vector(a.X + b.X, a.Y + b.Y);
  }

  // Overload - operator
  public static Vector operator -(Vector a, Vector b)
  {
    return new Vector(a.X - b.X, a.Y - b.Y);
  }

  // Overload == operator
  public static bool operator ==(Vector a, Vector b)
  {
    return a.X == b.X && a.Y == b.Y;
  }

  // Overload != operator (required when == is overloaded)
  public static bool operator !=(Vector a, Vector b)
  {
    return !(a == b);
  }

  public override bool Equals(object? obj)
  {
    return obj is Vector v && this == v;
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(X, Y);
  }
}
