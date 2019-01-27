using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_example
{
        class Animal
        {
            public string name, type, breed, favoFood;
            public int height, age;

            public Animal(string name, string type, string breed, int height, int age, string favoFood)
            {
                this.name = name;
                this.type = type;
                this.breed = breed;
                this.height = height;
                this.age = age;
                this.favoFood = favoFood;
            }// Constructor
        }// Class
}
