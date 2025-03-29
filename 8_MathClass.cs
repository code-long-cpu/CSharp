using System;


// 8.c# MathClass
class MathClass
{
  // static 是类方法，只能通过类名调用；不用new关键字创建实例。
  public static void Kecheng()
  {
    double x = 3;
    double a = Math.Pow(x, 2);

    Console.WriteLine(a);
  }
}


