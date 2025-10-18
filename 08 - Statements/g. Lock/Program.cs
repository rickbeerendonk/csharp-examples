// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// lock statement ensures thread-safe access to shared resources

object lockObject = new();
int counter = 0;

// Simulate multiple threads accessing shared resource
var tasks = new Task[5];
for (int i = 0; i < 5; i++)
{
  int taskId = i;
  tasks[i] = Task.Run(() =>
  {
    for (int j = 0; j < 100; j++)
    {
      lock (lockObject)
      {
        counter++;
        Console.WriteLine($"Task {taskId}: counter = {counter}");
      }
    }
  });
}

Task.WaitAll(tasks);
Console.WriteLine($"Final counter: {counter}");
