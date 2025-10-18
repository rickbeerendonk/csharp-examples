// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Generic interfaces

IRepository<Person> personRepo = new PersonRepository();
personRepo.Add(new Person { Id = 1, Name = "Rick" });
personRepo.Add(new Person { Id = 2, Name = "Alice" });

Person? person = personRepo.GetById(1);
Console.WriteLine($"Found: {person?.Name}");

interface IRepository<T>
{
  void Add(T item);
  T? GetById(int id);
}

class PersonRepository : IRepository<Person>
{
  private List<Person> _people = new();

  public void Add(Person item)
  {
    _people.Add(item);
    Console.WriteLine($"Added person: {item.Name}");
  }

  public Person? GetById(int id)
  {
    return _people.FirstOrDefault(p => p.Id == id);
  }
}

class Person
{
  public int Id { get; set; }
  public string Name { get; set; } = "";
}
