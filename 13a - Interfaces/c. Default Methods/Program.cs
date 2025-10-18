// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Default interface methods (C# 8.0+)

ILogger logger1 = new ConsoleLogger();
logger1.Log("Hello from ConsoleLogger");
logger1.LogWarning("This is a warning"); // Uses default implementation

ILogger logger2 = new CustomLogger();
logger2.Log("Hello from CustomLogger");
logger2.LogWarning("Custom warning"); // Uses custom implementation

interface ILogger
{
  void Log(string message);

  // Default implementation
  void LogWarning(string message)
  {
    Console.WriteLine($"[WARNING] {message}");
  }
}

class ConsoleLogger : ILogger
{
  public void Log(string message)
  {
    Console.WriteLine($"[LOG] {message}");
  }
}

class CustomLogger : ILogger
{
  public void Log(string message)
  {
    Console.WriteLine($"[CUSTOM] {message}");
  }

  // Override default implementation
  public void LogWarning(string message)
  {
    Console.WriteLine($"[CUSTOM WARNING] {message}");
  }
}
