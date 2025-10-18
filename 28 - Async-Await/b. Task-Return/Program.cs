// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Task<T> returns a value

Console.WriteLine("Calculating...");

int result = await CalculateAsync();
Console.WriteLine($"Result: {result}");

string greeting = await GetGreetingAsync("Rick");
Console.WriteLine(greeting);

async Task<int> CalculateAsync()
{
  await Task.Delay(500);
  return 42;
}

async Task<string> GetGreetingAsync(string name)
{
  await Task.Delay(300);
  return $"Hello, {name}!";
}
