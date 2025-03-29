using System;
using System.ComponentModel.Design;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

class TwentyThree_Method
{
  //对外的方法一定要写public关键字，不写就是private，只能类内部调用；
  //public里面调用了private方法，外部类调用了T_method()方法后依然会执行内部的preivate方法Birthday()；
  public static void T_method()
  {
    Console.WriteLine("23.method");
    String name = "Long";
    int age = 31;
    //23.TwentyThree_Method
    Birthday(name, age);

    //24.return keyword;
    double x;
    double y;
    double result;
    Console.WriteLine("Enter in number_1: ");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter in number_2: ");
    y = Convert.ToDouble(Console.ReadLine());

    result = Multiply(x, y);
    Console.WriteLine(x + " multiply " + y + " is " + result + ";");

    //25.method overload;
    double a = 1.5;
    double b = 1.7;
    double c = 1.6;
    double result2;

    result2 = Multiply(a, b, c);
    Console.WriteLine(a + " multiply " + b + " multiply " + c + " is " + result + ";");

    // 26.params keyword (a method patamrter that takes a variable number of arguments)
    // paramater type must be a single-dimentional array
    double total = Checkout(3.00, 5.00, 15, 1.01);
    Console.WriteLine("26.params keyword total is " + total + ";");

  }

  // static静态属性，类名调用, 无static需要new对象；static静态方法可调用另一个static方法；
  static void Birthday(String name, int age)
  {
    Console.WriteLine("Happy birthday to " + name + "!");
    Console.WriteLine("You are " + age + " years old!");
  }
  static double Multiply(double x, double y)
  {
    double z = x * y;
    return z;
  }
  static double Multiply(double x, double y, double z)
  {
    return x * y * z;
  }
  // 26.params keyword
  static double Checkout(params double[] prices)
  {
    double sum = 0;
    foreach (double price in prices)
    {
      sum += price;
    }
    return sum;
  }
}

