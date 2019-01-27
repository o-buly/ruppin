using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples_with_firends
{
    class Program
    {
        static void Main(string[] args)
        {
            stack b = new stack();
            b.push(new customer("ofir", "levi", 1234.5));
            b.push(new customer("ron", "buch", 45679.5));
            b.push(new customer("tomer", "lerner", 9513.45));
            b.push(new customer("hai", "eliasy", 7456.2));
            b.push(new customer("yaakov", "ellyhasov", 5613.5));
            b.show();
            b.Peek();
            b.Pop();
            Console.WriteLine("******************\none customer has been deleted\n******************");
            b.show();
            b.Pop();
            Console.WriteLine("******************\none customer has been deleted\n******************");
            b.show();
            b.Pop();
            Console.WriteLine("******************\none customer has been deleted\n******************");
            b.show();
            b.Pop();
            Console.WriteLine("******************\none customer has been deleted\n******************");
            b.show();
            b.Pop();
            Console.WriteLine("******************\none customer has been deleted\n******************");
            b.show();
            b.Pop();
            b.show();

        }

        public class customer
        {
            protected static int count = 0;
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Salary { get; set; }
            public customer(string firstName, string lastName, double salary)
            {
                FirstName = firstName;
                LastName = lastName;
                Salary = salary;
                count++;
            }
            public static int getCount()
            {
                return count;
            }
        }

        public class stack
        {
            int position;
            customer[] arr;

            public stack()
            {
                position = 0;
                arr = new customer[5];
            }
            public void push(customer New)
            {
                if (!isFull())
                    arr[position++] = New;
            }

            private bool isFull()
            {
                if (position == arr.Length)
                {
                    Console.WriteLine("stack is full !");
                    return true;
                }
                return false;
            }

            public bool isEmpty()
            {
                if (position == 0)
                {
                    Console.WriteLine("the stack is empty !");
                    return true;
                }
                return false;
            }
            public customer Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("pop() - EMPTY!");
                    return arr[position];
                }
                return arr[--position];
            }

            public customer Peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("peek() - EMPTY!");
                    return arr[position];
                }
                return arr[position - 1];
            }

            public void show()
            {
                for (int i = position - 1; i >= 0; i--)
                {
                    Console.WriteLine("customer name is: " + arr[i].FirstName + "\nthe last name is: "
                        + arr[i].LastName + "\nthe salary: " + arr[i].Salary + "\ncustomer number is: " + (i + 1) + "\n");
                }
                    Console.WriteLine("you create " + customer.getCount() + " customers\n");
            }
        }
    }
}
