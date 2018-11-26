using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    class Program
    {
        /** סעיף 1 !!!! **/
        //static void Main(string[] args)
        //{
        //    int[] grades;
        //    grades = new int[3] { 90, 20, 100 };
        //    int top = max(grades);
        //    Console.WriteLine(top);
        //}

        //static int max(int[] values)
        //{
        //    int x = values[0];
        //    for (int i = 0; i < values.Length; i++)
        //    {
        //        if (x < values[i])
        //            x = values[i];
        //    }
        //    return x;
        //}



        /**   סעיף 2 !!!!  **/
        //static void Main(string[] args)
        //{


        //    double[] monthlyGain = new double[] { -0.72, 1.05, 0.76, -1.49 };
        //    string[] symbols = new string[] { "MSFT", "INTC", "CSCO", "GOOG" };
        //    Console.WriteLine(monthlyMax(monthlyGain, symbols));
        //}
        //static string monthlyMax(double[]numbers,string[]symbols)
        //{
        //    return symbols[maxIndex(numbers)];
        //}

        //static int maxIndex(double[] values)
        //{
        //    double num = values[0];
        //    int index = 0;
        //    for (int i = 1; i < values.Length; i++)
        //    {
        //        if (num < values[i])
        //        {
        //            num = values[i];
        //            index = i;
        //        }
        //    }
        //    return index;
        //}


        /** סעיף 3 !!! **/
        //static void Main(string[] args)
        //{
        //    int[] newNumbers = FilterEvens(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9});
        //    for (int i = 0; i < newNumbers.Length; i++)
        //    {
        //        Console.Write("[" + newNumbers[i]+"]" + " ");
        //    }
        //    Console.WriteLine();
        //}


        // static int[] FilterEvens(int[] numbers)
        //{
        //    int count = 0;
        //    for (int x = 0; x < numbers.Length;x++)
        //    {
        //        if (numbers[x] % 2 == 0)
        //            count++;
        //    }
        //    int[] evenNUMBS = new int[count];
        //    for (int i = 0,j=0; i < numbers.Length; i++)
        //    {
        //        if(numbers[i]%2==0)
        //        {
        //            evenNUMBS[j] = numbers[i];
        //            j++;
        //        }
        //    }
        //    return evenNUMBS;
        //}


        //** סעיף 4 !!!! - באבל סורט **//
        static void Main(string[] args)
        {
            int[] array = new int[] {5,9,7,2 };
            bubblesort(array);
            print(array);
        }

        static void bubblesort(int[] sort)
        {
            for (int i = 0; i < sort.Length ; i++)
            {
                int temp;
                for (int j = 0; j < sort.Length-i-1; j++)
                {
                    if(sort[j]>sort[j+1])
                    {
                        temp = sort[j];
                        sort[j] = sort[j + 1];
                        sort[j + 1] = temp;
                    }
                }
            }
        }

        static void print(int [] arr)
        {
            foreach(int num in arr)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }

    }
}
