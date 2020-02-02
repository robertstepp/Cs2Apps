// Robert Stepp
// TINFO 200
// Cs2Apps / AITeacher
///////////////////////////////
// Change History
// Date     Developer   Description
// 01202020 rstepp      File creation and initial implementation of the application
// 02012020 rstepp      Finished the program and added comments
//
// References Used
// None

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITeacher
{
    class AITeacher
    {
        // Stores the random numbers generated and the result of the multiplication
        static Numbers problem = new Numbers();

        // Ask user for information
        private static void askQuestion()
        {
            int guess;
            
            Console.WriteLine($"What is {problem.returnNumbers()[0]} times {problem.returnNumbers()[1]}?");
            int.TryParse(Console.ReadLine(), out guess);
            checkGuess(guess);
        }

        // Checks if the users response is correct
        // Asks again if incorrect
        // Creates new problem if correct
        private static void checkGuess(int guess)
        {
            if (guess != problem.returnNumbers()[2]) // Incorrect
            {
                Console.WriteLine($"No, {guess} is incorrect. Please try again.\n");
                askQuestion();
            }
            else // Correct
            {
                Console.WriteLine($"{guess} is correct. Very good!\n");
                problem.setNewNumbers();
                askQuestion();
            }
        }

        // Help elementary students learn multiplication
        // two one-digit positive integers multiplied
        static void Main(string[] args)
        {
            Console.WriteLine(@"
*****************************************************************************************
******************************  Multiplication Assistance  ******************************
*****************************************************************************************

We are going to play a game today. I will ask multiplication questions with numbers from 
1 to 9. Please provide the answer in numbers and press Enter. There will be feedback if 
the answer is correct or not.

");
            askQuestion();
        }
    }
}
