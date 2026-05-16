// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// IQueryable - LINQ provider for custom data source

PersonQueryable people = new();

// Use LINQ with IQueryable
var adults = people.Where(p => p.Age >= 18);
var sorted = adults.OrderBy(p => p.Name);

Console.WriteLine("Adults (sorted by name):");
foreach (var person in sorted)
{
  Console.WriteLine($"{person.Name} - {person.Age}");
}

// Adults (sorted by name):
// Alice - 30
// Bob - 20
// Charlie - 25

record Person(string Name, int Age);

class PersonQueryable : IQueryable<Person>
{
  private readonly List<Person> _data =
  [
    new Person("Alice", 30),
    new Person("Bob", 20),
    new Person("Charlie", 25),
    new Person("Diana", 15)
  ];

  public Type ElementType => typeof(Person);
  public System.Linq.Expressions.Expression Expression => System.Linq.Expressions.Expression.Constant(this);
  public IQueryProvider Provider => new PersonQueryProvider(_data.AsQueryable());

  public IEnumerator<Person> GetEnumerator() => _data.GetEnumerator();
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}

class PersonQueryProvider : IQueryProvider
{
  private readonly IQueryable<Person> _queryable;

  public PersonQueryProvider(IQueryable<Person> queryable)
  {
    _queryable = queryable;
  }

  public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
  {
    return _queryable.Provider.CreateQuery(expression);
  }

  public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
  {
    return _queryable.Provider.CreateQuery<TElement>(expression);
  }

  public object? Execute(System.Linq.Expressions.Expression expression)
  {
    return _queryable.Provider.Execute(expression);
  }

  public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
  {
    return _queryable.Provider.Execute<TResult>(expression);
  }
}
