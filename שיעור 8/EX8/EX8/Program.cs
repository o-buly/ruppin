using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    class Program
    {
        /** סעיף 1 !!!**/
        //static void Main(string[] args)
        //{
        //    int[,] matrix = new int[10, 10];
        //    createmultiappboard(matrix);
        //    print(matrix);
        //}
        //static int[,] createmultiappboard(int[,] matrix)
        //{
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            matrix[i, j] = (i + 1) * (j + 1);
        //        }
        //    }
        //    return matrix;
        //}

        //static void print(int[,] matrix)
        //{
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++)
        //        {
        //            Console.Write(matrix[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}


        /**  סעיף 2 !!!! **/
        //static void Main(string[] args)
        //{
        //    double[,] cur = new double[,] {
        //         { 3.544, 3.691, 3.623, 0 },
        //         { 4.73, 5.0823, 5.0059, 0 },
        //         { 4.3551, 4.5272, 4.4113, 0 },
        //         { 5.493, 5.9473, 5.8959, 0 } };
        //    string[] currNames = new string[] { "Dollar", "Euro", "Yen", "GBP" };
        //    string print;
        //    print = tablestring(cur, currNames);
        //    Console.WriteLine("======= BEFORE AVG =======");
        //    Console.WriteLine(print);
        //    AverageRows(cur);
        //    print = tablestring(cur, currNames);
        //    Console.WriteLine("======= AFTER AVG ======");
        //    Console.WriteLine(print);
        //    double[] cSums = new double[3];
        //    cSums = SumColumns(cur);
        //    Console.WriteLine("======= SUMS OF COLUMNS ======");
        //    foreach (var y in cSums)
        //    {
        //        Console.Write(" " + y.ToString() + "  ");
        //    }
        //    Console.WriteLine();
        //}

        //static void AverageRows(double[,] table)
        //{

        //    for (int i = 0; i < table.GetLength(0); i++)
        //    {
        //        double sum = 0, avg = 0;
        //        for (int j = 0; j < table.GetLength(1)-1; j++)
        //        {
        //            sum += table[i, j];
        //        }
        //        avg = sum / (table.GetLength(1)-1);
        //        table[i, (table.GetLength(1)-1)] = avg;
        //    }
        //}

        //static string tablestring(double[,] table, string[] names)
        //{
        //    string matrix = "";
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        matrix += names[i] + ":\t ";
        //        for (int j = 0; j < table.GetLength(0); j++)
        //        {
        //            matrix += string.Format("{0:0.00}", table[i, j]) + "\t ";
        //        }
        //        matrix += "\n";
        //    }
        //    return matrix;
        //}

        //static double[] SumColumns(double[,] table)
        //{
        //    double[] x = new double[table.GetLength(1)];
        //    for (int i = 0; i < table.GetLength(1); i++)
        //    {
        //        double sum = 0;
        //        for (int j = 0; j < table.GetLength(0); j++)
        //        {
        //            sum += table[j, i];
        //        }
        //        x[i] = sum;
        //    }
        //    return x;
        //}


        /**  סעיף 3 !!!! **/
        //    static void Main(string[] args)
        //    {
        //        char zakif = ' ';
        //        int[,] Matrix = new int[,]{ { 1, 1 }, { 1,0} };
        //        PrintBoard(Matrix);
        //        Console.Write("do you wish to continue ? (y/n) : ");
        //        zakif = Console.ReadKey().KeyChar;
        //        while(zakif!='n')
        //        {
        //            Matrix = PumpMatrix(Matrix);
        //            PrintBoard(Matrix);
        //            Console.Write("do you wish to continue ? (y/n) : ");
        //            zakif = Console.ReadKey().KeyChar;
        //        }
        //    }

        //    static int[,] PumpMatrix(int[,] matrix)
        //    {
        //        int j;
        //        int[,] new_matrix = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];
        //        for (int i = 0; i < matrix.GetLength(0); i++)
        //        {
        //            for ( j = 0; j < matrix.GetLength(1); j++)
        //            {
        //                new_matrix[i, j] = matrix[i, j];
        //            }
        //        }
        //        for (int i = 0; i < matrix.GetLength(0); i++)
        //        {
        //            int x = 0;
        //            for (j=0; j < matrix.GetLength(1); j++)
        //            {
        //                x += new_matrix[i, j];
        //            }
        //            new_matrix[i, j] = x;

        //        }
        //        for (int i = 0; i < matrix.GetLength(1); i++)
        //        {
        //            int x = 0;
        //            for (j = 0; j < matrix.GetLength(0); j++)
        //            {
        //                x += new_matrix[j, i];
        //            }
        //            new_matrix[j, i] = x;
        //            Console.WriteLine();
        //        }
        //        return new_matrix;
        //    }


        //   static void PrintBoard(int[,] mat)
        //    {
        //        for (int i = 0; i < mat.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < mat.GetLength(1); j++)
        //            {
        //                Console.Write(mat[i,j]+"\t");
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}

        /*   EX 8 !!!!  */
        static void Main(string[] args)
        {
            string[] calender = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] days;
            for (int i = 0; i < calender.Length; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                    days = new int[31];
                else if (i == 2)
                    days = new int[29];
                else
                    days = new int[30];
            }

        }



    }
}