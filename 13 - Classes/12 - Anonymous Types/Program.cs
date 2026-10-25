// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Variables cannot be declared with an explicit type for an anonymous type;
// 'var' must be used.
var customer = new { Name = "Anna", Age = 30 };

Console.WriteLine($"{customer.Name} is {customer.Age} years old.");
Console.WriteLine(customer.GetType().ToString());

// Anna is 30 years old.
// <>f__AnonymousType0`2[System.String,System.Int32]