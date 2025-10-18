// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Console.WriteLine(Status.Pending);            // Pending
Console.WriteLine((int)Status.Pending);       // 0
Console.WriteLine(Status.Active);             // Active
Console.WriteLine((int)Status.Active);        // 1
Console.WriteLine(Status.Completed);          // Completed
Console.WriteLine((int)Status.Completed);     // 2

enum Status
{
    Pending,    // 0
    Active,     // 1
    Completed,  // 2
    Cancelled   // 3
}
