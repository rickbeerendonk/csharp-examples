// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// From int to enum
Status status1 = (Status)1;
Console.WriteLine(status1);                   // Active

// From enum to int
int value1 = (int)Status.Completed;
Console.WriteLine(value1);                    // 2

// Invalid cast (no runtime error, but undefined behavior)
Status status2 = (Status)99;
Console.WriteLine(status2);                   // 99 (displays as number)
Console.WriteLine((int)status2);              // 99

// Check if valid
Console.WriteLine(Enum.IsDefined(typeof(Status), status1));  // True
Console.WriteLine(Enum.IsDefined(typeof(Status), status2));  // False

enum Status
{
    Pending,
    Active,
    Completed,
    Cancelled
}
