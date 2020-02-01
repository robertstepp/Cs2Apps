using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Number
    {
        // Allow for the easy change of the maximum number
        public const int MAXNUM = 1001;

        // Object to store the number
        private static int randomNumber;

        // Creates Random object to use in the program 
        private readonly Random rand = new Random();

        // Constructor that assigns a random number
        public Number()
        {
            randomNumber = rand.Next(MAXNUM);
        }

        // Return the number
        public int getNumber()
        {
            return randomNumber;
        }

        // Sets new random number
        public void setNewNumber()
        {
            randomNumber = rand.Next(MAXNUM);
        }

    }
}
