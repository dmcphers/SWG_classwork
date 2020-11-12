using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.BLL
{
    public class GameManager
    {
        public const int MinimumGuess = 1;
        public const int MaximumGuess = 20;

        private int _answer;

        private bool IsValidGuess(int guess)
        {
          return (MinimumGuess <= guess && guess <= MaximumGuess);
        }

        private void CreateRandomAnswer()
        {
            Random rng = new Random();
            // Next's upper bound is EXCLUSIVE of the values, so we need to add 1 to the maximum.
            _answer = rng.Next(MinimumGuess, MaximumGuess + 1);
        }

        public GuessResult ProcessGuess(int guess)
        {
            // Best practice: Always initialize variables
            GuessResult guessResult = GuessResult.Invalid;

            if (IsValidGuess(guess))
            {
                if (guess < _answer)
                {
                    guessResult = GuessResult.Higher;
                }
                else if (guess > _answer)
                {
                    guessResult = GuessResult.Lower;
                }
                else
                {
                    guessResult = GuessResult.Victory;
                }
            }

            // Good practice: single exit point
            return guessResult;
        }

        public void Start()
        {
            CreateRandomAnswer();
        }

        public void Start(int answer)
        {
            // save the answer to our field
            _answer = answer;
        }
    }
}
