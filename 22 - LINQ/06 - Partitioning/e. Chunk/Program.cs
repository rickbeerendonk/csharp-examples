// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

IEnumerable<string> names = ["Alice", "Bob", "Charlie", "David", "Eve", "Frank"];

var result = names.Chunk(2);

foreach (var chunk in result)
{
    Console.WriteLine(string.Join(", ", chunk));
}

// Alice, Bob
// Charlie, David
// Eve, Frank
