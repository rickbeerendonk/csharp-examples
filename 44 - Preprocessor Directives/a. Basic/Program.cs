// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// To run these examples in the CLI, without preprocessor directives enabled, use the following command:
// dotnet run
//
// To run these examples in the CLI, with preprocessor directives enabled, use the following command:
// dotnet run -p:DefineConstants="DEBUG;TRACE"
//
// Preprocessor directives are used to conditionally compile code based on defined symbols. 
// They are processed before compilation and can be used to include 
// or exclude code, generate warnings or errors, and organize code into regions.

// Preprocessor directives

#define DEBUG
#define TRACE

using System;

#if DEBUG
Console.WriteLine("Debug mode enabled");
#endif

#if TRACE
Console.WriteLine("Trace mode enabled");
#endif

#if DEBUG && TRACE
Console.WriteLine("Both DEBUG and TRACE are defined");
#endif

#region Math Operations
int Add(int a, int b) => a + b;
int Subtract(int a, int b) => a - b;
#endregion

Console.WriteLine($"Add: {Add(5, 3)}");

#warning This is a warning message
// #error This would cause a compilation error

// Debug mode enabled
// Trace mode enabled
// Both DEBUG and TRACE are defined
// Add: 8