// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Parse from string
Status status1 = Enum.Parse<Status>("Pending");
Console.WriteLine(status1);                   // Pending

// TryParse
if (Enum.TryParse<Status>("Active", out Status status2))
{
    Console.WriteLine(status2);               // Active
}

// Parse with ignoreCase
Status status3 = Enum.Parse<Status>("COMPLETED", ignoreCase: true);
Console.WriteLine(status3);                   // Completed

// Invalid parse
try
{
    Status invalid = Enum.Parse<Status>("Unknown");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.GetType().Name);     // ArgumentException
}

enum Status
{
    Pending,
    Active,
    Completed,
    Cancelled
}
