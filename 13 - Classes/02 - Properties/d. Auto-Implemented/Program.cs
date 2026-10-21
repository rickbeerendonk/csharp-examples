// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Destination destination = new();
destination.City = "Amsterdam";
Console.WriteLine(destination.City);

class Destination
{
  // Auto-implemented property for the City.
  public string City { get; set; } = "";
}
