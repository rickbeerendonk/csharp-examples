// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Unary operator overloading: ++, --, -, +, !

Money money = new(5);
Console.WriteLine($"Initial: {money.Value}");

money++;
Console.WriteLine($"After ++: {money.Value}");

money--;
Console.WriteLine($"After --: {money.Value}");

Money negative = -money;
Console.WriteLine($"Negated: {negative.Value}");

Money positive = +money;
Console.WriteLine($"Positive: {positive.Value}");

// Initial: 5
// After ++: 6
// After --: 5
// Negated: -5
// Positive: 5

class Money(decimal value, string symbol = "€")
{
  public decimal Value { get; set; } = value;
  public string Symbol { get; set; } = symbol;

  // Unary ++ operator
  public static Money operator ++(Money m)
  {
    return new Money(m.Value + 1, m.Symbol);
  }

  // Unary -- operator
  public static Money operator --(Money m)
  {
    return new Money(m.Value - 1, m.Symbol);
  }

  // Unary - operator (negation)
  public static Money operator -(Money m)
  {
    return new Money(-m.Value, m.Symbol);
  }

  // Unary + operator
  public static Money operator +(Money m)
  {
    return new Money(+m.Value, m.Symbol);
  }
}
