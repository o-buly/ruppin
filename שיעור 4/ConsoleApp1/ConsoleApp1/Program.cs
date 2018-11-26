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
            int i = 1;
            for (; i <= 10; i++)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine("enter the 1st ANd the last number");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            for (i = x; i <= y; i++)
                Console.Write(i+" ");
            Console.WriteLine();
            for(i=25;i>=1;i--)
                Console.Write(i+" ");
            Console.WriteLine();
            Console.WriteLine("enter the 1st ANd the last number");
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            if(first<last)
            {
                for (i = first; i <= last; i++)
                    Console.Write(i + " ");
                Console.WriteLine();
            }
            else
                Console.WriteLine("ERROR !!!");
        }
    }
}
