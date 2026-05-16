// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Custom enumerator with yield return

NumberSequence sequence = new(5);

foreach (var number in sequence)
{
  Console.WriteLine(number);
}

// 0
// 1
// 2
// 3
// 4

class NumberSequence : IEnumerable<int>
{
  private readonly int _count;

  public NumberSequence(int count)
  {
    _count = count;
  }

  public IEnumerator<int> GetEnumerator()
  {
    for (int i = 0; i < _count; i++)
    {
      yield return i;
    }
  }

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }
}
