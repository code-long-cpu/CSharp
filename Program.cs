using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Threading;
namespace MyCShrpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.c# tutortial for begineers
            Console.WriteLine("Hello World! I like pizza!");
            Console.Beep(); //mac不会声音，win有；
            Process.Start("afplay", "/System/Library/Sounds/Glass.aiff"); // 播放 macOS 自带的 "Glass" 声音

            // 2.output format
            Console.Write("Xie!"); //句尾不换行
            Console.WriteLine("Long!"); //句尾换行
            Console.WriteLine("\tLong!"); //句首缩进
            Console.WriteLine("Lo\bng!"); //退一格 Lng;
            Console.WriteLine("Lo\nng!"); //换一行Lo 另一行ng;

            //variables
            int x; //declaration
            x = 123; //initialization

            int y = 321;//declatation + initialization

            int z = x + y;  //int only store whole number;

            int age = 21;

            double height = 180.234; //decimal number;

            bool happy = true; //true or false;

            char symbol = '@'; //Single char

            String name = "XieLong";

            String username = symbol + name;

            Console.WriteLine(x); //123
            Console.WriteLine(y); //321
            Console.WriteLine(z); //444
            Console.WriteLine("Hello " + name); //Hello Xie Long
            Console.WriteLine("Your age is " + age); //21
            Console.WriteLine("Your height is " + height); //180.234
            Console.WriteLine("Are you happy: " + happy); //True
            Console.WriteLine("Your symbol is: " + symbol); //@
            Console.WriteLine("Your username is: " + username); //@XieLong

            // 4.constants  = immutable values which are known at compile time;
            const double pi = 3.14159;
            Console.WriteLine("const double pi: " + pi); //3.14159

            //5.type casting = convert a value to a differet data type
            double a = 3.14; //3.14
            int b = Convert.ToInt32(a); //3
            Console.WriteLine(b); //3
            Console.WriteLine(b.GetType()); //Int32

            // double to int
            int c = 123;
            double d = Convert.ToDouble(c) + 0.123;
            Console.WriteLine(d); //123.123
            Console.WriteLine(d.GetType()); //Double

            // int to string
            int e = 123;
            String f = Convert.ToString(e);
            Console.WriteLine(f); //123
            Console.WriteLine(f.GetType()); //String

            // string to char
            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h); //$
            Console.WriteLine(h.GetType()); //Char

            // string to bool 
            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j); //True
            Console.WriteLine(j.GetType()); //Boolean

            //6.user input ：Console.ReadLine();
            // Six_input.S_input();

            //7.arithmetic operators
            // int friends = 5 ;
            // friends = friends + 2;  //standard
            // friends += 2;           //shotcuts
            // friends++;              //forloop

            // friends = friends/2;    //2 int类型
            // int remainder = friends % 3; //1 求余

            // 8.c# MathClass 
            // Eight_MathClass.E_Math();

            //9. random numbers
            // Night_random.N_random();

            //10.Hypotenuse calculator program
            // Ten_hypotenus.T_hypotenus();

            //11.String Methods;
            // Eleven_String.E_String();

            //12.if statement; 与c++一致；
            //13.switches;

            // 21_array - 22.for_each loop
            TwantyOne_Aarray.T_array();

            //23.TwentyThree_Method - 26.params keyword
            // TwentyThree_Method.T_method();

            // 27.Exception handling
            // Twenty_Exception.T_Exception();

            // 28.Contional Operator
            // 29.String interpolation
            String firstName = "Long";
            String lastName = "Xie";
            Console.WriteLine($"Hello {lastName} {firstName}.");

            // 30.Multi-Dimentional-Array
            Console.WriteLine("30.Multi-Dimentional-Array: ");
            Thirty_MultiDimentionalArray.T_MultiArray();

            // 31_classes; （有public和static，无序new对象可以直接访问属性调方法）
            Console.WriteLine("31.Classes访问静态属性： " + ThirtyOne_Class.T_CLass);
            Console.WriteLine("31.Classes访问静态方法： ");
            ThirtyOne_Class.Hello();
            ThirtyOne_Class.Watiting();
            ThirtyOne_Class.Bye();

            // 32_objects; （只有public无static，new对象可以访问属性调用方法）
            ThirtyTwo_Object human1 = new ThirtyTwo_Object();
            human1.name = "Long";
            human1.age = 31;
            human1.Eat();
            human1.Sleep();

            // 33_constructor(有参数)是类中方法，这样不用像32_object那样，manually assign属性值；
            ThirtyTwo_Object human2 = new ThirtyTwo_Object("Lele", 32);
            human2.Eat();
            human2.Sleep();

            // 34.static modifier；
            //static属性方法属于类，通过类名调用；
            //无static new 的 object实例对象属性方法属于实例对象自己；
            ThirtyFour_Static car1 = new ThirtyFour_Static("Mustang");
            ThirtyFour_Static car2 = new ThirtyFour_Static("Covette");
            ThirtyFour_Static car3 = new ThirtyFour_Static("Lamble");

            //统计一共创建了多少car实例，访问实例对象属性不行，数据是实例自己的；得用static类属性方法来统计
            Console.WriteLine(car1.Obj_numberofCars); //1 car1自己数据
            Console.WriteLine(car2.Obj_numberofCars); //1 car2自己数据
            Console.WriteLine(car3.Obj_numberofCars); //1 car2自己数据
            // 得用static类属性方法来统计创建了多少实例；
            Console.WriteLine(ThirtyFour_Static.Class_numberofCars); //3辆 类自己数据
            ThirtyFour_Static.StartRace(); //Now we have 3 cars! The race has begun!

            // 36.inheritance
            Console.WriteLine("36.inheritance:");
            //37.abstruct class: incomplete implementation; cant instantiat object
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            //abstruct类关键字abstruct将大类标记为abstruct，表明了此类缺少完整代码和实现（具体的实力属性与方法），Vehicle只能被car，bicycle继承，abstruct阻止有人用new创建这个不完整的大类Vehicle的实例；
            //下面的代码报错(//37.incomplete impletation)
            // ThirtySix_Inherit_Vehicle thirtySix_Inherit_Vehicle = new ThirtySix_Inherit_Vehicle();
            Console.WriteLine("36.inheritance: car.speed:" + car.speed); //0
            Console.WriteLine("36.inheritance: car.wheels" + car.wheels); //4
            car.go(); //This vehicle is moving!

            // 38.array of object 创建对象数组
            Car[] garage = new Car[3];
            Car car4 = new Car("Tesla");
            Car car5 = new Car("BMW");
            Car car6 = new Car("Benchi");
            garage[0] = car4;
            garage[1] = car5;
            garage[2] = car6;
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);

            foreach (Car carr in garage)
            {
                Console.WriteLine(carr.model);
            }
            // 另一种创建对象数组的方式
            Bicycle[] bicycles = { new Bicycle("goodboy"), new Bicycle("shandi ") };
            foreach (Bicycle bike in bicycles)
            {
                Console.WriteLine(bike.model);
            }

            // 39.objects as arguments，修改object的方法；
            Boat ship = new Boat("TaiTan", "Black");
            Console.WriteLine($"原shaip的型号：{ship.model}，原ship的颜色:{ship.color}");
            Program.ChangeColor(ship, "Red");
            Console.WriteLine($"现shaip的型号：{ship.model}，现ship的颜色:{ship.color}");
            // 39.copy一个object
            Boat ship2 = Copy_ship(ship);
            Console.WriteLine($"shaip1的型号：{ship.model}，ship1的颜色:{ship.color}");
            Console.WriteLine($"shaip2的型号：{ship.model}，ship2的颜色:{ship.color}");

            // 40.method overriding；子类重写父类方法；
            Car car7 = new Car("motuo");
            car7.go();//"This vehicle is moving!"
            car7.run(); //Car can run fast.

            //41.toString methods(override) 返回自定义实例的内容
            Car car8 = new Car("Focus", "Ford");
            Console.WriteLine(car8); //ToString 可以省略
            Console.WriteLine(car8.ToString());
            Console.WriteLine(car8.dayin());

            //42.polymorphism 多态；objects可以被定义为不同类型的数据；数组存储不同各类型的数据；
            F_Car f_car = new F_Car();
            F_Boat f_boat = new F_Boat();
            F_Bicycle f_bicycle = new F_Bicycle();

            FortyTwo_polymorphism_Vehicle[] Vehicles = { f_car, f_boat, f_bicycle };
            foreach (FortyTwo_polymorphism_Vehicle Vehicle in Vehicles)
            {
                Vehicle.go();
            }

            // 43.interface 
            Rabbit rabbit = new Rabbit();
            rabbit.Flee();
            Hawk hawk = new Hawk();
            hawk.Hunt();
            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();

            // 44.List,与array不一样，List是可变长短的数据结构
            List<String> food = new List<string>();
            food.Add("Pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");
            food.Add("apple");

            Console.WriteLine(food[0]);
            food.Insert(0, "mantou");
            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("Pizza"));
            Console.WriteLine(food.LastIndexOf("Pizza"));
            Console.WriteLine(food.Contains("Pizza"));
            food.Sort();
            food.Reverse();
            // food.Clear();

            String[] foodArray = food.ToArray(); //list转为array

            food.Remove("fries");
            foreach (String item in food) //遍历list
            {
                Console.WriteLine(item);
            }
            foreach (String item in foodArray) //便利array
            {
                Console.WriteLine(item);
            }

            //45.List of object
            List<ListObjectPlayer> players = new List<ListObjectPlayer>();
            players.Add(new ListObjectPlayer("long"));
            players.Add(new ListObjectPlayer("feng"));
            players.Add(new ListObjectPlayer("le"));

            foreach (ListObjectPlayer player in players)
            {
                Console.WriteLine(player.ToString());
            }

            //46.Getter and Setter
            FoutrySix_Car car9 = new FoutrySix_Car(80);
            Console.WriteLine("Set与get限制的speed：" + car9.Speed);
            car9.Speed = 500;
            Console.WriteLine("修改后set与get限制的speed：" + car9.Speed);

            // 47.简写形式Auto-Implemented properties of Getter and Setter;
            FortySeven_Car car10 = new FortySeven_Car("BMW");
            Console.WriteLine(car10.Model); //BMW

            //48.Enums:Special "class" that contains a set of named integer constants. 既可为string类型，又可以转为int型
            // Planets.Pluto就是enums的名字，ToString就是转为String格式
            Console.WriteLine(Planets.Pluto + "is a planet.");
            Console.WriteLine(Planets.Earth + "is planet #" + (int)Planets.Earth);

            String PlantName = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume = Volume(PlanetRadius.Earth); //这里PlanetRadius.Earth在方法中转为了int

            Console.WriteLine(PlanetRadius.Earth);      //Earth
            Console.WriteLine("Planet: " + PlantName);  //Earth
            Console.WriteLine("PlanetRadius: " + radius + "km");
            Console.WriteLine("PlanetVolume: " + volume + "km^3");
            Pint(PlanetRadius.Earth); //Earth

            // 49.generic add<T> 泛型可以存储不同的数据类型
            int[] number = { 1, 2, 3 };
            double[] number2 = { 2.3, 3.2, 4.5 };
            String[] number3 = { "1", "2", "3" };
            display(number);
            display(number2);
            display(number3);

            // 50.multithreading 多线程,同时执行代码
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);
            // CountDown();
            // CountUp();
            Console.WriteLine(mainThread.Name + " is complete!");

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
            // Console.WriteLine(thread1.Name + thread2.Name + " is complete!");


            // Console.ReadKey();




        }
        // 39.objects as arguments，修改object的方法；static修饰是类方法，不是实例方法；
        static void ChangeColor(Boat ship, String color)
        {
            ship.color = color;
        }
        // 39.copy一个object
        static Boat Copy_ship(Boat boat)
        {
            return new Boat(boat.model, boat.color);
        }
        // 48.Enums
        static double Volume(PlanetRadius radius)
        {
            Console.WriteLine("radius: " + radius); //Earth
            Console.WriteLine("radius: " + (int)radius); //38443
            return (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        }
        static void Pint(PlanetRadius planet)
        {
            Console.WriteLine(planet); //Earth
            Console.WriteLine("(int)planet:" + (int)planet); //38443

        }
        // 49.generic add<T>
        static void display<T>(T[] array)
        {
            foreach (T a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
        // 50.multithreading 多线程,同时执行代码
        static void CountDown()
        {
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }
        static void CountUp()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #12 is complete!");

        }


    }
    //6.user input ：Console.ReadLine();
    class Six_input
    {
        public static void S_input()
        {
            Console.WriteLine("What's your name?");
            String Name = Console.ReadLine();
            Console.WriteLine("What's your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + Name + "!");
            Console.WriteLine("You are " + Age + " years old!");
        }
    }
    // 8.c# MathClass 
    class Eight_MathClass
    {
        // 警告⚠️static是静态属性，就是类方法，只用通过类名调用；不用new关键字创建实例。⚠️静态方法通常用于工具类，例如 Math.Round()，因为它们不需要对象状态。
        public static void E_Math()
        {
            double x = 5.2;
            double y = 4;
            double a = Math.Pow(x, 2); //求平方
            double b = Math.Sqrt(x);    //求开方
            double c = Math.Abs(x);     //求绝对值
            double d = Math.Round(x);     //求四舍五入
            double e = Math.Ceiling(x); //求上限值 6
            double f = Math.Floor(x); //求下限值 5
            double g = Math.Max(x, y); //求最大值
            double h = Math.Min(x, y);   //求最小值

            Console.WriteLine(a + ";" + b + ";" + c + ";" + d + ";" + e + ";" + f + ";" + g + ";" + h + ";");
        }
    }
    //9. random numbers
    class Night_random
    {
        public static void N_random()
        {
            Random random = new Random();
            int num1 = random.Next(1, 7); //左闭右开
            int num2 = random.Next(1, 7);
            double num3 = random.NextDouble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
    //10.Hypotenuse calculator program
    class Ten_hypotenus
    {
        public static void T_hypotenus()
        {
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The first side is " + a + ";");
            Console.WriteLine("The second side " + b + ";");
            Console.WriteLine("The hypotenuse is " + c + ";");
        }
    }
    //11.String Methods;
    class Eleven_String
    {
        public static void E_String()
        {
            String fullName = "Long Xie";
            String phoneNumber = "123-456-789";

            //⚠️此处非传值，而是调用string方法，传array为浅拷贝，传string为深拷贝
            fullName = fullName.ToUpper();
            Console.WriteLine(fullName); //LONG XIE

            fullName = fullName.ToLower();
            Console.WriteLine(fullName); //long xie

            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine(phoneNumber);  //123/456/789

            phoneNumber = phoneNumber.Replace("-", "");
            Console.WriteLine(phoneNumber);  //123456789

            String userName = fullName.Insert(0, "@");
            Console.WriteLine(userName);  //@long xie

            String SirName = fullName.Insert(0, "Mr.");
            Console.WriteLine(SirName);  //Mr.long xie

            Console.WriteLine(fullName.Length);  //8

            String firstName = fullName.Substring(0, 4);
            Console.WriteLine(firstName); //long
            String lastName = fullName.Substring(5, 3);
            Console.WriteLine(lastName); //xie



        }
    }


}
