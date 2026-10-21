// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Abstract classes cannot be instantiated and may contain abstract members

Shape circle = new Circle(5);
circle.Draw();
Console.WriteLine($"Area: {circle.GetArea():F2}");

Shape rectangle = new Rectangle(4, 6);
rectangle.Draw();
Console.WriteLine($"Area: {rectangle.GetArea():F2}");

// Because GetArea is abstract, the class 'Shape' must also be declared as abstract.
abstract class Shape
{
  // Abstract method (no implementation)
  public abstract double GetArea();

  // Concrete method
  public void Draw()
  {
    Console.WriteLine($"Drawing a {this.GetType().Name}");
  }
}

class Circle(double radius) : Shape
{
  private double _radius = radius;

  public override double GetArea()
  {
    return Math.PI * _radius * _radius;
  }
}

class Rectangle(double width, double height) : Shape
{
  private double _width = width;
  private double _height = height;

  public override double GetArea()
  {
    return _width * _height;
  }
}
