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
            string answerExit = "";

            do
            {
                int numRangeMin;
                int numRangeMax;
                int[] userChoices = new int[6];
                int[] randomNumbers = new int[6];
                int jackpot = 60000;
                int numbersCorrect = 0;
                int userWinnings;
                int userGuesses;


                Console.WriteLine("Welcome to the Lucky Numbers Lottery Game. You can win a jackpot of up to $60000. Please choose your starting number.");
                numRangeMin = int.Parse(Console.ReadLine());

                Console.WriteLine("Please choose your ending number.");
                numRangeMax = int.Parse(Console.ReadLine());

                for (int i = 0; i < userChoices.Length; i++)
                {
                    Console.WriteLine("Please choose six numbers from the number range above.");
                    userGuesses = int.Parse(Console.ReadLine());
                    while (userGuesses < numRangeMin || userGuesses > numRangeMax)
                    {
                        Console.WriteLine("The number you have chosen is outside the range of numbers chosen. Please choose numbers within range.");
                        userGuesses = int.Parse(Console.ReadLine());
                    }

                    while (userChoices.Contains(userGuesses))
                    {
                        if (true)
                        {
                            Console.WriteLine("You have already entered this number. Please select a different number.");
                            userGuesses = int.Parse(Console.ReadLine());
                        }

                        else break;
                    }
                    userChoices[i] = userGuesses;


                }

                Random r = new Random();
                for (int i = 0; i < randomNumbers.Length; i++)
                {

                    randomNumbers[i] = r.Next(numRangeMin, numRangeMax + 1);
                    Console.WriteLine("Lucky Number: " + randomNumbers[i]);

                }

                for (int i = 0; i < userChoices.Length; i++)
                {
                    for (int j = 0; j < randomNumbers.Length; j++)
                    {
                        if (userChoices[i] == randomNumbers[j])
                        {
                            numbersCorrect += 1;
                        }

                    }

                }

                Console.WriteLine("You have chosen " + numbersCorrect + " numbers correctly. ");
                userWinnings = numbersCorrect * 10000;
                Console.WriteLine("Congratulations! You have won $ " + userWinnings + " dollars!!");
                Console.WriteLine("Would you like to play again?");
                answerExit = Console.ReadLine().ToLower();
                if (answerExit == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                   
                }
                
            }
            while (answerExit == "yes");
                  

                





            }


        } 
    }


    







































































      
    

