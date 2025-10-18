// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Console.WriteLine(Status.Pending);            // Pending
Console.WriteLine((byte)Status.Pending);      // 0
Console.WriteLine(Status.Cancelled);          // Cancelled
Console.WriteLine((byte)Status.Cancelled);    // 3

// Underlying type
Console.WriteLine(Enum.GetUnderlyingType(typeof(Status))); // System.Byte

enum Status : byte
{
    Pending,
    Active,
    Completed,
    Cancelled
}
