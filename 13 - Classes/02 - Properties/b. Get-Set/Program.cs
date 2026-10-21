// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Destination destination = new();
destination.City = "  Amsterdam  ";
Console.WriteLine(destination.City);

class Destination
{
  // Backing field for the City property.
  private string _city = "";

  public string City
  {
    get { return _city; }
    set { _city = value.Trim(); }
  }
}
