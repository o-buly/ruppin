using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 36812, newNumber;
            newNumber = RotateDigits(number);
            Console.WriteLine(newNumber);
        }
        //Rotate Numbers
        public static int RotateDigits(int num)
        {
            int newNum = 0;
            while (num >= 1)
            {
                newNum = newNum * 10;
                newNum = newNum + num % 10;
                num = num / 10;
            }
            return newNum;
        }

    }
}
