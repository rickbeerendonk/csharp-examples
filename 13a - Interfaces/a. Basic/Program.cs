// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Basic interface definition and implementation

IDrawable circle = new Circle();
circle.Draw();

IDrawable rectangle = new Rectangle();
rectangle.Draw();

interface IDrawable
{
  void Draw();
}

class Circle : IDrawable
{
  public void Draw()
  {
    Console.WriteLine("Drawing a circle");
  }
}

class Rectangle : IDrawable
{
  public void Draw()
  {
    Console.WriteLine("Drawing a rectangle");
  }
}
