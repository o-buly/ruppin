using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* סעיף 1 !!! */
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int factorial = 1, i = 1;
            while (i <= num)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine("the factorial is : " + factorial);


            /* סעיף 2 !!!  */
            //Console.WriteLine("enter a number");
            //int max = int.Parse(Console.ReadLine());
            //int i;
            //for(i=1;i<=max;i++)
            //{
            //    if(i%7==0)
            //        Console.WriteLine(" BOOM ");
            //    else
            //        Console.Write(i+" ");
            //}
            //Console.WriteLine();


            /* סעיף 3 !!!! */
            //Console.WriteLine("enter a number");
            //int n = int.Parse(Console.ReadLine());
            //int i;
            //for(i=2;i<=10;i++)
            //{
            //    if(n%i==0)
            //        Console.Write(i+" ");
            //}
            //Console.WriteLine();


            /*  סעיף 4 !!! */
            //string input = "end";
            //int number, sum = 0, counter = 0;

            //Console.WriteLine("enter a number\nELSE type 'done'");
            //input = Console.ReadLine();
            //while (input != "done")
            //{
            //    number = int.Parse(input);
            //    sum += number;
            //    counter++;
            //    Console.WriteLine("if you wish to continue enter a number\nELSE type 'done'");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("the AVG of all the numbers you type is : " + (sum / counter));


            /* סעיף 5 !!! */
            //Console.WriteLine("enter a number");
            //int num = int.Parse(Console.ReadLine());
            //double numDIV2 = Math.Sqrt(num);
            //int counter = 2;
            //bool isPRIME = true;
            //if (num == 1 || num == 0)
            //{
            //    Console.WriteLine("the number is NOT a prime number !");
            //    return;
            //}
            //while(counter<=numDIV2)
            //{
            //    if (num % counter == 0)
            //    {
            //        Console.WriteLine("the number is NOT a prime number !");
            //        isPRIME = false;
            //        break;
            //    }
            //    counter++;
            //}
            //if (isPRIME)
            //{
            //    Console.WriteLine("the number is a prime number !");
            //}
        }
    }
}
