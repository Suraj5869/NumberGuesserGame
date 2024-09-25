using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser.Models
{
    internal class CheckGuess
    {
        public static string GuessNumber(int number, int guess)
        {
            if (guess == number)
            {
                return "correct";
            }
            else if(guess < number)
            {
                return "Too low";
            }
            else 
            {
                return "Too high";
            }
        }
    }
}
