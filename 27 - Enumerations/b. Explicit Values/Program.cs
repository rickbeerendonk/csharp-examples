// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Console.WriteLine(Status.Pending);           // Pending
Console.WriteLine((int)Status.Pending);      // 10
Console.WriteLine(Status.Active);            // Active
Console.WriteLine((int)Status.Active);       // 20
Console.WriteLine(Status.Completed);         // Completed
Console.WriteLine((int)Status.Completed);    // 30

enum Status
{
    Pending = 10,
    Active = 20,
    Completed = 30,
    Cancelled = 40
}
