// Copyright © 2026 Rick Beerendonk

List<string> cities = ["Amsterdam", "Oslo"];
List<string> itinerary = [.. cities, "Copenhagen"];

cities[0] = "Utrecht"; // Spreading copied elements into a separate collection.

Console.WriteLine(string.Join(", ", cities));    // Utrecht, Oslo
Console.WriteLine(string.Join(", ", itinerary)); // Amsterdam, Oslo, Copenhagen
