using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 5, 7, 8, 11, 15, 18, 24, 25 };
            int index = Binary_Search(nums, 11);
            Console.WriteLine(index);
            foreach (var num in nums)
            {
                Console.WriteLine(Binary_Search(nums, num));
            }
            Random rnd = new Random(DateTime.Now.Millisecond);
            Console.WriteLine(rnd.Next(0, 100));

            nums = new int[2000];
            for (int i = 0; i < 2000; i++)
            {
                nums[i] = i;
            }
            Array.Sort(nums);
            Binary_Search(nums, 4000);


        }
        private static int Binary_Search(int[] nums, int valueToSearch)
        {
            int counter = 0;
            for (int start = 0, end = nums.Length - 1; start <= end;)
            {
                int middleIndex = (start + end) / 2;
                counter++;
                if (nums[middleIndex] == valueToSearch)
                {
                    Console.WriteLine("counter= " + counter);
                    return middleIndex;
                }
                else if (valueToSearch < nums[middleIndex])
                    end = middleIndex - 1;
                else
                    start = middleIndex + 1;
            }
            Console.WriteLine("counter= " + counter);
            return -1;
        }
    }
}
