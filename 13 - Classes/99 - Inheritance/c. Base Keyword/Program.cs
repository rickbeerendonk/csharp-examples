// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Base keyword to call parent class members

Dog dog = new Dog("Buddy", "Golden Retriever");
dog.Display();

class Animal
{
  public string Name { get; set; }

  public Animal(string name)
  {
    Name = name;
    Console.WriteLine($"Animal constructor: {name}");
  }

  public virtual void Display()
  {
    Console.WriteLine($"Animal: {Name}");
  }
}

class Dog : Animal
{
  public string Breed { get; set; }

  public Dog(string name, string breed) : base(name)
  {
    Breed = breed;
    Console.WriteLine($"Dog constructor: {breed}");
  }

  public override void Display()
  {
    base.Display(); // Call parent method
    Console.WriteLine($"Breed: {Breed}");
  }
}
