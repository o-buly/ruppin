using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number of steps needed :" + Hanoi(3));
            hanoiTowers(3, 'A', 'C', 'B');

        }
        private static int Hanoi(int v)
        {
            if (v == 1)
                return 1;
            else
                return Hanoi(v - 1) * 2 + 1;
        }

        private static void hanoiTowers(int numOfDisks, char source, char dest, char temp)
        {
            if (numOfDisks == 1)
                Console.WriteLine($"[{source}]->[{dest}]");
            else
            {
                hanoiTowers(numOfDisks - 1, source, temp, dest);
                hanoiTowers(1, source, dest, temp);
                hanoiTowers(numOfDisks - 1, temp, dest, source);
            }

        }
    }
}
