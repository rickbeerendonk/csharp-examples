// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

// bool Predicate<in>

Predicate<int> isLarge = Foo.IsLarge;
Console.WriteLine(isLarge(3));  // False
Console.WriteLine(isLarge(12)); // True

class Foo
{
    public static bool IsLarge(int value) => value > 10;
}