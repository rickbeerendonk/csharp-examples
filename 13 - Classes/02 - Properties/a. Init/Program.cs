// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

Destination destination1 = new("Amsterdam");
Console.WriteLine(destination1.City);

Destination destination2 = new()
{
  // Initialize the City property with the provided value.
  City = "Utrecht"
};
Console.WriteLine(destination2.City);

class Destination
{
  // The City property can only be set during object initialization or in the constructor.
  public string City { get; init; } = "";

  public Destination()
  {
  }

  public Destination(string city)
  {
    // Initialize the City property with the provided value.
    City = city;
  }
}
