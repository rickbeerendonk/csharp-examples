// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Interface inheritance

IAdvancedLogger logger = new FileLogger();
logger.Log("Standard log message");
logger.LogError("Error message");
logger.LogDebug("Debug message");

interface ILogger
{
  void Log(string message);
  void LogError(string message);
}

// IAdvancedLogger inherits from ILogger
interface IAdvancedLogger : ILogger
{
  void LogDebug(string message);
}

class FileLogger : IAdvancedLogger
{
  public void Log(string message)
  {
    Console.WriteLine($"[LOG] {message}");
  }

  public void LogError(string message)
  {
    Console.WriteLine($"[ERROR] {message}");
  }

  public void LogDebug(string message)
  {
    Console.WriteLine($"[DEBUG] {message}");
  }
}
