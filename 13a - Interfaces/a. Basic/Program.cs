// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Basic interface definition and implementation

IDrawable drawable;

drawable = new Circle();
drawable.Draw();

drawable = new Rectangle();
drawable.Draw();

interface IDrawable
{
  void Draw();
}

class Circle : IDrawable
{
  public void Draw() => Console.WriteLine("Drawing a circle");
}

class Rectangle : IDrawable
{
  public void Draw() => Console.WriteLine("Drawing a rectangle");
}
