// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Multiple async operations

Console.WriteLine("Starting multiple operations...");

// Sequential execution
await Operation1();
await Operation2();
await Operation3();

Console.WriteLine("\nStarting parallel operations...");

// Parallel execution with Task.WhenAll
await Task.WhenAll(
  Operation1(),
  Operation2(),
  Operation3()
);

Console.WriteLine("All operations completed");

async Task Operation1()
{
  await Task.Delay(1000);
  Console.WriteLine("Operation 1 completed");
}

async Task Operation2()
{
  await Task.Delay(500);
  Console.WriteLine("Operation 2 completed");
}

async Task Operation3()
{
  await Task.Delay(1500);
  Console.WriteLine("Operation 3 completed");
}
