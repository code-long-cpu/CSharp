using System;

//46.Getter and Setter

class FoutrySix_Car
{
  private int speed;

  public FoutrySix_Car(int speeds)
  {
    this.Speed = speeds;
  }

  //使用 property 来包含speed属性和方法，里面包含get和set方法，命名为Speed，外部通过访问和修改Speed来实现对speed的修改；
  public int Speed
  {
    get { return speed; } //readable; return出去private中的speed；本类中在public里可以访问private的数据
    set                   //writable; 在public方法中修改private的值，设置条件；
    {
      if (value > 100)
      {
        speed = 100;
      }
      else
      {
        speed = value; //value在这里是外部赋值操作或构造函数传来的参数
      }
    }
  }
}

//47.简写形式Auto-Implemented properties of Getter and Setter;用在只访问，不用额外条件限制修改的地方，就不需要定义新的property
class FortySeven_Car
{
  private String model;
  public String Model { get; set; }
  public FortySeven_Car(String model)
  {
    this.Model = model;
  }
}

