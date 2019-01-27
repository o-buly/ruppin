using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuOption;
            Animal[] animalsInCompany = new Animal[40];

            do
            {
                Console.Clear();
                string menu = "Tnu Lachayot Lichyot!\n\nchoose one option:\n1 - Add New Animal\n2 - Print All animals\n3 - Exit";
                Console.WriteLine(menu);
                menuOption = int.Parse(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        // Add Pet to company
                        animalsInCompany[FindAvailableIndexInArray(animalsInCompany)] = AddAnimal();
                        break;
                    case 2:
                        // Print All animals in comopany
                        PrintAnimals(animalsInCompany);
                        break;
                    case 3:
                        // Exit
                        break;
                    default:
                        Console.WriteLine("Choose number according to the menu!");
                        break;
                }// Switch

            } while (menuOption != 3);
        }// Main

        static void PrintAnimals(Animal[] array)
        {
            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine("Animal #{0}: {1}, {2}, {3}, {4}, {5}, {6}", i, array[i].name, array[i].type, array[i].breed, array[i].height, array[i].age, array[i].favoFood);
            }// For
        }// Print Animals in array

        static int FindAvailableIndexInArray(Animal[] array)
        {
            int availableIndex = 0;

            if (array.Length == 0)
                availableIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                    availableIndex = i;
            }// For

            return availableIndex;
        }// Find available index in array

        static Animal AddAnimal()
        {
            string name, type, breed, favoFood;
            int height, age;

            Console.WriteLine("Enter the following details:");

            Console.WriteLine("Animal Name:");
            name = Console.ReadLine();

            Console.WriteLine("Animal Type:");
            type = Console.ReadLine();

            Console.WriteLine("Animal Breed:");
            breed = Console.ReadLine();

            Console.WriteLine("Animal Height:");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine("Animal Age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Animal Favorit Food:");
            favoFood = Console.ReadLine();

            Animal anim = new Animal(name, type, breed, height, age, favoFood);

            return anim;
        }// Add Animal
    }
}
