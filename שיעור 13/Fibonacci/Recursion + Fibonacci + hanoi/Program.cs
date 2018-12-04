using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion___Fibonacci___hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****print*****");
            print(0);
            Console.WriteLine("*****factorial*****");
            Console.WriteLine(RecFectorial(4));
            Console.WriteLine("*****fibonacci*****");
            for (int i = 1; i < 10; i++)
                Console.WriteLine(fibo(i));
            Console.WriteLine(fibo(5));
            Console.WriteLine("*****printDigits*****");
            printDigits(3658);
            Console.WriteLine("*****GCD*****");
            Console.WriteLine(GCD(20,8));
            Console.WriteLine("*****Hanoi*****");
            Console.WriteLine(Hanoi(7));
        }
    }
}
