using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
            int userInput;
          
            do
            {
                Console.WriteLine("This is a number guessing game.\nEnter a number from 1-20:");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == randomNumber)
                {
                    Console.WriteLine("You guessed it right!");
                }
                else if (userInput < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
            while (userInput != randomNumber);
            
        }
    }
}
