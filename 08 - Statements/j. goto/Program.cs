// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

int number = 5;

if (number < 0)
  goto negative;
if (number == 0)
  goto zero;
goto positive;

// Labels:
// - negative: executed when the number is less than 0
// - zero: executed when the number is 0
// - positive: executed when the number is greater than 0
// - end: executed at the end of the program

// IMPORTANT: Discouraged because it makes the code harder to read and maintain

negative:
  Console.WriteLine("Negative");
  goto end;

zero:
  Console.WriteLine("Zero");
  goto end;

positive:
  Console.WriteLine("Positive");
  //goto end; // Not needed because this is the last label before the end of the program

end:
  Console.WriteLine("Done");

// Positive
// Done
