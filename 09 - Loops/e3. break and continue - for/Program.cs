// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

for (var i = 1; i < 20; i++)
{
  if (i % 3 == 0) continue;
  if (i % 10 == 0) break;
  Console.WriteLine(i);
}

// 1
// 2
// 4
// 5
// 7
// 8
