using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_10
{
    class Program
    {
        static void Main(string[] args)
        {
            stack s=new stack(3);
            s.push(100);
            s.push(101);
            s.push(102);
            s.push(103);
            s.push(4);
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine("___________________________");
            s.push(1);
            s.push(2);
            s.push(3);
            s.push(4);
            s.push(4);
            while (s.peek()!=int.MinValue)
            {
                Console.WriteLine(s.pop());
            }
            Console.WriteLine("Bye Bye");
        }
    }

    class stack
    {
        int[] values;
        int pointer;
        public stack() : this(5) { }
        public stack(int size)
        {
            values = new int[size];
            pointer = 0;
        }
        public void push(int newValue)
        {
            if (pointer == values.Length)
            {
                Console.WriteLine("push() - Full"); ;
            }
            else
            {
                values[pointer++] = newValue;
            }
        }
        public int pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("pop() - EMPTY");
                return int.MinValue;
            }
            return values[--pointer];
        }
        public int peek()
        {
            if(IsEmpty())
            {
                Console.WriteLine("peek() - EMPTY");
                return int.MinValue;
            }
            return values[pointer - 1];
        }
        public bool IsEmpty()
        {
            return pointer == 0;
        }
    }
}
