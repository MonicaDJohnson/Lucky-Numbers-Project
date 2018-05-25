using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRangeMin;
            int numRangeMax;
            int[] userChoices = new int[6];
            int[] randomNumbers = new int[6];
            int jackpot = 24000000;
            int numbersCorrect;
            int userWinnings;
            int userGuesses;
            

            Console.WriteLine("Welcome to the Lucky Numbers Lottery Game.You can win a jackpot of up to $24000000. Please choose your starting number.");
            numRangeMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose your ending number.");
            numRangeMax = int.Parse(Console.ReadLine());

            for (int i = 0; i < userChoices.Length; i++)
            {
                Console.WriteLine("Please choose six numbers from the number range above.");
                userGuesses = int.Parse(Console.ReadLine());

                userChoices[i] = userGuesses;

                
            }

            Random r = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
            {

                randomNumbers[i] = r.Next(numRangeMin, numRangeMax + 1);
                Console.WriteLine("Lucky Number: " + randomNumbers[i]);

            }







        }


    







































































      
    }
}
