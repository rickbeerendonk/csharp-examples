// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

using System.Globalization;

// Comparison operator overloading: <, >, <=, >=

Money first = new(20.5m);
Money second = new(15m);
Money third = new(20.5m);
Money other = new(25m, "$");

Console.WriteLine($"{first} > {second}: {first > second}");
Console.WriteLine($"{first} < {second}: {first < second}");
Console.WriteLine($"{first} >= {third}: {first >= third}");
Console.WriteLine($"{second} <= {third}: {second <= third}");
Console.WriteLine($"{first} > {other}: {first > other}");

// € 20,50 > € 15,00: True
// € 20,50 < € 15,00: False
// € 20,50 >= € 20,50: True
// € 15,00 <= € 20,50: True
// Unhandled exception. System.InvalidOperationException: Cannot compare amounts with different currencies.

class Money(decimal value, string symbol = "€")
{
  public decimal Value { get; } = value;
  public string Symbol { get; } = symbol;

  // Overload > operator
  public static bool operator >(Money a, Money b)
  {
    return Compare(a, b) > 0;
  }

  // Overload < operator (required when > is overloaded)
  public static bool operator <(Money a, Money b)
  {
    if (a.Symbol != b.Symbol)
      throw new InvalidOperationException("Cannot compare amounts with different currencies.");
    
    return Compare(a, b) < 0;
  }

  // Overload >= operator
  public static bool operator >=(Money a, Money b)
  {
    if (a.Symbol != b.Symbol)
      throw new InvalidOperationException("Cannot compare amounts with different currencies.");
    
    return Compare(a, b) >= 0;
  }

  // Overload <= operator (required when >= is overloaded)
  public static bool operator <=(Money a, Money b)
  {
    if (a.Symbol != b.Symbol)
      throw new InvalidOperationException("Cannot compare amounts with different currencies.");
    
    return Compare(a, b) <= 0;
  }

  private static int Compare(Money a, Money b)
  {
    if (a.Symbol != b.Symbol)
      throw new InvalidOperationException("Cannot compare amounts with different currencies.");

    return a.Value.CompareTo(b.Value);
  }

  public override string ToString()
  {
    NumberFormatInfo format =
      (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
    format.CurrencySymbol = Symbol;
    return Value.ToString("C", format);
  }
}
