// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

// Variables cannot be declared with an explicit type for an anonymous type;
// 'var' must be used.
var customer = new { Name = "Anna", City = "Amsterdam" };

Console.WriteLine($"{customer.Name} lives in {customer.City}.");
Console.WriteLine(customer.GetType().ToString());

// Anna lives in Amsterdam.
// <>f__AnonymousType0`2[System.String,System.String]