// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Empty statement is just a semicolon

int x = 0;

// Empty statement in a loop (not recommended, but valid)
while (x < 5)
{
  x++;
  ; // Empty statement
}

Console.WriteLine($"x = {x}");

// Empty statement after if (not recommended, but valid)
if (x == 5)
  ; // Empty statement

Console.WriteLine("Done");
