using System;

class Twenty_Exception
{
  public static void T_Exception()
  {
    double x;
    double y;
    double result;

    try
    {
      Console.WriteLine("Enter number_1: ");
      x = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter number_2: ");
      y = Convert.ToInt32(Console.ReadLine());

      result = x / y;

      Console.WriteLine("result:+" + result);
    }
    catch (FormatException e) //FormatException c#内置
    {
      Console.WriteLine("Enter Only number Please!" + e);

    }
    catch (DivideByZeroException e)  //DivideByZeroException c#内置
    {
      Console.WriteLine("You can't divide by zero! Idiot!" + e);

    }
    finally
    {
      Console.WriteLine("Thanks for visiting!");

    }


  }
}