using System;

// 34.static modifier；static属性方法属于类，通过类名调用；
//无static new 的 object实例对象属性方法属于实例对象自己；
class ThirtyFour_Static
{
  //这两个是实例属性；new出来数据都是实例自己的，实例互不影响；
  String model;
  public int Obj_numberofCars;

  // 这个类属性，之类数据是属于class的，不受实例影响；
  public static int Class_numberofCars;

  //构造函数尽管是new对象的，但可以访问类中的任意属性；
  public ThirtyFour_Static(String model)
  {
    this.model = model;
    Obj_numberofCars++;
    Class_numberofCars++;
  }
  public static void StartRace()
  {
    Console.WriteLine($"Now we have {ThirtyFour_Static.Class_numberofCars} cars! The race has begun!");
  }

}