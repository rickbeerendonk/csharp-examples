// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

int i = 0;

do
{
  i++;
  if (i % 3 == 0) continue;
  if (i % 10 == 0) break;
  Console.WriteLine(i);
} while (i < 20);

// 1
// 2
// 4
// 5
// 7
// 8
