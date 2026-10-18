// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// continue skips the rest of the current loop iteration

int skip = 3;

// For

Console.WriteLine("for:");
for (int i = 1; i <= 5; i++)
{
  if (i == skip)
    continue; // Skip 3; the for-loop increment still runs.
  Console.WriteLine(i);
}

// Foreach

Console.WriteLine("foreach:");
foreach (int number in new[] { 1, 2, 3, 4, 5 })
{
  if (number == skip)
    continue; // Skip 3 and move to the next item.
  Console.WriteLine(number);
}

// While

Console.WriteLine("while:");
int count = 0;
while (count < 5)
{
  count++;
  if (count == skip)
    continue; // Skip 3 and check the loop condition again.
  Console.WriteLine(count);
}

// Do-While

Console.WriteLine("do-while:");
count = 0;
do
{
  count++;
  if (count == skip)
    continue; // Skip 3, then check the condition at the loop's end.
  Console.WriteLine(count);
} while (count < 5);
