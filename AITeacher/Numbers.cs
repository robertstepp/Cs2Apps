using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITeacher
{
    class Numbers
    {
        private const int MAXNUM = 9;
        private int num1;

        private int num2;

        private int result;

        private readonly Random rand = new Random();

        // Constructor for both numbers
        public Numbers()
        {
            num1 = rand.Next(MAXNUM) + 1;
            num2 = rand.Next(MAXNUM) + 1;
            result = num1 * num2;
        }

        // Return an array of the three numbers for use in feedback and checking the result
        public int[] returnNumbers()
        {
            int[] storedNumbers = { num1, num2, result };
            return storedNumbers;
        }

        // Resets the numbers for a new problem.
        public void setNewNumbers()
        {
            num1 = rand.Next(MAXNUM) + 1;
            num2 = rand.Next(MAXNUM) + 1;
            result = num1 * num2;
        }
    }
}
