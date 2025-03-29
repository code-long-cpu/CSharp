using System;

//42.polymorphism 多态； objects可以被定义为不同类型的数据
// abstract禁止别人创建抽象类实例
abstract class FortyTwo_polymorphism_Vehicle
{
  public virtual void go()
  {

  }
}
class F_Car : FortyTwo_polymorphism_Vehicle
{
  public override void go()
  {
    Console.WriteLine("The car is moving.");
  }
}
class F_Boat : FortyTwo_polymorphism_Vehicle
{
  public override void go()
  {
    Console.WriteLine("The boat is moving.");
  }
}
class F_Bicycle : FortyTwo_polymorphism_Vehicle
{
  public override void go()
  {
    Console.WriteLine("The bicycle is moving.");
  }
}