using System;

// 21_array
class TwantyOne_Aarray
{
  public static void T_array()
  {
    Console.WriteLine("21.array: ");
    String[] cars = { "BMW", "Mustang", "Covette", };
    cars[2] = "Tesla";
    Console.WriteLine(cars[0]);
    Console.WriteLine(cars[1]);
    Console.WriteLine(cars[2]);

    for (int i = 0; i < cars.Length; i++)
    {
      Console.WriteLine(cars[i] + ";");
    }
    String[] houses = new String[3];
    houses[0] = "long";
    houses[1] = "feng";
    houses[2] = "le";

    for (int i = 0; i < houses.Length; i++)
    {
      Console.WriteLine(cars[i] + ";");
    }

    // 22.for_each loop
    Console.WriteLine("22.for_each loop: ");
    foreach (String house in houses)
    {
      Console.WriteLine(house + ";");
    }

  }


}