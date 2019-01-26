using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4] { { 1, 2, 2, 1 }, { 3, 4, 4, 3 }, { 3, 4, 4, 3 }, { 1, 2, 2, 1 } };
            Console.WriteLine(IsSymmetrical(arr));
        }

        //Symmetrical Matrix
        public static bool IsSymmetrical(int[,] numbers)
        {
            //init.
            bool result = true;
            //checking symmetric property.
            for (int i = 0; i < numbers.GetLength(0) / 2; i++)
            {
                for (int j = 0; j < numbers.GetLength(1) / 2; j++)
                {
                    if (numbers[i, j] != numbers[numbers.GetLength(0) - 1 - i, j])
                        result = false;
                    if (numbers[i, j] != numbers[i, numbers.GetLength(1) - 1 - j])
                        result = false;
                    if (numbers[i, j] != numbers[numbers.GetLength(0) - 1 - i, numbers.GetLength(1) - 1 - j])
                        result = false;
                }
            }
            return result;
        }
    }
}
