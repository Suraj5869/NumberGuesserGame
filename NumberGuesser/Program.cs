using NumberGuesser.Models;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxChances = 10;
            int chance = 0;
            bool win = false;
            int lowerBound = 1;
            int upperBound = 100;

            Console.WriteLine("Welcome to the Number guessing game");

            Random random = new Random();
            int number = random.Next(lowerBound, upperBound);

            while(maxChances!=chance)
            {
                Console.WriteLine($"Guess the Number within {lowerBound} to {upperBound}: ");
                int guess = int.Parse(Console.ReadLine());

                string output = CheckGuess.GuessNumber(number, guess);
                chance++;

                if (output == "correct")
                {
                    Console.WriteLine($"Congratulation you guessed the correct number in {chance} chances");
                    win = true;
                    break;
                }
                else
                {
                    Console.WriteLine($"{output}. Try again\n");
                }
            }

            if (!win) {
                Console.WriteLine($"Sorry you ran out of the chances, the number is {number}");
            }

        }
    }
}
