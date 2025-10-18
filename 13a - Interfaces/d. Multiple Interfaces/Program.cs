// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

// Class implementing multiple interfaces

Robot robot = new();

IMovable movable = robot;
movable.Move();

ISpeakable speakable = robot;
speakable.Speak();

IChargeable chargeable = robot;
chargeable.Charge();

interface IMovable
{
  void Move();
}

interface ISpeakable
{
  void Speak();
}

interface IChargeable
{
  void Charge();
}

class Robot : IMovable, ISpeakable, IChargeable
{
  public void Move()
  {
    Console.WriteLine("Robot is moving");
  }

  public void Speak()
  {
    Console.WriteLine("Robot is speaking");
  }

  public void Charge()
  {
    Console.WriteLine("Robot is charging");
  }
}
