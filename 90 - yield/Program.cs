foreach (var i in GetNumberLazy().Take(4))
{
	Console.WriteLine(i);
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

IEnumerable<int> GetNumberEager()
{
	return [1, 2, 4, 8];
}