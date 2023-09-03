using System;
using System.Numerics;

namespace Exercises
{
  internal class Week1
  {
    public static void Exercise1()
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("My name is Azeez Bello");

      string first_name, last_name; // declaring more than one variable in a single line

      first_name = "Azeez";
      last_name = "Bello";
      Console.WriteLine(first_name + " " + last_name);
    }
  }

  internal class Week2
  {
    public static void Exercise1()
    {
      Console.WriteLine("This program converts Celcius to Farenheit !");
      Console.Write("Input Temprature in Celcius : ");
      double c; // Declaration of variable c of type double
      c = Convert.ToDouble(Console.ReadLine()); // Assignment of value to c
      double f; // Declaration of variable f of type double
      f = (c * 9 / 5) + 32; // Assignment of value to f
      Console.WriteLine(c + " celcius is " + f + " farenheit !");
    }

    public static void Exercise2()
    {
      Console.WriteLine("This program converts inches to meter!");
      Console.Write("Input amount of inches : ");
      double i = Convert.ToDouble(Console.ReadLine());
      double m = (i * 0.0254);
      Console.WriteLine(i + " inches is " + m + " meters!");
    }

    public static void Exercise3()
    {
      Console.WriteLine("This program converts minutes to days!");
      Console.Write("Input amount of minutes : ");
      double minutes = Convert.ToDouble(Console.ReadLine());
      double days = (minutes / 60 / 24);
      Console.WriteLine(minutes + " minutes = " + days + " days!");
    }

    public static void Exercise4()
    {
      Console.WriteLine("This program add 4 numbers and prints the result!");
      Console.Write("Input first number : ");
      double first = Convert.ToDouble(Console.ReadLine());

      Console.Write("Input second number : ");
      double second = Convert.ToDouble(Console.ReadLine());

      Console.Write("Input third number : ");
      double third = Convert.ToDouble(Console.ReadLine());

      Console.Write("Input fourth number : ");
      double fourth = Convert.ToDouble(Console.ReadLine());
      double total = first + second + third + fourth;
      Console.WriteLine("Total sum of all four numbers is " + total);
    }

    public static void Exercise5()
    {
      Console.WriteLine("This program prints out the BMI of an individual!");
      Console.Write("Input weight of kilograms : ");
      double weight = Convert.ToDouble(Console.ReadLine());

      Console.Write("Input height of meters : ");
      double height = Convert.ToDouble(Console.ReadLine());

      double bmi = weight / Math.Pow(height, 2);
      Console.WriteLine($"Your BMI is {bmi}!");

    }

    // public static void Exercise6()
    // {
    //   Console.WriteLine("a program that computes speed: Takes distance (in meters) and time (as three numbers: hours,\nminutes, seconds), computes speed, in meters per second, kilometres per hour and miles per hour (hint: 1\nmile = 1609 meters). Prints results to Console");
    //   System.Console.WriteLine("Input distance ");
    //   int distance = System.Convert.ToInt32(Console.ReadLine());

    // }

    public static void Exercise7()
    {
      Console.WriteLine("a program that reads a number, computes and print to Console the square, cube, and fourth power");

      Console.Write("Input the number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      System.Console.WriteLine($"{num} squared is: {Math.Pow(num, 2)}");
      System.Console.WriteLine($"{num} cube is: {Math.Pow(num, 3)}");
      System.Console.WriteLine($"{num} fourth power is: {Math.Pow(num, 4)}");
    }

    public static void Exercise8()
    {
      System.Console.WriteLine("a program that takes the radius of a circle as input and calculate the perimeter and area of the circle.");
      const double pi = 3.142;
      double radius = Convert.ToDouble(Console.ReadLine());
      double perimeter = 2 * pi * radius;
      double area = pi * Math.Pow(radius, 2);
      System.Console.WriteLine($"The perimeter of this circle is {perimeter} and the area is {area}!");
    }

    public static void Exercise9()
    {
      System.Console.WriteLine("a program to break an integer into a sequence of individual digits");
      Console.Write("Input a number to be broken into an array: ");
      string number = Console.ReadLine();

      foreach (var num in number)
      {
        Console.Write($"{num} ");
      }
    }

    public static void Exercise10()
    {
      System.Console.WriteLine("a program that displays the lenght of a given string");
      Console.Write("Input the text to be counted: ");
      string str = Console.ReadLine();
      System.Console.WriteLine($"Length of \"{str}\" is {str.Length}");
    }

    public static void Exercise11()
    {
      System.Console.WriteLine($"The current time right now is {DateTime.Now.ToString()}");
    }
  }

  internal class Week3
  {
    public static void Exercise1()
    {
      Console.WriteLine("Input a number to be broken into an array: ");
      string number = Console.ReadLine();

      foreach (var num in number)
      {
        Console.Write($"{num} ");
      }
    }

    public static void Exercise2()
    {

      Console.WriteLine("Input anything to start the program or 'q' to terminate!");


      while (true)
      {
        Console.Write("Input the first number: ");
        string number1 = Console.ReadLine();

        if (number1 == "q")
        {
          break;
        }
        Console.Write("Input the second number: ");
        string number2 = Console.ReadLine();
        if (number2 == "q")
        {
          break;
        }



        if (Convert.ToInt32((number1)) == Convert.ToInt32(number2))
        {
          Console.WriteLine("These numbers are equal!");
        }

        else
        {
          Console.WriteLine("These numbers are not equal!");
        }

      }
      Console.Write("The program has ended!");
    }

    //public static void Exercise3()
    //{
    //    Console.WriteLine($"This program creates array of given size, ",
    //        $"each element will be 1+Position, and prints array.");
    //    Console.Write("Input the size of the Array");
    //    //int sizeOfArray = Console.ReadLine();
    //}
  }

  internal class Week4
  {


  }

  internal class Week5
  {
    static public int[] PopulateArray(int length)
    {
      Random random = new Random();
      int[] array = new int[length]; // create array of n items 
      for (int index = 0; index < length; index++)
      {
        array[index] = random.Next(100);
      }
      return array;
    }

    public static void PrintArray(string[] names)
    {
      for (int index = 0; index < names.Length; index++)
      {
        System.Console.Write($"{names[index]} ");
      }
    }

    public static void PrintArrayOfInt(int[] numbers)
    {
      for (int index = 0; index < numbers.Length; index++)
      {
        System.Console.WriteLine(numbers[index]);
      }
    }

    public static void Swap(int a, int b)
    {
      // creating a new variable to hold "a" first
      int c = a;

      // swapping out variables
      a = b;
      b = c;

      System.Console.WriteLine($"a is now {a} and b is now {b}");
    }

    public static void SwapInt(ref int a, ref int b)
    {
      // creating a new variable to hold "a" first
      int c = a;

      // swapping out variables
      a = b;
      b = c;

      System.Console.WriteLine($"a is now {a} and b is now {b}");
    }

    public static void SwapStr(ref string a, ref string b)
    {
      // creating a new variable to hold "a" first
      string c = a;

      // swapping out variables
      a = b;
      b = c;

      System.Console.WriteLine($"a is now {a} and b is now {b}");
    }

    public static void SwapNamesInArray()
    {
      string[] names = new string[4];
      for (int i = 1; i < names.Length + 1; i++)
      {
        System.Console.Write($"Input name {i}: ");
        string name = Console.ReadLine();
        names[i - 1] = name;
      }
      PrintArray(names);

      // string name1=names[0], name2=names[1];
      // SwapNamesInArray(name1, name2);
      // PrintArray(names);

    }
  }


  internal class Week6
  {
    public static Dictionary<string, int> GetClassNumbers()
    {
      Dictionary<string, int> classNumbers;
      classNumbers = new Dictionary<string, int>();
      classNumbers.Add("csharp", 90);
      classNumbers.Add("java", 120);
      classNumbers.Add("python", 208);
      classNumbers.Add("php", 72);

      // Print(classNumbers);
      return classNumbers;
    }

    public static void Print(Dictionary<string, int> dict)
    {
      foreach (var kvp in dict)
      {
        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
      }
    }

    public static void Print2(Dictionary<string, int> dict)
    {
      for (int i = 0; i < dict.Count; i++)
      {
        System.Console.WriteLine($"{dict.ElementAt(i).Key}: {dict.ElementAt(i).Value}");
      }
    }

    // public  static

    public static void GetCsharpStudents()
    {
      Dictionary<string, int> dict = GetClassNumbers();
      System.Console.WriteLine(dict["c#"]);
    }

    public static void SetJavaStudents(Dictionary<string, int> dict)
    {

      dict["java"] = 130;
      System.Console.WriteLine(dict["java"]);
      Print2(dict);
    }

    // Exercise5
    public static Dictionary<int, string> PeriodicTable()
    {
      Dictionary<int, string> dict = new Dictionary<int, string>
      {
            { 4, "Be" },
            { 2, "He" },
            { 2, "B" },
            { 2, "Li" },
            { 2, "H" }
        };

      return dict;
    }

    public static void OutputData(Dictionary<int, string> dict)
    {

    }


  }

  internal class Test
  {
    public static void Some()
    {

      var rec = new { name = "olumide", age = 13 };
      // Console.WriteLine(rec.age);

      IDictionary<int, string> courses = new Dictionary<int, string>()
      {
        {1,"Computing, ITM,AI"},
        {2,"MBA, Robotics, ITM"},
      };

      bool test = false;
      int i = 0;
      while (test == false)
      {
        Console.WriteLine(i);
        i = i + 1;
        test = true;
      }

    }

    public static int max(int a, int b)
    {
      if (a > b)
        return a;
      return b;
    }
    public static void MaxVal()
    {
      int[] numbers = { 3, 5, 21, 0, 450, 43, 2, 54, 1 };
      int maxi = numbers[0];
      foreach (var number in numbers)
      {
        maxi = max(maxi, number);
      }
      System.Console.WriteLine(maxi);
    }



    public static void something()
    {
      string var1 = "Hello I am learning programming";
      System.Console.WriteLine(var1.IndexOf('I'));

      // int speed = 25;
      // System.Console.WriteLine("The car was" + "Travelling at the speed of " + speed + " MPH");

      // int age;
      // age = 25;
      // age++;
      // age += 1;

      // age--;
      // age -= 1;

      // // in two years, age will be age + 2
      // age += 2; // 27

      // age -= 2; // 25
      // // System.Console.WriteLine(age);

      // double age2 = Convert.ToDouble(age);

      // age2 /= 2; // 12 not 12.5

      // age *= 2; // 24
      // System.Console.WriteLine(age);


      // 25.0 / 2; // 12.5


      // true false

      //       true and true  true
      //       true and false false
      //       false and false false
      //       false and true  false

      //       true or true  true
      //       true or false true
      //       false or false false
      //       false or true  true


      //       1 + 2 + 3 + 4
      // 3 + 3 + 4
      // 6 + 4


      // (false and true) or (true or false ) and ( false or false) and (true and true)
      // (false or true) and (false  and  true)
      // true and false
      // false


      // false or true or false ^ true or false and true and true
      // true or false ^ true or false and true and true
      // true ^ true or false and true and true
      // true or  false and true and true
      // true and true and true
      // true and true
      // true

      // false or true or false and false or false and true and true
      // true or false and false or false and true and true
      // true and false or false and true and true
      // false or false and true and true
      // false and  true and true
      // false and true
      // false

      // either peace and chidinma to be available before we hold a meeting

      // if chidinma and peace
      //   hold the meeting
      // else if chidinma or peace
      //   hold the meeting
      // else
      //   no meeting

      // always go to school monday to friday but not on weekends 
      // while the day is monday to friday
      //   go to school
      // day is saturday
      // don't go to school
      //  break



      // int count = 2;
      // int total = 10;
      // while (count < total)
      // {
      //   Console.WriteLine("Count " + count);
      //   count++;

      //   System.Console.WriteLine("Count is now " + count);
      //   if (count == 7)
      //     break;
      // }

      // do
      // {
      //   Console.WriteLine("Count " + count); // Count 2
      //   count++; // count = count + 1 =  3
      // }
      // while (count < total);

      // string name = "Chidinma";

      // for (int val = 0; val < name.Length; val = val + 2)
      // {
      //   System.Console.WriteLine(name[val]);
      // }

      // foreach (var character in name)
      // {
      //   System.Console.WriteLine(character);
      // }

      // string[] DayOfWeek;
      // DayOfWeek = new string[7];
      // DayOfWeek[0] = "Mon";
      // DayOfWeek[1] = "Tue";
      // DayOfWeek[2] = "Wec";
      // DayOfWeek[3] = "Thur";
      // DayOfWeek[4] = "Fri";
      // DayOfWeek[5] = "Sat";
      // DayOfWeek[6] = "Mon";



      // string[] daysOfWeek = { "Mon", "Tues", "Wed", "Thur", "Fri", "Sat", "Sun" };


      // int item = Convert.ToInt32(Console.ReadLine());

      // switch (item)
      // {
      //   case 1:
      //     Console.WriteLine("case 1");
      //     break;

      //   case 5:
      //     Console.WriteLine("case 5");
      //     break;

      //   case 9:
      //     Console.WriteLine("case 9");
      //     break;

      //   default:
      //     Console.WriteLine("No match found");
      //     break;
      // }




    }


    public static bool compare()
    {
      // Write a method that takes two numbers as input and returns true or false if the two numbers are equal.

      Console.WriteLine("Input two numbers ");

      Console.Write("Input first number: ");
      int number1;
      number1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Input second number: ");
      int number2;
      number2 = Convert.ToInt32(Console.ReadLine());
      return number1 == number2;
    }

    public static void login()
    {
      // Write a method that takes userid and password as input (type string). After 3 wrong attempts, user will be
      // rejected. Method must print appropriate message for success and for running out of tries.
      // Hint: You need an if statement that checks the two inputs against set values (For example userId = “mo”,
      // password = “secret” – the inputs are compared to “mo”, and “secret”). Also, you need to have a counter to
      // record number of attempts. You need a while loop to make sure up to 3 attempts are allowed.

      for (int counter = 0; counter < 3; counter++)
      {
        Console.Write("userid: ");
        string userid = Console.ReadLine();

        Console.Write("password: ");
        string password = Console.ReadLine();

        if (userid == "mo" && password == "secret")
        {
          System.Console.WriteLine("Login is successful");
          break;
        }
        else
        {
          System.Console.WriteLine("Login is unsuccessful");
        }
      }
    }

    public static void arrs()
    {
      // string[] nums = new string[4];
      // nums[0] = "zero";
      // nums[1] = "one";
      // nums[2] = "two";

      // string[] nums = new string[4] { "one", "two", "three", "four" };
      string[] nums = new string[] { "one", "two", "three", "four" };
      string[] nums2 = { "one", "two", "three", "four" };

      // multi-dimensional
      int[,,,,] m_nums = { { { { { 1, 2, 3 }, { 1, 2, 4 } } } } };
      System.Console.WriteLine(m_nums[0, 1, 2, 3, 4]);

    }

    public static void arr()
    {
      // int i = 30 % 4;
      // int j = 25 % 25;
      // if (i == j ^ j > i)
      // {
      //   System.Console.WriteLine("in 1st if");
      // }
      // if (i != j ^ j < i)
      // {
      //   System.Console.WriteLine("in 2nd if");
      // }
      // if (2 != 0 || 0 > 2)
      // {
      //   System.Console.WriteLine("in 3rd if");
      // }
      // if (i == j && j < i)
      // {
      //   System.Console.WriteLine("in 4th if");
      // }



    }

    public static void some()
    {
      BigInteger bigInt = new BigInteger(3.00006);
      // display(k);
    }


  }


}

