// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Definitions can also be passed as compiler arguments using /define:DEBUG or /define:RELEASE
// Visual Studio also allows defining symbols in the project properties under Build > Conditional compilation symbols

#define DEBUG

using System.Diagnostics;

// Conditional attribute

// DEBUG is defined, so DebugLog will be called
// RELEASE is not defined, so ReleaseLog will not be called

[Conditional("DEBUG")]
static void DebugLog(string message)
{
  Console.WriteLine($"DEBUG: {message}");
}

[Conditional("RELEASE")]
static void ReleaseLog(string message)
{
  Console.WriteLine($"RELEASE: {message}");
}

DebugLog("This will print because DEBUG is defined");
ReleaseLog("This won't print because RELEASE is not defined");

Console.WriteLine("Program continues...");
