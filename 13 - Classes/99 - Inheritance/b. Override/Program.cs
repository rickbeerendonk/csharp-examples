// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Method overriding with virtual and override

Animal animal = new Animal();
animal.MakeSound(); // Animal sound

Dog dog = new Dog();
dog.MakeSound(); // Bark!

Cat cat = new Cat();
cat.MakeSound(); // Meow!

// Polymorphism
Animal myPet = new Dog();
myPet.MakeSound(); // Bark!

class Animal
{
  public virtual void MakeSound()
  {
    Console.WriteLine("Animal sound");
  }
}

class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Bark!");
  }
}

class Cat : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Meow!");
  }
}
