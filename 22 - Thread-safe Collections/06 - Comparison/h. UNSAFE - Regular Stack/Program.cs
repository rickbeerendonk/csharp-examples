// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// UNSAFE: Regular Stack is NOT thread-safe
var unsafeStack = new Stack<string>();

Console.WriteLine("Multi-threaded operations with UNSAFE Stack");
Console.WriteLine("===========================================");
Console.WriteLine();

try
{
  // Multiple threads pushing
  var pushTask1 = Task.Run(() =>
  {
    for (int i = 0; i < 500; i++)
    {
      unsafeStack.Push($"Thread1-{i}"); // Race condition
    }
  });

  var pushTask2 = Task.Run(() =>
  {
    for (int i = 0; i < 500; i++)
    {
      unsafeStack.Push($"Thread2-{i}"); // Race condition
    }
  });

  Task.WaitAll(pushTask1, pushTask2);

  Console.WriteLine($"Expected count: 1000");
  Console.WriteLine($"Actual count: {unsafeStack.Count}");

  if (unsafeStack.Count != 1000)
  {
    Console.WriteLine("❌ Data loss occurred!");
  }

  // Multiple threads popping
  int popped1 = 0, popped2 = 0;
  
  var popTask1 = Task.Run(() =>
  {
    for (int i = 0; i < 500; i++)
    {
      if (unsafeStack.Count > 0)
      {
        unsafeStack.Pop(); // Race condition
        popped1++;
      }
    }
  });

  var popTask2 = Task.Run(() =>
  {
    for (int i = 0; i < 500; i++)
    {
      if (unsafeStack.Count > 0)
      {
        unsafeStack.Pop(); // Race condition
        popped2++;
      }
    }
  });

  Task.WaitAll(popTask1, popTask2);

  Console.WriteLine($"Thread 1 popped: {popped1}");
  Console.WriteLine($"Thread 2 popped: {popped2}");
  Console.WriteLine($"Remaining: {unsafeStack.Count}");
  
  if (popped1 + popped2 + unsafeStack.Count != 1000)
  {
    Console.WriteLine("❌ Items lost or miscounted!");
  }
}
catch (Exception ex)
{
  Console.WriteLine($"❌ Exception: {ex.GetType().Name}");
  Console.WriteLine($"   Message: {ex.Message}");
  Console.WriteLine();
  Console.WriteLine("Common exceptions:");
  Console.WriteLine("- InvalidOperationException: Stack empty (race condition)");
  Console.WriteLine("- NullReferenceException: Corrupted internal state");
}
