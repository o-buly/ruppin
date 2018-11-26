using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            /*  סעיף 1 !!!!  */
            //        bool IsPrime = false;
            //        Console.WriteLine("enter a number");
            //        int num = int.Parse(Console.ReadLine());
            //        IsPrime =IsPrimed(num);
            //        if(IsPrime)
            //            Console.WriteLine("the number is a PRIME NUMBER");
            //        else
            //            Console.WriteLine("the number is NOT PRIME NUMBER");
            //        Console.WriteLine("enter a number");
            //        num = int.Parse(Console.ReadLine());
            //        AllPrime(num);

            //    }


            //    static bool IsPrimed(int num)
            //    {
            //        bool IsPrime = false;
            //        if(num==1||num==0)
            //        {
            //            return IsPrime;
            //        }
            //        else
            //        {
            //            for(int i=2; i<num;i++)
            //            {
            //                if(num%i==0)
            //                {
            //                    return IsPrime;
            //                }
            //            }
            //        }
            //        IsPrime = true;
            //        return IsPrime;

            //    }

            //    static void AllPrime(int x)
            //    {
            //        for (int i = 2; i <= x; i++)
            //        {
            //            if (IsPrimed(i))
            //            {
            //                Console.WriteLine("the number " + " [ " + i + " ] " + " is a PRIME NUMBER");
            //            }
            //        }
            //    }



            /* סעיף 2 !!!  */

            Console.WriteLine("choose an option between 1-4 --- OR PRESS 5 TO EXIT!");
            Console.WriteLine("1 = summury");
            Console.WriteLine("2 = subtruct");
            Console.WriteLine("3 = multiply");
            Console.WriteLine("4 = divide");
            Console.WriteLine("5 = EXIT !");
            int choosenNUMBER = int.Parse(Console.ReadLine());
            int NUMBER;
            switch (choosenNUMBER)
            {
                case 1:
                    NUMBER = summury();
                    Console.WriteLine(NUMBER);
                    break;
                case 2:
                    NUMBER = subtruct();
                    Console.WriteLine(NUMBER);
                    break;
                case 3:
                    NUMBER = multiply();
                    Console.WriteLine(NUMBER);
                    break;
                case 4:
                    NUMBER = divide();
                    Console.WriteLine(NUMBER);
                    break;
                case 5:
                    Console.WriteLine("bye bye bye !!!");
                    return;
            }


        }
        static int summury()
        {
            Console.WriteLine("enter 2 numbers please");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return x +y;
        }
        static int subtruct()
        {
            Console.WriteLine("enter 2 numbers please");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return x - y;
        }
        static int multiply()
        {
            Console.WriteLine("enter 2 numbers please");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return x * y;
        }
        static int divide()
        {
            Console.WriteLine("enter 2 numbers please");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            return x / y;
        }
    }
}
