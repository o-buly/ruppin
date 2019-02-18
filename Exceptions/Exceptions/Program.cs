using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine(ReadNum());

            //Console.WriteLine(ReadNum2());

            // NOTE - REMAINDER !
            string input = "asd---123---er---78---y";
            string[] output = input.Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in output)
                Console.WriteLine(item);
            Console.WriteLine(sumOfNumbersInArry());
        }
        //OPT 1
        public static int ReadNum()
        {
            try
            {
                Console.WriteLine("please enter a number....");
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("wrong formt");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ReadNum();
        }
        //OPT 2
        public static int ReadNum2()
        {
            Console.WriteLine("ENTER A NUMBER .....");
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR !!!");
                }
            }
        }

        public static double sumOfNumbersInArry()
        {
            try
            {
                double x=0;
                Console.WriteLine("please insert your numbers space seperated and you can use '-' to input range");
                string input2;
                input2 =Console.ReadLine();
                string[] output2 = input2.Split(new char[] { ' ', '-' });
                for (int i = 0; i < output2.Length; i++)
                {
                    x += int.Parse(output2[i]);
                }
                return x /= output2.Length;
            }
            catch(Exception)
            {
                Console.WriteLine("error");
            }
            return sumOfNumbersInArry();

        }

    }
}
