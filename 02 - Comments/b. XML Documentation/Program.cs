// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// To generate and validate the XML documentation, run:
//   dotnet build -p:GenerateDocumentationFile=true

Console.WriteLine(Greeting.Create("Anna")); // Hello Anna

/// <summary>Creates greetings for visitors.</summary>
public static class Greeting
{
  /// <summary>Creates a greeting.</summary>
  /// <description>Generates a greeting message for the visitor.</description>
  /// <param name="name">The visitor's name.</param>
  /// <returns>A personalised greeting.</returns>
  /// <remarks>This method generates a simple greeting message for the visitor.</remarks>
  /// <example>
  /// <code>
  /// string greeting = Greeting.Create("Alice");
  /// Console.WriteLine(greeting); // Output: Hello Alice
  /// </code>
  /// </example>
  /// <seealso cref="Create(string)"/>
  public static string Create(string name) => $"Hello {name}";
}