using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(7));
        }
        static int Fibonacci(int step)
        {
            if (step == 1 || step == 2)
            {
                return 1;
            }
            else
                return Fibonacci(step - 1) + Fibonacci(step - 2);
        }
    }

}
