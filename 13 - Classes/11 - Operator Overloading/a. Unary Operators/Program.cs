// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

using System.Globalization;

// Unary operator overloading: ++, --, -, +

Money money = new(5);
Console.WriteLine($"Initial: {money}");

money++;
Console.WriteLine($"After ++: {money}");

money--;
Console.WriteLine($"After --: {money}");

Money negative = -money;
Console.WriteLine($"Negated: {negative}");

Money positive = +money;
Console.WriteLine($"Positive: {positive}");

// Example output for a culture that places € before the amount:
// Initial: € 5,00
// After ++: € 6,00
// After --: € 5,00
// Negated: € -5,00
// Positive: € 5,00

class Money(decimal value, string symbol = "€")
{
  public decimal Value { get; } = value;
  public string Symbol { get; } = symbol;

  // Unary ++ operator
  public static Money operator ++(Money money)
  {
    return new Money(money.Value + 1, money.Symbol);
  }

  // Unary -- operator
  public static Money operator --(Money money)
  {
    return new Money(money.Value - 1, money.Symbol);
  }

  // Unary - operator (negation)
  public static Money operator -(Money money)
  {
    return new Money(-money.Value, money.Symbol);
  }

  // Unary + operator
  public static Money operator +(Money money)
  {
    return new Money(+money.Value, money.Symbol);
  }

  public override string ToString()
  {
    NumberFormatInfo format =
      (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
    format.CurrencySymbol = Symbol;
    return Value.ToString("C", format);
  }
}
