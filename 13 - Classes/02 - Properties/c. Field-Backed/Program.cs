// Copyright © 2026 Rick Beerendonk

Destination destination = new();
destination.City = "  Amsterdam  ";
Console.WriteLine(destination.City);

class Destination
{
  public string City
  {
    get;
    set => field = value.Trim(); // C# 14 supplies the backing field.
  } = "";
}
