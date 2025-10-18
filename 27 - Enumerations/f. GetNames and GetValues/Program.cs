// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Get all names
string[] names = Enum.GetNames<Status>();
Console.WriteLine(string.Join(", ", names)); // Pending, Active, Completed, Cancelled

// Get all values
Status[] values = Enum.GetValues<Status>();
foreach (var value in values)
{
    Console.WriteLine($"{value} = {(int)value}");
}
// Pending = 0
// Active = 1
// Completed = 2
// Cancelled = 3

// IsDefined
Console.WriteLine(Enum.IsDefined(typeof(Status), "Pending"));  // True
Console.WriteLine(Enum.IsDefined(typeof(Status), "Unknown"));  // False

enum Status
{
    Pending,
    Active,
    Completed,
    Cancelled
}
