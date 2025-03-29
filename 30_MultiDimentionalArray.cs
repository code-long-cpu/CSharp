using System;

// 30.Multi-Dimentional-Array
class Thirty_MultiDimentionalArray
{

  public static void T_MultiArray()
  {
    String[] ford = { "Mustang", "F-150", "Explore" };
    String[] chevy = { "Corvette", "Camaro", "Silverado" };
    String[] toyota = { "Corolla", "Camry", "Rav4" };

    String[,] parkingLot = {
    {"Mustang", "F-150", "Explore" },
    { "Corvette", "Camaro", "Silverado" },
    {"Corolla", "Camry", "Rav4"}};

    String[,] array = new string[3, 3]; //此处3，3就是2维数组尺寸

    parkingLot[0, 2] = "Fusion";

    Console.WriteLine("ForEach遍历2维数组:");
    foreach (String car in parkingLot)
    {
      Console.WriteLine(car);
    }
    Console.WriteLine($"parkingLot数组第一维度长度：{parkingLot.GetLength(0)}");
    Console.WriteLine($"parkingLot数组第二维度长度：{parkingLot.GetLength(1)}");

    Console.WriteLine("Nested for loop遍历2维数组:");
    for (int i = 0; i < parkingLot.GetLength(0); i++)
    {
      for (int j = 0; j < parkingLot.GetLength(1); j++)
      {

        Console.Write(parkingLot[i, j] + " ");

      }
      Console.WriteLine();
    }



  }
}