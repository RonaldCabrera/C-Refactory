using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FiveMethods
{
    public static class MethodService
    {
        public static void PrintSalute(string name) => Console.WriteLine($"Welcome to the FBI, agent {name}.");

        public static void PrintLastDigit(int number) => Console.WriteLine($"The last digit is {number % 10}.");

        public static void PrintOddOrEven(int number)
        {
            if (number % 2 is 0)
            {
                Console.WriteLine($"The number is even.");
                return;
            }

            Console.WriteLine($"The number is odd.");
        }

        public static void PrintMultiplicationTableBetweenDigits(int twoDigitNumber)
        {
            if(twoDigitNumber <= 9 && twoDigitNumber >= 99) 
            {
                Console.WriteLine("The number is not two digits long you dork.");
                return;
            }

            int firstDigit = twoDigitNumber / 10;
            int secondDigit = twoDigitNumber % 10;

            for (int i = 1; i <= secondDigit; i++)
            {
                int result = firstDigit * i;
                Console.WriteLine($"{firstDigit} x {i} = {result}");
            }
        }

        public static void PrintBiggestDigitInNumber(int twoDigitNumber)
        {
            if (twoDigitNumber <= 9 && twoDigitNumber >= 99)
            {
                Console.WriteLine("The number is not two digits long you dork.");
                return;
            }

            int biggestDigit = Math.Max(twoDigitNumber / 10, twoDigitNumber % 10);
            Console.WriteLine($"The biggest of the two digits is {biggestDigit}.");
        }
    }
}
