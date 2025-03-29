using System;

// 43.interface = define a contract that all classes inheriting from should follow;
//An interface declares "what a class should have"
//An inheriting class defines "how it should do it"
//Benefit = security + multiple inheritance + plug-and-play
interface IPrey
{
  void Flee();
}
interface IPredator
{
  void Hunt();
}

class Rabbit : IPrey
{
  public void Flee()
  {
    Console.WriteLine("The rabbit runs away!");
  }
}

class Hawk : IPredator
{
  public void Hunt()
  {
    Console.WriteLine("The hawk is searching for food!");

  }
}
class Fish : IPrey, IPredator
{
  public void Flee()
  {
    Console.WriteLine("The fish swims away!");
  }
  public void Hunt()
  {
    Console.WriteLine("The fish is searching for smaller fish!");

  }
}
