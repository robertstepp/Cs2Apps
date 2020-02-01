// Robert Stepp
// TINFO 200
// Cs2Apps / BarChart
///////////////////////////////
// Change History
// Date     Developer   Description
// 01202020 rstepp      File creation and initial implementation of the application
// 02012020 rstepp      Added file comments
//
// References Used
// https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    class BarChart
    {
        // This program assigns a random numbers and creates a bar graph using astrisk (*) 

        // Constant for the bar character
        private const char BARCHAR = '*';

        // Construct random variable
        private static Random random = new Random();

        // Returns random integer
        private static int RandomNumber(int max)
        {
            return random.Next(max);
        }

        // Construct and display the bar graph
        private static void GraphDisplay(int number)
        {
            Console.Write($"{number}\t");
            for (int stars = 1; stars <= number; stars++)
            {
                Console.Write($"{BARCHAR}");
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                GraphDisplay(RandomNumber(30));
                Console.WriteLine();
            }
        }
    }
}
