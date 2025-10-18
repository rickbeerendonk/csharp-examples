// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Multiple catch blocks for different exception types

try
{
  Console.WriteLine("Enter 1 for divide by zero, 2 for null reference, 3 for index out of range:");
  int choice = 1; // Simulating user input

  if (choice == 1)
  {
    int result = 10 / 0;
  }
  else if (choice == 2)
  {
    string? text = null;
    Console.WriteLine(text!.Length);
  }
  else if (choice == 3)
  {
    int[] arr = { 1, 2, 3 };
    Console.WriteLine(arr[10]);
  }
}
catch (DivideByZeroException ex)
{
  Console.WriteLine($"Division by zero: {ex.Message}");
}
catch (NullReferenceException ex)
{
  Console.WriteLine($"Null reference: {ex.Message}");
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine($"Index out of range: {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"General exception: {ex.Message}");
}
