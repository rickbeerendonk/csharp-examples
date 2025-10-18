// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// UNSAFE: Regular List is NOT thread-safe
var unsafeList = new List<int>();

Console.WriteLine("Running unsafe List with multiple threads...");
Console.WriteLine("This will likely cause exceptions or incorrect results.");
Console.WriteLine();

try
{
  var tasks = new Task[10];
  for (int i = 0; i < 10; i++)
  {
    int threadId = i;
    tasks[i] = Task.Run(() =>
    {
      for (int j = 0; j < 1000; j++)
      {
        // Race condition: multiple threads modifying the same list
        unsafeList.Add(threadId * 1000 + j);
      }
    });
  }

  Task.WaitAll(tasks);
  
  Console.WriteLine($"Expected count: 10000");
  Console.WriteLine($"Actual count: {unsafeList.Count}");
  
  if (unsafeList.Count != 10000)
  {
    Console.WriteLine("❌ Data loss occurred due to race conditions!");
  }
}
catch (Exception ex)
{
  Console.WriteLine($"❌ Exception: {ex.GetType().Name}");
  Console.WriteLine($"   Message: {ex.Message}");
  Console.WriteLine();
  Console.WriteLine("Common exceptions:");
  Console.WriteLine("- ArgumentException: Invalid index");
  Console.WriteLine("- IndexOutOfRangeException: Race condition during resize");
  Console.WriteLine("- NullReferenceException: Corrupted internal state");
}
