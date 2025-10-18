// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Exception handling in async methods

try
{
  await FailingOperationAsync();
}
catch (InvalidOperationException ex)
{
  Console.WriteLine($"Caught exception: {ex.Message}");
}

// Multiple async operations with exception
try
{
  await Task.WhenAll(
    SuccessfulOperationAsync(),
    FailingOperationAsync()
  );
}
catch (Exception ex)
{
  Console.WriteLine($"One or more operations failed: {ex.Message}");
}

async Task SuccessfulOperationAsync()
{
  await Task.Delay(100);
  Console.WriteLine("Operation succeeded");
}

async Task FailingOperationAsync()
{
  await Task.Delay(200);
  throw new InvalidOperationException("Operation failed");
}
