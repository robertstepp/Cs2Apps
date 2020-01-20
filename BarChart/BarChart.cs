// Robert Stepp
// TINFO 200
// Cs2Apps / BarChart
///////////////////////////////
// Change History
// Date     Developer   Description
// 01202020  rstepp     File creation and initial implementation of the application
//
// References Used
// https://www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/

// TODO Add comments

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    class BarChart
    {
        private static readonly char barChar = '*';

        private static Random random = new Random();

        private static int RandomNumber(int max)
        {
            return random.Next(max);
        }

        private static void GraphDisplay(int number)
        {
            Console.Write($"{number}\t");
            for (int stars = 1; stars <= number; stars++)
            {
                Console.Write($"{barChar}");
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
