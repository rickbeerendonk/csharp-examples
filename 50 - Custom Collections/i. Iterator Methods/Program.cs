// Copyright © 2026 Rick Beerendonk

// Eager evaluation example
Console.WriteLine("Eager numbers:");

foreach (var i in GetNumberEager().Take(4))
{
	Console.WriteLine(i);
}

// Lazy evaluation example
Console.WriteLine("\nLazy numbers:");

foreach (var i in GetNumberLazy().Take(4))
{
	Console.WriteLine(i);
}

// Until limit example
Console.WriteLine("\nUntil limit:");
foreach (var i in UntilLimit(4))
{
	Console.WriteLine(i);
}

IEnumerable<int> GetNumberEager()
{
	return [1, 2, 4, 8];
}

IEnumerable<int> GetNumberLazy()
{
	int i = 1;
	while (true)
	{
		yield return i;
		i *= 2;
	}
}

IEnumerable<int> UntilLimit(int maximum)
{
	foreach (int number in GetNumberEager())
	{
		if (number > maximum) yield break; // Ends the entire enumeration.
		yield return number;
	}
}

// Eager numbers:
// 1
// 2
// 4
// 8
// 
// Lazy numbers:
// 1
// 2
// 4
// 8
// 
// Until limit:
// 1
// 2