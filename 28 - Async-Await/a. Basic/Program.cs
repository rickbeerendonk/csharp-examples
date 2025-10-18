// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Basic async/await

Console.WriteLine("Starting...");

await DoWorkAsync();

Console.WriteLine("Finished");

async Task DoWorkAsync()
{
  Console.WriteLine("Work started");
  await Task.Delay(1000); // Simulate async work
  Console.WriteLine("Work completed after 1 second");
}
