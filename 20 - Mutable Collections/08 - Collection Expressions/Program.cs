// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// The same [...] syntax creates different collection types.
int[] array = [18, 2, 5];
List<int> list = [18, 2, 5];
Span<int> span = [18, 2, 5];
IEnumerable<int> sequence = [18, 2, 5];
int[] empty = [];

Console.WriteLine(array.GetType().Name);  // Int32[]
Console.WriteLine(list.GetType().Name);   // List`1
Console.WriteLine(span.Length);           // 3
Console.WriteLine(sequence.Sum());        // 25
Console.WriteLine(empty.Length);          // 0
