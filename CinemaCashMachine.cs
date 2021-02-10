using System;

namespace CinemaCashMachine
{
    class CinemaCashMachineProgram
    {
        static void Main(string[] args)
        {   
            Console.Write("Welcome! Tickets are $5. \nHow many tickets do you wanna order?");

            int tickets = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 0; i < tickets; i++)
            {
                Console.Write("Please insert cash: ");
                int cash = Convert.ToInt32(Console.ReadLine());

                if (cash < 5)
                
            {
                Console.WriteLine("That's not enough money.");
                Console.WriteLine("Try again \n--------------------");
                i--;
            }
            else if (cash == 5)
            {
                Console.WriteLine("Here is your ticket");
            }
            else
            {
                int change = cash - 5;
                Console.WriteLine("Here is your ticket and " + change + " dollars in change");
            }
            }
            

            Console.ReadLine();
        }
    }
}