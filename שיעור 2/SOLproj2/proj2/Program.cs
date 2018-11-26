using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  סעיף 1 ! */
            //Console.WriteLine("enter a number");
            //string inputNumber = Console.ReadLine();
            //int num = int.Parse(inputNumber);
            ///*int num = int.Parse(Console.ReadLine());   דרך קצרה יותר - במקום 2 שורות !*/
            //if (num % 2 == 0)
            //    Console.WriteLine("the number {0}" + " is Even", num);
            ///*  Console.WriteLine($"the number {num} is Even");    דרך קרצה יותר  !!! */
            //else
            //    Console.WriteLine("the number {0}" + " ODD !!!!!", num);

            /* סעיף 2 ! */
            //Console.WriteLine("enter 3 numbers");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < b && a < c && b > a && b < c)
            //    Console.WriteLine($"first {a} , second {b} , third {c}");
            //else if (a < b && a < c && c > a && c < b)
            //    Console.WriteLine($"first {a} , second {c} , third {b}");
            //else if (b < a && b < c && a > b && a < c)
            //    Console.WriteLine($"first {b} , second {a} , third {c}");
            //else if (b < a && b < c && c > b && c < a)
            //    Console.WriteLine($"first {b} , second {c} , third {a}");
            //else if (c < a && c < b && a > c && a < b)
            //    Console.WriteLine($"first {c} , second {a} , third {b}");
            //else if (c < a && c < b && b > c && b < a)
            //    Console.WriteLine($"first {c} , second {b} , third {a}");

            /* סעיף 3 !! */
            //Console.WriteLine("enter 3 numbers");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //double avg = ((a * 0.4 + b * 0.2 + c * 0.4) / 3);
            //Console.WriteLine($"the AVG of your grades is : {avg:F2}");

            /* סעיף 4 !! */
            //Console.WriteLine("enter your room attributes");
            //Console.Write("wall x =");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("wall y =");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"the scope is = {x*2+y*2}" + $"\nthe area is = {x*y}");

            /* סעיף 5 !! */
            /* x^2 + y^2 = C^2 */
            Console.WriteLine("enter 2 tzlaot");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double yeter = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine($"the yeter is : {yeter:F2}");

            /*  EX - 1 !! */
            //Console.WriteLine("please enter your FULL name");
            //string fullName = Console.ReadLine();
            //Console.WriteLine("your name is : " + fullName);
            //Console.WriteLine("enter your age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter some number of years to calculate");
            //int calculate = int.Parse(Console.ReadLine());
            //Console.WriteLine("in " + calculate + " years you will be at age of : " + (calculate+age));

            /*  EX - 2 !!!  */
            //Console.WriteLine("please enter your name");
            //string Name = Console.ReadLine();
            //Console.WriteLine("please choose one option\n1. buy a stock\n2. buy stock on sale");
            //int option = int.Parse(Console.ReadLine());
            //if (option == 1)
            //{
            //    Console.Write("please enter the price of the desire stock : ");
            //    int stockPrice = int.Parse(Console.ReadLine());
            //    Console.Write("please enter the amount of the desire stock : ");
            //    int stockAmount = int.Parse(Console.ReadLine());
            //    if (stockAmount % 2 == 0)
            //        Console.WriteLine("the price needed to pay is : " + (stockAmount * stockPrice) + "$");
            //    else
            //        Console.WriteLine("this application cant calculate an ODD number of stocks");
            //}

            //else if (option == 2)
            //{
            //    Console.Write("please enter the price of ONE stock : ");
            //    int stockPrice = int.Parse(Console.ReadLine());
            //    Console.Write("please enter the amount of the desire stock on sale: ");
            //    int stockAmount = int.Parse(Console.ReadLine());
            //    if (stockAmount > 10)
            //        Console.WriteLine("you got 20% discount , price needed to pay is :  " + ((stockAmount * stockPrice) * 0.8) + "$");
            //    else
            //        Console.WriteLine("the price needed to pay is : " + (stockAmount * stockPrice) + "$");
            //}

            //else
            //    Console.WriteLine("This option is not a valid option!");


        }
    }
}
