using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Student
    {
        static int counter = 0;
        public Student()
        {
            name = "DEF";
            id = 0;
            age = 0;
            counter++;
        }
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
                if (name != "ofir")
                {
                    if (name != "nathaniel")
                        return name;
                    return name + " masharki";
                }
                else
                    return name + " levi ";
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
            Console.WriteLine($"*id*: {Id}\n*name*: {Name}\n*age*: {Age}\n*counter*: {counter}");
        }
    }
}
