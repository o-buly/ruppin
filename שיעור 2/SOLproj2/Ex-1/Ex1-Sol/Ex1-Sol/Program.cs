using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1_Sol
{
    class Program
    {
        static void Main(string[] args)
        {



            string name;                                                                    //שמות המשתנים
            int age;
            int years;
            int sum;

            Console.WriteLine("type your full name please:\n");                             //הכנס שם
            name = Console.ReadLine();                                                     //יקרא את השם
            Console.WriteLine("\nmy name is: {0}\n", name);                                 //יראה את השם

            Console.WriteLine("type your age please:\n");                                   // הכנס גיל
            age = int.Parse(Console.ReadLine());                                          //המרת הגיל לדצימלי

            Console.WriteLine("\ntype some number of years please:\n");                     //הכנס שנה
            years = int.Parse(Console.ReadLine());                                                             //יקרא שנים 

            sum = age + years;                                                            //חיבור שני המשתנים 

            Console.WriteLine("\nthe sum is: {0}\n", sum);                                  // יציג את הסכום של החיבור 

            Console.WriteLine("You are {0} years old.\n\nin {1} years, you will be {2} years old!(PRESS ENTER)", age, years, sum); // הצגת משפט סופי 
            Console.ReadLine();
            Console.WriteLine("\nEND EXERCICE 1:)");
            Console.ReadLine();







            //// Declare Variable
            //string name;
            //int age, newAge, numOfYears;
            

            ///* Show message to user */
            //Console.WriteLine("Please Enter Your Full Name");
            
            //// Save user's input into variable
            //name = Console.ReadLine();

            ///* Print message with user name */
            //Console.WriteLine("My Name Is \"{0}\"", name);

            //// Show message to user
            //Console.WriteLine("\nEnter Your Age");
            
            ///* Save user's age into variable */
            //age = int.Parse(Console.ReadLine());

            //// Show message to user
            //Console.WriteLine("Enter Number Of Years");

            ///* Save number of years into variable */
            //numOfYears = int.Parse(Console.ReadLine());

            //// Add num of years to user's age
            //newAge = age + numOfYears;

            ///* Print new age to user */
            //Console.WriteLine("You Are {0} Years Old.\n In {1} Years, You Will Be {2} Years Old!", age, numOfYears, newAge);

            //// Prevent dialog from closing
            //Console.ReadLine();
            
        }// Main
    }// Program
}// NameSpace
