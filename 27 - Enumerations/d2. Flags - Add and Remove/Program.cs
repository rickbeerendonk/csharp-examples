// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

var options = Options.Bold | Options.Italic;
Console.WriteLine(options);                              // Bold, Italic
Console.WriteLine((int)options);                         // 3

Console.WriteLine(options.HasFlag(Options.Bold));        // True
Console.WriteLine(options.HasFlag(Options.Underline));   // False

// Add a flag
options |= Options.Underline;
Console.WriteLine(options);                              // Bold, Italic, Underline
Console.WriteLine((int)options);                         // 7

// Remove a flag
options &= ~Options.Italic;
Console.WriteLine(options);                              // Bold, Underline
Console.WriteLine((int)options);                         // 5

[Flags]
enum Options
{
    None = 0,
    Bold = 1,
    Italic = 2,
    Underline = 4,
    Strikethrough = 8
}
 