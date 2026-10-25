// Copyright © 2026 Rick Beerendonk

using System.Dynamic;

dynamic reading = new ExpandoObject();
reading.City = "Amsterdam";
reading.Celsius = 18;
reading.WriteReading = (Action)(() => Console.WriteLine($"{reading.City}: {reading.Celsius} Celsius"));

reading.WriteReading();

// Amsterdam: 18 Celsius
