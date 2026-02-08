using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Game
    {
        // add a private field to hold the secret number
        private int _secretNumber;

        // add a constructor that generates a random secret number between 1 and 100
        public Game()
        {
            // use the Random class to generate a random number
            Random generateRandomNumber = new Random();
            _secretNumber = generateRandomNumber.Next(1, 15);
        }



        /*
          Add a method CheckGuess(int guess) that returns:  "low" if guess is too low
        , "high" if guess is too high, and "correct" if guess is correct.
         */

        public string CheckGuess(int guess) { 

            if (guess < _secretNumber)
            {
                return "low";
            }
            else if (guess > _secretNumber)
            {
                return "high";
            }
            else
            {
                return "correct";
            }

        }




    }
}
