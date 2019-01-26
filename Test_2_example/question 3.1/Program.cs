using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.ChangeName("ArikAndBentz"));
            Console.WriteLine();
            p1.PrintPerson();
            p1.Run();
            p1.Run();
            p1.Eat(3);
            p1.PrintPerson();
            p1.Run();
            p1.PrintPerson();
        }

        //Class Person
        public class Person
        {
            private string name;
            private int path;
            private int energy;

            public Person()
            {
                this.name = "";
                this.path = 0;
                this.energy = 1;
            }
            public void Eat(int portions)
            {
                this.energy += portions;
            }
            private bool IsDead()
            {
                if (energy == 0)
                {
                    return true;
                }
                return false;
            }
            public string ChangeName(string n1)
            {
                this.name = n1;
                return "the new name is: " + name;
            }
            public void Run()
            {
                if (IsDead()) //true , else false
                {
                    Console.WriteLine("can not run, person is dead!");
                }
                else
                {
                    this.path++;
                    this.energy -= 1;
                }

            }
            public void PrintPerson()
            {
                Console.WriteLine("name: " + name + "\nenergy: " + energy + "\npath: " + path);
            }
        }
    }
}
