using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.age = 14;
            p1.id = 305253932;
            p1.name = "ofir";
            p1.print();
        }
    }
    class Student
    {
        public int id;
        public string name;
        public int age;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name + " levi";
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age * 2;
            }
            set
            {
                age = value;
            }
        }
        public void print()
        {
            Console.WriteLine($"{Id}\n{Name}\n{Age}");
        }
    }

}

