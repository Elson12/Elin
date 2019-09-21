using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random random = new Random();
            int correct = 0;
            int incorrect = 0;

            Console.Write("How many times do you want to play? ");
            string times = Console.ReadLine();
            int tries = Convert.ToInt32(times);

            Console.Write("Maximum Range? ");
            string maxRange = Console.ReadLine();
            int range = Convert.ToInt32(maxRange);

            Console.Write("How many times do you want to guess a number? ");
            string attempts = Console.ReadLine();
            int guesses = Convert.ToInt32(attempts);

            for (int i = 0; i < tries; i++) { 
                int randomNumber = random.Next(1, range);
                int min = 1;
                int max = range;
                int mid;
                for (int attempt = 0; attempt < guesses; attempt++)
                {
                    Console.Write("Guess the number: ");
                    string guess = Console.ReadLine();
                    int stringToInt = Convert.ToInt32(guess);
                    int attemptsRemaining = attempt;
                    //Console.WriteLine("Attempts " + attempt);
                    //Console.WriteLine("Guesses " + guesses);


                    if (stringToInt == randomNumber)
                    {
                        correct = correct + 1;
                        Console.WriteLine("Correct!");
                        Console.WriteLine(randomNumber);
                        Console.WriteLine("Correct: " + correct + " Incorrect: " + incorrect);
                        break;

                    }
                    else if (stringToInt < randomNumber)
                    {
                        min = mid + 1; 
                        incorrect = incorrect + 1;
                        Console.WriteLine("Incorrect! Attempts remaining: " + attemptsRemaining );

                    }
                    else if (stringToInt > randomNumber)
                    {
                        max = mid - 1;
                        incorrect = incorrect + 1;
                        Console.WriteLine("Incorrect! Attempts remaining: " + attemptsRemaining);
                    }
                    Console.WriteLine("Correct: " + correct + " Incorrect: " + incorrect);
                    
                }


            }
        }
    }
}
