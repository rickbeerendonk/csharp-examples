// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

#define DEBUG

using System.Diagnostics;

// Conditional attribute

[Conditional("DEBUG")]
void DebugLog(string message)
{
  Console.WriteLine($"DEBUG: {message}");
}

[Conditional("RELEASE")]
void ReleaseLog(string message)
{
  Console.WriteLine($"RELEASE: {message}");
}

DebugLog("This will print because DEBUG is defined");
ReleaseLog("This won't print because RELEASE is not defined");

Console.WriteLine("Program continues...");
