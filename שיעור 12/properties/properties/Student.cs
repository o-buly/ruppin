using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
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
