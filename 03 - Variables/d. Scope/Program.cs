// Copyright © 2026 Rick Beerendonk

int total = 2;

{
  int added = 1;
  total += added;
  Console.WriteLine($"Inside block: {total}, added: {added}");
}

// total is still in scope; added is no longer accessible here.
//Console.WriteLine($"Outside block: {total}, added: {added}");
Console.WriteLine($"Outside block: {total}");

// Inside block: 3, added: 1
// Outside block: 3
