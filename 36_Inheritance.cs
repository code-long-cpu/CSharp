using System;

// 36.inheritance
// 37.abstruct classes: missing components or incomplete implementation
//prevent instantiating objects from Vehicle (为了程序安全)
abstract class ThirtySix_Inherit_Vehicle
{
  public int speed = 0;

  public void go()
  {
    Console.WriteLine("This vehicle is moving!");
  }

  // 40.method onerriding 子类重写父类方法,inhertend method must be acstract, vitual, or already overriden.
  public virtual void run()
  {
    Console.WriteLine("Vehicle can run fast.");
  }
}

class Car : ThirtySix_Inherit_Vehicle
{
  public int wheels = 4;
  int maxSpeed = 500;

  // 38.array of object
  public String model;
  public String make;
  public Car()
  {
  }
  public Car(String model)
  {
    this.model = model;
  }
  public Car(String model, String make)
  {
    this.model = model;
    this.make = make;
  }

  // 40.method onerriding
  public override void run()
  {
    Console.WriteLine("Car can run fast.");
  }

  //41.toString methods(override重写object自带的tostring方法) 返回自定义实例的内容
  public override string ToString()
  {
    return "This is a " + make + " " + model + ".";
  }
  // 41.tostring()下面这个方法也行
  public string dayin()
  {
    return "Dayin:This is a " + make + " " + model + ".";
  }

}
class Bicycle : ThirtySix_Inherit_Vehicle
{
  public int wheels = 2;
  int maxSpeed = 50;
  public String model;
  public Bicycle()
  {
  }

  public Bicycle(String model)
  {
    this.model = model;
  }
}
class Boat : ThirtySix_Inherit_Vehicle
{
  public int wheels = 0;
  int maxSpeed = 100;
  public String model;
  public String color;
  public Boat()
  {

  }
  public Boat(String model, String color)
  {
    this.model = model;
    this.color = color;
  }
}