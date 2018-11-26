using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_10___queue
{
    class Program
    {
        static void Main(string[] args)
        {
            queue q1 = new queue(3);
            q1.enqueue(1);
            q1.enqueue(2);
            q1.enqueue(3);
            q1.enqueue(1);
            q1.printqueue();
            Console.WriteLine(q1.dequeue());
            q1.printqueue();
            Console.WriteLine("________________________");
            Console.WriteLine(q1.dequeue());
            Console.WriteLine(q1.dequeue());
            q1.enqueue(5);
            Console.WriteLine(q1.dequeue());
            Console.WriteLine(q1.dequeue());
        }



        class queue
        {
            int[] arr;
            int empty_cell = 0;
            public queue() : this(5) { }
            public queue(int size)
            {
                arr = new int[size];
            }
            public void enqueue(int value)
            {
                if (!isFull())
                    arr[empty_cell++] = value;
                else
                    Console.WriteLine("***** FULL *****");
            }
            public int dequeue()
            {
                if (!isEmpty())
                {
                    int temp = arr[0];
                    empty_cell--;
                    for (int i = 0; i < empty_cell; i++)
                        arr[i] = arr[i + 1];
                    return temp;
                }
                Console.WriteLine("***** EMPTY *****");
                return -1;
            }
            public bool isFull()
            {
                return empty_cell == arr.Length;
            }
            public bool isEmpty()
            {
                return empty_cell == 0;
            }
            public void printqueue()
            {
                Console.WriteLine("queue:");
                for (int i = 0; i < empty_cell; i++)
                {
                    Console.Write(arr[i] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
