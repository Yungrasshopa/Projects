using System;

namespace CenturyFromYear
{
    class Program
    {
        public static int centuryFromYear(int year)
        {
            Console.WriteLine($"Year original: {year}");
            // Remove the 1's and 10's places 
            //  since we're dealing with centuries
            // 1's place
            year -= year % 10;
            // 10's place
            year -= year % 100;

            Console.WriteLine($"Removed 1's and 10's; Year: {year}");

            // Begin counting centuries
            // Grab the 100's place
            int century = (year % 1000) / 100;
            Console.WriteLine($"Start counting centuries; Century: {century}");
            // Remove the 100's place since we already
            //  grabbed it
            year -= year % 1000;

            Console.WriteLine($"Removed 100's place; Year: {year}");

            // Shift the numbers to the right by one
            year /= 10;
            Console.WriteLine($"Year shifted by one place; Year: {year}");


            for (int i = 10; year >= 10; i *= 10)
            {
                century += (year % 1000) / 100 * i;
                year /= 10;
            }

            // 0 - Indexed centuries (year 001 is century 1)
            ++century;

            return century;
        }

        static void Main(string[] args)
        {
            int year = 1905;
            Console.WriteLine(centuryFromYear(year));
        }
    }
}
