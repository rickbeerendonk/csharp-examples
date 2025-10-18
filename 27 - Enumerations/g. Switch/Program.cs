// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

Status status = Status.Active;

switch (status)
{
    case Status.Pending:
        Console.WriteLine("Task is pending");
        break;
    case Status.Active:
        Console.WriteLine("Task is active");
        break;
    case Status.Completed:
        Console.WriteLine("Task is completed");
        break;
    case Status.Cancelled:
        Console.WriteLine("Task is cancelled");
        break;
}

// Task is active

// Switch expression
string result = status switch
{
    Status.Pending => "Task is pending",
    Status.Active => "Task is active",
    Status.Completed => "Task is completed",
    Status.Cancelled => "Task is cancelled",
    _ => "Unknown status"
};
Console.WriteLine(result); // Task is active

enum Status
{
    Pending,
    Active,
    Completed,
    Cancelled
}
