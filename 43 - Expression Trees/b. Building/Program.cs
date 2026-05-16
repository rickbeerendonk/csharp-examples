// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Building expression trees manually

using System.Linq.Expressions;

// Build: (x, y) => x * y + 2
ParameterExpression x = Expression.Parameter(typeof(int), "x");
ParameterExpression y = Expression.Parameter(typeof(int), "y");

BinaryExpression multiply = Expression.Multiply(x, y);
ConstantExpression two = Expression.Constant(2);
BinaryExpression add = Expression.Add(multiply, two);

Expression<Func<int, int, int>> lambda = Expression.Lambda<Func<int, int, int>>(
  add,
  x, y
);

Console.WriteLine($"Expression: {lambda}");

var compiled = lambda.Compile();
Console.WriteLine($"Result for (3, 4): {compiled(3, 4)}");

// Expression: (x, y) => ((x * y) + 2)
// Result for (3, 4): 14
