using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourLoops
{
    public static class LoopService
    {
        public static void PrintEvenNumbers(int start, int end)
        {
            Console.WriteLine($"Printing even numbers between: {start} and {end}");
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0) 
                    Console.WriteLine(i);
            }
            Console.WriteLine("");
        }

        public static void PrintLastDigitSevenNumbers(int start, int end)
        {
            Console.WriteLine($"Printing numbers that end in 7 between: {start} and {end}");
            for (int i = start; i < end; i++)
            {
                if (i % 10 == 7)
                    Console.WriteLine(i);
            }
            Console.WriteLine("");
        }

        public static void PrintSumToNumber(int start, int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of all the numbers between {start} and {end} is: {sum}");
            Console.WriteLine("");
        }

        public static void PrintIntegersBetweenNumberDigits(int number)
        {
            if(number % 10 is 0)
            {
                Console.WriteLine($"There are no integers between the digits of {number}.");
                return;
            }

            var digits = GetDigits(number).OrderByDescending(num => num);
            //var digits = GetDigits(number).OrderBy(num => num);
            Console.WriteLine($"Printing the integers between all the digits of: {number}");

            for (int i = 0; i < digits.Count() - 1; i++)
            {
                int currentDigit = digits.ElementAt(i);
                int nextDigit = digits.ElementAt(i + 1);

                Console.WriteLine($"Between {currentDigit} and {nextDigit} there's the following integers:");
                PrintAllNumbers(currentDigit - 1, nextDigit + 1);
                Console.WriteLine("");
            }
        }

        private static void PrintAllNumbers(int init, int limit)
        {
            int loopStart = init < limit
                ? init : limit;

            int loopEnd = loopStart != init
                ? init : limit;

            for (; loopStart <= loopEnd; loopStart++)
            {
                Console.WriteLine(loopStart);
            }
        }

        private static IEnumerable<int> GetDigits(int number)
        {
            while (number > 0)
            {
                yield return number % 10;
                number /= 10;
            }
        }
    }
}
