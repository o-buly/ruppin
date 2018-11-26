using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex2_Sol
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Diaplay message to user */
            Console.WriteLine("Please Type Your First Name");

            // Save Nuser's input to variable
            string firstName = Console.ReadLine();

            // Display message to user
            Console.WriteLine("Choose Your Option:\n1 - Buy a Stock.\n2 - Buy Stocks on Sale.");

            /*Save user's choice*/
            int choice = int.Parse(Console.ReadLine());

            // Conditions for user option input
            if (choice == 1)
            {
                Console.WriteLine("Insert the price of the desired stock:");

                int price = int.Parse(Console.ReadLine());

                Console.WriteLine("Insert the number of desired stocks");

                int numOfStocks = int.Parse(Console.ReadLine());


                if (numOfStocks % 2 == 0)
                {
                    int totalAmount = price * numOfStocks;
                    Console.WriteLine("Total amount to pay is: {0}", totalAmount);
                    Console.ReadLine();
                }// If - num of stocks is Even
                else
                {
                    Console.WriteLine("This aplication cannot calculate odd numbers of stocks!");
                    Console.ReadLine();
                }// Else - num of stocks is Odd
            }// If - choice = 1
            else if (choice == 2)
            {
                Console.WriteLine("Insert the regular price of the desired stock (price for one stock");
                int regularPrice = int.Parse(Console.ReadLine());

                Console.WriteLine("Insert amount of the desired stock");
                int numOfStocks = int.Parse(Console.ReadLine());

                double discountPrice = 0;
                double discountPercent = 0;
                double totalAmountToPay = 0;

                if (numOfStocks > 10)
                {
                    discountPercent = 0.5;
                    discountPrice = regularPrice * (1 - discountPercent);
                    totalAmountToPay = discountPrice * numOfStocks;
                }// If - more than 10 stocks
                else if (numOfStocks == 10)
                {
                    discountPercent = 0.2;
                    discountPrice = regularPrice * (1 - discountPercent);
                    totalAmountToPay = discountPrice * numOfStocks;
                }// Else-If - less than 10 stocks
                else
                {
                    // No Discount!
                    totalAmountToPay = regularPrice * numOfStocks;
                }// Else - 10 stocks

                Console.WriteLine("Stocks amount: {0}.\nStock regular price: {1}.\nDiscount percent is: {2}%.\nStock price after discount id: {3}.\nTotal amount to pay: {4}", numOfStocks, regularPrice, discountPercent * 100, discountPrice, totalAmountToPay);
                Console.ReadLine();

            }// If - choice = 2
            else
            {
                // Print message
                Console.WriteLine("This option is not a valid option!");
                Console.ReadLine();
            }// Else - all other input options




        }// Main
    }// Class
}// NameSpace
