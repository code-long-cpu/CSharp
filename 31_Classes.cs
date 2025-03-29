using System;

// 31_classes;  
//public关键字，外部类可以访问并调用本类内部的属性和方法，输入本类名后面点击.就会自动提示public属性和方法；
//static关键字，直接通过类名访问属性和调用方法，无序创建实例；
class ThirtyOne_Class
{
  //公共静态属性
  public static String T_CLass = "public类属性";
  //公共静态方法
  public static void Hello()
  {
    Console.WriteLine("Hello! Welcome to the program.");
  }
  public static void Watiting()
  {
    Console.WriteLine("I am waititng for something.");
  }
  public static void Bye()
  {
    Console.WriteLine("Bye. Thanks for waiting.");
  }
}

// 32_objects; 
// public关键字,外部类可以访问到该类的public的属性和public方法；
// 属性和方法里无static关键字，new对象后，才能用访问属性和调用里面的方法；
class ThirtyTwo_Object
{
  public string name;
  public int age;

  // 33_constructor 无参数 
  // 35_overloading constructor（different parameters）
  public ThirtyTwo_Object()
  {
  }
  // 33_constructor 有参数 overloading constructor
  // 35_overloading constructor（different parameters）
  public ThirtyTwo_Object(String name, int age)
  {
    this.name = name;
    this.age = age;
  }

  public void Eat()
  {
    Console.WriteLine(name + " is eating.");
  }
  public void Sleep()
  {
    Console.WriteLine(name + " is sleeping.");
  }
}

// 34_static 关键字