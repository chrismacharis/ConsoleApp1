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
            int randomNumber = random.Next(1, 31);
            int userInput;
            int attempts = 0;

            do
            {
                Console.WriteLine("This is a number guessing game." +
                                  "\nEnter a number from 1-30:");
                userInput = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (userInput == randomNumber)
                {
                    Console.WriteLine("Correct! You win!");
                    Console.WriteLine($"It took you {attempts} tries.");
                }
                else if (userInput < randomNumber)
                {
                    Console.WriteLine("Too low! Try again.\n");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.\n");
                }
            }

            while (userInput != randomNumber);
            
        }
    }
}
