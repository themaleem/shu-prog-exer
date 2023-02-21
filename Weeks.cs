using System;

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
}

