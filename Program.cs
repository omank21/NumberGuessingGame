using System;

namespace numberGuessingGame
{

    class NumberGuessingGame
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 501);
            int numberOfGuesses = 1;
            bool guess_is_correct = false;
            Console.WriteLine("This is the Number Guessing Game!\nChoose a number from 1-500. If you guess correct you win!");
            Console.WriteLine(randomNumber);
            while (!guess_is_correct)
            {
                Console.WriteLine("Guess a number between 1-500");
                int userGuess = Convert.ToInt16(Console.ReadLine());

                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Well done!! You've guessed the correct number");
                    guess_is_correct = true;
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("The number you've guessed is less than the chosen number");
                    numberOfGuesses++;
                }
                else
                {
                    Console.WriteLine("The number you've guessed is more than the chosen number");
                    numberOfGuesses++;
                }
            }
            Console.Write($"To complete the game, it took you {numberOfGuesses} attempts ");

        }
    }
}