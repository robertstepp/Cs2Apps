// Robert Stepp
// TINFO 200
// Cs2Apps / GuessTheNumber
///////////////////////////////
// Change History
// Date     Developer   Description
// 01202020 rstepp      File creation and initial implementation of the application
// 02012020 rstepp      Finished program and added comments
//
// References Used
// Suman, S. (2015, October 21). Exit Methods In C# Application. 
//      Retrieved February 1, 2020, from https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class GuessTheNumber
    {
        // Program is to create a random number and have a guessing game with the user.

        // Creates object that stores and sets a random number
        private static Number num = new Number();

        // I addded a win counter for multiple games in a row
        private static int wins = 0;

        // Asks the user for input and gives the result.
        // Calls itself if the guess is incorrect
        // Calls newGame if the game is over
        private static void guessNumber()
        {
            int guess;
            Console.WriteLine($"Please enter a guess between 1 and 1000: ");
            int.TryParse(Console.ReadLine(), out guess);
            if (guess < num.getNumber()) // Too low
            {
                Console.WriteLine($"{guess} is too low. Please try again.\n");
                guessNumber();
            }
            else if (guess > num.getNumber()) // Too high
            {
                Console.WriteLine($"{guess} is too high. Please try again.\n");
                guessNumber();
            }
            else if (guess == num.getNumber()) // Correct
            {
                wins += 1; // Increment the win counter
                Console.WriteLine($"Congratulations. Your guess {guess} is the correct number!");
                newGame();
            }
        }

        // Prompts user if they want a new game
        // If yes, sets new random number and allows new guesses
        private static void newGame()
        {
            Console.WriteLine(@"
You have won {wins} times. Would you like to play again? 
Please answer y or n.
");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                num.setNewNumber();
                guessNumber();
            }
            else
            {
                Console.WriteLine($"Thanks for playing. You correctly guessed {wins} numbers.");
                System.Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            guessNumber();
        }
    }
}
