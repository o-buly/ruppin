using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class main
    {
        static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.age = 14;
            p1.id = 305253932;
            p1.name = "ofir";
            p1.print();
            Student p2 = new Student();
            p2.age = 12;
            p2.id = 65476542;
            p2.name = "nathaniel";
            p2.print();
            Student p3 = new Student();
            p3.print();
        }
    }
}

