using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ids = new int[30];
            string[] names = new string[30];
            double[] ages = new double[30];

            person p1;
            p1 = new person();
            int num = p1.id;
            Console.WriteLine(num);
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            Console.WriteLine("======END======");
            p1.id = 7;
            p1.name = "benny";
            p1.age = 21.2;
            Console.WriteLine(p1.id);
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            p1.sayHello();
            Console.WriteLine("======END======");
            person p2 = new person();
            p2.id = 8;
            p2.name = "avi";
            p2.age = 30.6;
            Console.WriteLine(p2.id);
            Console.WriteLine(p2.name);
            Console.WriteLine(p2.age);
            p2.sayHello();
            Console.WriteLine("======END======");
            p1 = p2;
            Console.WriteLine(p1.id);
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            p1.sayHello();
            p2.sayHello();
            Console.WriteLine("======END======");
            p2.getOldder(2);
            p2.sayHello();
            p2.getOldder(2);
            p2.sayHello();
            Console.WriteLine("======END======");
            person p3=new person(88);
            p3.sayHello();
        }
    }

    class person
    {
        //Fields:
        public int id=9; // first
        public string name;
        public double age;

        //Methods:
        public person() // ctor tab->tab // short of : constructor
        {
            name = "no name";
            age = 20;
            if (DateTime.Now.DayOfWeek==DayOfWeek.Tuesday)
            {
                name = "shlishi";
            }
        }

        public person(int i) // second
        {
            id = i;
        }

        public void sayHello()
        {
            Console.WriteLine($"id={id}\t name={name}\t age={age}");
        }

        public void getOldder(int year)
        {
            age += year;
        }
    }
}
