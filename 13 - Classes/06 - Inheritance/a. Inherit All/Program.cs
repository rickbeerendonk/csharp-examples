// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

MySuper sup = new();
sup.Foo(); // MySuper.Foo

MySub sub = new();
sub.Foo(); // MySuper.Foo

class MySuper
{
  public void Foo() => Console.WriteLine("MySuper.Foo");
}

class MySub : MySuper {}